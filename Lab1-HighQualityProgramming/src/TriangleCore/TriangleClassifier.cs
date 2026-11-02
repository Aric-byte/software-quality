using System;
using System.Globalization;

namespace TriangleCore
{
    /// <summary>
    /// 根据三条边长判定三角形形状。
    /// 业务逻辑与界面分离，便于单元测试与复用。
    /// </summary>
    public static class TriangleClassifier
    {
        /// <summary>
        /// 解析并判定用户输入的三条边。
        /// </summary>
        /// <param name="sideAText">边 A 的文本。</param>
        /// <param name="sideBText">边 B 的文本。</param>
        /// <param name="sideCText">边 C 的文本。</param>
        /// <returns>判定结果。</returns>
        public static TriangleType Classify(string? sideAText, string? sideBText, string? sideCText)
        {
            if (!TryParseSide(sideAText, out int sideA)
                || !TryParseSide(sideBText, out int sideB)
                || !TryParseSide(sideCText, out int sideC))
            {
                return TriangleType.InvalidInput;
            }

            return Classify(sideA, sideB, sideC);
        }

        /// <summary>
        /// 判定三条整数边构成的三角形形状。
        /// </summary>
        /// <param name="sideA">边 A。</param>
        /// <param name="sideB">边 B。</param>
        /// <param name="sideC">边 C。</param>
        /// <returns>判定结果。</returns>
        public static TriangleType Classify(int sideA, int sideB, int sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                return TriangleType.InvalidInput;
            }

            if (!IsTriangle(sideA, sideB, sideC))
            {
                return TriangleType.NotATriangle;
            }

            if (sideA == sideB && sideB == sideC)
            {
                return TriangleType.Equilateral;
            }

            if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                return TriangleType.Isosceles;
            }

            return TriangleType.Scalene;
        }

        /// <summary>
        /// 返回判定结果对应的中文提示信息。
        /// </summary>
        /// <param name="type">判定结果。</param>
        /// <returns>提示信息。</returns>
        public static string GetDescription(TriangleType type)
        {
            switch (type)
            {
                case TriangleType.InvalidInput:
                    return "输入不合法，请输入三个正整数！";
                case TriangleType.NotATriangle:
                    return "不能构成三角形！";
                case TriangleType.Scalene:
                    return "普通三角形";
                case TriangleType.Isosceles:
                    return "等腰三角形";
                case TriangleType.Equilateral:
                    return "等边三角形";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "未知的三角形类型");
            }
        }

        /// <summary>
        /// 任意两边之和大于第三边。使用 long 计算，避免 int 加法溢出。
        /// </summary>
        private static bool IsTriangle(int sideA, int sideB, int sideC)
        {
            long a = sideA;
            long b = sideB;
            long c = sideC;
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// 将文本解析为正整数边长；只接受纯数字（允许首尾空白）。
        /// </summary>
        private static bool TryParseSide(string? text, out int side)
        {
            side = 0;
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            bool parsed = int.TryParse(
                text.Trim(),
                NumberStyles.None,
                CultureInfo.InvariantCulture,
                out side);
            return parsed && side > 0;
        }
    }
}
