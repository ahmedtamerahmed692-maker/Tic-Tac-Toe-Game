using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progect_Tic_Tac_Toe_Game
{
    public partial class Form2 : Form
    {
        enum enPlayer
        {
            Empty,
            X,
            O
        }

        private enPlayer[,] Board = new enPlayer[3, 3];
        private bool isXTurn;
        private int turnCount;
        private bool isGameActive;

        public Form2()
        {
            InitializeComponent();
            ResetGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            Button btn = sender as Button;
            if (btn != null)
            {
                MakeMove(btn);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void MakeMove(Button btn)
        {
            if (btn.Tag == null) return;

            string tagStr = btn.Tag.ToString().Replace("\"", "").Trim();
            string[] position = tagStr.Split(',');
            int row = Convert.ToInt32(position[0]);
            int col = Convert.ToInt32(position[1]);

            if (Board[row, col] != enPlayer.Empty) return;

            if (isXTurn)
            {
                btn.Image = ResizeImage(Properties.Resources.pharaonic_x, 85, 85);
                lblTurn.Text = "Turn: Player 2 (O)";
                Board[row, col] = enPlayer.X;
                isXTurn = false;
            }
            else
            {
                btn.Image = ResizeImage(Properties.Resources.pharaonic_o, 85, 85);
                lblTurn.Text = "Turn: Player 1 (X)";
                Board[row, col] = enPlayer.O;
                isXTurn = true;
            }

            btn.Enabled = false;
            turnCount++;

            CheckWinner();
        }

        private bool CheckThree(enPlayer p1, enPlayer p2, enPlayer p3)
        {
            return (p1 != enPlayer.Empty && p1 == p2 && p2 == p3);
        }

        private void HighlightWinner(Button b1, Button b2, Button b3)
        {
            Color goldHighlight = Color.FromArgb(160, 218, 165, 32);
            b1.BackColor = goldHighlight;
            b2.BackColor = goldHighlight;
            b3.BackColor = goldHighlight;
        }

        private void CheckWinner()
        {
            enPlayer winner = enPlayer.Empty;

            // 1. Rows
            if (CheckThree(Board[0, 0], Board[0, 1], Board[0, 2]))
            {
                winner = Board[0, 0];
                HighlightWinner(button1, button2, button3);
            }
            else if (CheckThree(Board[1, 0], Board[1, 1], Board[1, 2]))
            {
                winner = Board[1, 0];
                HighlightWinner(button4, button5, button6);
            }
            else if (CheckThree(Board[2, 0], Board[2, 1], Board[2, 2]))
            {
                winner = Board[2, 0];
                HighlightWinner(button7, button8, button9);
            }
            // 2. Columns
            else if (CheckThree(Board[0, 0], Board[1, 0], Board[2, 0]))
            {
                winner = Board[0, 0];
                HighlightWinner(button1, button4, button7);
            }
            else if (CheckThree(Board[0, 1], Board[1, 1], Board[2, 1]))
            {
                winner = Board[0, 1];
                HighlightWinner(button2, button5, button8);
            }
            else if (CheckThree(Board[0, 2], Board[1, 2], Board[2, 2]))
            {
                winner = Board[0, 2];
                HighlightWinner(button3, button6, button9);
            }
            // 3. Diagonals
            else if (CheckThree(Board[0, 0], Board[1, 1], Board[2, 2]))
            {
                winner = Board[0, 0];
                HighlightWinner(button1, button5, button9);
            }
            else if (CheckThree(Board[0, 2], Board[1, 1], Board[2, 0]))
            {
                winner = Board[0, 2];
                HighlightWinner(button3, button5, button7);
            }

            // Results
            if (winner != enPlayer.Empty)
            {
                isGameActive = false;
                string winnerName = (winner == enPlayer.X) ? "Player 1" : "Player 2";
                lblWinner.Text = "Winner: " + winnerName;
                lblWinner.ForeColor = Color.Yellow;
                MessageBox.Show(winnerName + " Wins!", "Pharaonic Victory 𓋹", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (turnCount == 9)
            {
                isGameActive = false;
                lblWinner.Text = "Status: Draw!";
                lblWinner.ForeColor = Color.Orange;
                MessageBox.Show("It's a Draw!", "Game Over 𓀀", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetGame()
        {
            isXTurn = true;
            turnCount = 0;
            isGameActive = true;

            lblTurn.Text = "Turn: Player 1 (X)";
            lblWinner.Text = "Status: In Progress";
            lblWinner.ForeColor = Color.Gold;

            Array.Clear(Board, 0, Board.Length);
            SetInitialButtonImages();
        }

        private Image ResizeImage(Image img, int newWidth, int newHeight)
        {
            if (img == null) return null;
            Bitmap b = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, newHeight);
            }
            return b;
        }

        private void SetInitialButtonImages()
        {
            Image qImage = ResizeImage(Properties.Resources.pharaonic_question, 85, 85);

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button btn in buttons)
            {
                btn.Image = qImage;
                btn.Enabled = true;
                btn.BackColor = Color.Transparent;
            }
        }

        private void picPapyrusBoard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen darkPen = new Pen(Color.FromArgb(60, 50, 35), 4))
            {
                darkPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                darkPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                // Vertical lines
                e.Graphics.DrawLine(darkPen, 190, 30, 190, 390);
                e.Graphics.DrawLine(darkPen, 365, 30, 365, 390);

                // Horizontal lines
                e.Graphics.DrawLine(darkPen, 40, 150, 520, 150);
                e.Graphics.DrawLine(darkPen, 40, 270, 520, 270);
            }
        }
    }
}
