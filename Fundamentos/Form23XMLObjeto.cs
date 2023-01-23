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
using ProyectoClases.Models;
using System.IO;

namespace Fundamentos
{
    public partial class Form23XMLObjeto : Form
    {
        XmlSerializer serializer;
        public Form23XMLObjeto()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void read_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascotas.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.name.Text = mascota.Nombre;
            this.raza.Text = mascota.Raza;
            this.age.Text = mascota.Age.ToString();
        }

        private async void write_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.name.Text;
            mascota.Raza = this.raza.Text;
            mascota.Age = int.Parse(this.age.Text);
            using (StreamWriter writer = new StreamWriter("mascotas.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.name.Text = "";
            this.raza.Text = "";
            this.age.Text = "";
        }
    }
}
