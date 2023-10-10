using System.Collections.Generic;

namespace WinFormCalculeyt
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public double mexrec;
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
            textBox1.Text += "/";
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

            List<string> list = new List<string>();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            string temp = default;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (int.TryParse(textBox1.Text[i].ToString(), out _))
                {
                    temp += textBox1.Text[i];
                }
                else
                {
                    list.Add(temp);
                    list.Add(textBox1.Text[i].ToString());
                    temp = default;
                }
            }
            list.Add(temp);



            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i + 1] == "*")
                {
                    a = int.Parse(list[i]);
                    b = int.Parse(list[i + 2]);
                    mexrec = a * b;
                    list1.Add(mexrec.ToString());
                    i += 2;
                }
                else
                {
                    list1.Add(list[i]);
                    if (list[i] != "*" && i == list.Count - 2)
                    {
                        list1.Add(list[i + 1]);
                    }
                }

            }





            for (int i = 0; i < list1.Count - 1; i++)
            {
                if (list1[i + 1] == "/")
                {
                    a = int.Parse(list1[i]);
                    b = int.Parse(list1[i + 2]);
                    mexrec = a / b;
                    list2.Add(mexrec.ToString());
                    i += 2;
                }
                else
                {
                    list2.Add(list1[i]);
                    if (list1[i] != "/" && i == list1.Count - 2)
                    {
                        list2.Add(list1[i + 1]);
                    }
                }

            }

            for (int i = 0; i < list2.Count - 1; i++)
            {
                if (list2[i + 1] == "+")
                {
                    a = int.Parse(list2[i]);
                    b = int.Parse(list2[i + 2]);
                    mexrec = a + b;
                    list3.Add(mexrec.ToString());
                    i += 2;
                }
                else
                {
                    list3.Add(list2[i]);
                    if (list2[i] != "+" && i == list2.Count - 2)
                    {
                        list3.Add(list2[i + 1]);
                    }
                }

            }
            for (int i = 0; i < list3.Count - 1; i++)
            {
                if (list3[i + 1] == "-")
                {
                    a = int.Parse(list3[i]);
                    b = int.Parse(list3[i + 2]);
                    mexrec = a - b;
                    list4.Add(mexrec.ToString());
                    i += 2;
                }
                else
                {
                    list4.Add(list3[i]);

                }

            }
            if (list4.Count == 0)
            {
                if (list3.Count != 0)
                {
                    list4 = list3;
                }
                else if (list2.Count != 0)
                {
                    list4 = list2;
                }
                else if (list1.Count != 0)
                {
                    list4 = list1;
                }
            }

            textBox1.Clear();

            textBox1.Text = list4[0];
        }



        private void buttonToplama_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            string temp=default;

            //Yol 1
            //textBox1.Clear();
            //Muellim hamisin silmek isdeseniz asagini coment edin yuxarini acin

            //Yol2
            //for (int i = 0; i < textBox1.Text.Length-1; i++)
            //{
            //    temp += textBox1.Text[i];
            //}

            //Yol 3
            temp=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            textBox1.Text=temp;
        }
    }
}