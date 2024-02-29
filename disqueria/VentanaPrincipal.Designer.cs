namespace disqueria
{
    partial class VentanaPrincipal
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.imagenTapa = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.labelFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.labCampo = new System.Windows.Forms.Label();
            this.labCriterio = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.addCampo = new System.Windows.Forms.ComboBox();
            this.addCrit = new System.Windows.Forms.ComboBox();
            this.addClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInactivos = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenTapa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.GridColor = System.Drawing.Color.Black;
            this.dgvDiscos.Location = new System.Drawing.Point(24, 45);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.ReadOnly = true;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(660, 297);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // imagenTapa
            // 
            this.imagenTapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imagenTapa.Location = new System.Drawing.Point(690, 54);
            this.imagenTapa.Name = "imagenTapa";
            this.imagenTapa.Size = new System.Drawing.Size(187, 172);
            this.imagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenTapa.TabIndex = 1;
            this.imagenTapa.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(14, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 25);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Disco";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(779, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir del programa";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(109, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 25);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Black;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(690, 232);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(89, 25);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.Black;
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisico.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFisico.Location = new System.Drawing.Point(299, 7);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(74, 25);
            this.btnEliminarFisico.TabIndex = 10;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.Color.Black;
            this.btnEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLogico.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLogico.Location = new System.Drawing.Point(204, 7);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(89, 25);
            this.btnEliminarLogico.TabIndex = 11;
            this.btnEliminarLogico.Text = "Dar de baja";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // labelFiltroRapido
            // 
            this.labelFiltroRapido.AutoSize = true;
            this.labelFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroRapido.Location = new System.Drawing.Point(21, 20);
            this.labelFiltroRapido.Name = "labelFiltroRapido";
            this.labelFiltroRapido.Size = new System.Drawing.Size(45, 15);
            this.labelFiltroRapido.TabIndex = 12;
            this.labelFiltroRapido.Text = "Buscar";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.BackColor = System.Drawing.Color.White;
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroRapido.Location = new System.Drawing.Point(72, 18);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(196, 21);
            this.txtFiltroRapido.TabIndex = 13;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labCampo
            // 
            this.labCampo.AutoSize = true;
            this.labCampo.Location = new System.Drawing.Point(21, 361);
            this.labCampo.Name = "labCampo";
            this.labCampo.Size = new System.Drawing.Size(40, 13);
            this.labCampo.TabIndex = 14;
            this.labCampo.Text = "Campo";
            // 
            // labCriterio
            // 
            this.labCriterio.AutoSize = true;
            this.labCriterio.Location = new System.Drawing.Point(189, 360);
            this.labCriterio.Name = "labCriterio";
            this.labCriterio.Size = new System.Drawing.Size(39, 13);
            this.labCriterio.TabIndex = 15;
            this.labCriterio.Text = "Criterio";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(347, 360);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 16;
            this.Clave.Text = "Clave";
            // 
            // addCampo
            // 
            this.addCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCampo.FormattingEnabled = true;
            this.addCampo.Location = new System.Drawing.Point(72, 358);
            this.addCampo.Name = "addCampo";
            this.addCampo.Size = new System.Drawing.Size(111, 21);
            this.addCampo.TabIndex = 17;
            this.addCampo.SelectedIndexChanged += new System.EventHandler(this.addCampo_SelectedIndexChanged);
            // 
            // addCrit
            // 
            this.addCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCrit.FormattingEnabled = true;
            this.addCrit.Location = new System.Drawing.Point(230, 357);
            this.addCrit.Name = "addCrit";
            this.addCrit.Size = new System.Drawing.Size(111, 21);
            this.addCrit.TabIndex = 18;
            this.addCrit.SelectedIndexChanged += new System.EventHandler(this.addCrit_SelectedIndexChanged);
            // 
            // addClave
            // 
            this.addClave.BackColor = System.Drawing.Color.White;
            this.addClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClave.ForeColor = System.Drawing.SystemColors.Window;
            this.addClave.Location = new System.Drawing.Point(389, 356);
            this.addClave.Name = "addClave";
            this.addClave.Size = new System.Drawing.Size(171, 21);
            this.addClave.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(566, 354);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 25);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnEliminarLogico);
            this.panel1.Controls.Add(this.btnEliminarFisico);
            this.panel1.Location = new System.Drawing.Point(72, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 42);
            this.panel1.TabIndex = 21;
            // 
            // btnInactivos
            // 
            this.btnInactivos.BackColor = System.Drawing.Color.Black;
            this.btnInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivos.ForeColor = System.Drawing.Color.White;
            this.btnInactivos.Location = new System.Drawing.Point(690, 263);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Size = new System.Drawing.Size(89, 25);
            this.btnInactivos.TabIndex = 22;
            this.btnInactivos.Text = "Traer Inactivos";
            this.btnInactivos.UseVisualStyleBackColor = false;
            this.btnInactivos.Click += new System.EventHandler(this.btnInactivos_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Black;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(451, 392);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(79, 25);
            this.btnAlta.TabIndex = 23;
            this.btnAlta.Text = "Dar de alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(904, 439);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnInactivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.addClave);
            this.Controls.Add(this.addCrit);
            this.Controls.Add(this.addCampo);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.labCriterio);
            this.Controls.Add(this.labCampo);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.labelFiltroRapido);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.imagenTapa);
            this.Controls.Add(this.dgvDiscos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenTapa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox imagenTapa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Label labelFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label labCampo;
        private System.Windows.Forms.Label labCriterio;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.ComboBox addCampo;
        private System.Windows.Forms.ComboBox addCrit;
        private System.Windows.Forms.TextBox addClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInactivos;
        private System.Windows.Forms.Button btnAlta;
    }
}

