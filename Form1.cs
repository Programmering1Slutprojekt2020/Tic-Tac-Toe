using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0; //för att hålla reda vems tur det är

        void checkwinner(string symbol)
        {
            if (button1.Text==symbol && button2.Text == symbol && button3.Text == symbol) //x1
            {
                MessageBox.Show(symbol+" Won the game");
            }
            else if(button4.Text == symbol && button5.Text == symbol && button6.Text == symbol) //x2
            {
                    MessageBox.Show(symbol + " Won the game");
                }
            else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol) //x3
            {
                MessageBox.Show(symbol + " Won the game");
            }
            //alla i xled
            else if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol) //y1
            {
                MessageBox.Show(symbol + " Won the game");
            }
            else if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol) //y2
            {
                MessageBox.Show(symbol + " Won the game");
            }
            else if (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol) //y3
            {
                MessageBox.Show(symbol + " Won the game");
            }
            //alla i y led
            else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol) //y3
            {
                MessageBox.Show(symbol + " Won the game");
            }
        }

        void fnsymbol(object senderobj)
        {
            string buttontxt = ((Button)senderobj).Text;
            if (buttontxt == "")
            {
                if (count % 2 == 0)
                {
                    ((Button)senderobj).Text = "0";
                }
                else
                {
                    ((Button)senderobj).Text = "X";
                }

                count++;//ökar så att dte blir nästa omgång
                checkwinner("0");
                checkwinner("X");
            }
            else 
            {
                MessageBox.Show("Invalid Click");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }
    }
}
