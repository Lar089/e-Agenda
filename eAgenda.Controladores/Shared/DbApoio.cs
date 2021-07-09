using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Controladores.Shared
{
    public static class DbApoio
    {
        public static void SetParameters(this SqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                SqlParameter dbParameter = new SqlParameter(name, value);

                command.Parameters.Add(dbParameter);
            }
        }

        public static void SetParametersSqlite(this SQLiteCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                SQLiteParameter dbParameter = new SQLiteParameter(name, value);

                command.Parameters.Add(dbParameter);
            }
        }

        public static string AppendSelectIdentity(this string sql)
        {
            return sql + ";SELECT SCOPE_IDENTITY()";
        }

        public static string AppendSelectLastInsertRowId(this string sql)
        {
            return sql + ";SELECT LAST_INSERT_ROWID();";
        }
    }
}
