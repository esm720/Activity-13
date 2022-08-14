using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static Random random = new Random();

        private int randGen()
        {
            return random.Next(0,2);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
          ResultLabel.Text = " ";

          int ROW = 3;
          int COL = 3;
          int[,] ticTacArray = new int[ROW, COL];
          string[,] ticTacDisplayArray = new string[ROW, COL]; 
         

            for(int row = 0; row < ROW; row++)
            {
                for(int col = 0; col < COL; col++)
                {
                    ticTacArray[row, col] = randGen();
                    if (ticTacArray[row,col] == 0)
                    {
                        ticTacDisplayArray[row, col] = "X";
                    }
                    else
                    {
                        ticTacDisplayArray[row, col] = "O";
                    }
                }
            }

            TLLabel.Text = ticTacDisplayArray[0, 0];
            TMLabel.Text = ticTacDisplayArray[0, 1];
            TRLabel.Text = ticTacDisplayArray[0, 2];
            MLLabel.Text = ticTacDisplayArray[1, 0];
            MMLabel.Text = ticTacDisplayArray[1, 1];
            MRLabel.Text = ticTacDisplayArray[1, 2];
            BLLabel.Text = ticTacDisplayArray[2, 0];
            BMLabel.Text = ticTacDisplayArray[2, 1];
            BRLabel.Text = ticTacDisplayArray[2, 2];

            checkWin();
        }

        private void checkWin()
        {
            int xPlayerWins = 0;
            int yPlayerWins = 0;
            //HORIZONTAL WINS
            if (TLLabel.Text.Equals("X") && TMLabel.Text.Equals("X") && TRLabel.Text.Equals("X"))//
            {
                xPlayerWins++;
            }
            else if (TLLabel.Text.Equals("O") && TMLabel.Text.Equals("O") && TRLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            if (MLLabel.Text.Equals("X") && MMLabel.Text.Equals("X") && MRLabel.Text.Equals("X"))//
            {
                xPlayerWins++;
            }
            else if (MLLabel.Text.Equals("O") && MMLabel.Text.Equals("O") && MRLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            if (BLLabel.Text.Equals("X") && BMLabel.Text.Equals("X") && BRLabel.Text.Equals("X"))
            {
                xPlayerWins++;
            }
            else if (BLLabel.Text.Equals("O") && BMLabel.Text.Equals("O") && BRLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            //VERTICAL WINS
            if (TLLabel.Text.Equals("X") && MLLabel.Text.Equals("X") && BLLabel.Text.Equals("X"))
            {
                xPlayerWins++;
            }
            else if (TLLabel.Text.Equals("O") && MLLabel.Text.Equals("O") && BLLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            if (TMLabel.Text.Equals("X") && MMLabel.Text.Equals("X") && BMLabel.Text.Equals("X"))
            {
                xPlayerWins++;
            }
            else if (TMLabel.Text.Equals("O") && MMLabel.Text.Equals("O") && BMLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            if (TRLabel.Text.Equals("X") && MRLabel.Text.Equals("X") && BRLabel.Text.Equals("X"))
            {
                xPlayerWins++;
            }
            else if (TRLabel.Text.Equals("O") && MRLabel.Text.Equals("O") && BRLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            //DIAGNAL WINS

            if (TLLabel.Text.Equals("X") && MMLabel.Text.Equals("X") && BRLabel.Text.Equals("X"))
            {
                xPlayerWins++;
            }
            else if (TLLabel.Text.Equals("O") && MMLabel.Text.Equals("O") && BRLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            if (TRLabel.Text.Equals("X") && MMLabel.Text.Equals("X") && BLLabel.Text.Equals("X"))
            {
                xPlayerWins++;
            }
            else if (TRLabel.Text.Equals("O") && MMLabel.Text.Equals("O") && BLLabel.Text.Equals("O"))
            {
                yPlayerWins++;
            }
            //Compare Wins
            if(xPlayerWins > yPlayerWins)
            {
                ResultLabel.Text = "X Player Wins";
            }
            else if (xPlayerWins < yPlayerWins)
            {
                ResultLabel.Text = "O Player Wins";
            }
            else
            {
                ResultLabel.Text = "It's a Tie";
            }
           // MessageBox.Show("X: " + xPlayerWins + "\n Y: " + yPlayerWins); USE FOR DEBUGGING WIN COUNT

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
