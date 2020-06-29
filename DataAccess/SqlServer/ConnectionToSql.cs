﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionstring;
        public ConnectionToSql()
        {
            connectionstring = "Server=.; DataBase=DrogasOneCNS; User Id=sa;Password=sa1;integrated security= false";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }

    }
}
