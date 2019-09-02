using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cambiarbackcolor
{
    public partial class programa : Form
    {
        public programa()
        {
            InitializeComponent();
        }

        private void Rojo_Click(object sender, EventArgs e)
        {
            
            BackColor = System.Drawing.Color.Red;
        }

        private void Verde_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Green;
        }

        private void Azul_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Blue;
        }

        private void Negro_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Black;
        }

        private void Amarillo_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Yellow;
        }

        private void Morado_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Purple;
        }

        private void Blanco_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.White;
        }
    }
}
