using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        private void CreateMascotas(string data)
        {
            this.Mascotas.Clear();
            string[] datamascotas = data.Split(',');
            foreach (string d in datamascotas)
            {
                string[] propiedades = d.Split('#');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        public async Task ReadFileMascotasAsync (string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }
        
        private string GetMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";
            }
            data = data.Trim(',');
            return data;
        }

        public async Task SaveFileMascotasAsync (string path)
        {
            string data = this.GetMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }

    }
}
