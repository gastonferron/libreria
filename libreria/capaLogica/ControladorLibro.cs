using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public static class ControladorLibro
    {

        public static void Crear(int icbn, string nombre, string autor, string genero, string fechaLanzamiento, int cantidadPaginas)
        {
            ModelLibro libro = new ModelLibro();
            libro.icbn = icbn;
            libro.nombre = nombre;
            libro.autor = autor;
            libro.genero = genero;
            libro.fechaLanzamiento = fechaLanzamiento;
            libro.cantidadPaginas = cantidadPaginas;
            libro.Save();
        }

        public static DataTable Obtener()
        {
            ModelLibro LibroTableModel = new ModelLibro();
            List<ModelLibro> libros = LibroTableModel.obtenerLibros();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("autor", typeof(string));
            table.Columns.Add("genero", typeof(string));
            table.Columns.Add("fechaLanzamiento", typeof(string));
            table.Columns.Add("cantidadPaginas", typeof(int));

            foreach (ModelLibro libro in libros)
            {
                DataRow row = table.NewRow();
                row["id"] = libro.id;
                row["nombre"] = libro.nombre;
                row["autor"] = libro.autor;
                row["genero"] = libro.genero;
                row["fechaLanzamiento"] = libro.fechaLanzamiento;
                row["cantidadPaginas"] = libro.cantidadPaginas;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void EliminarLibro(int id)
        {
            ModelLibro libro = new ModelLibro();
            libro.id = id;
            libro.Eliminar();
        }
 
    }
}
