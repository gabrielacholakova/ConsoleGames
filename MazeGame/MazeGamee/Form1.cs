using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGamee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox50_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You hit the wall! Game over!");
        }

        private void pictureBox52_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You won the game!");
        }

        private void pictureBox53_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You hit the wall! Game over!");
        }
    }
}
