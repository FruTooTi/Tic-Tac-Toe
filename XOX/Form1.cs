using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        Game new_game = new Game();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void SuccessChecker(bool value)
        {
            if(value)
            {
                return;
            }
            else
            {
                MessageBox.Show("Please press a valid button");
            }
        }
        private void QueueLabelSetter()
        {
            if(new_game.queue == "O")
            {
                QueueLabel.Text = "O";
                QueueLabel.ForeColor = Color.Blue;
            }
            else
            {
                QueueLabel.Text = "X";
                QueueLabel.ForeColor = Color.Red;
            }
        }
        private void EndGameChecker()
        {
            DialogResult dr = MessageBox.Show("Would you like to restart?", "Restart?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                GamemodeLabel.Visible = true;
                SinglePlayer.Visible = true;
                MultiPlayer.Visible = true;

                QueueLabel.Visible = false;
                label1.Visible = false;

                new_game = new Game();
            }
            else
            {
                Application.Exit();
            }
        }
        private void WinChecker()
        {
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X won the game!");
                EndGameChecker();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O won the game!");
                EndGameChecker();
            }
            else if(new_game.total_moves == 9)
            {
                MessageBox.Show("It's a draw!");
                EndGameChecker();
            }
        }
        private void SinglePlayerAI()
        {
            if(new_game.gamemode == 1)
            {
                if(new_game.queue == "O")
                {
                    bool move = AIFinisherorBlocker();
                    if (!move)
                    {
                        AIChecker();
                    }
                }
            }
        }

        private bool AIFinisherorBlocker()
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "")
            {
                button3_Click(null, null);
                return true;
            }
            else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "")
            {
                button2_Click(null, null);
                return true;
            }
            else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "")
            {
                button1_Click(null, null);
                return true;
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "")
            {
                button6_Click(null, null);
                return true;
            }
            else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button2.Text == "O" && button3.Text == "O" && button4.Text == "")
            {
                button4_Click(null, null);
                return true;
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "")
            {
                button9_Click(null, null);
                return true;
            }
            else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "")
            {
                button8_Click(null, null);
                return true;
            }
            else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "")
            {
                button7_Click(null, null);
                return true;
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "")
            {
                button7_Click(null, null);
                return true;
            }
            else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "")
            {
                button4_Click(null, null);
                return true;
            }
            else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "")
            {
                button1_Click(null, null);
                return true;
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "")
            {
                button8_Click(null, null);
                return true;
            }
            else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "")
            {
                button2_Click(null, null);
                return true;
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "")
            {
                button9_Click(null, null);
                return true;
            }
            else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "")
            {
                button6_Click(null, null);
                return true;
            }
            else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "")
            {
                button3_Click(null, null);
                return true;
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "")
            {
                button9_Click(null, null);
                return true;
            }
            else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "")
            {
                button1_Click(null, null);
                return true;
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "")
            {
                button7_Click(null, null);
                return true;
            }
            else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "")
            {
                button3_Click(null, null);
                return true;
            }
            else if (button1.Text == "X" && button2.Text == "X" && button3.Text == "")
            {
                button3_Click(null, null);
                return true;
            }
            else if (button1.Text == "X" && button3.Text == "X" && button2.Text == "")
            {
                button2_Click(null, null);
                return true;
            }
            else if (button2.Text == "X" && button3.Text == "X" && button1.Text == "")
            {
                button1_Click(null, null);
                return true;
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "")
            {
                button6_Click(null, null);
                return true;
            }
            else if (button4.Text == "X" && button6.Text == "X" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "X" && button6.Text == "X" && button4.Text == "")
            {
                button4_Click(null, null);
                return true;
            }
            else if (button2.Text == "X" && button3.Text == "X" && button4.Text == "")
            {
                button4_Click(null, null);
                return true;
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "")
            {
                button9_Click(null, null);
                return true;
            }
            else if (button7.Text == "X" && button9.Text == "X" && button8.Text == "")
            {
                button8_Click(null, null);
                return true;
            }
            else if (button8.Text == "X" && button9.Text == "X" && button7.Text == "")
            {
                button7_Click(null, null);
                return true;
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "")
            {
                button7_Click(null, null);
                return true;
            }
            else if (button1.Text == "X" && button7.Text == "X" && button4.Text == "")
            {
                button4_Click(null, null);
                return true;
            }
            else if (button4.Text == "X" && button7.Text == "X" && button1.Text == "")
            {
                button1_Click(null, null);
                return true;
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "")
            {
                button8_Click(null, null);
                return true;
            }
            else if (button2.Text == "X" && button8.Text == "X" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "X" && button8.Text == "X" && button2.Text == "")
            {
                button2_Click(null, null);
                return true;
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "")
            {
                button9_Click(null, null);
                return true;
            }
            else if (button3.Text == "X" && button9.Text == "X" && button6.Text == "")
            {
                button6_Click(null, null);
                return true;
            }
            else if (button6.Text == "X" && button9.Text == "X" && button3.Text == "")
            {
                button3_Click(null, null);
                return true;
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "")
            {
                button9_Click(null, null);
                return true;
            }
            else if (button1.Text == "X" && button9.Text == "X" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "X" && button9.Text == "X" && button1.Text == "")
            {
                button1_Click(null, null);
                return true;
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "")
            {
                button7_Click(null, null);
                return true;
            }
            else if (button3.Text == "X" && button7.Text == "X" && button5.Text == "")
            {
                button5_Click(null, null);
                return true;
            }
            else if (button5.Text == "X" && button7.Text == "X" && button3.Text == "")
            {
                button3_Click(null, null);
                return true;
            }
            else
            {
                return false;
            }

        }
        private void AIChecker()
        {
            if (button5.Text != "X" && button5.Text != "O")
            {
                button5_Click(null, null);
            }
            else
            {
                int possibility = rnd.Next(0, 101);
                if (possibility < 18 && (button1.Text != "X" && button1.Text != "O"))
                {
                    button1_Click(null, null);
                }
                else if (possibility < 35 && possibility > 17 && (button3.Text != "X" && button3.Text != "O"))
                {
                    button3_Click(null, null);
                }
                else if (possibility < 52 && possibility > 34 && (button7.Text != "X" && button7.Text != "O"))
                {
                    button7_Click(null, null);
                }
                else if (possibility < 69 && possibility > 51 && (button9.Text != "X" && button9.Text != "O"))
                {
                    button9_Click(null, null);
                }
                else if (possibility < 77 && possibility > 68 && (button2.Text != "X" && button2.Text != "O"))
                {
                    button2_Click(null, null);
                }
                else if (possibility < 85 && possibility > 76 && (button4.Text != "X" && button4.Text != "O"))
                {
                    button4_Click(null, null);
                }
                else if (possibility < 93 && possibility > 84 && (button6.Text != "X" && button6.Text != "O"))
                {
                    button6_Click(null, null);
                }
                else if (possibility < 101 && possibility > 92 && (button8.Text != "X" && button8.Text != "O"))
                {
                    button8_Click(null, null);
                }
                else
                {
                    AIChecker();
                }
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button1", button1);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button2", button2);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button3", button3);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button4", button4);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button5", button5);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button6", button6);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button7", button7);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button8", button8);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            bool operation = new_game.ButtonChecker("button9", button9);
            SuccessChecker(operation);
            WinChecker();
            QueueLabelSetter();
            SinglePlayerAI();
        }

        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            new_game = new Game(rnd.Next(1, 3));
            new_game.gamemode = 1;
            if (new_game.queue == "X")
            {
                QueueLabel.Text = "X";
                QueueLabel.ForeColor = Color.Red;
            }
            else
            {
                QueueLabel.Text = "O";
                QueueLabel.ForeColor = Color.Blue;
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            SinglePlayer.Visible = false;
            MultiPlayer.Visible = false;
            GamemodeLabel.Visible = false;

            QueueLabel.Visible = true;
            label1.Visible = true;

            SinglePlayerAI();
        }

        private void MultiPlayer_Click(object sender, EventArgs e)
        {
            new_game = new Game(rnd.Next(1, 3));
            new_game.gamemode = 2;
            if (new_game.queue == "X")
            {
                QueueLabel.Text = "X";
                QueueLabel.ForeColor = Color.Red;
            }
            else
            {
                QueueLabel.Text = "O";
                QueueLabel.ForeColor = Color.Blue;
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            SinglePlayer.Visible = false;
            MultiPlayer.Visible = false;
            GamemodeLabel.Visible = false;

            QueueLabel.Visible = true;
            label1.Visible = true;

            SinglePlayerAI();
        }
    }
}
