﻿using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaLogica
{
    public static class ControladorSocio
    {

        public static void Crear(string nombre, string apellido, int telefono)
        {
            ModelSocio socio = new ModelSocio();
            socio.nombre = nombre;
            socio.apellido = apellido;
            socio.telefono = telefono;
            socio.Save();
        }

        public static DataTable Obtener()
        {
            ModelSocio SocioTableModel = new ModelSocio();
            List<ModelSocio> socios = SocioTableModel.obtenerSocios();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("apellido", typeof(string));
            table.Columns.Add("telefono", typeof(int));

            foreach (ModelSocio socio in socios)
            {
                DataRow row = table.NewRow();
                row["id"] = socio.id;
                row["nombre"] = socio.nombre;
                row["apellido"] = socio.apellido;
                row["telefono"] = socio.telefono;
                table.Rows.Add(row);
            }
            return table;
        }

        public static void EliminarSocio(int id)
        {
            ModelSocio socio = new ModelSocio();
            socio.id = id;
            socio.Eliminar();
        }

    }
}
