using DataUtility;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    //public class GenericFactory<T> where T : class, new() //No Interface
    public class GenericFactoryMySql<T> : IGenericFactoryMySql<T> where T : class, new()
    {
        public Task<int> ExecuteCommand(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                int result = 0;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = dr.GetInt32(0);
                        }
                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return result;
            });
        }

        public Task<int> ExecuteCommandInt(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                int result = 0;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = dr.GetInt32(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return result;
            });
        }

        public Task<string> ExecuteCommandString(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = Convert.ToString(dr.GetString(0));
                        }

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        public Task<List<T>> ExecuteCommandList(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        Results = DataReaderMapToList<T>(cmd.ExecuteReader());
                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return Results;
            });
        }

        public Task<T> ExecuteCommandSingle(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                T Results = null;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        Results = DataReaderMapToList<T>(cmd.ExecuteReader()).FirstOrDefault();
                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return Results;
            });
        }

        public Task<T> ExecuteQuerySingle(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                T Results = null;

                try
                {
                    using (MySqlConnection con = new MySqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        Results = DataReaderMapToList<T>(cmd.ExecuteReader()).FirstOrDefault();
                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return Results;
            });
        }

        public Task<List<T>> ExecuteQuery(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            Results = DataReaderMapToList<T>(reader).ToList();
                        }

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return Results;
            });
        }

        public Task<List<T>> ExecuteQueryString(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            MySqlParameter parameter = new MySqlParameter("@" + str, ht[obj]);
                            cmd.Parameters.Add(parameter);
                        }

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            Results = DataReaderMapToList<T>(reader).ToList();
                        }

                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return Results;
            });
        }

        public Task<List<T>> ExecuteQueryList(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            Results = DataReaderMapToLists<T>(reader).ToList();
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }

                return Results;
            });
        }

        public List<T> DataReaderMapToList<Tentity>(IDataReader reader)
        {
            var results = new List<T>();

            var columnCount = reader.FieldCount;
            while (reader.Read())
            {
                var item = Activator.CreateInstance<T>();
                try
                {
                    var rdrProperties = Enumerable.Range(0, columnCount).Select(i => reader.GetName(i)).ToArray();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if ((typeof(T).GetProperty(property.Name).GetGetMethod().IsVirtual) || (!rdrProperties.Contains(property.Name)))
                        {
                            continue;
                        }
                        else
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                    }
                    results.Add(item);
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
            }
            return results;
        }

        public List<T> DataReaderMapToLists<Tentity>(IDataReader reader)
        {
            var results = new List<T>();

            var columnCount = reader.FieldCount;
            while (reader.Read())
            {
                var item = Activator.CreateInstance<T>();
                try
                {
                    var rdrProperties = Enumerable.Range(0, columnCount).Select(i => reader.GetName(i)).ToArray();
                    foreach (var property in typeof(T).GetProperties())
                    {

                        if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                        {
                            Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                            property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                        }
                    }
                    results.Add(item);
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
            }
            return results;
        }

        public Task<string> ExecuteCommandJsonString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            result = Convert.ToString(ToJson(reader));
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        public Task<string> ExecuteCommandString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = dr.GetString(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        private String ToJson(MySqlDataReader rdr)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.WriteStartArray();

                while (rdr.Read())
                {
                    jsonWriter.WriteStartObject();

                    int fields = rdr.FieldCount;

                    for (int i = 0; i < fields; i++)
                    {
                        jsonWriter.WritePropertyName(rdr.GetName(i));
                        jsonWriter.WriteValue(rdr[i]);
                    }

                    jsonWriter.WriteEndObject();
                }

                jsonWriter.WriteEndArray();

                return sw.ToString();
            }
        }
    }
}
