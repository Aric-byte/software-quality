using System;
using System.Text.RegularExpressions;
using Xunit;

namespace TriangleCore.Tests
{
    /// <summary>
    /// 用同一组等价类用例检验指导书附件中的原始代码（逻辑原样摘录，去掉界面部分），
    /// 证明实验1中指出的缺陷确实存在。
    /// </summary>
    public class OriginalCodeDefectTests
    {
        // ---- 以下三个方法摘自附件代码，仅把 MessageBox 输出改为返回字符串 ----
        private static string OriginalButtonClick(string t1, string t2, string t3)
        {
            if (CheckInput(t1, t2, t3))
            {
                var e1 = double.Parse(t1);
                var e2 = double.Parse(t2);
                var e3 = double.Parse(t3);
                if (e1 < e2 + e3 && e2 < e1 + e3 && e3 < e1 + e2)
                {
                    string resultTip = (e1 == e2 || e2 == e3 || e3 == e1) ? "等腰" : "";
                    resultTip += (e1 == e2 && e2 == e3) ? "等边" : "";
                    return resultTip + "三角形";
                }

                return "您输入的三边构不成三角形！";
            }

            return "您输入的信息有问题！";
        }

        private static bool CheckInput(string edge1, string edge2, string edge3)
        {
            Regex reg = new Regex("^[0-9]*$");
            return reg.IsMatch(edge1) && reg.IsMatch(edge2) && reg.IsMatch(edge3)
                && int.Parse(edge1) > 0 && int.Parse(edge2) > 0 && int.Parse(edge3) > 0;
        }

        [Fact]
        public void TC12_EmptyInput_OriginalCrashesWithFormatException()
        {
            Assert.Throws<FormatException>(() => OriginalButtonClick("", "4", "5"));
        }

        [Fact]
        public void TC21_HugeNumber_OriginalCrashesWithOverflowException()
        {
            Assert.Throws<OverflowException>(() => OriginalButtonClick("99999999999", "4", "5"));
        }

        [Fact]
        public void TC05_Equilateral_OriginalReportsIsoscelesEquilateral()
        {
            Assert.Equal("等腰等边三角形", OriginalButtonClick("5", "5", "5"));
        }

        [Fact]
        public void TC01_Scalene_OriginalPrintsOnlyTriangle()
        {
            // 题目要求输出“普通三角形”，原代码只输出“三角形”
            Assert.Equal("三角形", OriginalButtonClick("3", "4", "5"));
        }
    }
}
