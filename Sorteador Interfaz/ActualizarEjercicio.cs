using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteador_Interfaz
{
    public partial class ActualizarEjercicio : Form
    {
        private DataGridViewRow _fila;
        public ActualizarEjercicio(DataGridViewRow fila)
        {
            InitializeComponent();
            _fila = fila;
        }

        private void ActualizarEjercicio_Load(object sender, EventArgs e)
        {
            // Cargar el nombre del ejercicio en el TextBox
            txtEjercicio.Text = _fila.Cells[0].Value.ToString();

        }

        private void btnIngresarE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEjercicio.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de ejercicio.");
                return;
            }
            // Actualizar el nombre del ejercicio en la fila seleccionada
            _fila.Cells[0].Value = txtEjercicio.Text;
            this.Close(); // Cierra el formulario después de actualizar.
        }

        private void PressEntrer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Verifica si se presionó la tecla Enter.
            {
                btnIngresarE_Click(sender, e); // Llama al evento de clic del botón.
            }
        }
    }
}
