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
    public partial class Form09ColeccionMultiple : Form
    {
        public Form09ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string elem = this.element.Text;
            this.lstElementos.Items.Add(elem);
            this.element.Focus();
            this.element.SelectAll();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedNums = this.lstElementos.SelectedIndices.Count;
            for (int i = selectedNums - 1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void selecteds_Click(object sender, EventArgs e)
        {
            string indexes = "";
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indexes += index + ",";
            }
            this.lblIndex.Text = indexes.Trim(',');
            string items = "";
            foreach (string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblItem.Text = items.Trim(',');
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
    }
}
