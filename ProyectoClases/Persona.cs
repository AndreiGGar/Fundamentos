using System.Diagnostics;

namespace ProyectoClases
{
    #region Persona

    public enum TipoGenero { Masculino, Femenino}
    public enum Paises { España, Italia, Alemania, Bélgica, Suiza}

    public class Persona
    {
        public Persona()
        {
            this.DomicilioV = new Direccion("ABC", "XYZ", 28800);
        }
        #region Campos de propiedad

        private TipoGenero _Genero;
        private int _Edad;

        #endregion

        #region Propiedades

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioV { get; set; }
        public TipoGenero Genero
        {
            get
            {
                return _Genero;
            }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor no disponible");
                }
                else
                {
                    _Genero = value;
                }
            }
        }

        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public int Edad
        {
            get { return _Edad; }
            set
            {
                if (value < 0)
                {
                    // throw new ArgumentOutOfRangeException("value");
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
            }
        }

        #endregion

        #region Métodos

        public string GetNombreCompleto()
        {
            return Nombre + " " + Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            if (orden)
            {
                return Apellidos + " " + Nombre;
            } else
            {
                return this.GetNombreCompleto();
            }
        }

        #endregion
    }
    #endregion
}