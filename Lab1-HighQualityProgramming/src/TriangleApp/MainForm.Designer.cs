namespace TriangleApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.Label sideALabel = null!;
        private System.Windows.Forms.Label sideBLabel = null!;
        private System.Windows.Forms.Label sideCLabel = null!;
        private System.Windows.Forms.TextBox sideATextBox = null!;
        private System.Windows.Forms.TextBox sideBTextBox = null!;
        private System.Windows.Forms.TextBox sideCTextBox = null!;
        private System.Windows.Forms.Button checkButton = null!;
        private System.Windows.Forms.Label resultLabel = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            sideALabel = new System.Windows.Forms.Label();
            sideBLabel = new System.Windows.Forms.Label();
            sideCLabel = new System.Windows.Forms.Label();
            sideATextBox = new System.Windows.Forms.TextBox();
            sideBTextBox = new System.Windows.Forms.TextBox();
            sideCTextBox = new System.Windows.Forms.TextBox();
            checkButton = new System.Windows.Forms.Button();
            resultLabel = new System.Windows.Forms.Label();
            SuspendLayout();

            sideALabel.AutoSize = true;
            sideALabel.Location = new System.Drawing.Point(30, 30);
            sideALabel.Name = "sideALabel";
            sideALabel.Text = "边 A：";

            sideATextBox.Location = new System.Drawing.Point(100, 26);
            sideATextBox.Name = "sideATextBox";
            sideATextBox.Size = new System.Drawing.Size(150, 23);
            sideATextBox.TabIndex = 0;

            sideBLabel.AutoSize = true;
            sideBLabel.Location = new System.Drawing.Point(30, 70);
            sideBLabel.Name = "sideBLabel";
            sideBLabel.Text = "边 B：";

            sideBTextBox.Location = new System.Drawing.Point(100, 66);
            sideBTextBox.Name = "sideBTextBox";
            sideBTextBox.Size = new System.Drawing.Size(150, 23);
            sideBTextBox.TabIndex = 1;

            sideCLabel.AutoSize = true;
            sideCLabel.Location = new System.Drawing.Point(30, 110);
            sideCLabel.Name = "sideCLabel";
            sideCLabel.Text = "边 C：";

            sideCTextBox.Location = new System.Drawing.Point(100, 106);
            sideCTextBox.Name = "sideCTextBox";
            sideCTextBox.Size = new System.Drawing.Size(150, 23);
            sideCTextBox.TabIndex = 2;

            checkButton.Location = new System.Drawing.Point(100, 146);
            checkButton.Name = "checkButton";
            checkButton.Size = new System.Drawing.Size(150, 30);
            checkButton.TabIndex = 3;
            checkButton.Text = "check";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += CheckButton_Click;

            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(30, 195);
            resultLabel.Name = "resultLabel";
            resultLabel.Text = "结果：";

            AcceptButton = checkButton;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 240);
            Controls.Add(sideALabel);
            Controls.Add(sideATextBox);
            Controls.Add(sideBLabel);
            Controls.Add(sideBTextBox);
            Controls.Add(sideCLabel);
            Controls.Add(sideCTextBox);
            Controls.Add(checkButton);
            Controls.Add(resultLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "三角形形状判定";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
