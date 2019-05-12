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
            this.pictureRadic = new System.Windows.Forms.PictureBox();
            this.labelRad = new System.Windows.Forms.Label();
            this.labelPot = new System.Windows.Forms.Label();
            this.picturePot = new System.Windows.Forms.PictureBox();
            this.labelSFasores = new System.Windows.Forms.Label();
            this.labelOpBasicas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpBasicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSFasores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRadic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido a NCOM!";
            // 
            // pictureOpBasicas
            // 
            this.pictureOpBasicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureOpBasicas.Image = ((System.Drawing.Image)(resources.GetObject("pictureOpBasicas.Image")));
            this.pictureOpBasicas.Location = new System.Drawing.Point(58, 136);
            this.pictureOpBasicas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureOpBasicas.Name = "pictureOpBasicas";
            this.pictureOpBasicas.Size = new System.Drawing.Size(276, 54);
            this.pictureOpBasicas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpBasicas.TabIndex = 1;
            this.pictureOpBasicas.TabStop = false;
            this.pictureOpBasicas.Click += new System.EventHandler(this.PictureOpBasicas_Click);
            // 
            // pictureSFasores
            // 
            this.pictureSFasores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSFasores.Image = ((System.Drawing.Image)(resources.GetObject("pictureSFasores.Image")));
            this.pictureSFasores.Location = new System.Drawing.Point(373, 136);
            this.pictureSFasores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureSFasores.Name = "pictureSFasores";
            this.pictureSFasores.Size = new System.Drawing.Size(276, 54);
            this.pictureSFasores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSFasores.TabIndex = 2;
            this.pictureSFasores.TabStop = false;
            this.pictureSFasores.Click += new System.EventHandler(this.PictureSFasores_Click);
            // 
            // pictureRadic
            // 
            this.pictureRadic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRadic.Image = ((System.Drawing.Image)(resources.GetObject("pictureRadic.Image")));
            this.pictureRadic.Location = new System.Drawing.Point(373, 241);
            this.pictureRadic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureRadic.Name = "pictureRadic";
            this.pictureRadic.Size = new System.Drawing.Size(276, 54);
            this.pictureRadic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRadic.TabIndex = 3;
            this.pictureRadic.TabStop = false;
            this.pictureRadic.Click += new System.EventHandler(this.PictureRadic_Click);
            // 
            // labelRad
            // 
            this.labelRad.AutoSize = true;
            this.labelRad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.labelRad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRad.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRad.ForeColor = System.Drawing.Color.White;
            this.labelRad.Location = new System.Drawing.Point(450, 253);
            this.labelRad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(120, 30);
            this.labelRad.TabIndex = 4;
            this.labelRad.Text = "Radicación";
            this.labelRad.Click += new System.EventHandler(this.LaberRad_Click);
            // 
            // labelPot
            // 
            this.labelPot.AutoSize = true;
            this.labelPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.labelPot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPot.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPot.ForeColor = System.Drawing.Color.White;
            this.labelPot.Location = new System.Drawing.Point(130, 253);
            this.labelPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPot.Name = "labelPot";
            this.labelPot.Size = new System.Drawing.Size(140, 30);
            this.labelPot.TabIndex = 6;
            this.labelPot.Text = "Potenciación";
            this.labelPot.Click += new System.EventHandler(this.LabelPot_Click);
            // 
            // picturePot
            // 
            this.picturePot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePot.Image = ((System.Drawing.Image)(resources.GetObject("picturePot.Image")));
            this.picturePot.Location = new System.Drawing.Point(58, 241);
            this.picturePot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturePot.Name = "picturePot";
            this.picturePot.Size = new System.Drawing.Size(276, 54);
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
            this.labelSFasores.Location = new System.Drawing.Point(437, 145);
            this.labelSFasores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSFasores.Name = "labelSFasores";
            this.labelSFasores.Size = new System.Drawing.Size(163, 32);
            this.labelSFasores.TabIndex = 24;
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
            this.labelOpBasicas.Location = new System.Drawing.Point(87, 145);
            this.labelOpBasicas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpBasicas.Name = "labelOpBasicas";
            this.labelOpBasicas.Size = new System.Drawing.Size(235, 32);
            this.labelOpBasicas.TabIndex = 25;
            this.labelOpBasicas.Text = "Operaciones Básicas";
            this.labelOpBasicas.Click += new System.EventHandler(this.LabelOpBasicas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(697, 340);
            this.Controls.Add(this.labelOpBasicas);
            this.Controls.Add(this.labelSFasores);
            this.Controls.Add(this.labelPot);
            this.Controls.Add(this.picturePot);
            this.Controls.Add(this.labelRad);
            this.Controls.Add(this.pictureRadic);
            this.Controls.Add(this.pictureSFasores);
            this.Controls.Add(this.pictureOpBasicas);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpBasicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSFasores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRadic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureOpBasicas;
        private System.Windows.Forms.PictureBox pictureSFasores;
        private System.Windows.Forms.PictureBox pictureRadic;
        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.Label labelPot;
        private System.Windows.Forms.PictureBox picturePot;
        private System.Windows.Forms.Label labelSFasores;
        private System.Windows.Forms.Label labelOpBasicas;
    }
}

