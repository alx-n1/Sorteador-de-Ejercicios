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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }


        private void btnIngresarI_Click(object sender, EventArgs e)
        {
            // Verifica si el campo de texto está vacío o contiene solo espacios.
            if (string.IsNullOrWhiteSpace(txtIntegrante.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de integrante."); 
                return;
            }
            // Agrega el texto ingresado al DataGridView de integrantes.
            dgvIntegrantes.Rows.Add(txtIntegrante.Text);
            txtIntegrante.Clear(); // Limpia el campo de texto.
        }


        private void btnIngresarE_Click(object sender, EventArgs e)
        {
            // Verifica si el campo de texto está vacío o contiene solo espacios.
            if (string.IsNullOrWhiteSpace(txtEjercicio.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de ejercicio."); 
                return;
            }
            // Agrega el texto ingresado al DataGridView de ejercicios.
            dgvEjercicios.Rows.Add(txtEjercicio.Text);
            txtEjercicio.Clear(); // Limpia el campo de texto.
        }


        private void btnSortear_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos un integrante y un ejercicio en las tablas.
            if (dgvIntegrantes.Rows.Count == 0 || dgvEjercicios.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos un integrante y un ejercicio."); // Muestra un mensaje de error.
                return;
            }
            // Crea referencias a las tablas de integrantes y ejercicios.
            DataGridView tablaIntegrantes = dgvIntegrantes;
            DataGridView tablaEjercicios = dgvEjercicios;

            // Crea una nueva instancia del formulario de resultados y lo muestra.
            Resultados formResultados = new Resultados(tablaIntegrantes, tablaEjercicios);
            formResultados.ShowDialog();
        }

        private void PressEntrer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Verifica si se presionó la tecla Enter.
            {
                if (sender == txtIntegrante) // Si el foco está en el campo de texto de integrantes.
                {
                    btnIngresarI.PerformClick(); // Simula un clic en el botón "Ingresar Integrante".
                }
                else if (sender == txtEjercicio) // Si el foco está en el campo de texto de ejercicios.
                {
                    btnIngresarE.PerformClick(); // Simula un clic en el botón "Ingresar Ejercicio".
                }
            }
        }


        private void dgvIntegrantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna clickeada es la de "Eliminar".
            if (dgvIntegrantes.Columns[e.ColumnIndex].Name == "EliminarI")
            {
                if (e.RowIndex >= 0) // Verifica que la fila sea válida.
                {
                    dgvIntegrantes.Rows.RemoveAt(e.RowIndex); // Elimina la fila seleccionada.
                }
            }
            else if (dgvIntegrantes.Columns[e.ColumnIndex].Name == "EditarI")
            {
                if (e.RowIndex >= 0) // Verifica que la fila sea válida.
                {
                    // Crea una nueva instancia del formulario de actualización y lo muestra.
                    DataGridViewRow fila = dgvIntegrantes.Rows[e.RowIndex]; // Obtiene la fila seleccionada.
                    ActualizarIntegrante formActualizar = new ActualizarIntegrante(fila);
                    formActualizar.ShowDialog();
                }
            }
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void dgvEjercicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna clickeada es la de "Eliminar".
            if (dgvEjercicios.Columns[e.ColumnIndex].Name == "EliminarE")
            {
                if (e.RowIndex >= 0) // Verifica que la fila sea válida.
                {
                    dgvEjercicios.Rows.RemoveAt(e.RowIndex); 
                }
            }
            else if (dgvEjercicios.Columns[e.ColumnIndex].Name == "EditarE")
            {
                if (e.RowIndex >= 0) // Verifica que la fila sea válida.
                {
                    // Crea una nueva instancia del formulario de actualización y lo muestra.
                    DataGridViewRow fila = dgvEjercicios.Rows[e.RowIndex]; // Obtiene la fila seleccionada.
                    ActualizarEjercicio formActualizar = new ActualizarEjercicio(fila);
                    formActualizar.ShowDialog();
                }
            }
        }
    }
}
