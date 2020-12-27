using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class ParkingMeter : Form
    {
        public ParkingMeter()
        {
            InitializeComponent();
        }
        int charge;
        double time;
        //============DHE KETU=======================
        Random r = new Random();
        int sum = 0;
        /*private void btn_Click(object sender, EventArgs e)
        {
            sum += r.Next(0, 100);
            richTextBox2.Text = sum.ToString();
        }*/
        //================TEST KETU===================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Clean()
        {
            tekst1.Text = "";
            input1.Text = "";
            richTextBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            richTextBox2.Text = "";
            Option.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }


            private void tekst1_TextChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                if(charge >= 24)
                {
                    tekst1.Text = " ";
                    
                }
                }
            if (radioButton2.Checked == true)
            {
               
                if (charge <= 23)
                {
                    tekst1.Text = " ";
                    
                }
            }
            }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Choose an option!");
            }

            else
            {
                charge = Convert.ToInt32(input1.Text);

                if (charge <= 3 || charge == 0)
                {
                    tekst1.Text = "2$";
                    int a = Convert.ToInt32(input1.Text);
                    int n = Convert.ToInt32(DateTime.Now.ToString("hh"));
                    int c = n + a;
                    textBox1.Text = Convert.ToString(c) + ":" + Convert.ToInt32(DateTime.Now.ToString("mm"));
                    richTextBox2.Text = "========PARKING TICKET========= " +
                       "\n DATE: " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss") +
                    "\n END DATE: " + textBox1.Text +
                   " \nTICKET ID. " + " AA" + sum.ToString() +
                       "\nOPTION: " + Option.Text +
                       "\nHOURS: " + input1.Text +
                       "\nPRICE: " + tekst1.Text +
                       " \nTHANK YOU FOR USING OUR SERVICE";
                }
                else
                {
                    time = 2;
                    for (int i = 3; i < charge; i++)
                    {
                        time += 0.50;
                        tekst1.Text = time.ToString() + "$";
                        int a = Convert.ToInt32(input1.Text);
                        int n = Convert.ToInt32(DateTime.Now.ToString("hh"));
                        int c = n + a;
                        textBox1.Text = Convert.ToString(c) + ":" + Convert.ToInt32(DateTime.Now.ToString("mm")); ;
                    }
                    sum += r.Next(0, 100);
                    richTextBox2.Text = "========PARKING TICKET========= " +
                        "\n DATE: " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss") +
                     "\n END DATE: " + textBox1.Text +
                    " \nTICKET ID. " + " AA" + sum.ToString() +
                        "\nOPTION: " + Option.Text +
                        "\nHOURS: " + input1.Text +
                        "\nPRICE: " + tekst1.Text +
                        " \nTHANK YOU FOR USING OUR SERVICE";
                    //===============KETU TESTIM==================
                    if (radioButton1.Checked == true)
                    {
                        if (charge >= 24)
                        {
                            MessageBox.Show("Choose the option More then 24h");
                            Clean();
                        }
                    }
                    else
                    {
                        if (radioButton2.Checked == true)
                        {
                            if (charge <= 23)
                            {
                                MessageBox.Show("CHOOSE LESS THEN 24H");
                                Clean();
                            }
                        }
                    }
                }
            }
                int num = 24;
                int z = charge / num;
                textBox2.Text = Convert.ToString(z + "Days");
            }






            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButton1.Checked == true)
            {
               
                richTextBox1.Text = "Price for less than 24h\n" +
                    "0-3h = 2$\n" +
                    "3-23h = 2$ + 0.5$/h";

                
            }
           if(radioButton1.Checked == true)
            {
                Option.Text = "Less then 24h";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                richTextBox1.Text = "Price for more than 24h\n" +
                    "1 day = 10$\n" +
                    "3-5 days = 35$\n" +
                    "5+ days = 35$ + 5$";
            }

            if(radioButton2.Checked == true)
            {
                Option.Text = "More then 24h";
            }

        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please choose an option and input the hours!");
            }
            else
            {

                MessageBox.Show("========PARKING TICKET========= " +
                        "\n START DATE: " + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss") +
                      "\n END DATE: " + textBox1.Text + 
                " \nTICKET ID. " + " AA" + sum.ToString() +
                        "\nOPTION: " + Option.Text +
                        "\nHOURS: " + input1.Text +
                        "\nPRICE: " + tekst1.Text +
                        " \nTHANK YOU FOR USING OUR SERVICE") ;

                Clean();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //PER TE PARE DITET
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

