namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            String operation = Convert.ToString(textBox3.Text);
            if (operation.Equals("+"))
            {
                result = num1 + num2;
                label1.Text = result.ToString();
            }
            else if (operation.Equals("-"))
            {
                result = num1 - num2;
                label1.Text = result.ToString();
            }
            else if (operation.Equals("*"))
            {
                result = num1 * num2;
                label1.Text = result.ToString();
            }
            else
            {
                label1.Text = "Invalid choice.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}