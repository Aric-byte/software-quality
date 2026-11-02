#ifndef BUBBLE_SORT_TEST_H
#define BUBBLE_SORT_TEST_H

#include <cppunit/extensions/HelperMacros.h>

class BubbleSortTest : public CppUnit::TestFixture
{
    CPPUNIT_TEST_SUITE(BubbleSortTest);
    CPPUNIT_TEST(testPath3AlreadySorted);
    CPPUNIT_TEST(testPath4ReverseOrder);
    CPPUNIT_TEST(testMixedWithDuplicates);
    CPPUNIT_TEST(testOriginalReadsBeyondArray);
    CPPUNIT_TEST_SUITE_END();

public:
    void testPath3AlreadySorted();      // 基本路径 P3：内层判定恒假，不交换
    void testPath4ReverseOrder();       // 基本路径 P4：内层判定为真，发生交换
    void testMixedWithDuplicates();     // 补充：乱序且含重复、负数
    void testOriginalReadsBeyondArray();// 缺陷演示：原算法访问 a[10]

private:
    static void assertArrayEquals(const int expected[], const int actual[], int size);
};

#endif
