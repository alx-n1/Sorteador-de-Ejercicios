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
    public partial class ActualizarIntegrante : Form
    {
        private DataGridViewRow _fila;
        public ActualizarIntegrante(DataGridViewRow fila)
        {
            InitializeComponent();
            _fila = fila;
        }

        private void ActualizarIntegrante_Load(object sender, EventArgs e)
        {
            // Cargar el nombre del integrante en el TextBox
            txtIntegrante.Text = _fila.Cells[0].Value.ToString();

        }

        private void btnIngresarI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIntegrante.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de integrante.");
                return;
            }
            // Actualizar el nombre del integrante en la fila seleccionada
            _fila.Cells[0].Value = txtIntegrante.Text;
            this.Close(); // Cierra el formulario después de actualizar.
        }
        private void PressEntrer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Verifica si se presionó la tecla Enter.
            {
                btnIngresarI_Click(sender, e); // Llama al evento de clic del botón.

            }
        }
    }
}
