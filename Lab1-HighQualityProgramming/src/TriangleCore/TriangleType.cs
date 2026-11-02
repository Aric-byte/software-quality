namespace TriangleCore
{
    /// <summary>
    /// 三角形判定结果。
    /// </summary>
    public enum TriangleType
    {
        /// <summary>输入不合法（为空、非数字、非正整数或超出范围）。</summary>
        InvalidInput,

        /// <summary>三条边不满足"任意两边之和大于第三边"，无法构成三角形。</summary>
        NotATriangle,

        /// <summary>普通（不等边）三角形。</summary>
        Scalene,

        /// <summary>等腰三角形（恰有两边相等）。</summary>
        Isosceles,

        /// <summary>等边三角形（三边均相等）。</summary>
        Equilateral,
    }
}
