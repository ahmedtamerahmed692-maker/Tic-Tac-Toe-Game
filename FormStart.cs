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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            Form1 classicGame = new Form1();
            classicGame.Show();
        }

        private void btnPharaonic_Click(object sender, EventArgs e)
        {
            Form2 pharaonicGame = new Form2();
            pharaonicGame.Show();
        }
    }
}
