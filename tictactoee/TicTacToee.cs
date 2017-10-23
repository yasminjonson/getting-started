using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace tictactoee
{
    public partial class Form1 : Form
    {
        //Variable to store player, 0 is X, 1 is O.
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button1.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button1.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button1.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button2.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button2.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button2.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button3.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button3.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button3.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button4.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button4.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button4.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button5.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button5.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button5.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button6.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button6.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button6.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button7.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button7.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button7.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button8.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button8.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button8.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                button9.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                button9.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            button9.Enabled = false;

            //Check if anyone won, lose, tie
            check();
        }

        void check()
        {
            //Check if tie
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                textBox1.Text = "Tied";
            }

            //Check diagonal for X
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            //Check rows for X
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            //Check columns for X
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                textBox1.Text = "Player X wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            //Check diagonal for O
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            //Check rows for O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            //Check columns for O
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                textBox1.Text = "Player O wins";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            textBox1.Text = "";
            counter = 0;
        }
    }
}
