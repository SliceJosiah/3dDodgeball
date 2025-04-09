namespace _3dDodgeball
{
    partial class Game2
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
            lblPlayerPos = new Label();
            lblPlayerMultPos = new Label();
            lblKeyTogDir = new Label();
            lblRKeyDown = new Label();
            SuspendLayout();
            // 
            // lblPlayerPos
            // 
            lblPlayerPos.AutoSize = true;
            lblPlayerPos.Location = new Point(12, 9);
            lblPlayerPos.Name = "lblPlayerPos";
            lblPlayerPos.Size = new Size(38, 15);
            lblPlayerPos.TabIndex = 0;
            lblPlayerPos.Text = "label1";
            // 
            // lblPlayerMultPos
            // 
            lblPlayerMultPos.AutoSize = true;
            lblPlayerMultPos.Location = new Point(12, 24);
            lblPlayerMultPos.Name = "lblPlayerMultPos";
            lblPlayerMultPos.Size = new Size(38, 15);
            lblPlayerMultPos.TabIndex = 1;
            lblPlayerMultPos.Text = "label1";
            // 
            // lblKeyTogDir
            // 
            lblKeyTogDir.AutoSize = true;
            lblKeyTogDir.Location = new Point(12, 39);
            lblKeyTogDir.Name = "lblKeyTogDir";
            lblKeyTogDir.Size = new Size(38, 15);
            lblKeyTogDir.TabIndex = 2;
            lblKeyTogDir.Text = "label1";
            // 
            // lblRKeyDown
            // 
            lblRKeyDown.AutoSize = true;
            lblRKeyDown.Location = new Point(12, 54);
            lblRKeyDown.Name = "lblRKeyDown";
            lblRKeyDown.Size = new Size(38, 15);
            lblRKeyDown.TabIndex = 3;
            lblRKeyDown.Text = "label1";
            // 
            // Game2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(484, 811);
            Controls.Add(lblRKeyDown);
            Controls.Add(lblKeyTogDir);
            Controls.Add(lblPlayerMultPos);
            Controls.Add(lblPlayerPos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Game2";
            Text = "Game2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblPlayerPos;
        public Label lblPlayerMultPos;
        public Label lblKeyTogDir;
        public Label lblRKeyDown;
    }
}