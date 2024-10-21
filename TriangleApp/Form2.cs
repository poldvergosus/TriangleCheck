using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleApp
{
    public partial class Form2 : Form
    {
        private TriangleThing mainForm;
        public Form2(string textBox1Value, string textBox2Value, string textBox3Value, TriangleThing form)
        {
            InitializeComponent();
            this.mainForm = form;
            try
            {

                if (string.IsNullOrWhiteSpace(textBox1Value) ||
                    string.IsNullOrWhiteSpace(textBox2Value) ||
                    string.IsNullOrWhiteSpace(textBox3Value))
                {
                    LabelHidden.Text = "Пожалуйста, заполните все поля!";
                    return;
                }

                double a = Convert.ToDouble(textBox1Value);
                double b = Convert.ToDouble(textBox2Value);
                double c = Convert.ToDouble(textBox3Value);

                // Проверка, можно ли построить треугольник с такими сторонами
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    LabelHidden.Text = "Стороны должны быть положительными числами.";
                    return;
                }

                if (a + b > c && a + c > b && b + c > a)
                {
                    // Определение типа треугольника
                    if (a == b && b == c)
                    {
                        LabelHidden.Text = "Треугольник равносторонний.";
                    }
                    else if (a == b || b == c || a == c)
                    {
                        LabelHidden.Text = "Треугольник равнобедренный.";
                    }
                    else
                    {
                        LabelHidden.Text = "Треугольник разносторонний.";
                    }
                }
                else
                {
                    LabelHidden.Text = "Треугольник с такими сторонами не существует.";
                }
            }
            catch
            {
                LabelHidden.Text = "Некорректные значения";
            }
        }

        private void ExecuteButton2_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide(); 
        }
    }
}
