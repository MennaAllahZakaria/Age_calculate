namespace age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int n;
                n = Convert.ToInt32(input.Text);
                year.Text = Convert.ToString(n / 365);
                month.Text = Convert.ToString((n - (365 * (n / 365))) / 30);
                day.Text = Convert.ToString((n - ((n / 365) * 365)) - (((n - ((n / 365) * 365)) / 30) * 30));


            }catch(Exception ex)
            {
                MessageBox.Show("Invalid input");
            }
    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}