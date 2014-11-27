using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public bool playerOneTurn = true;
        public bool playerTwoTurn = false;
        public bool[] matrix = new bool[9];
        public string[] matrixSymbols = new string[9];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = false;
            }
        }

        public bool checkIfCellIsFull(int index)
        {
            if (matrix[index] == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }   

        public void ticTacToe()
        {
            // Start of horizontal line check
            if (matrixSymbols[0] == "X" && matrixSymbols[1] == "X" && matrixSymbols[2] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[3] == "X" && matrixSymbols[4] == "X" && matrixSymbols[5] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[6] == "X" && matrixSymbols[7] == "X" && matrixSymbols[8] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[0] == "Y" && matrixSymbols[1] == "Y" && matrixSymbols[2] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[3] == "Y" && matrixSymbols[4] == "Y" && matrixSymbols[5] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[6] == "Y" && matrixSymbols[7] == "Y" && matrixSymbols[8] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }
            // End of horizontal check

            // Start of vertical check
            if (matrixSymbols[0] == "X" && matrixSymbols[3] == "X" && matrixSymbols[6] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[1] == "X" && matrixSymbols[4] == "X" && matrixSymbols[7] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[2] == "X" && matrixSymbols[5] == "X" && matrixSymbols[8] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[0] == "Y" && matrixSymbols[3] == "Y" && matrixSymbols[6] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[1] == "Y" && matrixSymbols[4] == "Y" && matrixSymbols[7] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[2] == "Y" && matrixSymbols[5] == "Y" && matrixSymbols[8] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }
            // End of vertical check

            // Start of diagonal checks
            if (matrixSymbols[0] == "X" && matrixSymbols[4] == "X" && matrixSymbols[8] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[2] == "X" && matrixSymbols[4] == "X" && matrixSymbols[6] == "X")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[0] == "Y" && matrixSymbols[4] == "Y" && matrixSymbols[8] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }

            if (matrixSymbols[2] == "Y" && matrixSymbols[4] == "Y" && matrixSymbols[6] == "Y")
            {
                MessageBox.Show("Winner is Player 1!", "We have a winner!");
                Application.Restart();
            }
            // End of diagonal checks
        }

        public void gameLogic(PictureBox picBox, int cell)
        {
            if (playerOneTurn == true && checkIfCellIsFull(cell) == false)
            {
                picBox.Image = Image.FromFile(@"C:\Users\Нико\Documents\Visual Studio 2013\Projects\tictactoe\tictactoe\x.png");
                matrix[cell] = true;
                matrixSymbols[cell] = "X";
                playerOneTurn = false;
                playerTwoTurn = true;
            }
            else if (playerOneTurn == false && playerTwoTurn == true && checkIfCellIsFull(cell) == false)
            {
                picBox.Image = Image.FromFile(@"C:\Users\Нико\Documents\Visual Studio 2013\Projects\tictactoe\tictactoe\o.png");
                matrix[cell] = true;
                matrixSymbols[cell] = "O";
                playerOneTurn = true;
                playerTwoTurn = false;
            }

            ticTacToe();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox1, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox2, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox3, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox4, 3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox5, 4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox6, 5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox7, 6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox8, 7);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            gameLogic(pictureBox9, 8);
        }
    }
}
