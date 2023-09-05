using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            recargarTabla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void recargarTabla()
        {
            DataTable dataTableLibros = ControladorLibro.Obtener();
            DataTable dataTableSocios = ControladorSocio.Obtener();
            DataTable dataTablePrestamo = ControladorPrestamo.Obtener();
        }

        public void limpiarTxtbox()
        {
            textBoxIdLibro.Clear();
            textBoxICBN.Clear();
            textBoxNombre.Clear();
            textBoxAutor.Clear();
            textBoxGenero.Clear();
            textBoxLanzamiento.Clear();

            txtBoxIdSocio.Clear();
            txtBoxNombreSocio.Clear();
            txtBoxApellidoSocio.Clear();
            txtBoxTelefonoSocio.Clear();

            txtBoxIdPrestamo.Clear();
            txtBoxIDLibroPrestamo.Clear();
            txtBoxIDSocioPrestamo.Clear();
            txtBoxFechaPrestamo.Clear();
            txtBoxDevolucionPrestamo.Clear();
        }

        public void aniadirLibro()
        {
            ControladorLibro.Crear(Int32.Parse(textBoxICBN.Text), textBoxNombre.Text, textBoxAutor.Text, textBoxGenero.Text, textBoxLanzamiento.Text, Int32.Parse(textBoxPaginas.Text));
            MessageBox.Show("Libro agregado con exito");
            recargarTabla();
            limpiarTxtbox();
        }
        public void aniadirSocio()
        {
            ControladorSocio.Crear(txtBoxNombreSocio.Text, txtBoxApellidoSocio.Text, Int32.Parse(txtBoxTelefonoSocio.Text));
            MessageBox.Show("Socio agregado con exito");
            recargarTabla();
            limpiarTxtbox();
        }
        public void aniadirPrestamo()
        {
            ControladorPrestamo.Crear(Int32.Parse(txtBoxIDLibroPrestamo.Text), Int32.Parse(txtBoxIDSocioPrestamo.Text), txtBoxFechaPrestamo.Text, txtBoxDevolucionPrestamo.Text);
            MessageBox.Show("Prestamo agregado con exito");
            recargarTabla();
            limpiarTxtbox();
        }

        public void eliminarLibro()
        {
            if (dataGridLibro.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridLibro.SelectedRows[0].Index;
                int id = (int)dataGridLibro.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableLibro = (DataTable)dataGridLibro.DataSource;
                dataTableLibro.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El libro fue eliminado correctamente");

                ControladorLibro.EliminarLibro(id);
                dataGridLibro.DataSource = dataTableLibro;
                recargarTabla();
            }
        }

        public void eliminarSocio()
        {
            if (dataGridViewSocios.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewSocios.SelectedRows[0].Index;
                int id = (int)dataGridViewSocios.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableSocio = (DataTable)dataGridViewSocios.DataSource;
                dataTableSocio.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El socio fue eliminado correctamente");

                ControladorSocio.EliminarSocio(id);
                dataGridViewSocios.DataSource = dataTableSocio;
                recargarTabla();
            }
        }

        public void eliminarPrestamo()
        {
            if (dataGridViewPrestamos.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPrestamos.SelectedRows[0].Index;
                int id = (int)dataGridViewPrestamos.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTablePrestamo = (DataTable)dataGridViewPrestamos.DataSource;
                dataTablePrestamo.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El prestamo fue eliminado correctamente");

                ControladorPrestamo.EliminarPrestamo(id);
                dataGridViewPrestamos.DataSource = dataTablePrestamo;
                recargarTabla();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void botonRecargar_Click(object sender, EventArgs e)
        {
            recargarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            aniadirLibro();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            eliminarLibro();
        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            aniadirSocio();
        }

        private void buttonEliminarSocio_Click(object sender, EventArgs e)
        {
            eliminarSocio();
        }

        private void buttonAddPrestamo_Click(object sender, EventArgs e)
        {
            aniadirPrestamo();
        }

        private void buttonDeletePrestamo_Click(object sender, EventArgs e)
        {
            eliminarPrestamo();
        }
    }
}
