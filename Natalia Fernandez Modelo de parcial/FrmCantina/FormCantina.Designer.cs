namespace FrmCantina
{
    partial class FormCantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantina));
            this.barra1 = new ControlCantina.Barra();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.numericUpDownCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownContenido = new System.Windows.Forms.NumericUpDown();
            this.radioBtnCerveza = new System.Windows.Forms.RadioButton();
            this.radioBtnAgua = new System.Windows.Forms.RadioButton();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(647, 368);
            this.barra1.TabIndex = 0;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(227, 414);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(166, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(449, 453);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Vidrio",
            "Agua"});
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(449, 413);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 3;
            // 
            // numericUpDownCapacidad
            // 
            this.numericUpDownCapacidad.Location = new System.Drawing.Point(227, 474);
            this.numericUpDownCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            this.numericUpDownCapacidad.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownCapacidad.TabIndex = 4;
            this.numericUpDownCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownContenido
            // 
            this.numericUpDownContenido.Location = new System.Drawing.Point(329, 474);
            this.numericUpDownContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContenido.Name = "numericUpDownContenido";
            this.numericUpDownContenido.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownContenido.TabIndex = 5;
            this.numericUpDownContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // radioBtnCerveza
            // 
            this.radioBtnCerveza.AutoSize = true;
            this.radioBtnCerveza.Location = new System.Drawing.Point(12, 402);
            this.radioBtnCerveza.Name = "radioBtnCerveza";
            this.radioBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioBtnCerveza.TabIndex = 6;
            this.radioBtnCerveza.TabStop = true;
            this.radioBtnCerveza.Text = "Cerveza";
            this.radioBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // radioBtnAgua
            // 
            this.radioBtnAgua.AutoSize = true;
            this.radioBtnAgua.Location = new System.Drawing.Point(12, 433);
            this.radioBtnAgua.Name = "radioBtnAgua";
            this.radioBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.radioBtnAgua.TabIndex = 7;
            this.radioBtnAgua.TabStop = true;
            this.radioBtnAgua.Text = "Agua";
            this.radioBtnAgua.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(227, 395);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(449, 395);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 9;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(227, 453);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 10;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(329, 453);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 11;
            this.lblContenido.Text = "Contenido";
            // 
            // FormCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 516);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.radioBtnAgua);
            this.Controls.Add(this.radioBtnCerveza);
            this.Controls.Add(this.numericUpDownContenido);
            this.Controls.Add(this.numericUpDownCapacidad);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.barra1);
            this.Name = "FormCantina";
            this.Text = "Natalia Fernandez";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidad;
        private System.Windows.Forms.NumericUpDown numericUpDownContenido;
        private System.Windows.Forms.RadioButton radioBtnCerveza;
        private System.Windows.Forms.RadioButton radioBtnAgua;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
    }
}

