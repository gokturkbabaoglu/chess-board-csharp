using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_board_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] buttons = new Button[8, 8];
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int buttonSize = 50;

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = buttonSize;
                    buttons[i, j].Width = buttonSize;
                    buttons[i, j].Left = buttonSize * i + 100;
                    buttons[i, j].Top = buttonSize * j + 15;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].ForeColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int counter = 1;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    buttons[i, j].Text = counter.ToString();
                    counter++;
                }
            }
        }
    }
}
