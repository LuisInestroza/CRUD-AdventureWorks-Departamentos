namespace CRUD_AdventureWorksDepartamentos
{
    partial class frmOpetacionesCRUD
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
            this.gbOperacionesDisponibles = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.txtGrupoDepto = new System.Windows.Forms.TextBox();
            this.txtCodigoDepto = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbGrupoDepto = new System.Windows.Forms.Label();
            this.lbNombreDepto = new System.Windows.Forms.Label();
            this.lbCodigoDepto = new System.Windows.Forms.Label();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.btnListarDepartamento = new System.Windows.Forms.Button();
            this.btnCrearDepartementos = new System.Windows.Forms.Button();
            this.btnActualizarDepartamento = new System.Windows.Forms.Button();
            this.lbReader = new System.Windows.Forms.ListBox();
            this.lbEstadoCRUD = new System.Windows.Forms.Label();
            this.gbOperacionesDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperacionesDisponibles
            // 
            this.gbOperacionesDisponibles.Controls.Add(this.lbEstadoCRUD);
            this.gbOperacionesDisponibles.Controls.Add(this.lbReader);
            this.gbOperacionesDisponibles.Controls.Add(this.dtpFecha);
            this.gbOperacionesDisponibles.Controls.Add(this.txtNombreDepto);
            this.gbOperacionesDisponibles.Controls.Add(this.txtGrupoDepto);
            this.gbOperacionesDisponibles.Controls.Add(this.txtCodigoDepto);
            this.gbOperacionesDisponibles.Controls.Add(this.lbFecha);
            this.gbOperacionesDisponibles.Controls.Add(this.lbGrupoDepto);
            this.gbOperacionesDisponibles.Controls.Add(this.lbNombreDepto);
            this.gbOperacionesDisponibles.Controls.Add(this.lbCodigoDepto);
            this.gbOperacionesDisponibles.Controls.Add(this.btnEliminarDepartamento);
            this.gbOperacionesDisponibles.Controls.Add(this.btnListarDepartamento);
            this.gbOperacionesDisponibles.Controls.Add(this.btnCrearDepartementos);
            this.gbOperacionesDisponibles.Controls.Add(this.btnActualizarDepartamento);
            this.gbOperacionesDisponibles.Font = new System.Drawing.Font("Arial", 10F);
            this.gbOperacionesDisponibles.Location = new System.Drawing.Point(12, 12);
            this.gbOperacionesDisponibles.Name = "gbOperacionesDisponibles";
            this.gbOperacionesDisponibles.Size = new System.Drawing.Size(749, 337);
            this.gbOperacionesDisponibles.TabIndex = 0;
            this.gbOperacionesDisponibles.TabStop = false;
            this.gbOperacionesDisponibles.Text = "Operaciones disponibles para departamentos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(136, 142);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(193, 23);
            this.dtpFecha.TabIndex = 12;
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.Location = new System.Drawing.Point(136, 75);
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(193, 23);
            this.txtNombreDepto.TabIndex = 11;
            // 
            // txtGrupoDepto
            // 
            this.txtGrupoDepto.Location = new System.Drawing.Point(136, 105);
            this.txtGrupoDepto.Name = "txtGrupoDepto";
            this.txtGrupoDepto.Size = new System.Drawing.Size(193, 23);
            this.txtGrupoDepto.TabIndex = 10;
            // 
            // txtCodigoDepto
            // 
            this.txtCodigoDepto.Location = new System.Drawing.Point(136, 37);
            this.txtCodigoDepto.Name = "txtCodigoDepto";
            this.txtCodigoDepto.Size = new System.Drawing.Size(193, 23);
            this.txtCodigoDepto.TabIndex = 9;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(31, 142);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(48, 16);
            this.lbFecha.TabIndex = 8;
            this.lbFecha.Text = "Fecha";
            // 
            // lbGrupoDepto
            // 
            this.lbGrupoDepto.AutoSize = true;
            this.lbGrupoDepto.Location = new System.Drawing.Point(31, 108);
            this.lbGrupoDepto.Name = "lbGrupoDepto";
            this.lbGrupoDepto.Size = new System.Drawing.Size(52, 16);
            this.lbGrupoDepto.TabIndex = 7;
            this.lbGrupoDepto.Text = "Grupo:";
            // 
            // lbNombreDepto
            // 
            this.lbNombreDepto.AutoSize = true;
            this.lbNombreDepto.Location = new System.Drawing.Point(31, 78);
            this.lbNombreDepto.Name = "lbNombreDepto";
            this.lbNombreDepto.Size = new System.Drawing.Size(61, 16);
            this.lbNombreDepto.TabIndex = 6;
            this.lbNombreDepto.Text = "Nombre:";
            // 
            // lbCodigoDepto
            // 
            this.lbCodigoDepto.AutoSize = true;
            this.lbCodigoDepto.Location = new System.Drawing.Point(31, 40);
            this.lbCodigoDepto.Name = "lbCodigoDepto";
            this.lbCodigoDepto.Size = new System.Drawing.Size(99, 16);
            this.lbCodigoDepto.TabIndex = 5;
            this.lbCodigoDepto.Text = "Codigo Depto.";
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(208, 279);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(166, 43);
            this.btnEliminarDepartamento.TabIndex = 4;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // btnListarDepartamento
            // 
            this.btnListarDepartamento.Location = new System.Drawing.Point(30, 205);
            this.btnListarDepartamento.Name = "btnListarDepartamento";
            this.btnListarDepartamento.Size = new System.Drawing.Size(155, 39);
            this.btnListarDepartamento.TabIndex = 1;
            this.btnListarDepartamento.Text = "Listar Departamentos";
            this.btnListarDepartamento.UseVisualStyleBackColor = true;
            this.btnListarDepartamento.Click += new System.EventHandler(this.btnListarDepartamento_Click);
            // 
            // btnCrearDepartementos
            // 
            this.btnCrearDepartementos.Location = new System.Drawing.Point(208, 205);
            this.btnCrearDepartementos.Name = "btnCrearDepartementos";
            this.btnCrearDepartementos.Size = new System.Drawing.Size(166, 39);
            this.btnCrearDepartementos.TabIndex = 2;
            this.btnCrearDepartementos.Text = "Crear Departamento";
            this.btnCrearDepartementos.UseVisualStyleBackColor = true;
            this.btnCrearDepartementos.Click += new System.EventHandler(this.btnCrearDepartementos_Click);
            // 
            // btnActualizarDepartamento
            // 
            this.btnActualizarDepartamento.Location = new System.Drawing.Point(30, 279);
            this.btnActualizarDepartamento.Name = "btnActualizarDepartamento";
            this.btnActualizarDepartamento.Size = new System.Drawing.Size(155, 43);
            this.btnActualizarDepartamento.TabIndex = 3;
            this.btnActualizarDepartamento.Text = "Actualizar";
            this.btnActualizarDepartamento.UseVisualStyleBackColor = true;
            this.btnActualizarDepartamento.Click += new System.EventHandler(this.btnActualizarDepartamento_Click);
            // 
            // lbReader
            // 
            this.lbReader.FormattingEnabled = true;
            this.lbReader.ItemHeight = 16;
            this.lbReader.Location = new System.Drawing.Point(433, 22);
            this.lbReader.Name = "lbReader";
            this.lbReader.Size = new System.Drawing.Size(280, 260);
            this.lbReader.TabIndex = 13;
            // 
            // lbEstadoCRUD
            // 
            this.lbEstadoCRUD.AutoSize = true;
            this.lbEstadoCRUD.Location = new System.Drawing.Point(550, 306);
            this.lbEstadoCRUD.Name = "lbEstadoCRUD";
            this.lbEstadoCRUD.Size = new System.Drawing.Size(0, 16);
            this.lbEstadoCRUD.TabIndex = 14;
            // 
            // frmOpetacionesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.gbOperacionesDisponibles);
            this.Name = "frmOpetacionesCRUD";
            this.Text = "Operaciones CRUD con departamentos Adventure Works";
            this.gbOperacionesDisponibles.ResumeLayout(false);
            this.gbOperacionesDisponibles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperacionesDisponibles;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnListarDepartamento;
        private System.Windows.Forms.Button btnCrearDepartementos;
        private System.Windows.Forms.Button btnActualizarDepartamento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.TextBox txtGrupoDepto;
        private System.Windows.Forms.TextBox txtCodigoDepto;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbGrupoDepto;
        private System.Windows.Forms.Label lbNombreDepto;
        private System.Windows.Forms.Label lbCodigoDepto;
        private System.Windows.Forms.ListBox lbReader;
        private System.Windows.Forms.Label lbEstadoCRUD;
    }
}

