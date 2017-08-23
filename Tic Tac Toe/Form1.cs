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
        bool turn = true;//true=x,false=o;
        int turn_count = 0;
        bool againest_computer = false;
        //static string player1, player2;

        public Form1()
        {
            InitializeComponent();
        }

        //public static void SetPlayerName(string n1,string n2)
        //{
        //    player1 = n1+" Wins";
        //    player2 = n2+" Wins";
        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Kanon Shet", "Tic Tac Toe");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

                foreach (Control c in Controls)
                {
                try
                {
                       Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch (Exception)
                {

                    //throw;
                }
                }//end foreach

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if(p1.Text=="Player 1"&&p2.Text=="Player 2")
            {
                MessageBox.Show("you can set yours name as a player\n If you set computer(for Player 2)\n computer mama will play with you");
            }
            else
            {
                Button b = (Button)sender;
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
                turn = !turn;
                b.Enabled = false;
                turn_count++;
                CheckForWinner();

            }
            if ((!turn) &&( againest_computer))
            {
                computer_make_move();
            }

        }
        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            //horizontali checked.
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
            {
                there_is_a_winner = true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
            {
                there_is_a_winner = true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
            {
                there_is_a_winner = true;
            }

            //verticalli checked.
            if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
            {
                there_is_a_winner = true;
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
            {
                there_is_a_winner = true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
            {
                there_is_a_winner = true;
            }           
            
            //diagonally checked.
            if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
            {
                there_is_a_winner = true;
            }
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled)
            {
                there_is_a_winner = true;
            }

            if (there_is_a_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " win!", "yaa");
                turn = true;
                turn_count = 0;

                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                }//end foreach

            }
            else
            {
                if(turn_count==9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!!!!", "opps");
                    turn = true;
                    turn_count = 0;

                    foreach (Control c in Controls)
                    {
                        try
                        {
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.Text = "";
                        }
                        catch (Exception)
                        {

                            //throw;
                        }
                    }//end foreach

                }
            }
        }
        //end checkforwinndr

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach

            }
            catch (Exception)
            {

               
            }

        }

        private void button_enter(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (b.Enabled)
                {
                    if (turn)
                    {
                        b.Text = "X";
                    }
                    else
                    {
                        b.Text = "O";
                    }
                }//end if
            }
            catch (Exception)
            {

            
            }
            

        }

        private void button_leave(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (b.Enabled)
                {
                    b.Text = "";
                }//end if
            }
            catch (Exception)
            {

                
            }


        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw_count.Text = "0";
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch (Exception)
                {

                    //throw;
                }
            }//end foreach


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Form2 f2 = new Form2();
             f2.ShowDialog();
             label1.Text = player1;
             label3.Text = player2;
             */
            setDefaultPlayerToolStripMenuItem.PerformClick();
        }

        private void p2_textchanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
            {
                againest_computer = true;
            }
            else
            {
                againest_computer = false;
            }
        }
        private void computer_make_move()
        {
            //priority1:get tic tac toe
            //priority2:stop x's tic tac toe
            //priority3:get the corner space
            //priority4:get the free space

            Button move = null;
            //look for tic tac toe opportunity
            move = look_for_win_or_block("O");//look for win.
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            move.PerformClick();
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }


        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }




        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }




        private void setDefaultPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.Text = "Player 1";
            p2.Text = "Player 2";
        }
    }
}
