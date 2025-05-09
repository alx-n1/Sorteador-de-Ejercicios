namespace Sorteador_Interfaz
{
    partial class ActualizarEjercicio
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
            this.btnIngresarE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresarE
            // 
            this.btnIngresarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarE.Location = new System.Drawing.Point(87, 174);
            this.btnIngresarE.Name = "btnIngresarE";
            this.btnIngresarE.Size = new System.Drawing.Size(152, 44);
            this.btnIngresarE.TabIndex = 6;
            this.btnIngresarE.Text = "Ingresar";
            this.btnIngresarE.UseVisualStyleBackColor = true;
            this.btnIngresarE.Click += new System.EventHandler(this.btnIngresarE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ejercicio";
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio.Location = new System.Drawing.Point(34, 123);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(251, 30);
            this.txtEjercicio.TabIndex = 4;
            // 
            // ActualizarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 288);
            this.Controls.Add(this.btnIngresarE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEjercicio);
            this.Name = "ActualizarEjercicio";
            this.Text = "ActualizarEjercicio";
            this.Load += new System.EventHandler(this.ActualizarEjercicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEjercicio;
    }
}