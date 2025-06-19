#include <iostream>
#include <vector>
using namespace std;

int main() {
    int n, l;
    char c;
    cin >> n;

    vector<string> file(50);
    vector<char> answer;
    
    for (int i = 0; i < n; i++)
    {
        cin >> file[i];
    }

    l = file[0].length();

    for (int i = 0; i < l; i++)
    {
        c = file[0][i];
        
        for (int j = 1; j < n; j++)
        {
            if (c != file[j][i])
            {
                c = '?';
                break;
            }
        }
        answer.push_back(c);
    }

    for (int i = 0; i < l; i++)
    {
        printf("%c", answer[i]);
    }
    
    return 0;
}