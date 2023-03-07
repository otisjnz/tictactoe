using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int turn = 0;
        void reset()
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
        }

        private void buttonClick(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;
            
            if(turn%2 == 0 )
            {
                clickedButton.Text = "X";
                displayturn.Text = "Player 1";
                turn++;
                
            }
            else
            {
                clickedButton.Text = "O";
                displayturn.Text = "Player 2";
                turn++;
                
            }

            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||  //top 
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||  //left diagonal
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X" ||  //right diagonal
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || //bottom
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || //left
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" //right
                )
            {
                MessageBox.Show("Player 1 Wins!");
                reset();
            }
            else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||  //top 
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||  //left diagonal
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O" ||  //right diagonal
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" || //bottom
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" || //left
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" //right
                )
            {
                MessageBox.Show("Player 2 Wins!");
                reset();
            }
        }
        private void resetGame(object sender, EventArgs e)
        {
            reset();
        }
    }
}
