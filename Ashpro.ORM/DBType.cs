using System;
using System.Collections.Generic;
using System.Text;

namespace Ashpro.ORM
{
    public static class DBType
    {
        public static string DatabaseType { get; set; } = "MSSQL";
        public static void SetType(string type)
        {
            DatabaseType = type;
        }
    }
}
