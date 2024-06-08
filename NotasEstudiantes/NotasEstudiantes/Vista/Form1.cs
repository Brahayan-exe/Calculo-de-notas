using NotasEstudiantes.Controlador;
using NotasEstudiantes.Modelo;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NotasEstudiantes
{
    public partial class Form1 : Form
    {
        CEstudiantes estudiantes = new CEstudiantes();
        private string id = null;
        private bool editar = false;
        private string nombreEstudiante = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarEstudiantes();
        }

        private void MostrarEstudiantes()
        {
            MEstudiantes refrescar = new MEstudiantes();
            dtgEstudiantes.DataSource = refrescar.MostrarEstudiantes();

        }



        private void dtgEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sdf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtEstudiante.Clear();
            txtCorte1.Clear();
            txtCorte2.Clear();
            txtCorte3.Clear();
        }

        private void btnDefinitiva_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {
                try
                {
                    estudiantes.InsertarEstudiantes(txtEstudiante.Text, txtCorte1.Text, txtCorte2.Text, txtCorte3.Text);
                    MessageBox.Show("Registro insertado correctamente");
                    MostrarEstudiantes();
                    Limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else
                try
                {
                    estudiantes.ActualizarNota(id,txtEstudiante.Text, txtCorte1.Text,txtCorte2.Text,txtCorte3.Text);
                    MessageBox.Show("Registro acytualizado correctamente");
                    MostrarEstudiantes();
                    Limpiar();

                    editar = false;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex.Message);
                }

        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
                      
            bool encontrado = false;
            nombreEstudiante = txtEstudiante.Text;
            int filaIndex = -1;
            int f = 0;
            int idEstudiante = -1;
            /* if (nombreEstudiante != "")
             {
                 nombreEstudiante = txtEstudiante.Text;
                 estudiantes.BuscarEstudiante(nombreEstudiante);

                 MessageBox.Show(nombreEstudiante);
             }
             else
                 MessageBox.Show("Ingre el nombre del estudiante a buscar");*/

            foreach (DataGridViewRow fila in dtgEstudiantes.Rows)
            {
                if (fila.Cells["Estudiante"].Value != null &&
                    fila.Cells["Estudiante"].Value.ToString().Equals(nombreEstudiante, StringComparison.OrdinalIgnoreCase))
                {
                    fila.Selected = true;
                    dtgEstudiantes.FirstDisplayedScrollingRowIndex = fila.Index; // Desplazar a la fila encontrada
                    filaIndex = fila.Index;
                    idEstudiante = Convert.ToInt32(fila.Cells["id"].Value);
                    txtEstudiante.Text = fila.Cells["Estudiante"].Value.ToString();
                    txtCorte1.Text = fila.Cells["Nota_1"].Value.ToString();
                    txtCorte2.Text = fila.Cells["Nota_2"].Value.ToString();
                    txtCorte3.Text = fila.Cells["Nota_3"].Value.ToString();
                    encontrado = true;

                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Estudiante no encontrado.");
            }

        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (dtgEstudiantes.SelectedRows.Count > 0)
            {
                id = dtgEstudiantes.CurrentRow.Cells["id"].Value.ToString();
                estudiantes.EliminarEstudiante(id);
                MessageBox.Show("Registro eliminado correctamente");
                MostrarEstudiantes();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnActualizarNota_Click(object sender, EventArgs e)
        {
            editar = true;
            if (dtgEstudiantes.SelectedRows.Count > 0)
            {
                id = dtgEstudiantes.CurrentRow.Cells["id"].Value.ToString();
                txtEstudiante.Text = dtgEstudiantes.CurrentRow.Cells["Estudiante"].Value.ToString();
                txtCorte1.Text = dtgEstudiantes.CurrentRow.Cells["Nota_1"].Value.ToString();
                txtCorte2.Text = dtgEstudiantes.CurrentRow.Cells["Nota_2"].Value.ToString();
                txtCorte3.Text = dtgEstudiantes.CurrentRow.Cells["Nota_3"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila");
        }
      
    }
}
