using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace Fundamentos
{
    public partial class Form21Files : Form
    {
        public Form21Files()
        {
            InitializeComponent();
        }

        private async void read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string contenido = await HelperFiles.ReadFileAsync(path);
                this.content.Text = contenido;
                this.SetStringNombres(contenido);
            }
        }

        private async void write_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                string contenido = this.GetStringNombres();
                await HelperFiles.WriteFileAsync(path, contenido);
                MessageBox.Show("Saved Data");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string nombre = this.name.Text;
            this.list.Items.Add(nombre);
        }

        public string GetStringNombres()
        {
            string data = "";
            foreach (string nombre in this.list.Items)
            {
                data += nombre + ",";
            }
            data = data.Trim(',');
            return data;
        }

        public void SetStringNombres(string data)
        {
            string[] nombres = data.Split(',');
            this.list.Items.Clear();
            foreach (string name in nombres)
            {
                this.list.Items.Add(name);
            }
        }
    }
}
