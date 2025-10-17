namespace CIS_207_Project_5_Student_Report_Card
{
    partial class Form1
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
            lblName = new Label();
            lblScore = new Label();
            txtName = new TextBox();
            txtScore = new TextBox();
            btnShowLetterGrade = new Button();
            lblLetterGrade = new Label();
            lblPassFailStatus = new Label();
            grpSummary = new GroupBox();
            lblSummaryPassFailStatus = new Label();
            lblSummaryLetterGrade = new Label();
            lblSummaryScore = new Label();
            lblSummaryName = new Label();
            lblSummaryPassFailStatusLabel = new Label();
            lblSummaryLetterGradeLabel = new Label();
            lblSummaryScoreLabel = new Label();
            lblSummaryNameLabel = new Label();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.75F);
            lblName.Location = new Point(16, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 15.75F);
            lblScore.Location = new Point(17, 56);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(64, 30);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15.75F);
            txtName.Location = new Point(91, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 35);
            txtName.TabIndex = 1;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Segoe UI", 15.75F);
            txtScore.Location = new Point(91, 53);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(186, 35);
            txtScore.TabIndex = 2;
            // 
            // btnShowLetterGrade
            // 
            btnShowLetterGrade.Font = new Font("Segoe UI", 15.75F);
            btnShowLetterGrade.Location = new Point(91, 94);
            btnShowLetterGrade.Name = "btnShowLetterGrade";
            btnShowLetterGrade.Size = new Size(186, 48);
            btnShowLetterGrade.TabIndex = 3;
            btnShowLetterGrade.Text = "Evaluate";
            btnShowLetterGrade.UseVisualStyleBackColor = true;
            btnShowLetterGrade.Click += btnShowLetterGrade_Click;
            // 
            // lblLetterGrade
            // 
            lblLetterGrade.BorderStyle = BorderStyle.Fixed3D;
            lblLetterGrade.Font = new Font("Segoe UI", 72F);
            lblLetterGrade.Location = new Point(283, 12);
            lblLetterGrade.Name = "lblLetterGrade";
            lblLetterGrade.Size = new Size(151, 130);
            lblLetterGrade.TabIndex = 5;
            lblLetterGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassFailStatus
            // 
            lblPassFailStatus.BorderStyle = BorderStyle.Fixed3D;
            lblPassFailStatus.Font = new Font("Segoe UI", 15.75F);
            lblPassFailStatus.Location = new Point(283, 152);
            lblPassFailStatus.Name = "lblPassFailStatus";
            lblPassFailStatus.Size = new Size(151, 48);
            lblPassFailStatus.TabIndex = 6;
            lblPassFailStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblSummaryPassFailStatus);
            grpSummary.Controls.Add(lblSummaryLetterGrade);
            grpSummary.Controls.Add(lblSummaryScore);
            grpSummary.Controls.Add(lblSummaryName);
            grpSummary.Controls.Add(lblSummaryPassFailStatusLabel);
            grpSummary.Controls.Add(lblSummaryLetterGradeLabel);
            grpSummary.Controls.Add(lblSummaryScoreLabel);
            grpSummary.Controls.Add(lblSummaryNameLabel);
            grpSummary.Location = new Point(472, 12);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(296, 188);
            grpSummary.TabIndex = 15;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary";
            // 
            // lblSummaryPassFailStatus
            // 
            lblSummaryPassFailStatus.BorderStyle = BorderStyle.Fixed3D;
            lblSummaryPassFailStatus.Font = new Font("Segoe UI", 15.75F);
            lblSummaryPassFailStatus.Location = new Point(92, 139);
            lblSummaryPassFailStatus.Name = "lblSummaryPassFailStatus";
            lblSummaryPassFailStatus.Size = new Size(186, 35);
            lblSummaryPassFailStatus.TabIndex = 22;
            // 
            // lblSummaryLetterGrade
            // 
            lblSummaryLetterGrade.BorderStyle = BorderStyle.Fixed3D;
            lblSummaryLetterGrade.Font = new Font("Segoe UI", 15.75F);
            lblSummaryLetterGrade.Location = new Point(92, 99);
            lblSummaryLetterGrade.Name = "lblSummaryLetterGrade";
            lblSummaryLetterGrade.Size = new Size(186, 35);
            lblSummaryLetterGrade.TabIndex = 21;
            // 
            // lblSummaryScore
            // 
            lblSummaryScore.BorderStyle = BorderStyle.Fixed3D;
            lblSummaryScore.Font = new Font("Segoe UI", 15.75F);
            lblSummaryScore.Location = new Point(92, 59);
            lblSummaryScore.Name = "lblSummaryScore";
            lblSummaryScore.Size = new Size(186, 35);
            lblSummaryScore.TabIndex = 20;
            // 
            // lblSummaryName
            // 
            lblSummaryName.BorderStyle = BorderStyle.Fixed3D;
            lblSummaryName.Font = new Font("Segoe UI", 15.75F);
            lblSummaryName.Location = new Point(92, 19);
            lblSummaryName.Name = "lblSummaryName";
            lblSummaryName.Size = new Size(186, 35);
            lblSummaryName.TabIndex = 19;
            // 
            // lblSummaryPassFailStatusLabel
            // 
            lblSummaryPassFailStatusLabel.AutoSize = true;
            lblSummaryPassFailStatusLabel.Font = new Font("Segoe UI", 15.75F);
            lblSummaryPassFailStatusLabel.Location = new Point(18, 140);
            lblSummaryPassFailStatusLabel.Name = "lblSummaryPassFailStatusLabel";
            lblSummaryPassFailStatusLabel.Size = new Size(69, 30);
            lblSummaryPassFailStatusLabel.TabIndex = 18;
            lblSummaryPassFailStatusLabel.Text = "Status";
            // 
            // lblSummaryLetterGradeLabel
            // 
            lblSummaryLetterGradeLabel.AutoSize = true;
            lblSummaryLetterGradeLabel.Font = new Font("Segoe UI", 15.75F);
            lblSummaryLetterGradeLabel.Location = new Point(19, 100);
            lblSummaryLetterGradeLabel.Name = "lblSummaryLetterGradeLabel";
            lblSummaryLetterGradeLabel.Size = new Size(68, 30);
            lblSummaryLetterGradeLabel.TabIndex = 17;
            lblSummaryLetterGradeLabel.Text = "Grade";
            // 
            // lblSummaryScoreLabel
            // 
            lblSummaryScoreLabel.AutoSize = true;
            lblSummaryScoreLabel.Font = new Font("Segoe UI", 15.75F);
            lblSummaryScoreLabel.Location = new Point(23, 60);
            lblSummaryScoreLabel.Name = "lblSummaryScoreLabel";
            lblSummaryScoreLabel.Size = new Size(64, 30);
            lblSummaryScoreLabel.TabIndex = 16;
            lblSummaryScoreLabel.Text = "Score";
            // 
            // lblSummaryNameLabel
            // 
            lblSummaryNameLabel.AutoSize = true;
            lblSummaryNameLabel.Font = new Font("Segoe UI", 15.75F);
            lblSummaryNameLabel.Location = new Point(18, 20);
            lblSummaryNameLabel.Name = "lblSummaryNameLabel";
            lblSummaryNameLabel.Size = new Size(69, 30);
            lblSummaryNameLabel.TabIndex = 15;
            lblSummaryNameLabel.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 217);
            Controls.Add(grpSummary);
            Controls.Add(lblPassFailStatus);
            Controls.Add(lblLetterGrade);
            Controls.Add(btnShowLetterGrade);
            Controls.Add(txtScore);
            Controls.Add(txtName);
            Controls.Add(lblScore);
            Controls.Add(lblName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Card";
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblScore;
        private TextBox txtName;
        private TextBox txtScore;
        private Button btnShowLetterGrade;
        private Label lblLetterGrade;
        private Label lblPassFailStatus;
        private GroupBox grpSummary;
        private Label lblSummaryPassFailStatus;
        private Label lblSummaryLetterGrade;
        private Label lblSummaryScore;
        private Label lblSummaryName;
        private Label lblSummaryPassFailStatusLabel;
        private Label lblSummaryLetterGradeLabel;
        private Label lblSummaryScoreLabel;
        private Label lblSummaryNameLabel;
    }
}