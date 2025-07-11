#include <iostream>
#include <vector>
using namespace std;

int main() {
    int num[3];
    for (int i = 0; i < 3; i++)
    {
        cin >> num[i];
    }
    while (num[0] != 0)
    {
        int max_idx = 0;
        int sum = 0;
        
        for (int i = 1; i < 3; i++)
        {
            if (num[i] > num[max_idx])
                max_idx = i;
        }

        for (int i = 0; i < 3; i++)
        {
            if (i != max_idx)
                sum += num[i] * num[i];
        }

        if (sum == num[max_idx] * num[max_idx])
        {
            cout << "right\n";
        }
        else
        {
            cout << "wrong\n";
        }
        
        for (int i = 0; i < 3; i++)
        {
            cin >> num[i];
        }
    }
    return 0;
}