using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form24XMLCollection : Form
    {
        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;
        public Form24XMLCollection()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas = new List<Mascota>();
        }
        private void add_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.name.Text;
            mascota.Raza = this.raza.Text;
            mascota.Age = int.Parse(this.age.Text);
            this.coleccionMascotas.Add(mascota);
            this.name.Text = "";
            this.raza.Text = "";
            this.age.Text = "";
            this.DibujarMascotas();
        }

        private void read_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("coleccionmascotas.xml"))
            {
                this.coleccionMascotas = (List<Mascota>)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.DibujarMascotas();
        }

        private async void write_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("coleccionmascotas.xml"))
            {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();
            }
            this.list.Items.Clear();
            this.coleccionMascotas.Clear();
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.list.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.coleccionMascotas[index];
                this.name.Text = mascota.Nombre;
                this.raza.Text = mascota.Raza;
                this.age.Text = mascota.Age.ToString();
            }
        }

        private void DibujarMascotas()
        {
            this.list.Items.Clear();
            foreach (Mascota mascota in this.coleccionMascotas)
            {
                this.list.Items.Add(mascota.Nombre);
            }
        }
    }
}
