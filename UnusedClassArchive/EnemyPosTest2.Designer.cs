namespace _3dDodgeball
{
    partial class EnemyPosTest2
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
            btnRegen = new Button();
            SuspendLayout();
            // 
            // btnRegen
            // 
            btnRegen.Location = new Point(12, 12);
            btnRegen.Name = "btnRegen";
            btnRegen.Size = new Size(75, 23);
            btnRegen.TabIndex = 0;
            btnRegen.Text = "button1";
            btnRegen.UseVisualStyleBackColor = true;
            btnRegen.Click += btnRegen_Click;
            // 
            // EnemyPosTest2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnRegen);
            Name = "EnemyPosTest2";
            Text = "EnemyPosTest2";
            Paint += drawBall;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegen;
    }
}