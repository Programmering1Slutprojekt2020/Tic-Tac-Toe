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

        string wincache = ""; //cache för att se vem som fick poäng senast
        int winp1 = 0; //spelare 1 score
        int winp2 = 0; //spelare 2 score

        void restartgame()
        {
            foreach (Button btn in this.Controls.OfType<Button>()) //alla knappar som används blir tomma
            {
                btn.Text = "";
            }
            button10.Text = "Restart";//lägger till så att restart blir restart och inte tom
            count = 0; // återställa omgång
        }

        void winner(object symbol) //skriver utt vinnaren 
        {
            string playerwin = "Player 1";
            if (symbol == "X")
            {
                playerwin = "Player 2";
            }
            MessageBox.Show(playerwin + " won the game!");
        } 

        void checkwinner(string symbol)
        {
            if (button1.Text==symbol && button2.Text == symbol && button3.Text == symbol) //x1
            {
                winner(symbol); //skickar bikstaven till metoiden som skriver ut vinnaren
                wincache = symbol; // wincache får x eller 0 beroende vem som vann
                restartgame();
            }
            else if(button4.Text == symbol && button5.Text == symbol && button6.Text == symbol) //x2
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol) //x3
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            //alla i xled
            else if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol) //y1
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            else if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol) //y2
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            else if (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol) //y3
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            //alla i y led
            else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol) //deagonalt
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            else if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol) //deagonalt
            {
                winner(symbol);
                wincache = symbol;
                restartgame();
            }
            else
            {
                wincache = ""; // nollställa cache
            }
        }

        void score()
        {
            if (wincache == "0")
            {
                winp1++;
            }
            else if (wincache == "X")
            {
                winp2++;
            }
            ScoreP1.Text = ("Score:  " + winp1); //uppdaterar scoreboard
            ScoreP2.Text = ("Score:  " + winp2);
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
                score();
                checkwinner("X");
                score();

                if (count > 8) //alla rutor är fulla
                {
                    MessageBox.Show("Draw, try again!");
                    restartgame();
                }
            }
            else 
            {
                MessageBox.Show("Invalid Click!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
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

        private void button10_Click(object sender, EventArgs e)
        {
            restartgame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
