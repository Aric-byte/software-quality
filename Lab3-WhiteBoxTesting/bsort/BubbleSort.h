#ifndef BUBBLE_SORT_H
#define BUBBLE_SORT_H

const int ARRAY_SIZE = 10;

// 实验指导书中给出的原始算法（内层循环条件 i < 10 - j）。
// 白盒测试发现：j == 0 时 i 可取到 9，会访问 a[10]，数组越界。
// 仅用于在测试中演示该缺陷，调用方必须提供长度至少为 11 的数组。
void BubbleSortOriginal(int a[]);

// 修正后的算法（内层循环条件 i < 9 - j），对长度为 10 的数组升序排序。
void BubbleSort(int a[]);

#endif
