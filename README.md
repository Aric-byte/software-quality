# 《软件质量保证与测试》实验

| 实验 | 目录 | 内容 |
|---|---|---|
| 实验1 高质量编程 | [Lab1-HighQualityProgramming](Lab1-HighQualityProgramming) | C# WinForms 三角形判定程序（界面与逻辑分离、按编码规范书写） |
| 实验2 黑盒测试 | [Lab2-BlackBoxTesting](Lab2-BlackBoxTesting) | 等价类划分 + 测试用例 + AutoRunner 脚本 + xUnit 自动化测试 |
| 实验3 白盒测试 | [Lab3-WhiteBoxTesting](Lab3-WhiteBoxTesting) | 冒泡排序的基本路径测试 + CppUnit 测试工程 |

## 实验报告

按评分标准（实验说明 / 实验分析 / 程序运行结果 / 实验体会 / 报告标识）编写，每个实验提供 Markdown 与 Word 两个版本：

| 实验 | 上课日期 | 报告 |
|---|---|---|
| 高质量编程 | 2026.11.9、11.16 | `Lab1-HighQualityProgramming/实验1报告-高质量编程.docx` |
| 黑盒测试 | 2026.11.23、11.30 | `Lab2-BlackBoxTesting/实验2报告-黑盒测试.docx` |
| 白盒测试 | 2026.12.7、12.14 | `Lab3-WhiteBoxTesting/实验3报告-白盒测试.docx` |

提交前需补充：学号、姓名、班级、指导教师，以及报告中标注【截图】处的 Windows 运行截图（WinForms 界面、AutoRunner 录制回放）。流程图源文件在 `diagrams/`。

## 运行

```bash
# 实验1/2：核心逻辑 + 等价类自动化测试（任意平台，.NET 8）
dotnet test Lab2-BlackBoxTesting/TriangleCore.Tests

# 实验1：WinForms 界面（仅 Windows）
dotnet run --project Lab1-HighQualityProgramming/src/TriangleApp
#   或用 VS 打开 Lab1-HighQualityProgramming/TriangleChecker.sln

# 实验3：CppUnit（Linux 需安装 libcppunit-dev；Windows 按指导书在 VS 中配置 cppunit.lib）
make -C Lab3-WhiteBoxTesting test
```
