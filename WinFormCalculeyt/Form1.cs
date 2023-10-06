namespace WinFormCalculeyt
{
    public partial class Form1 : Form
    {
        public float a ;
        public float b ;
        public float mexrec;
        public string operators = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            a += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void buttonn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void buttonn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void buttonn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void buttonn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void buttonn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            if (operators==" ")
            {
                a = float.Parse(textBox1.Text);
                operators = "/";
                textBox1.Text += "/";
            }
            else
            {
                int minindex;
                int maxindex;
                if(operators=="/")
                {
                    minindex =textBox1.Text.IndexOf('/');
                    maxindex=textBox1.Text.Length;
                    MessageBox.Show(mexrec.ToString());
                    b=float.Parse(textBox1.Text.Substring(minindex,maxindex));
                    mexrec = a / b;
                }
            }
            

        }

        private void buttonVurma_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonCixma_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonBeraberdir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
        }

        private void buttonToplama_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonNoqte_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        public void hesabat()
        {

        }
    }
}