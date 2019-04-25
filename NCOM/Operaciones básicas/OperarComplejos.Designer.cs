namespace NCOM.Operaciones_básicas
{
    partial class OperarComplejos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperarComplejos));
            this.comboBoxOperacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureAtras = new System.Windows.Forms.PictureBox();
            this.pictureContinuar = new System.Windows.Forms.PictureBox();
            this.textComplejo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textComplejo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelContinuar = new System.Windows.Forms.Label();
            this.labelAtras = new System.Windows.Forms.Label();
            this.textResultadoBin = new System.Windows.Forms.TextBox();
            this.textResultadoPol = new System.Windows.Forms.TextBox();
            this.labelResBin = new System.Windows.Forms.Label();
            this.labelResPol = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContinuar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOperacion
            // 
            this.comboBoxOperacion.DisplayMember = "0";
            this.comboBoxOperacion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperacion.FormattingEnabled = true;
            this.comboBoxOperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.comboBoxOperacion.Location = new System.Drawing.Point(330, 254);
            this.comboBoxOperacion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOperacion.Name = "comboBoxOperacion";
            this.comboBoxOperacion.Size = new System.Drawing.Size(173, 33);
            this.comboBoxOperacion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(153, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(553, 59);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operaciones entre complejos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureAtras
            // 
            this.pictureAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureAtras.Image = ((System.Drawing.Image)(resources.GetObject("pictureAtras.Image")));
            this.pictureAtras.Location = new System.Drawing.Point(12, 607);
            this.pictureAtras.Name = "pictureAtras";
            this.pictureAtras.Size = new System.Drawing.Size(148, 41);
            this.pictureAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAtras.TabIndex = 8;
            this.pictureAtras.TabStop = false;
            this.pictureAtras.Click += new System.EventHandler(this.PictureAtras_Click);
            // 
            // pictureContinuar
            // 
            this.pictureContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureContinuar.Image = ((System.Drawing.Image)(resources.GetObject("pictureContinuar.Image")));
            this.pictureContinuar.Location = new System.Drawing.Point(326, 364);
            this.pictureContinuar.Name = "pictureContinuar";
            this.pictureContinuar.Size = new System.Drawing.Size(173, 41);
            this.pictureContinuar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureContinuar.TabIndex = 9;
            this.pictureContinuar.TabStop = false;
            this.pictureContinuar.Click += new System.EventHandler(this.PictureContinuar_Click);
            // 
            // textComplejo1
            // 
            this.textComplejo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComplejo1.Location = new System.Drawing.Point(87, 254);
            this.textComplejo1.Name = "textComplejo1";
            this.textComplejo1.Size = new System.Drawing.Size(173, 34);
            this.textComplejo1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero Complejo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textComplejo2
            // 
            this.textComplejo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComplejo2.Location = new System.Drawing.Point(573, 254);
            this.textComplejo2.Name = "textComplejo2";
            this.textComplejo2.Size = new System.Drawing.Size(173, 34);
            this.textComplejo2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(572, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Numero Complejo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(370, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Operacion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "En forma binomica:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(147, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "En forma polar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(335, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "[a;b] - \'a\' módulo, \'b\' argumento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(335, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "(a,b) - \'a\' parte Real, \'b\' parte imaginaria";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(193, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(437, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Introduzca los números con el siguiente formato:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // labelContinuar
            // 
            this.labelContinuar.AutoSize = true;
            this.labelContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(66)))));
            this.labelContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelContinuar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinuar.ForeColor = System.Drawing.Color.White;
            this.labelContinuar.Location = new System.Drawing.Point(364, 367);
            this.labelContinuar.Name = "labelContinuar";
            this.labelContinuar.Size = new System.Drawing.Size(102, 32);
            this.labelContinuar.TabIndex = 23;
            this.labelContinuar.Text = "Calcular";
            this.labelContinuar.Click += new System.EventHandler(this.LabelContinuar_Click);
            // 
            // labelAtras
            // 
            this.labelAtras.AutoSize = true;
            this.labelAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(66)))));
            this.labelAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAtras.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtras.ForeColor = System.Drawing.Color.White;
            this.labelAtras.Location = new System.Drawing.Point(48, 610);
            this.labelAtras.Name = "labelAtras";
            this.labelAtras.Size = new System.Drawing.Size(72, 32);
            this.labelAtras.TabIndex = 24;
            this.labelAtras.Text = "Atras";
            this.labelAtras.Click += new System.EventHandler(this.LabelAtras_Click);
            // 
            // textResultadoBin
            // 
            this.textResultadoBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultadoBin.Location = new System.Drawing.Point(573, 458);
            this.textResultadoBin.Name = "textResultadoBin";
            this.textResultadoBin.Size = new System.Drawing.Size(173, 34);
            this.textResultadoBin.TabIndex = 25;
            this.textResultadoBin.Visible = false;
            // 
            // textResultadoPol
            // 
            this.textResultadoPol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultadoPol.Location = new System.Drawing.Point(573, 536);
            this.textResultadoPol.Name = "textResultadoPol";
            this.textResultadoPol.Size = new System.Drawing.Size(173, 34);
            this.textResultadoPol.TabIndex = 26;
            this.textResultadoPol.Visible = false;
            // 
            // labelResBin
            // 
            this.labelResBin.AutoSize = true;
            this.labelResBin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResBin.ForeColor = System.Drawing.Color.White;
            this.labelResBin.Location = new System.Drawing.Point(408, 458);
            this.labelResBin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResBin.Name = "labelResBin";
            this.labelResBin.Size = new System.Drawing.Size(158, 28);
            this.labelResBin.TabIndex = 27;
            this.labelResBin.Text = "Forma binomica:";
            this.labelResBin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResBin.Visible = false;
            this.labelResBin.Click += new System.EventHandler(this.Label12_Click);
            // 
            // labelResPol
            // 
            this.labelResPol.AutoSize = true;
            this.labelResPol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResPol.ForeColor = System.Drawing.Color.White;
            this.labelResPol.Location = new System.Drawing.Point(408, 536);
            this.labelResPol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResPol.Name = "labelResPol";
            this.labelResPol.Size = new System.Drawing.Size(121, 28);
            this.labelResPol.TabIndex = 28;
            this.labelResPol.Text = "Forma Polar:";
            this.labelResPol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResPol.Visible = false;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.Color.White;
            this.labelResultado.Location = new System.Drawing.Point(260, 495);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(98, 28);
            this.labelResultado.TabIndex = 29;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelResultado.Visible = false;
            // 
            // OperarComplejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(841, 660);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelResPol);
            this.Controls.Add(this.labelResBin);
            this.Controls.Add(this.textResultadoPol);
            this.Controls.Add(this.textResultadoBin);
            this.Controls.Add(this.labelAtras);
            this.Controls.Add(this.labelContinuar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textComplejo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textComplejo1);
            this.Controls.Add(this.pictureContinuar);
            this.Controls.Add(this.pictureAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOperacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperarComplejos";
            this.Text = "Operaciones básicas";
            this.Load += new System.EventHandler(this.OperarComplejos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContinuar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureAtras;
        private System.Windows.Forms.PictureBox pictureContinuar;
        private System.Windows.Forms.TextBox textComplejo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textComplejo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelContinuar;
        private System.Windows.Forms.Label labelAtras;
        private System.Windows.Forms.TextBox textResultadoBin;
        private System.Windows.Forms.TextBox textResultadoPol;
        private System.Windows.Forms.Label labelResBin;
        private System.Windows.Forms.Label labelResPol;
        private System.Windows.Forms.Label labelResultado;
        public System.Windows.Forms.ComboBox comboBoxOperacion;
    }
}