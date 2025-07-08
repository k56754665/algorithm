#include <iostream>
using namespace std;

void solve()
{
    string s;
    int combo = 0;
    int score = 0;
    cin >> s;
    for (int i = 0; i < s.length(); i++)
    {
        if (s[i] == 'O')
        {
            combo++;
            score += combo;
        }
        else
        {
            combo = 0;
        }
    }
    cout << score << "\n";
}

int main()
{
    int t;
    cin >> t;
    for (int i = 0; i < t; i++)
    {
        solve();
    }
}