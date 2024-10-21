namespace TriangleApp
{
    partial class Form2
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
            LabelHidden = new Label();
            ExecuteButton2 = new Button();
            SuspendLayout();
            // 
            // LabelHidden
            // 
            LabelHidden.AutoSize = true;
            LabelHidden.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelHidden.Location = new Point(221, 117);
            LabelHidden.Name = "LabelHidden";
            LabelHidden.Size = new Size(330, 25);
            LabelHidden.TabIndex = 6;
            LabelHidden.Text = "Введите длины сторон треугольника";
            LabelHidden.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExecuteButton2
            // 
            ExecuteButton2.Location = new Point(301, 247);
            ExecuteButton2.Name = "ExecuteButton2";
            ExecuteButton2.Size = new Size(149, 63);
            ExecuteButton2.TabIndex = 7;
            ExecuteButton2.Text = "Начать снова";
            ExecuteButton2.UseVisualStyleBackColor = true;
            ExecuteButton2.Click += ExecuteButton2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(742, 409);
            Controls.Add(ExecuteButton2);
            Controls.Add(LabelHidden);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelHidden;
        private Button ExecuteButton2;
    }
}