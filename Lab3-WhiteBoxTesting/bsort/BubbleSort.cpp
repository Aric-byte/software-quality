#include "BubbleSort.h"

void BubbleSortOriginal(int a[])
{
    int i, j, temp;
    for (j = 0; j < 9; j++)
    {
        for (i = 0; i < 10 - j; i++)
            if (a[i] > a[i + 1])
            {
                temp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = temp;
            }
    }
}

void BubbleSort(int a[])
{
    int i, j, temp;
    for (j = 0; j < ARRAY_SIZE - 1; j++)               // 判定 P1
    {
        for (i = 0; i < ARRAY_SIZE - 1 - j; i++)       // 判定 P2
        {
            if (a[i] > a[i + 1])                       // 判定 P3
            {
                temp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = temp;
            }
        }
    }
}
