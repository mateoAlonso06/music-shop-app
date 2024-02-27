namespace disqueria
{
    partial class AgregarDisco
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labFecha = new System.Windows.Forms.Label();
            this.labCantidad = new System.Windows.Forms.Label();
            this.labUrl = new System.Windows.Forms.Label();
            this.labEstilo = new System.Windows.Forms.Label();
            this.labTipo = new System.Windows.Forms.Label();
            this.addTitulo = new System.Windows.Forms.TextBox();
            this.addUrl = new System.Windows.Forms.TextBox();
            this.addCantidad = new System.Windows.Forms.TextBox();
            this.addGenero = new System.Windows.Forms.ComboBox();
            this.addTipo = new System.Windows.Forms.ComboBox();
            this.loadPortada = new System.Windows.Forms.PictureBox();
            this.leyenda = new System.Windows.Forms.Label();
            this.addFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadPortada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(247, 213);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(368, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(74, 16);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(84, 13);
            this.labTitulo.TabIndex = 2;
            this.labTitulo.Text = "Titulo del album:";
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Location = new System.Drawing.Point(59, 64);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(114, 13);
            this.labFecha.TabIndex = 3;
            this.labFecha.Text = "Fecha de lanzamiento:";
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.Location = new System.Drawing.Point(276, 16);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(119, 13);
            this.labCantidad.TabIndex = 4;
            this.labCantidad.Text = "Cantidad de canciones:";
            // 
            // labUrl
            // 
            this.labUrl.AutoSize = true;
            this.labUrl.Location = new System.Drawing.Point(297, 64);
            this.labUrl.Name = "labUrl";
            this.labUrl.Size = new System.Drawing.Size(73, 13);
            this.labUrl.TabIndex = 5;
            this.labUrl.Text = "Url de la tapa:";
            // 
            // labEstilo
            // 
            this.labEstilo.AutoSize = true;
            this.labEstilo.Location = new System.Drawing.Point(87, 113);
            this.labEstilo.Name = "labEstilo";
            this.labEstilo.Size = new System.Drawing.Size(45, 13);
            this.labEstilo.TabIndex = 6;
            this.labEstilo.Text = "Genero:";
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.Location = new System.Drawing.Point(287, 113);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(83, 13);
            this.labTipo.TabIndex = 7;
            this.labTipo.Text = "Tipo de edición:";
            // 
            // addTitulo
            // 
            this.addTitulo.Location = new System.Drawing.Point(18, 32);
            this.addTitulo.Name = "addTitulo";
            this.addTitulo.Size = new System.Drawing.Size(196, 20);
            this.addTitulo.TabIndex = 0;
            // 
            // addUrl
            // 
            this.addUrl.Location = new System.Drawing.Point(235, 80);
            this.addUrl.Name = "addUrl";
            this.addUrl.Size = new System.Drawing.Size(196, 20);
            this.addUrl.TabIndex = 3;
            this.addUrl.Leave += new System.EventHandler(this.addUrl_Leave);
            // 
            // addCantidad
            // 
            this.addCantidad.Location = new System.Drawing.Point(235, 32);
            this.addCantidad.Name = "addCantidad";
            this.addCantidad.Size = new System.Drawing.Size(196, 20);
            this.addCantidad.TabIndex = 1;
            // 
            // addGenero
            // 
            this.addGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGenero.FormattingEnabled = true;
            this.addGenero.Location = new System.Drawing.Point(18, 129);
            this.addGenero.Name = "addGenero";
            this.addGenero.Size = new System.Drawing.Size(196, 21);
            this.addGenero.TabIndex = 4;
            // 
            // addTipo
            // 
            this.addTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTipo.FormattingEnabled = true;
            this.addTipo.Location = new System.Drawing.Point(235, 129);
            this.addTipo.Name = "addTipo";
            this.addTipo.Size = new System.Drawing.Size(196, 21);
            this.addTipo.TabIndex = 5;
            // 
            // loadPortada
            // 
            this.loadPortada.Location = new System.Drawing.Point(490, 19);
            this.loadPortada.Name = "loadPortada";
            this.loadPortada.Size = new System.Drawing.Size(127, 119);
            this.loadPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadPortada.TabIndex = 14;
            this.loadPortada.TabStop = false;
            // 
            // leyenda
            // 
            this.leyenda.AutoSize = true;
            this.leyenda.BackColor = System.Drawing.Color.White;
            this.leyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leyenda.Location = new System.Drawing.Point(522, 152);
            this.leyenda.Name = "leyenda";
            this.leyenda.Size = new System.Drawing.Size(55, 16);
            this.leyenda.TabIndex = 15;
            this.leyenda.Text = "Portada";
            // 
            // addFecha
            // 
            this.addFecha.Location = new System.Drawing.Point(18, 80);
            this.addFecha.Name = "addFecha";
            this.addFecha.Size = new System.Drawing.Size(196, 20);
            this.addFecha.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.addFecha);
            this.groupBox1.Controls.Add(this.leyenda);
            this.groupBox1.Controls.Add(this.loadPortada);
            this.groupBox1.Controls.Add(this.addTipo);
            this.groupBox1.Controls.Add(this.addGenero);
            this.groupBox1.Controls.Add(this.addCantidad);
            this.groupBox1.Controls.Add(this.addUrl);
            this.groupBox1.Controls.Add(this.addTitulo);
            this.groupBox1.Controls.Add(this.labTipo);
            this.groupBox1.Controls.Add(this.labEstilo);
            this.groupBox1.Controls.Add(this.labUrl);
            this.groupBox1.Controls.Add(this.labCantidad);
            this.groupBox1.Controls.Add(this.labFecha);
            this.groupBox1.Controls.Add(this.labTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 184);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // AgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(683, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "AgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir albúm";
            this.Load += new System.EventHandler(this.AgregarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadPortada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.Label labUrl;
        private System.Windows.Forms.Label labEstilo;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.TextBox addTitulo;
        private System.Windows.Forms.TextBox addUrl;
        private System.Windows.Forms.TextBox addCantidad;
        private System.Windows.Forms.ComboBox addGenero;
        private System.Windows.Forms.ComboBox addTipo;
        private System.Windows.Forms.PictureBox loadPortada;
        private System.Windows.Forms.Label leyenda;
        private System.Windows.Forms.DateTimePicker addFecha;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}