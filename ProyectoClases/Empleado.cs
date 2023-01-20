using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1000;
        }

        public Empleado(string nombre, string apellidos)
            :base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO dos params");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        public virtual int GetVacaciones()
        {
            Debug.WriteLine("Get vacaciones empleado");
            return 22;
        }
    }
}
