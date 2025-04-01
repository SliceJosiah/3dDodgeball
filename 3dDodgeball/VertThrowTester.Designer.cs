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
            SuspendLayout();
            // 
            // btnThrow
            // 
            btnThrow.Location = new Point(12, 12);
            btnThrow.Name = "btnThrow";
            btnThrow.Size = new Size(75, 23);
            btnThrow.TabIndex = 0;
            btnThrow.Text = "button1";
            btnThrow.UseVisualStyleBackColor = true;
            btnThrow.Click += btnThrow_Click;
            // 
            // VertThrowTester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(btnThrow);
            Name = "VertThrowTester";
            Text = "VertThrowTester";
            ResumeLayout(false);
        }

        #endregion

        private Button btnThrow;
    }
}