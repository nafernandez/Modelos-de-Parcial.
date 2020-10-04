using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeParcial
{
    public class Gato : Mascota
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DatosCompletos());

            return sb.ToString();
        }

        public Gato(string nombre, string raza)
            : base(nombre, raza)
        {
        }
        public static bool operator !=(Gato j1, Gato j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Gato j1, Gato j2)
        {
            return j1.Nombre == j2.Nombre && j2.Raza == j2.Raza;
        }

        public override string ToString()
        {
            return Ficha();
        }
    }
}
