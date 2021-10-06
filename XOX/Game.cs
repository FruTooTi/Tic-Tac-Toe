using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace XOX
{
    class Game
    {
        public string queue { get; set; }
        public int total_moves { get; set; }

        public int gamemode { get; set; }
        
        public Hashtable buttons = new Hashtable()
        {
            { "button1" , "" },
            { "button2" , "" },
            { "button3" , "" },
            { "button4" , "" },
            { "button5" , "" },
            { "button6" , "" },
            { "button7" , "" },
            { "button8" , "" },
            { "button9" , "" },
        };
        public Game(int starter)
        {
            if(starter == 1)
            {
                queue = "X";
            }
            else if(starter == 2)
            {
                queue = "O";
            }
        }

        public Game()
        {
            gamemode = 0;
        }

        public bool ButtonChecker(string button, Button buttontext)
        {
            if (buttons[button] == "")
            {
                if(queue == "X")
                {
                    total_moves++;
                    buttontext.Text = queue;
                    buttontext.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
                    buttons[button] = queue;
                    queue = "O";
                }
                else
                {
                    total_moves++;
                    buttontext.Text = queue;
                    buttontext.ForeColor = System.Drawing.Color.FromArgb(0, 0, 255);
                    buttons[button] = queue;
                    queue = "X";
                }
                return true;
            }
            return false;
        }
    }
}
