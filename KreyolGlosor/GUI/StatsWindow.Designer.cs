namespace KreyolGlosor.GUI
{
    partial class StatsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            correctWordsLabel = new Label();
            successRateLabel = new Label();
            label4 = new Label();
            bestResult = new Label();
            averageSuccess = new Label();
            timesPlayedLabel = new Label();
            historyPlot = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Föregående omgång";
            // 
            // correctWordsLabel
            // 
            correctWordsLabel.AutoSize = true;
            correctWordsLabel.Location = new Point(12, 68);
            correctWordsLabel.Name = "correctWordsLabel";
            correctWordsLabel.Size = new Size(75, 15);
            correctWordsLabel.TabIndex = 1;
            correctWordsLabel.Text = "Korrekta ord:";
            // 
            // successRateLabel
            // 
            successRateLabel.AutoSize = true;
            successRateLabel.Location = new Point(12, 93);
            successRateLabel.Name = "successRateLabel";
            successRateLabel.Size = new Size(34, 15);
            successRateLabel.TabIndex = 2;
            successRateLabel.Text = "Kvot:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Sammanfattning";
            // 
            // bestResult
            // 
            bestResult.AutoSize = true;
            bestResult.Location = new Point(12, 196);
            bestResult.Name = "bestResult";
            bestResult.Size = new Size(64, 15);
            bestResult.TabIndex = 5;
            bestResult.Text = "Bästa kvot:";
            // 
            // averageSuccess
            // 
            averageSuccess.AutoSize = true;
            averageSuccess.Location = new Point(12, 171);
            averageSuccess.Name = "averageSuccess";
            averageSuccess.Size = new Size(72, 15);
            averageSuccess.TabIndex = 4;
            averageSuccess.Text = "Genomsnitt:";
            // 
            // timesPlayedLabel
            // 
            timesPlayedLabel.AutoSize = true;
            timesPlayedLabel.Location = new Point(12, 145);
            timesPlayedLabel.Name = "timesPlayedLabel";
            timesPlayedLabel.Size = new Size(109, 15);
            timesPlayedLabel.TabIndex = 6;
            timesPlayedLabel.Text = "Spelade omgångar:";
            // 
            // historyPlot
            // 
            historyPlot.DisplayScale = 1F;
            historyPlot.Location = new Point(187, 18);
            historyPlot.Name = "historyPlot";
            historyPlot.Size = new Size(600, 351);
            historyPlot.TabIndex = 7;
            // 
            // StatsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(historyPlot);
            Controls.Add(timesPlayedLabel);
            Controls.Add(bestResult);
            Controls.Add(averageSuccess);
            Controls.Add(label4);
            Controls.Add(successRateLabel);
            Controls.Add(correctWordsLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "StatsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistik";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label correctWordsLabel;
        private Label successRateLabel;
        private Label label4;
        private Label bestResult;
        private Label averageSuccess;
        private Label timesPlayedLabel;
        private ScottPlot.WinForms.FormsPlot historyPlot;
    }
}