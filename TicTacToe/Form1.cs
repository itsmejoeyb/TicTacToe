using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    //**********************
    //App: TicTacToe
    //Framework: WinForms
    //Dev: Joey Breithaupt
    //Date: 4/28/2019
    //Modified: 4/29/2019
    //**********************
    public partial class Form1 : Form
    {
        bool turn = true;
        int turns = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "")
            {
                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Blue;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Red;
                }
                turn = !turn;
                turns++;
                CheckWin();
            }
        }

        private void CheckWin()
        {
            bool xWins = false;
            bool oWins = false;
            
            if(x0y0.Text == x1y0.Text && x0y0.Text == x2y0.Text && x0y0.Text != "")
            {
                if(x0y0.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            else if(x0y1.Text == x1y1.Text && x0y1.Text == x2y1.Text && x0y1.Text != "")
            {
                if (x0y1.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            else if (x0y2.Text == x1y2.Text && x0y2.Text == x2y2.Text && x0y2.Text != "")
            {
                if (x0y1.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }

            if (x0y0.Text == x0y1.Text && x0y0.Text == x0y2.Text && x0y0.Text != "")
            {
                if (x0y0.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            else if (x1y0.Text == x1y1.Text && x1y0.Text == x1y2.Text && x1y0.Text != "")
            {
                if (x1y0.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            else if (x2y0.Text == x2y1.Text && x2y0.Text == x2y2.Text && x2y0.Text != "")
            {
                if (x2y0.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            
            if(x0y0.Text == x1y1.Text && x0y0.Text == x2y2.Text && x0y0.Text != "")
            {
                if (x0y0.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            else if(x0y2.Text == x1y1.Text && x0y2.Text == x2y0.Text && x0y2.Text != "")
            {
                if (x0y2.Text == "X")
                    xWins = true;
                else
                    oWins = true;
            }
            

            if (xWins)
            {
                MiniMax.Text = "X Wins!";
                MiniMax.ForeColor = Color.Blue;
                foreach (Control c in Controls)
                {
                    if (c.Text == "")
                    {
                        try
                        {
                            _ = (Button)c;
                            c.Text = " ";
                        }
                        catch { }
                    }
                }
            }
            else if (oWins)
            {
                MiniMax.Text = "O Wins!";
                MiniMax.ForeColor = Color.Red;
            }
            else if(xWins == false && oWins == false && turns == 9)
            {
                MiniMax.Text = "Tie Game!";
                MiniMax.ForeColor = Color.Black;
            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiniMax.ForeColor = Color.Black;
            MiniMax.Text = "MiniMax";
            turn = true;
            turns = 0;
            foreach(Control c in Controls)
            {
                try
                {
                    _ = (Button)c;
                    c.Text = "";
                }
                catch { }
            }
        }
    }
}
