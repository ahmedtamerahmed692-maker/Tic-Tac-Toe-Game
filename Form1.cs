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
    public partial class Form1 : Form
    {
        enum enPlayer
        {
            Empty,
            X,
            O
        }

        enPlayer[,] Board = new enPlayer[3, 3];
        private bool isXTurn;
        private int turnCount;
        private bool isGameActive;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!isGameActive) return;

            Button btn = sender as Button;
            if (btn != null)
            {
                ChangeEmage(btn);
            }
        }

        private void ChangeEmage(Button btn)
        {
            if (btn.Tag == null) return;

            string tagStr = btn.Tag.ToString().Replace("\"", "").Trim();
            string[] position = tagStr.Split(',');
            int row = Convert.ToInt32(position[0]);
            int col = Convert.ToInt32(position[1]);

            if (isXTurn)
            {
                btn.Image = ResizeImage(Properties.Resources.X, 60, 60);
                lblTurn.Text = "Player 2";
                Board[row, col] = enPlayer.X;
                isXTurn = false;
            }
            else
            {
                btn.Image = ResizeImage(Properties.Resources.O, 60, 60);
                lblTurn.Text = "Player 1";
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
            b1.BackColor = Color.GreenYellow;
            b2.BackColor = Color.GreenYellow;
            b3.BackColor = Color.GreenYellow;
        }

        private void CheckWinner()
        {
            enPlayer winner = enPlayer.Empty;

            // 1. فحص الصفوف (Rows)
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

            // 2. فحص الأعمدة (Columns)
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

            // 3. فحص الأقطار (Diagonals)
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

            // النتيجة
            if (winner != enPlayer.Empty)
            {
                isGameActive = false;
                string winnerName = (winner == enPlayer.X) ? "Player 1" : "Player 2";
                lblWinner.Text = winnerName;
                MessageBox.Show(winnerName + " Wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (turnCount == 9)
            {
                isGameActive = false;
                lblWinner.Text = "Draw";
                MessageBox.Show("It's a Draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetGame()
        {
            isXTurn = true;
            turnCount = 0;
            isGameActive = true;

            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";

            Array.Clear(Board, 0, Board.Length);
            SetSmallImages();
        }

        private Image ResizeImage(Image img, int newWidth, int newHeight)
        {
            Bitmap b = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, newHeight);
            }
            return b;
        }

        private void SetSmallImages()
        {
            Image smallImage = ResizeImage(Properties.Resources.question_mark_96, 60, 60);

            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button btn in buttons)
            {
                btn.Image = smallImage;
                btn.Enabled = true;
                btn.BackColor = Color.Transparent;
            }
        }

        protected virtual void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen whitePen = new Pen(Color.White, 8))
            {
                whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                int v1X = (button1.Right + button2.Left) / 2;
                int v2X = (button2.Right + button3.Left) / 2;

                int h1Y = (button1.Bottom + button4.Top) / 2;
                int h2Y = (button4.Bottom + button7.Top) / 2;

                int startX = button1.Left - 15;
                int endX = button3.Right + 15;

                int startY = button1.Top - 15;
                int endY = button7.Bottom + 15;

                e.Graphics.DrawLine(whitePen, startX, h1Y, endX, h1Y);
                e.Graphics.DrawLine(whitePen, startX, h2Y, endX, h2Y);

                e.Graphics.DrawLine(whitePen, v1X, startY, v1X, endY);
                e.Graphics.DrawLine(whitePen, v2X, startY, v2X, endY);
            }
        }
    }
}
