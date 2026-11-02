using System;
using System.Windows.Forms;
using TriangleCore;

namespace TriangleApp
{
    /// <summary>
    /// 三角形判定主窗体：只负责收集输入与展示结果，判定逻辑由 <see cref="TriangleClassifier"/> 完成。
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object? sender, EventArgs e)
        {
            TriangleType type = TriangleClassifier.Classify(
                sideATextBox.Text,
                sideBTextBox.Text,
                sideCTextBox.Text);

            string message = TriangleClassifier.GetDescription(type);
            resultLabel.Text = message;
            MessageBox.Show(message, "判定结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
