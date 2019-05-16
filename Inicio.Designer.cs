namespace NCOM
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureOpBasicas = new System.Windows.Forms.PictureBox();
            this.pictureSFasores = new System.Windows.Forms.PictureBox();
            this.labelPot = new System.Windows.Forms.Label();
            this.picturePot = new System.Windows.Forms.PictureBox();
            this.labelSFasores = new System.Windows.Forms.Label();
            this.labelOpBasicas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpBasicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSFasores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido a NCOM!";
            // 
            // pictureOpBasicas
            // 
            this.pictureOpBasicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureOpBasicas.Image = ((System.Drawing.Image)(resources.GetObject("pictureOpBasicas.Image")));
            this.pictureOpBasicas.Location = new System.Drawing.Point(49, 148);
            this.pictureOpBasicas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureOpBasicas.Name = "pictureOpBasicas";
            this.pictureOpBasicas.Size = new System.Drawing.Size(368, 66);
            this.pictureOpBasicas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpBasicas.TabIndex = 1;
            this.pictureOpBasicas.TabStop = false;
            this.pictureOpBasicas.Click += new System.EventHandler(this.PictureOpBasicas_Click);
            // 
            // pictureSFasores
            // 
            this.pictureSFasores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSFasores.Image = ((System.Drawing.Image)(resources.GetObject("pictureSFasores.Image")));
            this.pictureSFasores.Location = new System.Drawing.Point(51, 366);
            this.pictureSFasores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSFasores.Name = "pictureSFasores";
            this.pictureSFasores.Size = new System.Drawing.Size(368, 66);
            this.pictureSFasores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSFasores.TabIndex = 2;
            this.pictureSFasores.TabStop = false;
            this.pictureSFasores.Click += new System.EventHandler(this.PictureSFasores_Click);
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.labelPot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPot.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPot.ForeColor = System.Drawing.Color.White;
            this.labelPot.Location = new System.Drawing.Point(77, 272);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(315, 38);
            this.labelPot.TabIndex = 1;
            this.labelPot.Text = "Operaciones avanzadas";
            this.labelPot.Click += new System.EventHandler(this.LabelPot_Click);
            // 
            // picturePot
            // 
            this.picturePot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePot.Image = ((System.Drawing.Image)(resources.GetObject("picturePot.Image")));
            this.picturePot.Location = new System.Drawing.Point(49, 257);
            this.picturePot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePot.Name = "picturePot";
            this.picturePot.Size = new System.Drawing.Size(368, 69);
            this.picturePot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePot.TabIndex = 5;
            this.picturePot.TabStop = false;
            this.picturePot.Click += new System.EventHandler(this.PicturePot_Click);
            // 
            // labelSFasores
            // 
            this.labelSFasores.AutoSize = true;
            this.labelSFasores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(74)))), ((int)(((byte)(66)))));
            this.labelSFasores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSFasores.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labelSFasores.ForeColor = System.Drawing.Color.White;
            this.labelSFasores.Location = new System.Drawing.Point(129, 379);
            this.labelSFasores.Name = "labelSFasores";
            this.labelSFasores.Size = new System.Drawing.Size(204, 41);
            this.labelSFasores.TabIndex = 2;
            this.labelSFasores.Text = "Suma Fasores";
            this.labelSFasores.Click += new System.EventHandler(this.LabelSFasores_Click);
            // 
            // labelOpBasicas
            // 
            this.labelOpBasicas.AutoSize = true;
            this.labelOpBasicas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(101)))));
            this.labelOpBasicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpBasicas.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpBasicas.ForeColor = System.Drawing.Color.White;
            this.labelOpBasicas.Location = new System.Drawing.Point(88, 159);
            this.labelOpBasicas.Name = "labelOpBasicas";
            this.labelOpBasicas.Size = new System.Drawing.Size(295, 41);
            this.labelOpBasicas.TabIndex = 0;
            this.labelOpBasicas.Text = "Operaciones Básicas";
            this.labelOpBasicas.Click += new System.EventHandler(this.LabelOpBasicas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(471, 473);
            this.Controls.Add(this.labelOpBasicas);
            this.Controls.Add(this.labelSFasores);
            this.Controls.Add(this.labelPot);
            this.Controls.Add(this.picturePot);
            this.Controls.Add(this.pictureSFasores);
            this.Controls.Add(this.pictureOpBasicas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpBasicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSFasores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureOpBasicas;
        private System.Windows.Forms.PictureBox pictureSFasores;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.PictureBox picturePot;
        private System.Windows.Forms.Label labelSFasores;
        private System.Windows.Forms.Label labelOpBasicas;
    }
}

