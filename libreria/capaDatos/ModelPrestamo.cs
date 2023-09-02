using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    class ModelPrestamo : DataBaseConnector
    {
        public int id { get; set; }
        public int socio { get; set; }
        public int libro { get; set; }
        public string fechaPrestamo { get; set; }
        public string fechaDevolucion { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO socio(socio, libro, fechaPrestamo, fechaDevolucion) " +
                $"VALUES('{this.socio}, {this.libro}, {this.fechaPrestamo}', '{this.fechaDevolucion}')";

            this.Command.ExecuteNonQuery();
        }

        public List<ModelPrestamo> obtenerPrestamos()
        {
            this.Command.CommandText = "SELECT * FROM prestamo";
            this.Reader = this.Command.ExecuteReader();

            List<ModelPrestamo> nuevoPrestamo = new List<ModelPrestamo>();
            while (this.Reader.Read())
            {
                ModelPrestamo prestamo = new ModelPrestamo();
                prestamo.id = Int32.Parse(this.Reader["id"].ToString());
                prestamo.socio = Int32.Parse(this.Reader["socio"].ToString());
                prestamo.libro = Int32.Parse(this.Reader["libro"].ToString());
                prestamo.fechaPrestamo = this.Reader["fechaPrestamo"].ToString();
                prestamo.fechaDevolucion = this.Reader["fechaDevolucion"].ToString();
                nuevoPrestamo.Add(prestamo);
            }
            return nuevoPrestamo;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM socio WHERE id = {this.id}";
            this.Command.ExecuteNonQuery();
        }
    }
}
