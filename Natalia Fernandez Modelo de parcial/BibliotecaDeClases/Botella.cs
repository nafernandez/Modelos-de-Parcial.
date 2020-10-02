using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public int CapacidadLitros
        {
            get
            {
                return capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            } 
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * 100) / capacidadML;
            }
        }

        public Botella(string marca, int capacidadML, int contenidoML)
        {
            if(capacidadML<=contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
            this.capacidadML = capacidadML;
            this.marca = marca;

        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Capacidad: " + this.capacidadML);
            sb.AppendLine("Contenido: " + this.contenidoML);
            sb.AppendLine("Resta el: " + this.PorcentajeContenido + "%");
          
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme();
        }

        public enum Tipo
        {
            Plastico,
            Vidrio,
        }
    }
}
