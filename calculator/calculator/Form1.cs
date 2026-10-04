using System;
namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool click;
        double birinciEded = 0;
        string emeliyyat = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains(","))
            {
                if (click)
                {
                    richTextBox1.Text = "0";
                    click = false;
                }
                richTextBox1.Text += ",";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                birinciEded = Convert.ToDouble(richTextBox1.Text);
                emeliyyat = "-";
                click = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                birinciEded = Convert.ToDouble(richTextBox1.Text);
                emeliyyat = "+";
                click = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                birinciEded = Convert.ToDouble(richTextBox1.Text);
                emeliyyat = "*";
                click = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                birinciEded = Convert.ToDouble(richTextBox1.Text);
                emeliyyat = "/";
                click = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text)) return;

            double ikinciEded = Convert.ToDouble(richTextBox1.Text);
            double netice = 0;
            string hesabSetiri = birinciEded + " " + emeliyyat + " " + ikinciEded + " = ";

            switch (emeliyyat)
            {
                case "+":
                    netice = birinciEded + ikinciEded;
                    break;
                case "-":
                    netice = birinciEded - ikinciEded;
                    break;
                case "*":
                    netice = birinciEded * ikinciEded;
                    break;
                case "/":
                    if (ikinciEded != 0)
                    {
                        netice = birinciEded / ikinciEded;
                    }
                    else
                    {
                        MessageBox.Show("Sifira bolmek olmaz!");
                        netice = 0;
                    }
                    break;
            }

            richTextBox1.Text = netice.ToString();

            listBox1.Items.Add(hesabSetiri + netice);
            click = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text) && richTextBox1.Text != "0")
            {
                if (richTextBox1.Text.StartsWith("-"))
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                }
                else
                {
                    richTextBox1.Text = "-" + richTextBox1.Text;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                double say = Convert.ToDouble(richTextBox1.Text);
                double netice = (birinciEded * say) / 100;
                richTextBox1.Text = netice.ToString();
                click = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            birinciEded = 0;
            emeliyyat = "";
            click = false;
        }
    }
}