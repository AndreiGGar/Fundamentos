﻿using System;
using System.Collections;
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
    public partial class Form13ArrayList : Form
    {
        public Form13ArrayList()
        {
            InitializeComponent();
            // List<Button> botones = new List<Button>();
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            ((Button)coleccion[0]).Text = "Bot 1";
            /*foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.Bisque;
            }*/
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.Bisque;
                if (control is TextBox)
                {
                    //((TextBox)control).BackColor = Color.RebeccaPurple;
                    ((TextBox)control).Paste();
                }
            }
            this.button3.Click += button3_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
