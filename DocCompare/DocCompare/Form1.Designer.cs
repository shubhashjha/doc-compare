namespace DocCompare
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
            R_TextBox1 = new RichTextBox();
            R_TextBox2 = new RichTextBox();
            btn_File1 = new Button();
            btn_File2 = new Button();
            Btn_Compare = new Button();
            SuspendLayout();
            // 
            // R_TextBox1
            // 
            R_TextBox1.Location = new Point(0, 0);
            R_TextBox1.Name = "R_TextBox1";
            R_TextBox1.Size = new Size(379, 504);
            R_TextBox1.TabIndex = 0;
            R_TextBox1.Text = "";
            // 
            // R_TextBox2
            // 
            R_TextBox2.Location = new Point(422, 0);
            R_TextBox2.Name = "R_TextBox2";
            R_TextBox2.Size = new Size(379, 504);
            R_TextBox2.TabIndex = 1;
            R_TextBox2.Text = "";
            // 
            // btn_File1
            // 
            btn_File1.Location = new Point(12, 510);
            btn_File1.Name = "btn_File1";
            btn_File1.Size = new Size(75, 23);
            btn_File1.TabIndex = 2;
            btn_File1.Text = "Browse";
            btn_File1.UseVisualStyleBackColor = true;
            btn_File1.Click += btn_File1_Click;
            // 
            // btn_File2
            // 
            btn_File2.Location = new Point(713, 510);
            btn_File2.Name = "btn_File2";
            btn_File2.Size = new Size(75, 23);
            btn_File2.TabIndex = 3;
            btn_File2.Text = "Browse";
            btn_File2.UseVisualStyleBackColor = true;
            btn_File2.Click += btn_File2_Click;
            // 
            // Btn_Compare
            // 
            Btn_Compare.Location = new Point(359, 545);
            Btn_Compare.Name = "Btn_Compare";
            Btn_Compare.Size = new Size(75, 23);
            Btn_Compare.TabIndex = 4;
            Btn_Compare.Text = "Compare";
            Btn_Compare.UseVisualStyleBackColor = true;
            Btn_Compare.Click += Btn_Compare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 580);
            Controls.Add(Btn_Compare);
            Controls.Add(btn_File2);
            Controls.Add(btn_File1);
            Controls.Add(R_TextBox2);
            Controls.Add(R_TextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox R_TextBox1;
        private RichTextBox R_TextBox2;
        private Button btn_File1;
        private Button btn_File2;
        private Button Btn_Compare;
    }
}
