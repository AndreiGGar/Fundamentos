using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Temperatura
    {
        public Temperatura(string Mes, int TMax, int TMin)
        {
            this.Mes = Mes;
            this.TMax = TMax;
            this.TMin = TMin;
        }
        public string Mes { get; set; }
        public int TMax { get; set; }
        public int TMin { get; set; }

        public int GetMedia ()
        {
            return (this.TMax + this.TMin) / 2;
        }
    }
}
