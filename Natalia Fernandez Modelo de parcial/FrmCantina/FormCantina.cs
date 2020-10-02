using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantina
{
    public partial class FormCantina : Form
    {
        public FormCantina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

            if(this.radioBtnCerveza.Checked== true)
            {
                this.barra1.AgregarBotella(new Cerveza((int)this.numericUpDownCapacidad.Value, this.txtMarca.Text, (int)this.numericUpDownContenido.Value));
            }

            if (this.radioBtnAgua.Checked == true)
            {
                this.barra1.AgregarBotella(new Agua((int)this.numericUpDownCapacidad.Value, this.txtMarca.Text, (int)this.numericUpDownContenido.Value));
            }
        }
    }
}
