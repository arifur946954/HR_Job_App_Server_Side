using DataUtility;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
//using Oracle.ManagedDataAccess.Client;
//using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    public class GenericFactoryOracle<T> : IGenericFactoryOracle<T> where T : class, new()
    {
        public Task<int> ExecuteCommand(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                int result = 0;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);

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

        public Task<int> ExecuteCommand(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                int result = 0;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

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

        public Task<int> ExecuteCommand(string spQuery, OracleParameter[] oparameter, string conString)
        {
            return Task.Run(() =>
            {
                int result = 0;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddRange(oparameter);

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

        public Task<string> ExecuteCommandString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = Convert.ToString(dr.GetString(0));
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
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = Convert.ToString(dr.GetString(0));
                        }

                        cmd.Parameters.Clear();
                        //con.Close();
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        public Task<string> ExecuteCommandString(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

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

        public Task<DataTable> ExecuteCommandDataTable(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                DataTable result = new DataTable();
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        IDataReader dr = cmd.ExecuteReader();
                        //if (dr.Read())
                        //{
                        result.Load(dr);
                        //}

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

        public Task<string> ExecuteNonQueryOutString(string spQuery, OracleCommand cmd, string OutParameter, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.ExecuteNonQueryAsync();                        
                        result = cmd.Parameters[OutParameter].Value.ToString();
                        cmd.Connection.CloseAsync();
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

        public Task<string> ExecuteNonQueryOutString(string spQuery, Hashtable ht, string OutParameter, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);
                        cmd.ExecuteNonQueryAsync();                        
                        result = cmd.Parameters[OutParameter].Value.ToString();
                        cmd.Connection.CloseAsync();
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

        public Task<string> ExecuteNonQueryOutClob(string spQuery, OracleCommand cmd, string OutParameter, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.ExecuteNonQueryAsync();
                        OracleClob res = (OracleClob)cmd.Parameters[OutParameter].Value;
                        result = string.IsNullOrEmpty(res.Value) ? string.Empty : res.Value.ToString();
                        cmd.Connection.CloseAsync();
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

        public Task<string> ExecuteNonQueryOutClob(string spQuery, Hashtable ht, string OutParameter, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);
                        cmd.ExecuteNonQueryAsync();
                        OracleClob res = (OracleClob)cmd.Parameters[OutParameter].Value;
                        result = string.IsNullOrEmpty(res.Value) ? string.Empty : res.Value.ToString();
                        cmd.Connection.CloseAsync();
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

        public Task ExecuteNonQueryCommand(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.ExecuteNonQueryAsync();
                        cmd.Connection.CloseAsync();
                        cmd.Parameters.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Logs.Bug(ex);
                }
            });
        }

        public Task<string> ExecuteCommandString(string spQuery, OracleParameter[] oparameter, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddRange(oparameter);

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
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);

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

        public Task<List<T>> ExecuteCommandList(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

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

        public Task<List<T>> ExecuteCommandList(string spQuery, OracleParameter[] oparameter, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddRange(oparameter);

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
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);

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

        public Task<T> ExecuteCommandSingle(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                T Results = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

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

        public Task<T> ExecuteCommandSingle(string spQuery, OracleParameter[] oparameter, string conString)
        {
            return Task.Run(() =>
            {
                T Results = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(StaticInfos.conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddRange(oparameter);

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
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);

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

        public Task<T> ExecuteQuerySingle(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                T Results = null;

                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

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

        public Task<T> ExecuteQuerySingle(string spQuery, OracleParameter[] oparameter, string conString)
        {
            return Task.Run(() =>
            {
                T Results = null;

                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddRange(oparameter);

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
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        OracleParameter[] oparam = HashToOraParam(ht);
                        cmd.Parameters.AddRange(oparam);

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

        public Task<List<T>> ExecuteQuery(string spQuery, OracleCommand cmd, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

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

        public Task<List<T>> ExecuteQuery(string spQuery, OracleParameter[] oparameter, string conString)
        {
            return Task.Run(() =>
            {
                List<T> Results = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddRange(oparameter);

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

        public Task<string> GetByQueryString(string Query, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        Query = MapQueryParameter(Query, ht);
                        cmd.CommandText = Query;

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = Convert.ToString(dr.GetString(0));
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

        public Task<string> GetByQueryJsonString(string Query, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        Query = MapQueryParameter(Query, ht);
                        cmd.CommandText = Query;

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            result = DataReaderMapToJson(reader);
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

        public Task<List<T>> GetListByQueryString(string Query, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                List<T> result = null;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        Query = MapQueryParameter(Query, ht);
                        cmd.CommandText = Query;

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            result = DataReaderMapToList<T>(reader).ToList();
                        }

                        //string Results = JsonConvert.SerializeObject(result);
                        //result = DataReaderMapToList<T>(cmd.ExecuteReader());                        
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        public Task<string> GetByQuerySingleString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        IDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            result = Convert.ToString(dr.GetString(0));
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

        public Task<string> GetByQueryJsonString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (IDataReader reader = cmd.ExecuteReader())
                        {
                            result = DataReaderMapToJson(reader);
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

        public Task<string> SetByQueryString(string spQuery, Hashtable ht, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        cmd.ExecuteReader();
                        //IDataReader dr = cmd.ExecuteReader();
                        //if (dr.Read())
                        //{
                        //    result = Convert.ToString(dr.GetString(0));
                        //}
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        public Task<string> SetByQueryString(string spQuery, string conString)
        {
            return Task.Run(() =>
            {
                string result = string.Empty;
                try
                {
                    using (OracleConnection con = new OracleConnection(conString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = spQuery;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        cmd.ExecuteReader();
                        //IDataReader dr = cmd.ExecuteReader();
                        //if (dr.Read())
                        //{
                        //    result = Convert.ToString(dr.GetString(0));
                        //}
                    }
                }
                catch (Exception ex)
                {
                    //Logs.WriteBug(ex);
                }
                return result;
            });
        }

        //public List<T> OraDataReaderMapToList<Tentity>(OracleDataReader reader)
        //{
        //    var results = new List<T>();

        //    var columnCount = reader.FieldCount;
        //    while (reader.Read())
        //    {
        //        var item = Activator.CreateInstance<T>();
        //        try
        //        {
        //            var rdrProperties = Enumerable.Range(0, columnCount).Select(i => reader.GetName(i)).ToArray();
        //            foreach (var property in typeof(T).GetProperties())
        //            {
        //                if ((typeof(T).GetProperty(property.Name).GetGetMethod().IsVirtual) || (!rdrProperties.Contains(property.Name)))
        //                {
        //                    continue;
        //                }
        //                else
        //                {
        //                    if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
        //                    {
        //                        Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
        //                        property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
        //                    }
        //                }
        //            }
        //            results.Add(item);
        //        }
        //        catch (Exception ex)
        //        {
        //            //Logs.WriteBug(ex);
        //        }
        //    }
        //    return results;
        //}

        //public List<T> DataReaderMapToList<Tentity>(IDataReader reader)
        //{
        //    var results = new List<T>();

        //    var columnCount = reader.FieldCount;
        //    while (reader.Read())
        //    {
        //        var item = Activator.CreateInstance<T>();
        //        try
        //        {
        //            var rdrProperties = Enumerable.Range(0, columnCount).Select(i => reader.GetName(i)).ToArray();
        //            foreach (var property in typeof(T).GetProperties())
        //            {
        //                if ((typeof(T).GetProperty(property.Name).GetGetMethod().IsVirtual) || (!rdrProperties.Contains(property.Name)))
        //                {
        //                    continue;
        //                }
        //                else
        //                {
        //                    if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
        //                    {
        //                        Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
        //                        property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
        //                    }
        //                }
        //            }
        //            results.Add(item);
        //        }
        //        catch (Exception ex)
        //        {
        //            //Logs.WriteBug(ex);
        //        }
        //    }
        //    return results;
        //}

        public List<T> DataReaderMapToList<Tentity>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (var prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        private string DataReaderMapToJson(IDataReader dataReader)
        {
            var dataTable = new DataTable();
            dataTable.Load(dataReader);
            string JsonString = string.Empty;
            JsonString = JsonConvert.SerializeObject(dataTable);
            return JsonString;
        }

        private OracleParameter[] HashToOraParam(Hashtable ht)
        {
            OracleParameter[] orclParamList = new OracleParameter[ht.Keys.Count]; int lCount = 0;

            //var orderKeys = ht.Cast<string>().OrderBy(c => c);
            //var allKvp = from x in orderKeys select new { key = x, value = ht[x] };
            foreach (DictionaryEntry obj in ht)
            {
                OracleParameter parameter = null;
                //string str = Convert.ToString(obj);
                //string val = ht[obj].ToString();
                string str = obj.Key.ToString();
                string val = obj.Value.ToString();
                string[] oDbType = null;
                string oVal = val.Replace("(", "").Trim().Replace(")", "").Trim().Replace(" ", "").Trim();
                oDbType = oVal.Split(',');

                if (oDbType.Length == 2)
                {
                    string dbType = string.Empty;
                    foreach (string item in oDbTypes) { if (item == oDbType[1].ToString()) { dbType = item; break; } };
                    if (string.IsNullOrEmpty(dbType.ToString()))
                    {
                        string oDbVal = oDbType[1].ToString();
                        parameter = new OracleParameter(str, oDbVal.ToString());
                    }
                }
                else if (oDbType.Length == 3)
                {
                    string dbType = string.Empty;
                    foreach (string item in oDbTypes) { if (item == oDbType[1].ToString()) { dbType = item; break; } };
                    if (!string.IsNullOrEmpty(dbType.ToString()))
                    {
                        OracleDbType orclDb;
                        if (OracleDbType.TryParse(dbType.ToString(), out orclDb))
                        {
                            ParameterDirection prmdir;
                            if (ParameterDirection.TryParse(oDbType[2].ToString(), out prmdir))
                            {
                                string oDbVal = oDbType[2].ToString();
                                if (oDbVal == "Input" || oDbVal == "Output" || oDbVal == "InputOutput" || oDbVal == "ReturnValue")
                                {
                                    parameter = new OracleParameter(str, orclDb, prmdir);
                                }
                                else
                                {
                                    if (prmdir.ToString() == "Input" || prmdir.ToString() == "Output" || prmdir.ToString() == "InputOutput" || prmdir.ToString() == "ReturnValue")
                                    {
                                        parameter = new OracleParameter(str, orclDb, oDbVal.ToString(), prmdir);
                                    }
                                    else
                                    {
                                        parameter = new OracleParameter(str, orclDb, oDbVal, ParameterDirection.Input);
                                    }
                                }
                            }
                            else
                            {
                                string oDbVal = oDbType[2].ToString();
                                parameter = new OracleParameter(str, orclDb, oDbVal, ParameterDirection.Input);
                            }
                        }
                    }
                }

                orclParamList[Convert.ToInt32(oDbType[0])] = parameter;
                lCount++;
            }

            return orclParamList;
        }

        private string MapQueryParameter(string query, Hashtable ht)
        {
            int lCount = 0;
            foreach (object obj in ht.Keys)
            {
                string str = Convert.ToString(obj);
                string val = Convert.ToString(ht[obj]);
                string txtQuery = lCount == 0 ? " WHERE " + str + " = " + val : " AND " + str + " = " + val;
                query += txtQuery;
            }
            return query;
        }

        private string[] oDbTypes = new string[] { "BFile", "BinaryDouble", "BinaryFloat", "Blob", "Boolean", "Byte", "Char", "Clob", "Date", "Decimal", "Double", "Int16", "Int32", "Int64", "IntervalDS", "IntervalYM", "Long", "LongRaw", "NChar", "NClob", "NVarchar2", "Raw", "RefCursor", "Single", "TimeStamp", "TimeStampLTZ", "TimeStampTZ", "Varchar2", "XmlType" };
    }
}
