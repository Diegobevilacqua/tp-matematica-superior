namespace NCOM.Operaciones_avanzadas
{
    partial class OperacionesAvanzadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComplejo = new System.Windows.Forms.TextBox();
            this.labelComplejo = new System.Windows.Forms.Label();
            this.comboBoxOperacion = new System.Windows.Forms.ComboBox();
            this.labelOperacion = new System.Windows.Forms.Label();
            this.labelExpOrden = new System.Windows.Forms.Label();
            this.textBoxExpOrden = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelResPol = new System.Windows.Forms.Label();
            this.labelResBin = new System.Windows.Forms.Label();
            this.textBoxResBin = new System.Windows.Forms.TextBox();
            this.textBoxResPol = new System.Windows.Forms.TextBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operaciones avanzadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxComplejo
            // 
            this.textBoxComplejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComplejo.Location = new System.Drawing.Point(468, 161);
            this.textBoxComplejo.Name = "textBoxComplejo";
            this.textBoxComplejo.Size = new System.Drawing.Size(198, 26);
            this.textBoxComplejo.TabIndex = 9;
            // 
            // labelComplejo
            // 
            this.labelComplejo.AutoSize = true;
            this.labelComplejo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplejo.ForeColor = System.Drawing.Color.White;
            this.labelComplejo.Location = new System.Drawing.Point(12, 163);
            this.labelComplejo.Name = "labelComplejo";
            this.labelComplejo.Size = new System.Drawing.Size(235, 21);
            this.labelComplejo.TabIndex = 23;
            this.labelComplejo.Text = "Introduzca un número complejo:";
            this.labelComplejo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxOperacion
            // 
            this.comboBoxOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperacion.FormattingEnabled = true;
            this.comboBoxOperacion.Items.AddRange(new object[] {
            "Potenciación",
            "Radicación",
            "Raíces primitivas"});
            this.comboBoxOperacion.Location = new System.Drawing.Point(468, 111);
            this.comboBoxOperacion.Name = "comboBoxOperacion";
            this.comboBoxOperacion.Size = new System.Drawing.Size(198, 28);
            this.comboBoxOperacion.TabIndex = 24;
            // 
            // labelOperacion
            // 
            this.labelOperacion.AutoSize = true;
            this.labelOperacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperacion.ForeColor = System.Drawing.Color.White;
            this.labelOperacion.Location = new System.Drawing.Point(12, 113);
            this.labelOperacion.Name = "labelOperacion";
            this.labelOperacion.Size = new System.Drawing.Size(242, 21);
            this.labelOperacion.TabIndex = 25;
            this.labelOperacion.Text = "Seleccione la operación a realizar:";
            this.labelOperacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelExpOrden
            // 
            this.labelExpOrden.AutoSize = true;
            this.labelExpOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpOrden.ForeColor = System.Drawing.Color.White;
            this.labelExpOrden.Location = new System.Drawing.Point(8, 211);
            this.labelExpOrden.Name = "labelExpOrden";
            this.labelExpOrden.Size = new System.Drawing.Size(391, 21);
            this.labelExpOrden.TabIndex = 26;
            this.labelExpOrden.Text = "Introduzca el valor del exponente o del orden de la raíz:";
            this.labelExpOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxExpOrden
            // 
            this.textBoxExpOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpOrden.Location = new System.Drawing.Point(468, 206);
            this.textBoxExpOrden.Name = "textBoxExpOrden";
            this.textBoxExpOrden.Size = new System.Drawing.Size(198, 26);
            this.textBoxExpOrden.TabIndex = 27;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.labelResultado.ForeColor = System.Drawing.Color.White;
            this.labelResultado.Location = new System.Drawing.Point(258, 356);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(159, 46);
            this.labelResultado.TabIndex = 30;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelResPol
            // 
            this.labelResPol.AutoSize = true;
            this.labelResPol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResPol.ForeColor = System.Drawing.Color.White;
            this.labelResPol.Location = new System.Drawing.Point(354, 427);
            this.labelResPol.Name = "labelResPol";
            this.labelResPol.Size = new System.Drawing.Size(98, 21);
            this.labelResPol.TabIndex = 36;
            this.labelResPol.Text = "Forma polar:";
            this.labelResPol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelResBin
            // 
            this.labelResBin.AutoSize = true;
            this.labelResBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResBin.ForeColor = System.Drawing.Color.White;
            this.labelResBin.Location = new System.Drawing.Point(8, 429);
            this.labelResBin.Name = "labelResBin";
            this.labelResBin.Size = new System.Drawing.Size(126, 21);
            this.labelResBin.TabIndex = 35;
            this.labelResBin.Text = "Forma binómica:";
            this.labelResBin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxResBin
            // 
            this.textBoxResBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResBin.Location = new System.Drawing.Point(149, 427);
            this.textBoxResBin.Name = "textBoxResBin";
            this.textBoxResBin.Size = new System.Drawing.Size(173, 26);
            this.textBoxResBin.TabIndex = 37;
            // 
            // textBoxResPol
            // 
            this.textBoxResPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResPol.Location = new System.Drawing.Point(468, 427);
            this.textBoxResPol.Name = "textBoxResPol";
            this.textBoxResPol.Size = new System.Drawing.Size(198, 26);
            this.textBoxResPol.TabIndex = 38;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 567);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 39;
            this.buttonAtras.Text = " Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(276, 264);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(127, 43);
            this.buttonCalcular.TabIndex = 40;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnterior.Location = new System.Drawing.Point(149, 494);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(153, 33);
            this.buttonAnterior.TabIndex = 43;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Visible = false;
            this.buttonAnterior.Click += new System.EventHandler(this.ButtonAnterior_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiguiente.Location = new System.Drawing.Point(349, 494);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(153, 33);
            this.buttonSiguiente.TabIndex = 44;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Visible = false;
            this.buttonSiguiente.Click += new System.EventHandler(this.ButtonSiguiente_Click);
            // 
            // OperacionesAvanzadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(680, 603);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.textBoxResPol);
            this.Controls.Add(this.textBoxResBin);
            this.Controls.Add(this.labelResPol);
            this.Controls.Add(this.labelResBin);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxExpOrden);
            this.Controls.Add(this.labelExpOrden);
            this.Controls.Add(this.labelOperacion);
            this.Controls.Add(this.comboBoxOperacion);
            this.Controls.Add(this.labelComplejo);
            this.Controls.Add(this.textBoxComplejo);
            this.Controls.Add(this.label3);
            this.Name = "OperacionesAvanzadas";
            this.Text = "Operaciones avanzadas";
            this.Load += new System.EventHandler(this.OperacionesAvanzadas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComplejo;
        private System.Windows.Forms.Label labelComplejo;
        private System.Windows.Forms.ComboBox comboBoxOperacion;
        private System.Windows.Forms.Label labelOperacion;
        private System.Windows.Forms.Label labelExpOrden;
        private System.Windows.Forms.TextBox textBoxExpOrden;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelResPol;
        private System.Windows.Forms.Label labelResBin;
        private System.Windows.Forms.TextBox textBoxResBin;
        private System.Windows.Forms.TextBox textBoxResPol;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSiguiente;
    }
}