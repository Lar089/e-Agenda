using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;

namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {
        private static readonly string connectionString = "";
        private static readonly string banco = "";

        static Db()
        {
            banco = ConfigurationManager.AppSettings["bancoparausar"].Trim();
            connectionString = ConfigurationManager.ConnectionStrings[banco].ConnectionString;

        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            if (banco.Equals("SQLite"))
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
                connection.Open();
                int id = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return id;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql.AppendSelectIdentity(), connection);

                command.SetParameters(parameters);

                connection.Open();

                int id = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return id;
            }
        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            if (banco.Equals("SQLite"))
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                    command.SetParametersSqlite(parameters);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();

                }
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            if (banco.Equals("SQLite"))
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);

                SQLiteCommand command = new SQLiteCommand(sql, connection);

                command.SetParametersSqlite(parameters);

                connection.Open();

                var list = new List<T>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }

                connection.Close();
                return list;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                var list = new List<T>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }

                connection.Close();
                return list;
            }
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            if (banco.Equals("SQLite"))
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                SQLiteCommand command = new SQLiteCommand(sql.AppendSelectLastInsertRowId(), connection);

                command.SetParametersSqlite(parameters);
                connection.Open();

                T t = default;
                using (var reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                        t = default;
                    else
                    {
                        reader.Read();
                        t = convert(reader);
                    }
                }
                connection.Close();
                return t;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                T t = default;

                var reader = command.ExecuteReader();

                if (reader.Read())
                    t = convert(reader);

                connection.Close();
                return t;
            }
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            if (banco.Equals("SQLite"))
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);

                SQLiteCommand command = new SQLiteCommand(sql, connection);

                command.SetParametersSqlite(parameters);

                connection.Open();

                int numberRows = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return numberRows > 0;
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand(sql, connection);

                command.SetParameters(parameters);

                connection.Open();

                int numberRows = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return numberRows > 0;
            }

        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

    }
}
