namespace TriangleApp
{
    public partial class TriangleThing : Form
    {
        public TriangleThing()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text, textBox2.Text, textBox3.Text,this);
            form2.Show();
            this.Hide();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
