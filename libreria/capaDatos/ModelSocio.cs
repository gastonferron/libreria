using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class ModelSocio : DataBaseConnector
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO socio(nombre, apellido, telefono) " +
                $"VALUES('{this.nombre}', '{this.apellido}', {this.telefono})";

            this.Command.ExecuteNonQuery();
        }

        public List<ModelSocio> obtenerSocios()
        {
            this.Command.CommandText = "SELECT * FROM socio";
            this.Reader = this.Command.ExecuteReader();

            List<ModelSocio> nuevoSocio = new List<ModelSocio>();
            while (this.Reader.Read())
            {
                ModelSocio socio = new ModelSocio();
                socio.id = Int32.Parse(this.Reader["id"].ToString());
                socio.nombre = this.Reader["nombre"].ToString();
                socio.apellido = this.Reader["apellido"].ToString();
                socio.telefono = Int32.Parse(this.Reader["telefono"].ToString());
                nuevoSocio.Add(socio);
            }
            return nuevoSocio;
        }

        public void Eliminar()
        {
            this.Command.CommandText = $"DELETE FROM socio WHERE id = {this.id}";
            this.Command.ExecuteNonQuery();
        }
    }
}
