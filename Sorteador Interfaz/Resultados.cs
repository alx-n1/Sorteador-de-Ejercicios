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
    public partial class Resultados : Form
    {
        private DataGridView tablaIntegrantes;
        private DataGridView tablaEjercicios;
        public Resultados(DataGridView tablaIntegrantes, DataGridView tablaEjercicios)
        {
            InitializeComponent();
            this.tablaIntegrantes = tablaIntegrantes;
            this.tablaEjercicios = tablaEjercicios;
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            // Limpiar el DataGridView de resultados
            dgvResultados.Rows.Clear();
            // Obtener los integrantes y ejercicios
            List<string> integrantes = new List<string>();
            List<string> ejercicios = new List<string>();
            foreach (DataGridViewRow row in tablaIntegrantes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    integrantes.Add(row.Cells[0].Value.ToString());
                }
            }
            foreach (DataGridViewRow row in tablaEjercicios.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    ejercicios.Add(row.Cells[0].Value.ToString());
                }
            }
            // Sortear los ejercicios para cada integrante
            Random random = new Random();
            foreach (string integrante in integrantes)
            {
                int index = random.Next(ejercicios.Count);
                string ejercicio = ejercicios[index];
                dgvResultados.Rows.Add(integrante, ejercicio);
                ejercicios.RemoveAt(index); // Eliminar el ejercicio sorteado
            }

        }
    }
}
