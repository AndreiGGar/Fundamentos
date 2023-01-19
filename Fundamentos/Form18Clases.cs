using ProyectoClases;
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
    public partial class Form18Clases : Form
    {
        public Form18Clases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Domicilio = new Direccion("Calle Suiza", "Madrid");
            persona.Apellidos = "Net Core";
            persona.Edad = 6;
            persona.Nacionalidad = Paises.Suiza;
            persona.Genero = TipoGenero.Masculino;
            this.listBox1.Items.Add(persona.Nombre + " " + persona.Apellidos + ", Edad: " + persona.Edad);
            this.listBox1.Items.Add("Dirección: " + persona.Domicilio.Calle);
            this.listBox1.Items.Add("Dirección Vacaciones: " + persona.DomicilioV.Calle);
            this.listBox1.Items.Add(persona.Genero + ", " + persona.Nacionalidad);
            this.listBox1.Items.Add(persona.GetNombreCompleto());
            this.listBox1.Items.Add(persona.GetNombreCompleto(true));
        }
    }
}
