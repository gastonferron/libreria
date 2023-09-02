﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace capaDatos
{
    public abstract class DataBaseConnector
    {
        public string dbip;
        public string dbUser;
        public string dbPassword;
        public string dbDatabaseName;

        public MySqlConnection Connection;
        public MySqlCommand Command;
        public MySqlDataReader Reader;

        public DataBaseConnector()
        {
            this.dbip = "localhost";
            this.dbUser = "root";
            this.dbPassword = "asd123";
            this.dbDatabaseName = "programacion";

            this.Connection = new MySqlConnection(
                $"server={this.dbip};" +
                $"user={this.dbUser};" +
                $"password={this.dbPassword};" +
                $"database={this.dbDatabaseName};");

            this.Connection.Open();
            this.Command = new MySqlCommand();
            this.Command.Connection = this.Connection;
        }
    }
}
