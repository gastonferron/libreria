using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class ModelLibro : DataBaseConnector
    {
        public int id { get; set; }
        public int icbn { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public string fechaLanzamiento { get; set; }
        public int cantidadPaginas { get; set; }


        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO libro(icbn, nombre, autor, genero, fechalanzamiento, cantidadpaginas) " +
                $"VALUES({this.icbn}, '{this.nombre}', '{this.autor}', '{this.genero}', '{this.fechaLanzamiento}', {this.cantidadPaginas})";

            this.Command.ExecuteNonQuery();
        }

        public List<ModelLibro> obtenerLibros()
        {
            this.Command.CommandText = "SELECT * FROM libro";
            this.Reader = this.Command.ExecuteReader();

            List<ModelLibro> nuevoLibro = new List<ModelLibro>();
            while (this.Reader.Read())
            {
                ModelLibro libro = new ModelLibro();
                libro.id = Int32.Parse(this.Reader["id"].ToString());
                libro.icbn = Int32.Parse(this.Reader["icbn"].ToString());
                libro.nombre = this.Reader["nombre"].ToString();
                libro.autor = this.Reader["autor"].ToString();
                libro.genero = this.Reader["genero"].ToString();
                libro.fechaLanzamiento = this.Reader["fechalanzamiento"].ToString();
                libro.cantidadPaginas = Int32.Parse(this.Reader["cantidadpaginas"].ToString());
                nuevoLibro.Add(libro);
            }
            return nuevoLibro;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM libro WHERE id = {this.id}";
            this.Command.ExecuteNonQuery();
        }
    }
}
