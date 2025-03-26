namespace _3dDodgeball
{
    partial class Settings1
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
            txtEnemyCount = new TextBox();
            label2 = new Label();
            txtGravity = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Enemy count";
            // 
            // txtEnemyCount
            // 
            txtEnemyCount.Location = new Point(12, 27);
            txtEnemyCount.Name = "txtEnemyCount";
            txtEnemyCount.Size = new Size(201, 23);
            txtEnemyCount.TabIndex = 1;
            txtEnemyCount.Text = "5";
            txtEnemyCount.TextChanged += txtEnemyCount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Gravity";
            // 
            // txtGravity
            // 
            txtGravity.Location = new Point(12, 71);
            txtGravity.Name = "txtGravity";
            txtGravity.Size = new Size(201, 23);
            txtGravity.TabIndex = 3;
            txtGravity.Text = "9.8";
            // 
            // button1
            // 
            button1.Location = new Point(12, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 313);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(138, 313);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // Settings1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 348);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtGravity);
            Controls.Add(label2);
            Controls.Add(txtEnemyCount);
            Controls.Add(label1);
            Name = "Settings1";
            Text = "Settings1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtEnemyCount;
        private Label label2;
        public TextBox txtGravity;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}