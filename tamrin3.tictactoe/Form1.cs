using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin3.tictactoe
{
    public partial class Form1 : Form
    {
        Boolean turn = false;
        string a;
        int s1 = 1; //The number of times player1 has won
        int s2 = 1; //The number of times player2 has won
        int emt; //the number of empty buttons
        public Form1()
        {

            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.WhiteSmoke)
            {

            if (turn == false)
            {
                label_display.Text = "its player 1 turn";
                ((Button)sender).BackColor = Color.DarkTurquoise;
                ((Button)sender).Text = "X";
                turn = true;
            }
            else
            {
                label_display.Text = "its player 2 turn";
                ((Button)sender).BackColor = Color.DeepPink;
                ((Button)sender).Text = "O";
                turn = false;
            }
            }
            
             gameply(null, null);
        }
        private void gameply(object sender, EventArgs e)
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "")
            {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Lime;
                a = button1.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "")
            {
                button4.BackColor = button5.BackColor = button6.BackColor = Color.Lime;
                a = button4.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "")
            {
                button7.BackColor = button8.BackColor = button9.BackColor = Color.Lime;
                a = button7.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
            {
                button1.BackColor = button4.BackColor = button7.BackColor = Color.Lime;
                a = button1.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "")
            {
                button2.BackColor = button5.BackColor = button8.BackColor = Color.Lime;
                a = button2.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "")
            {
                button3.BackColor = button6.BackColor = button9.BackColor = Color.Lime;
                a = button3.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
            {
                button1.BackColor = button5.BackColor = button9.BackColor = Color.Lime;
                a = button1.Text;
                result(null, null);
                replay(null, null);
            }
            else if (button7.Text == button5.Text && button7.Text == button3.Text && button7.Text != "")
            {
                button7.BackColor = button5.BackColor = button3.BackColor = Color.Lime;
                a = button7.Text;
                result(null, null);
                replay(null, null);
            }
            else
            {
                emt = 0;
                foreach (Button x in panel1.Controls)
                    if (x.Text != "")
                    {
                        emt++;
                        result(null, null);
                    }
            }
        }
        private void button_replay_Click(object sender, EventArgs e)
        {
            txt_player1.Text = "";
            txt_player2.Text = "";
            label_display.Text = "";
            s1 = 1;
            s2 = 1;
            replay(null, null);
        }
        private void result(object sender,EventArgs e)
        {
            if (a == "X")
            {
                MessageBox.Show("player 2 wan", "winner", MessageBoxButtons.OK);
                txt_player2.Text = s2.ToString();
                s2++;
            }
            else if (a == "O")
            {
                MessageBox.Show("player 1 wan", "winner", MessageBoxButtons.OK);
                txt_player1.Text = s1.ToString();
                s1++;
            }
            else if(emt==9)
            {
                label_display.Text = "looks like its a draw!";
                replay(null, null);
            }
        }
        private void replay(object sender,EventArgs e)
        {
            button1.BackColor = button2.BackColor = button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = button5.BackColor = button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = button8.BackColor = button9.BackColor = Color.WhiteSmoke;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            a = "";
        }
    }
    }

