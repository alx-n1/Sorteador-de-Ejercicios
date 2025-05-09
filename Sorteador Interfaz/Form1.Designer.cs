namespace Sorteador_Interfaz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtIntegrante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.btnIngresarI = new System.Windows.Forms.Button();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEjercicios = new System.Windows.Forms.DataGridView();
            this.btnIngresarE = new System.Windows.Forms.Button();
            this.btnSortear = new System.Windows.Forms.Button();
            this.Ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Integrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarI = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarI = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIntegrante
            // 
            this.txtIntegrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegrante.Location = new System.Drawing.Point(42, 119);
            this.txtIntegrante.Name = "txtIntegrante";
            this.txtIntegrante.Size = new System.Drawing.Size(248, 30);
            this.txtIntegrante.TabIndex = 0;
            this.txtIntegrante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressEntrer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de integrante";
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.AllowUserToAddRows = false;
            this.dgvIntegrantes.AllowUserToDeleteRows = false;
            this.dgvIntegrantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Integrante,
            this.EditarI,
            this.EliminarI});
            this.dgvIntegrantes.Location = new System.Drawing.Point(42, 182);
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.RowHeadersWidth = 51;
            this.dgvIntegrantes.RowTemplate.Height = 24;
            this.dgvIntegrantes.Size = new System.Drawing.Size(619, 235);
            this.dgvIntegrantes.TabIndex = 2;
            this.dgvIntegrantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntegrantes_CellContentClick);
            // 
            // btnIngresarI
            // 
            this.btnIngresarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarI.Location = new System.Drawing.Point(398, 85);
            this.btnIngresarI.Name = "btnIngresarI";
            this.btnIngresarI.Size = new System.Drawing.Size(161, 44);
            this.btnIngresarI.TabIndex = 3;
            this.btnIngresarI.Text = "Ingresar";
            this.btnIngresarI.UseVisualStyleBackColor = true;
            this.btnIngresarI.Click += new System.EventHandler(this.btnIngresarI_Click);
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio.Location = new System.Drawing.Point(751, 119);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(251, 30);
            this.txtEjercicio.TabIndex = 0;
            this.txtEjercicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressEntrer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejercicio";
            // 
            // dgvEjercicios
            // 
            this.dgvEjercicios.AllowUserToAddRows = false;
            this.dgvEjercicios.AllowUserToDeleteRows = false;
            this.dgvEjercicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEjercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ejercicio,
            this.EditarE,
            this.EliminarE});
            this.dgvEjercicios.Location = new System.Drawing.Point(751, 182);
            this.dgvEjercicios.Name = "dgvEjercicios";
            this.dgvEjercicios.RowHeadersWidth = 51;
            this.dgvEjercicios.RowTemplate.Height = 24;
            this.dgvEjercicios.Size = new System.Drawing.Size(646, 235);
            this.dgvEjercicios.TabIndex = 2;
            // 
            // btnIngresarE
            // 
            this.btnIngresarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarE.Location = new System.Drawing.Point(1118, 85);
            this.btnIngresarE.Name = "btnIngresarE";
            this.btnIngresarE.Size = new System.Drawing.Size(152, 44);
            this.btnIngresarE.TabIndex = 3;
            this.btnIngresarE.Text = "Ingresar";
            this.btnIngresarE.UseVisualStyleBackColor = true;
            this.btnIngresarE.Click += new System.EventHandler(this.btnIngresarE_Click);
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(632, 480);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(152, 44);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "SORTEAR!";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // Ejercicio
            // 
            this.Ejercicio.HeaderText = "Ejercicio";
            this.Ejercicio.MinimumWidth = 6;
            this.Ejercicio.Name = "Ejercicio";
            // 
            // EditarE
            // 
            this.EditarE.HeaderText = "Editar";
            this.EditarE.MinimumWidth = 6;
            this.EditarE.Name = "EditarE";
            this.EditarE.Text = "Editar";
            this.EditarE.UseColumnTextForButtonValue = true;
            // 
            // EliminarE
            // 
            this.EliminarE.HeaderText = "Eliminar";
            this.EliminarE.MinimumWidth = 6;
            this.EliminarE.Name = "EliminarE";
            this.EliminarE.Text = "Eliminar";
            this.EliminarE.UseColumnTextForButtonValue = true;
            // 
            // Integrante
            // 
            this.Integrante.HeaderText = "Integrante";
            this.Integrante.MinimumWidth = 6;
            this.Integrante.Name = "Integrante";
            // 
            // EditarI
            // 
            this.EditarI.HeaderText = "Editar";
            this.EditarI.MinimumWidth = 6;
            this.EditarI.Name = "EditarI";
            this.EditarI.Text = "Editar";
            this.EditarI.UseColumnTextForButtonValue = true;
            // 
            // EliminarI
            // 
            this.EliminarI.HeaderText = "Eliminar";
            this.EliminarI.MinimumWidth = 6;
            this.EliminarI.Name = "EliminarI";
            this.EliminarI.Text = "Eliminar";
            this.EliminarI.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 718);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.btnIngresarE);
            this.Controls.Add(this.btnIngresarI);
            this.Controls.Add(this.dgvEjercicios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIntegrantes);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntegrante);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntegrante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Button btnIngresarI;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEjercicios;
        private System.Windows.Forms.Button btnIngresarE;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejercicio;
        private System.Windows.Forms.DataGridViewButtonColumn EditarE;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integrante;
        private System.Windows.Forms.DataGridViewButtonColumn EditarI;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarI;
    }
}

