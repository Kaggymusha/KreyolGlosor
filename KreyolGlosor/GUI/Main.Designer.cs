namespace KreyolGlosor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            inputBox = new TextBox();
            statBtn = new Button();
            completedLabel = new Label();
            wordLabel = new Label();
            restartBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 0;
            label2.Text = "Ord:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Översättning:";
            // 
            // inputBox
            // 
            inputBox.AcceptsReturn = true;
            inputBox.Location = new Point(96, 95);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(146, 23);
            inputBox.TabIndex = 2;
            inputBox.KeyDown += inputBox_KeyDown;
            // 
            // statBtn
            // 
            statBtn.Location = new Point(129, 134);
            statBtn.Name = "statBtn";
            statBtn.Size = new Size(113, 34);
            statBtn.TabIndex = 3;
            statBtn.Text = "Statistik";
            statBtn.UseVisualStyleBackColor = true;
            statBtn.Click += statBtn_Click;
            // 
            // completedLabel
            // 
            completedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            completedLabel.Font = new Font("Segoe UI", 20F);
            completedLabel.Location = new Point(10, 9);
            completedLabel.Name = "completedLabel";
            completedLabel.Size = new Size(232, 37);
            completedLabel.TabIndex = 4;
            completedLabel.Text = "200/200";
            completedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Location = new Point(96, 66);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(72, 15);
            wordLabel.TabIndex = 5;
            wordLabel.Text = "ett långt ord";
            // 
            // restartBtn
            // 
            restartBtn.Enabled = false;
            restartBtn.Location = new Point(10, 134);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(113, 34);
            restartBtn.TabIndex = 6;
            restartBtn.Text = "Börja om";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Click += restartBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(254, 180);
            Controls.Add(restartBtn);
            Controls.Add(wordLabel);
            Controls.Add(completedLabel);
            Controls.Add(statBtn);
            Controls.Add(inputBox);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kreyolglosor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox inputBox;
        private Button statBtn;
        private Label completedLabel;
        private Label wordLabel;
        private Button restartBtn;
    }
}
