namespace Sorteador_Interfaz
{
    partial class ActualizarIntegrante
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
            this.btnIngresarI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntegrante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresarI
            // 
            this.btnIngresarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarI.Location = new System.Drawing.Point(89, 219);
            this.btnIngresarI.Name = "btnIngresarI";
            this.btnIngresarI.Size = new System.Drawing.Size(161, 44);
            this.btnIngresarI.TabIndex = 6;
            this.btnIngresarI.Text = "Ingresar";
            this.btnIngresarI.UseVisualStyleBackColor = true;
            this.btnIngresarI.Click += new System.EventHandler(this.btnIngresarI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de integrante";
            // 
            // txtIntegrante
            // 
            this.txtIntegrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegrante.Location = new System.Drawing.Point(50, 174);
            this.txtIntegrante.Name = "txtIntegrante";
            this.txtIntegrante.Size = new System.Drawing.Size(248, 30);
            this.txtIntegrante.TabIndex = 4;
            // 
            // ActualizarIntegrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 382);
            this.Controls.Add(this.btnIngresarI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntegrante);
            this.Name = "ActualizarIntegrante";
            this.Text = "ActualizarIntegrante";
            this.Load += new System.EventHandler(this.ActualizarIntegrante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntegrante;
    }
}