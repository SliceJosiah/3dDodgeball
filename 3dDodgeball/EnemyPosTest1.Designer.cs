namespace _3dDodgeball
{
    partial class EnemyPosTest1
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
            btnRegenerate = new Button();
            lstEnemyPos = new ListBox();
            lstEnemyPWidth = new ListBox();
            SuspendLayout();
            // 
            // btnRegenerate
            // 
            btnRegenerate.Location = new Point(12, 415);
            btnRegenerate.Name = "btnRegenerate";
            btnRegenerate.Size = new Size(75, 23);
            btnRegenerate.TabIndex = 10;
            btnRegenerate.Text = "button1";
            btnRegenerate.UseVisualStyleBackColor = true;
            btnRegenerate.Click += btnRegenerate_Click;
            // 
            // lstEnemyPos
            // 
            lstEnemyPos.FormattingEnabled = true;
            lstEnemyPos.ItemHeight = 15;
            lstEnemyPos.Location = new Point(11, 12);
            lstEnemyPos.Name = "lstEnemyPos";
            lstEnemyPos.Size = new Size(151, 94);
            lstEnemyPos.TabIndex = 11;
            // 
            // lstEnemyPWidth
            // 
            lstEnemyPWidth.FormattingEnabled = true;
            lstEnemyPWidth.ItemHeight = 15;
            lstEnemyPWidth.Location = new Point(168, 12);
            lstEnemyPWidth.Name = "lstEnemyPWidth";
            lstEnemyPWidth.Size = new Size(154, 94);
            lstEnemyPWidth.TabIndex = 12;
            // 
            // EnemyPosTest1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 450);
            Controls.Add(lstEnemyPWidth);
            Controls.Add(lstEnemyPos);
            Controls.Add(btnRegenerate);
            Name = "EnemyPosTest1";
            Text = "EnemyPosTest1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegenerate;
        private ListBox lstEnemyPos;
        private ListBox lstEnemyPWidth;
    }
}