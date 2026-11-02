#include "BubbleSortTest.h"
#include "../bsort/BubbleSort.h"

#include <sstream>

CPPUNIT_TEST_SUITE_REGISTRATION(BubbleSortTest);

void BubbleSortTest::assertArrayEquals(const int expected[], const int actual[], int size)
{
    for (int k = 0; k < size; k++)
    {
        std::ostringstream msg;
        msg << "index " << k;
        CPPUNIT_ASSERT_EQUAL_MESSAGE(msg.str(), expected[k], actual[k]);
    }
}

void BubbleSortTest::testPath3AlreadySorted()
{
    int input[ARRAY_SIZE]    = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    int expected[ARRAY_SIZE] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    BubbleSort(input);
    assertArrayEquals(expected, input, ARRAY_SIZE);
}

void BubbleSortTest::testPath4ReverseOrder()
{
    int input[ARRAY_SIZE]    = {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
    int expected[ARRAY_SIZE] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    BubbleSort(input);
    assertArrayEquals(expected, input, ARRAY_SIZE);
}

void BubbleSortTest::testMixedWithDuplicates()
{
    int input[ARRAY_SIZE]    = {5, -3, 8, 5, 0, 12, -3, 7, 1, 5};
    int expected[ARRAY_SIZE] = {-3, -3, 0, 1, 5, 5, 5, 7, 8, 12};
    BubbleSort(input);
    assertArrayEquals(expected, input, ARRAY_SIZE);
}

void BubbleSortTest::testOriginalReadsBeyondArray()
{
    // 第 11 个元素作为"哨兵"，模拟紧邻数组之后的内存。
    // 原算法会把哨兵 -1 交换进数组，而把 9 挤到数组外，证明发生越界访问。
    int buffer[ARRAY_SIZE + 1] = {9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1};
    BubbleSortOriginal(buffer);
    bool sentinelInside = false;
    for (int k = 0; k < ARRAY_SIZE; k++)
    {
        if (buffer[k] == -1)
        {
            sentinelInside = true;
        }
    }
    CPPUNIT_ASSERT_MESSAGE("原算法把越界的哨兵值排进了数组", sentinelInside);
    CPPUNIT_ASSERT_EQUAL_MESSAGE("原算法修改了数组之外的内存", 9, buffer[ARRAY_SIZE]);

    // 修正后的算法不触碰 a[10]。
    int fixed[ARRAY_SIZE + 1] = {9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1};
    BubbleSort(fixed);
    CPPUNIT_ASSERT_EQUAL(0, fixed[0]);
    CPPUNIT_ASSERT_EQUAL(-1, fixed[ARRAY_SIZE]);
}
