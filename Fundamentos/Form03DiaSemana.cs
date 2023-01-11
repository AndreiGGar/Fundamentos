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
    public partial class Form03DiaSemana : Form
    {
        public Form03DiaSemana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = int.Parse(this.day.Text);
            int month = int.Parse(this.month.Text);
            int year = int.Parse(this.year.Text);

            if (month == 1)
            {
                month = 13;
                year -= 1;
            } else if (month == 2)
            {
                month = 14;
                year -= 1;
            }

            int op1 = ((month + 1) * 3) / 5;
            int op2 = year / 4;
            int op3 = year / 100;
            int op4 = year / 400;
            int op5 = day + (month * 2) + year + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);

            this.result.Text = op7.ToString();

            switch(op7)
            {
                case 0:
                    this.result.Text = "Sábado";
                    break;
                case 1:
                    this.result.Text = "Domingo";
                    break;
                case 2:
                    this.result.Text = "Lunes";
                    break;
                case 3:
                    this.result.Text = "Martes";
                    break;
                case 4:
                    this.result.Text = "Miércoles";
                    break;
                case 5:
                    this.result.Text = "Jueves";
                    break;
                case 6:
                    this.result.Text = "Viernes";
                    break;
            }
        }
    }
}
