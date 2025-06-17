#include <iostream>
using namespace std;

int main()
{
    int count = 31;
    bool attendance[count];

    for (int i = 0; i < count; i++)
    {
        attendance[i] = false;
    }
    
    for (int i = 1; i <= 28; i++)
    {
        int idx;
        cin >> idx;
        attendance[idx] = true;
    }

    for (int i = 1; i < count; i++)
    {
        if (attendance[i] == false)
        {
            cout << i << endl;
        }
    }
}