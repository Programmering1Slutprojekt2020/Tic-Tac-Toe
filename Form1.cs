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
