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
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            String text = this.email.Text;
            if (text.Contains("@")) 
            { 
                if (!text.StartsWith("@") || !text.EndsWith("@"))
                {
                    // if (text.IndexOf("@", text.IndexOf("@") + 1) == -1)
                    if (text.IndexOf("@") == text.LastIndexOf("@"))
                    {
                        if (text.Contains("."))
                        {
                            /*string compare = text.Substring(text.IndexOf("@"), text.Length - 1);
                            if (compare.Contains("."))
                            {
                                this.result.Text = "bien";
                            } else
                            {
                                this.result.Text = "El email no contiene ningún punto después del @.";
                            }*/
                            if (text.LastIndexOf(".") > text.IndexOf("@"))
                            {
                                int lastPoint = text.LastIndexOf(".");
                                string domain = text.Substring(lastPoint + 1);
                                if (domain.Length >= 2 && domain.Length <= 4)
                                {
                                    this.result.Text = "Nice email bro.";
                                } else
                                {
                                    this.result.Text = "El dominio debe ser de 2 a 4 caracteres.";
                                }
                            } else
                            {
                                this.result.Text = "Debe de existir un punto después del @.";
                            }
                        } else {
                            this.result.Text = "El email no contiene ningún punto.";
                        }
                    } else
                    {
                        this.result.Text = "Hay más de una @ en el email.";
                    }
                } else
                {
                    this.result.Text = "El email empieza o acaba por @.";
                }
            } else
            {
                this.result.Text = "El email no contiene @.";
            }
        }
    }
}
