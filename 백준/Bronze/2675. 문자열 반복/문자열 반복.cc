#include <iostream>
#include <string>
using namespace std;

int main() {
    int t, r;
    string s;
    cin >> t;
    for (int i = 0; i < t; i++)
    {
        string p;
        cin >> r;
        cin >> s;
        for (int i = 0; i < s.length(); i++)
        {
            for (int j = 0; j < r; j++)
            {
                p += s[i];
            }
        }
        cout << p << endl;
    }
    return 0;
}