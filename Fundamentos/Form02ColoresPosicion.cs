using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void coord_Click(object sender, EventArgs e)
        {
            int coordX = int.Parse(this.posicionX.Text);
            int coordY = int.Parse(this.posicionY.Text);
            this.coord.Location = new Point(coordX, coordY);
        }

        private void fondo_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.red.Text);
            int green = int.Parse(this.green.Text);
            int blue = int.Parse(this.blue.Text);
            if (red <= 0 || red > 255)
            {
                MessageBox.Show("El color rojo debe estar entre 0 y 255.");
            } else if (green <= 0 || green > 255)
            {
                MessageBox.Show("El color verde debe estar entre 0 y 255.");
            } else if (blue <= 0 || blue > 255)
            {
                MessageBox.Show("El color azul debe estar entre 0 y 255.");
            } else
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }
        }
    }
}
