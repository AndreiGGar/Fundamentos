using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }

        public override int GetVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            int vacacionesEmpleado = base.GetVacaciones();
            return vacacionesEmpleado + 8;
        }

        public override string ToString()
        {
            return this.GetNombreCompleto() + ", Salario: " + this.SalarioMinimo + ", Vacaciones: " + this.GetVacaciones();
        }
    }
}
