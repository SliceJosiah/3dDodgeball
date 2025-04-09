namespace _3dDodgeball
{
    partial class Start
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
            txtName = new TextBox();
            label2 = new Label();
            btnPlay = new Button();
            btnTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(73, 40);
            label1.Name = "label1";
            label1.Size = new Size(424, 90);
            label1.TabIndex = 0;
            label1.Text = "balls game :3";
            // 
            // txtName
            // 
            txtName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Lime;
            txtName.Location = new Point(270, 243);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 30);
            txtName.TabIndex = 1;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(167, 246);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 2;
            label2.Text = "player name";
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.Magenta;
            btnPlay.Location = new Point(204, 279);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(132, 30);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "play game";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnTest
            // 
            btnTest.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTest.ForeColor = Color.Cyan;
            btnTest.Location = new Point(379, 355);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(161, 30);
            btnTest.TabIndex = 4;
            btnTest.Text = "test leaderboard";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(552, 397);
            Controls.Add(btnTest);
            Controls.Add(btnPlay);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Start";
            Text = "Start";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Button btnPlay;
        private Button btnTest;
    }
}