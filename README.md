# 《软件质量保证与测试》实验

| 实验 | 目录 | 内容 |
|---|---|---|
| 实验1 高质量编程 | [Lab1-HighQualityProgramming](Lab1-HighQualityProgramming) | C# WinForms 三角形判定程序（界面与逻辑分离、按编码规范书写） |
| 实验2 黑盒测试 | [Lab2-BlackBoxTesting](Lab2-BlackBoxTesting) | 等价类划分 + 测试用例 + AutoRunner 脚本 + xUnit 自动化测试 |
| 实验3 白盒测试 | [Lab3-WhiteBoxTesting](Lab3-WhiteBoxTesting) | 冒泡排序的基本路径测试 + CppUnit 测试工程 |

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
