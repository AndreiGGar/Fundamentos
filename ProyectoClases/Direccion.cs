using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        #region Propiedades
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        #endregion

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Dirección 2 Params");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor Dirección 3 Params");
        }
    }
}
