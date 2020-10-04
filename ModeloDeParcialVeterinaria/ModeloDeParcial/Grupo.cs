using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeParcial
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        private Grupo()
        {
            this.manada = new List<Mascota>(); 
        }

         static Grupo()
        {
            tipo = TipoManada.Unica;
        }

        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            this.Tipo = tipo;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("**Rio Unica**");
            sb.Append("\nIntegrantes: ");
            
            foreach(Mascota integrante in e.manada)
            {
                sb.Append(integrante.ToString());
            }

            return sb.ToString();
        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach(Mascota mascota in e.manada)
            {
                if(mascota== j)
                  return true;   
            }
            return false;
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if(e != j)
            {
                e.manada.Add(j);
            }
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            for (int i = 0; i<e.manada.Count; i++)
            {
                e.manada.RemoveAt(i);
            }
            return e;
        }

        public enum TipoManada
        {
            Unica, 
            Mixta,
        }


    }
}
