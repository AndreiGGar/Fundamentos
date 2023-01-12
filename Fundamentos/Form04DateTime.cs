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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.actualDate.Text = DateTime.Now.ToString();
        }

        private void dateChange_CheckedChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(actualDate.Text);
            if (this.dateChange.Checked == true)
            {
                this.actualDate.Text = date.ToShortDateString();
            }
            else
            {
                this.actualDate.Text = date.ToLongDateString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int add = int.Parse(this.addTxt.Text);
            DateTime date = DateTime.Parse(this.actualDate.Text);

            if (this.days.Checked == true)
            {
                date = date.AddDays(add);
            } else if (this.months.Checked == true)
            {
                date = date.AddMonths(add);
            }
            else
            {
                date = date.AddYears(add);
            }

            this.newDate.Text = date.ToString();
        }
    }
}
