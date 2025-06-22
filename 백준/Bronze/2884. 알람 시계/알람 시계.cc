#include <iostream>

int main() {
    int h, m;
    int answer_h, answer_m;
    scanf("%d %d", &h, &m);

    if (m >= 45)
    {
        answer_h = h;
        answer_m = m - 45;
    }
    else if (h >= 1 && m < 45)
    {
        answer_h = h - 1;
        answer_m = m + 60 - 45;
    }
    else
    {
        answer_h = 23;
        answer_m = m + 60 - 45;
    }

    printf("%d %d", answer_h, answer_m);
    
    return 0;
}