namespace TriangleApp
{
    partial class TriangleThing
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
            ExecuteButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(301, 247);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(149, 63);
            ExecuteButton.TabIndex = 0;
            ExecuteButton.Text = "Вычислить";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(208, 70);
            label1.Name = "label1";
            label1.Size = new Size(330, 25);
            label1.TabIndex = 1;
            label1.Text = "Введите длины сторон треугольника";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F);
            textBox1.Location = new Point(146, 167);
            textBox1.MaxLength = 14;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 26);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14.25F);
            textBox2.Location = new Point(301, 167);
            textBox2.MaxLength = 14;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 26);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 14.25F);
            textBox3.Location = new Point(456, 167);
            textBox3.MaxLength = 14;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 26);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // TriangleThing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(742, 409);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(ExecuteButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TriangleThing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Triangle app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExecuteButton;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
