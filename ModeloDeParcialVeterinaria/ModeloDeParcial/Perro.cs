using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeParcial
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
         public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.DatosCompletos());
          
            if(esAlfa==true)
            {
                sb.AppendLine("Alfa de la manada.");
            }
            sb.AppendFormat("Edad: {0}", edad);

            return sb.ToString();
        }
        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Perro j1, Perro j2)
        {
            return j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.edad == j2.edad;
        }

        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }
        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
