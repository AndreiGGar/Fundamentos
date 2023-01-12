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
    public partial class Form08Colecciones : Form
    {
        public Form08Colecciones()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string elem = this.element.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            /*string selected = this.lstElementos.SelectedItem.ToString();
            this.lstElementos.Items.Remove(selected);*/
            int index = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(index);
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
