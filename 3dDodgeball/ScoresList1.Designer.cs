namespace _3dDodgeball
{
    partial class ScoresList1
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
            lstNames = new ListBox();
            lstScores = new ListBox();
            lblPoints = new Label();
            btnRestart = new Button();
            btn = new Button();
            SuspendLayout();
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(12, 12);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(140, 154);
            lstNames.TabIndex = 0;
            // 
            // lstScores
            // 
            lstScores.FormattingEnabled = true;
            lstScores.ItemHeight = 15;
            lstScores.Location = new Point(158, 12);
            lstScores.Name = "lstScores";
            lstScores.Size = new Size(140, 154);
            lstScores.TabIndex = 1;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(12, 169);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(96, 15);
            lblPoints.TabIndex = 2;
            lblPoints.Text = "You got 0 points!";
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(12, 246);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(75, 23);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Location = new Point(223, 246);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 4;
            btn.Text = "Exit";
            btn.UseVisualStyleBackColor = true;
            // 
            // ScoresList1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 281);
            Controls.Add(btn);
            Controls.Add(btnRestart);
            Controls.Add(lblPoints);
            Controls.Add(lstScores);
            Controls.Add(lstNames);
            Name = "ScoresList1";
            Text = "ScoresList1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNames;
        private ListBox lstScores;
        private Label lblPoints;
        private Button btnRestart;
        private Button btn;
    }
}