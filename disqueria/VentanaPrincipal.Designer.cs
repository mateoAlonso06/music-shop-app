namespace disqueria
{
    partial class FrmMain
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.GridColor = System.Drawing.Color.Black;
            this.dgvDiscos.Location = new System.Drawing.Point(9, 13);
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
            this.imagenTapa.Location = new System.Drawing.Point(690, 13);
            this.imagenTapa.Name = "imagenTapa";
            this.imagenTapa.Size = new System.Drawing.Size(187, 172);
            this.imagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenTapa.TabIndex = 1;
            this.imagenTapa.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 316);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 22);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Disco";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(764, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 22);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir del programa";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Chocolate;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(107, 316);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 22);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Chocolate;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Location = new System.Drawing.Point(580, 316);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(89, 22);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.Chocolate;
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisico.Location = new System.Drawing.Point(297, 316);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(89, 22);
            this.btnEliminarFisico.TabIndex = 10;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.Color.Chocolate;
            this.btnEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLogico.Location = new System.Drawing.Point(202, 316);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(89, 22);
            this.btnEliminarLogico.TabIndex = 11;
            this.btnEliminarLogico.Text = "Dar de baja";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 448);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.imagenTapa);
            this.Controls.Add(this.dgvDiscos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenTapa)).EndInit();
            this.ResumeLayout(false);

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
    }
}

