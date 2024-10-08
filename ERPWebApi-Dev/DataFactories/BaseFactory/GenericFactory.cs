using DataUtility;
using Microsoft.Data.SqlClient;
//using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    //public class GenericFactory<T> where T : class, new() //No Interface
    public class GenericFactory<T> : IGenericFactory<T> where T : class, new()
    {
        public Task<int> ExecuteCommand(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                int result = 0;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
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

        public Task<string> ExecuteCommandString(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
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
        public Task<string> ExecuteCommandString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        //foreach (object obj in ht.Keys)
                        //{
                        //    string str = Convert.ToString(obj);
                        //    SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
                        //    cmd.Parameters.Add(parameter);
                        //}

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = Convert.ToString(dr.GetString(0));
                        }

                        //cmd.Parameters.Clear();
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
                    using (SqlConnection con = new SqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
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
                    using (SqlConnection con = new SqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
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
                    using (SqlConnection con = new SqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
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
                    using (SqlConnection con = new SqlConnection(StaticInfos.conString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        foreach (object obj in ht.Keys)
                        {
                            string str = Convert.ToString(obj);
                            SqlParameter parameter = new SqlParameter("@" + str, ht[obj]);
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
    }
}
