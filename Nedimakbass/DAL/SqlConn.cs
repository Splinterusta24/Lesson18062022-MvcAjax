using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nedimakbass.DAL
{
    public class SqlConn
    {
        private string _connectionString= @"Server=DESKTOP-63E5VH2;Database=MVCWebSite;Trusted_Connection=True;";

        public string ConnectionString { get { return _connectionString;} }


    }
}