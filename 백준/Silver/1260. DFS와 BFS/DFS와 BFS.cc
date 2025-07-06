#include <iostream>
#include <vector>
#include <stack>
#include <queue>
#include <algorithm> 
using namespace std;

void dfs(int n, int m, int v, vector<vector<int>> graph)
{
    vector<int> visited(n+1, false);
    
    // 첫번째 노드 스택에 넣기
    // 스택에서 빼면서 갈 수 있는 노드들(visited 아닌 애들) 내림차순으로 스택에 싹 넣기
    // 가장 위에 있는 거 스택에서 빼기
    // 스택에서 빼면서 ~~ 이하동문
    
    stack<int> st;
    int cur = v;
    st.push(cur);

    while (!st.empty())
    {
        cur = st.top();
        st.pop();

        if (!visited[cur])
        {
            visited[cur] = true;
            cout << cur << " ";
            
            for (int i = graph[cur].size() - 1; i >= 0; i--)
            {
                if (!visited[graph[cur][i]])
                {
                    st.push(graph[cur][i]);
                }
            }
        }
    }
}

void bfs(int n, int m, int v, vector<vector<int>> graph)
{
    vector<int> visited(n+1, false);

    // 첫번째 노드 큐에 넣기
    // 큐에서 빼면서 갈 수 있는 노드들(visited 아닌 애들) 오름차순으로 큐에 싹넣기
    // 큐에서 하나 빼기~반복

    queue<int> que;
    int cur = v;
    que.push(cur);

    while (!que.empty())
    {
        cur = que.front();
        que.pop();

        if (!visited[cur])
        {
            visited[cur] = true;
            cout << cur << " ";

            for (int i = 0; i < graph[cur].size(); i++)
            {
                if (!visited[graph[cur][i]])
                {
                    que.push(graph[cur][i]);
                }
            }
        }
    }
}

int main()
{
    int n, m, v;
    int a, b;
    
    cin >> n >> m >> v;
    
    vector<vector<int>> graph(n+1, vector<int>());

    for (int i = 0; i < m; i++)
    {
        cin >> a >> b;
        graph[a].push_back(b);
        graph[b].push_back(a);
    }

    for (int i = 1; i <= n; i++)
    {
        sort(graph[i].begin(), graph[i].end());
    }
    
    dfs(n, m, v, graph);
    cout << "\n";
    bfs(n, m, v, graph);
    
    return 0;
}