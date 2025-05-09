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
            if (string.IsNullOrWhiteSpace(txtIntegrante.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de integrante.");
                return;
            }
            dgvIntegrantes.Rows.Add(txtIntegrante.Text);
            txtIntegrante.Clear();
        }

        private void btnIngresarE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEjercicio.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de ejercicio.");
                return;
            }
            dgvEjercicios.Rows.Add(txtEjercicio.Text);
            txtEjercicio.Clear();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            if (dgvIntegrantes.Rows.Count == 0 || dgvEjercicios.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos un integrante y un ejercicio.");
                return;
            }
            DataGridView tablaIntegrantes = dgvIntegrantes;
            DataGridView tablaEjercicios = dgvEjercicios;
            Resultados formResultados = new Resultados(tablaIntegrantes,tablaEjercicios);
            formResultados.ShowDialog();
        }

        private void PressEntrer (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender == txtIntegrante)
                {
                    btnIngresarI.PerformClick();
                }
                else if (sender == txtEjercicio)
                {
                    btnIngresarE.PerformClick();
                }
            }
        }

        private void dgvIntegrantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
