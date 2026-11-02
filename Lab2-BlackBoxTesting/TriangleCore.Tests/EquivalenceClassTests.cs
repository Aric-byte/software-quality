using TriangleCore;
using Xunit;

namespace TriangleCore.Tests
{
    /// <summary>
    /// 等价类划分测试用例（编号与《实验2报告》中的用例表一一对应）。
    /// </summary>
    public class EquivalenceClassTests
    {
        [Theory]
        // ---------- 有效等价类 ----------
        [InlineData("TC01", "3", "4", "5", TriangleType.Scalene)]        // 普通三角形
        [InlineData("TC02", "3", "3", "4", TriangleType.Isosceles)]      // A=B
        [InlineData("TC03", "4", "3", "3", TriangleType.Isosceles)]      // B=C
        [InlineData("TC04", "3", "4", "3", TriangleType.Isosceles)]      // A=C
        [InlineData("TC05", "5", "5", "5", TriangleType.Equilateral)]    // 等边
        // ---------- 无效等价类：非三角形 ----------
        [InlineData("TC06", "1", "2", "4", TriangleType.NotATriangle)]   // A+B<C
        [InlineData("TC07", "1", "2", "3", TriangleType.NotATriangle)]   // A+B=C
        [InlineData("TC08", "4", "1", "2", TriangleType.NotATriangle)]   // B+C<A
        [InlineData("TC09", "3", "1", "2", TriangleType.NotATriangle)]   // B+C=A
        [InlineData("TC10", "1", "4", "2", TriangleType.NotATriangle)]   // A+C<B
        [InlineData("TC11", "1", "3", "2", TriangleType.NotATriangle)]   // A+C=B
        // ---------- 无效等价类：输入不合法 ----------
        [InlineData("TC12", "", "4", "5", TriangleType.InvalidInput)]    // A 为空
        [InlineData("TC13", "3", "", "5", TriangleType.InvalidInput)]    // B 为空
        [InlineData("TC14", "3", "4", "", TriangleType.InvalidInput)]    // C 为空
        [InlineData("TC15", "a", "4", "5", TriangleType.InvalidInput)]   // 非数字
        [InlineData("TC16", "3.5", "4", "5", TriangleType.InvalidInput)] // 小数
        [InlineData("TC17", "-3", "4", "5", TriangleType.InvalidInput)]  // 负数
        [InlineData("TC18", "0", "4", "5", TriangleType.InvalidInput)]   // 零
        [InlineData("TC19", "3", "0", "5", TriangleType.InvalidInput)]   // 零
        [InlineData("TC20", "3", "4", "0", TriangleType.InvalidInput)]   // 零
        [InlineData("TC21", "99999999999", "4", "5", TriangleType.InvalidInput)] // 超出 int 范围
        // ---------- 边界补充 ----------
        [InlineData("TC22", "2147483647", "2147483647", "2147483647", TriangleType.Equilateral)] // 求和不溢出
        [InlineData("TC23", " 3 ", "4", "5", TriangleType.Scalene)]     // 首尾空白
        public void Classify_ReturnsExpectedType(string id, string a, string b, string c, TriangleType expected)
        {
            TriangleType actual = TriangleClassifier.Classify(a, b, c);
            Assert.True(expected == actual, $"{id}: 期望 {expected}，实际 {actual}");
        }

        [Fact]
        public void Classify_NullInput_IsInvalid()
        {
            Assert.Equal(TriangleType.InvalidInput, TriangleClassifier.Classify(null, "4", "5"));
        }
    }
}
