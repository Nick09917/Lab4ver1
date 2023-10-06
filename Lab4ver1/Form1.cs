namespace Lab4ver1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double A = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox6.Text);

            textBox5.Text = "Работу выполнил Осипов Н.М" + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2)) 
            {
                double answ1 = Math.Pow(x, 3) - b;
                double answ2 = Math.Cos(answ1); 
                double asnw3 = Math.Pow(answ2, 2);

                double y = (A * Math.Pow(x, 3)) + asnw3 ;
                textBox5.Text += "x = " + Convert.ToString(x) + "" +
                    "; y = " + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}