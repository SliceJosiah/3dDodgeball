namespace _3dDodgeball
{
    partial class VertThrowTester
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
            btnThrow = new Button();
            lblX = new Label();
            lblY = new Label();
            SuspendLayout();
            // 
            // btnThrow
            // 
            btnThrow.Location = new Point(897, 12);
            btnThrow.Name = "btnThrow";
            btnThrow.Size = new Size(75, 23);
            btnThrow.TabIndex = 0;
            btnThrow.Text = "button1";
            btnThrow.UseVisualStyleBackColor = true;
            btnThrow.Click += btnThrow_Click;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(897, 114);
            lblX.Name = "lblX";
            lblX.Size = new Size(13, 15);
            lblX.TabIndex = 1;
            lblX.Text = "0";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(897, 129);
            lblY.Name = "lblY";
            lblY.Size = new Size(13, 15);
            lblY.TabIndex = 2;
            lblY.Text = "0";
            // 
            // VertThrowTester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(btnThrow);
            Name = "VertThrowTester";
            Text = "VertThrowTester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThrow;
        private Label lblX;
        private Label lblY;
    }
}