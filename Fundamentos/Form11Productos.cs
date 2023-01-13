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
    public partial class Form11Productos : Form
    {
        public Form11Productos()
        {
            InitializeComponent();
            this.store.SelectionMode = SelectionMode.MultiExtended;
        }

        void InsertProduct()
        {
            string text = product.Text.ToString();
            int exists = this.store.Items.IndexOf(text);
            if (exists != -1)
            {
                this.store.SelectedIndex = exists;
            } else
            {
                this.store.Items.Add(text);
            }
        }

        /* private void add_Click(object sender, EventArgs e)
        {
            string text = product.Text.ToString();
            int exists = this.store.Items.IndexOf(text);
            if (exists != -1)
            {
                this.store.SelectedIndex = exists;
            } else
            {
                this.store.Items.Add(text);
            }
        } */

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedNums = this.store.SelectedIndices.Count;
            for (int i = selectedNums - 1; i >= 0; i--)
            {
                int index = this.store.SelectedIndices[i];
                this.store.Items.RemoveAt(index);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int selectedNums = this.store.SelectedIndices.Count;
            string text = product.Text.ToString();
            for (int i = selectedNums - 1; i >= 0; i--)
            {
                int index = this.store.SelectedIndices[i];
                this.store.Items[index] = text;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.store.Items.Clear();
        }

        private void select_Click(object sender, EventArgs e)
        {
            int selectedNums = this.store.SelectedIndices.Count;
            for (int i = selectedNums - 1; i >= 0; i--)
            {
                int index = this.store.SelectedIndices[i];
                this.stock.Items.Add(this.store.SelectedItems[i]);
                this.store.Items.RemoveAt(index);
            }
        }

        private void all_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < this.store.Items.Count; i++)
            {
                this.stock.Items.Add(this.store.Items[i]);
            }*/
            foreach (string item in this.store.Items)
            {
                this.stock.Items.Add(item);
            }
            this.store.Items.Clear();
        }

        private void up_Click(object sender, EventArgs e)
        {
            int index = this.stock.SelectedIndex;
            string product = this.stock.SelectedItem.ToString();
            this.stock.Items.RemoveAt(index);
            this.stock.Items.Insert(index - 1, product);
            this.stock.SelectedIndex = index - 1;
        }

        private void down_Click(object sender, EventArgs e)
        {
            int index = this.stock.SelectedIndex;
            string product = this.stock.SelectedItem.ToString();
            this.stock.Items.RemoveAt(index);
            this.stock.Items.Insert(index + 1, product);
            this.stock.SelectedIndex = index +  1;
        }

        private void stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.stock.SelectedIndex;
            if (index == 0)
            {
                this.up.Enabled = false;
            } else
            {
                this.up.Enabled = true;
            }
            if (index == this.stock.Items.Count - 1)
            {
                this.down.Enabled = false;
            } else
            {
                this.down.Enabled = true;
            }
        }

        private void product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.InsertProduct();
            }
        }
    }
}
