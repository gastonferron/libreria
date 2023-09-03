using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    class ControladorPrestamo
    {
        public static void Crear(int socio, int libro, string fechaPrestamo, string fechaDevolucion)
        {
            ModelPrestamo prestamo = new ModelPrestamo();
            prestamo.socio = socio;
            prestamo.libro = libro;
            prestamo.fechaPrestamo = fechaPrestamo;
            prestamo.fechaDevolucion = fechaDevolucion;
            prestamo.Save();
        }

        public static DataTable Obtener()
        {
            ModelPrestamo PrestamoTableModel = new ModelPrestamo();
            List<ModelPrestamo> prestamos = PrestamoTableModel.obtenerPrestamos();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("socio", typeof(int));
            table.Columns.Add("libro", typeof(int));
            table.Columns.Add("fechaPrestamo", typeof(string));
            table.Columns.Add("fechaDevolucion", typeof(string));

            foreach (ModelPrestamo prestamo in prestamos)
            {
                DataRow row = table.NewRow();
                row["id"] = prestamo.id;
                row["libro"] = prestamo.socio;
                row["libro"] = prestamo.libro;
                row["fechaPrestamo"] = prestamo.fechaPrestamo;
                row["fechaDevolucion"] = prestamo.fechaDevolucion;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void EliminarSocio(int id)
        {
            ModelPrestamo prestamo = new ModelPrestamo();
            prestamo.id = id;
            prestamo.Delete();
        }
    }
}
