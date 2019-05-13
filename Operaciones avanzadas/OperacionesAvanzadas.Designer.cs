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
            this.labelRaicesPrimitivas = new System.Windows.Forms.Label();
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
            this.textBoxComplejo.Location = new System.Drawing.Point(467, 160);
            this.textBoxComplejo.Name = "textBoxComplejo";
            this.textBoxComplejo.Size = new System.Drawing.Size(198, 20);
            this.textBoxComplejo.TabIndex = 9;
            this.textBoxComplejo.Visible = false;
            // 
            // labelComplejo
            // 
            this.labelComplejo.AutoSize = true;
            this.labelComplejo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplejo.ForeColor = System.Drawing.Color.White;
            this.labelComplejo.Location = new System.Drawing.Point(12, 157);
            this.labelComplejo.Name = "labelComplejo";
            this.labelComplejo.Size = new System.Drawing.Size(235, 21);
            this.labelComplejo.TabIndex = 23;
            this.labelComplejo.Text = "Introduzca un número complejo:";
            this.labelComplejo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelComplejo.Visible = false;
            // 
            // comboBoxOperacion
            // 
            this.comboBoxOperacion.FormattingEnabled = true;
            this.comboBoxOperacion.Items.AddRange(new object[] {
            "Potenciación",
            "Radicación",
            "Raíces primitivas"});
            this.comboBoxOperacion.Location = new System.Drawing.Point(467, 107);
            this.comboBoxOperacion.Name = "comboBoxOperacion";
            this.comboBoxOperacion.Size = new System.Drawing.Size(198, 21);
            this.comboBoxOperacion.TabIndex = 24;
            // 
            // labelOperacion
            // 
            this.labelOperacion.AutoSize = true;
            this.labelOperacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperacion.ForeColor = System.Drawing.Color.White;
            this.labelOperacion.Location = new System.Drawing.Point(12, 107);
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
            this.labelExpOrden.Location = new System.Drawing.Point(12, 211);
            this.labelExpOrden.Name = "labelExpOrden";
            this.labelExpOrden.Size = new System.Drawing.Size(391, 21);
            this.labelExpOrden.TabIndex = 26;
            this.labelExpOrden.Text = "Introduzca el valor del exponente o del orden de la raíz:";
            this.labelExpOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelExpOrden.Visible = false;
            // 
            // textBoxExpOrden
            // 
            this.textBoxExpOrden.Location = new System.Drawing.Point(467, 214);
            this.textBoxExpOrden.Name = "textBoxExpOrden";
            this.textBoxExpOrden.Size = new System.Drawing.Size(198, 20);
            this.textBoxExpOrden.TabIndex = 27;
            this.textBoxExpOrden.Visible = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelResultado.ForeColor = System.Drawing.Color.White;
            this.labelResultado.Location = new System.Drawing.Point(269, 329);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(134, 37);
            this.labelResultado.TabIndex = 30;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultado.Visible = false;
            // 
            // labelResPol
            // 
            this.labelResPol.AutoSize = true;
            this.labelResPol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResPol.ForeColor = System.Drawing.Color.White;
            this.labelResPol.Location = new System.Drawing.Point(350, 432);
            this.labelResPol.Name = "labelResPol";
            this.labelResPol.Size = new System.Drawing.Size(98, 21);
            this.labelResPol.TabIndex = 36;
            this.labelResPol.Text = "Forma polar:";
            this.labelResPol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResPol.Visible = false;
            // 
            // labelResBin
            // 
            this.labelResBin.AutoSize = true;
            this.labelResBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResBin.ForeColor = System.Drawing.Color.White;
            this.labelResBin.Location = new System.Drawing.Point(10, 431);
            this.labelResBin.Name = "labelResBin";
            this.labelResBin.Size = new System.Drawing.Size(126, 21);
            this.labelResBin.TabIndex = 35;
            this.labelResBin.Text = "Forma binómica:";
            this.labelResBin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResBin.Visible = false;
            // 
            // textBoxResBin
            // 
            this.textBoxResBin.Location = new System.Drawing.Point(153, 434);
            this.textBoxResBin.Name = "textBoxResBin";
            this.textBoxResBin.Size = new System.Drawing.Size(173, 20);
            this.textBoxResBin.TabIndex = 37;
            this.textBoxResBin.Visible = false;
            // 
            // textBoxResPol
            // 
            this.textBoxResPol.Location = new System.Drawing.Point(465, 434);
            this.textBoxResPol.Name = "textBoxResPol";
            this.textBoxResPol.Size = new System.Drawing.Size(198, 20);
            this.textBoxResPol.TabIndex = 38;
            this.textBoxResPol.Visible = false;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(12, 478);
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
            // labelRaicesPrimitivas
            // 
            this.labelRaicesPrimitivas.AutoSize = true;
            this.labelRaicesPrimitivas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaicesPrimitivas.ForeColor = System.Drawing.Color.White;
            this.labelRaicesPrimitivas.Location = new System.Drawing.Point(12, 386);
            this.labelRaicesPrimitivas.Name = "labelRaicesPrimitivas";
            this.labelRaicesPrimitivas.Size = new System.Drawing.Size(130, 21);
            this.labelRaicesPrimitivas.TabIndex = 41;
            this.labelRaicesPrimitivas.Text = "Raíces primitivas:";
            this.labelRaicesPrimitivas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelRaicesPrimitivas.Visible = false;
            // 
            // OperacionesAvanzadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(678, 513);
            this.Controls.Add(this.labelRaicesPrimitivas);
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
        private System.Windows.Forms.Label labelRaicesPrimitivas;
    }
}