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
    public partial class Form10Random : Form
    {
        public Form10Random()
        {
            InitializeComponent();
            this.list.SelectionMode = SelectionMode.MultiExtended;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor = random.Next(1, 200);
            this.list.Items.Add(valor);
        }

        /* private void data_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int odd = 0;
            int even = 0;
            for (int i = 0; i < this.list.Items.Count; i++)
            {
                int num = int.Parse(this.list.Items[i].ToString());
                sum += num;
                if (num % 2 == 0)
                {
                    even += num;
                } else
                {
                    odd += num; 
                }
            }
            this.sum.Text = sum.ToString();
            this.odd.Text = odd.ToString();
            this.even.Text = even.ToString();
        }*/
        private void data_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int odd = 0;
            int even = 0;
            foreach (int elem in this.list.SelectedItems)
            {
                int num = elem;
                sum += num;
                if (num % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }
            }
            this.sum.Text = sum.ToString();
            this.odd.Text = odd.ToString();
            this.even.Text = even.ToString();
        }
    }
}
