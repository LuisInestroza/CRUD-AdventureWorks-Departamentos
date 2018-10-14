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
            this.btnListarDepartamento = new System.Windows.Forms.Button();
            this.btnCrearDepartementos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.gbOperacionesDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperacionesDisponibles
            // 
            this.gbOperacionesDisponibles.Controls.Add(this.btnEliminarDepartamento);
            this.gbOperacionesDisponibles.Controls.Add(this.btnListarDepartamento);
            this.gbOperacionesDisponibles.Controls.Add(this.btnCrearDepartementos);
            this.gbOperacionesDisponibles.Controls.Add(this.button3);
            this.gbOperacionesDisponibles.Font = new System.Drawing.Font("Arial", 10F);
            this.gbOperacionesDisponibles.Location = new System.Drawing.Point(12, 29);
            this.gbOperacionesDisponibles.Name = "gbOperacionesDisponibles";
            this.gbOperacionesDisponibles.Size = new System.Drawing.Size(400, 179);
            this.gbOperacionesDisponibles.TabIndex = 0;
            this.gbOperacionesDisponibles.TabStop = false;
            this.gbOperacionesDisponibles.Text = "Operaciones disponibles para departamentos";
            // 
            // btnListarDepartamento
            // 
            this.btnListarDepartamento.Location = new System.Drawing.Point(6, 43);
            this.btnListarDepartamento.Name = "btnListarDepartamento";
            this.btnListarDepartamento.Size = new System.Drawing.Size(155, 39);
            this.btnListarDepartamento.TabIndex = 1;
            this.btnListarDepartamento.Text = "Listar Departamentos";
            this.btnListarDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnCrearDepartementos
            // 
            this.btnCrearDepartementos.Location = new System.Drawing.Point(184, 43);
            this.btnCrearDepartementos.Name = "btnCrearDepartementos";
            this.btnCrearDepartementos.Size = new System.Drawing.Size(166, 39);
            this.btnCrearDepartementos.TabIndex = 2;
            this.btnCrearDepartementos.Text = "Crear Departamento";
            this.btnCrearDepartementos.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(184, 117);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(166, 43);
            this.btnEliminarDepartamento.TabIndex = 4;
            this.btnEliminarDepartamento.Text = "Eliminar Departamento";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            // 
            // frmOpetacionesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 225);
            this.Controls.Add(this.gbOperacionesDisponibles);
            this.Name = "frmOpetacionesCRUD";
            this.Text = "Operaciones CRUD con departamentos Adventure Works";
            this.gbOperacionesDisponibles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperacionesDisponibles;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnListarDepartamento;
        private System.Windows.Forms.Button btnCrearDepartementos;
        private System.Windows.Forms.Button button3;
    }
}

