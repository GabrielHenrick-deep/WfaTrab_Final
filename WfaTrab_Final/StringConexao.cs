using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaTrab_Final
{
    class StringConexao
    {
        string serverName = "localhost";
        string port = "5432";
        string userName = "gabriel";
        string password = "78091215";
        string dataBaseName = "BdTrab";

        public string Conectar()
        {
            var connString = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3};" +
                "Database = {4};", serverName, port, userName, password, dataBaseName);
            return connString;
        }
    }
}
