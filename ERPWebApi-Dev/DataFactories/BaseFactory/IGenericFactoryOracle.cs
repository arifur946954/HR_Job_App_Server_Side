using Oracle.ManagedDataAccess.Client;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    public interface IGenericFactoryOracle<T> where T : class
    {
      
        Task<int> ExecuteCommand(string spQuery, Hashtable ht, string conString);
        Task<int> ExecuteCommand(string spQuery, OracleCommand cmd, string conString);
        Task<int> ExecuteCommand(string spQuery, OracleParameter[] oparameter, string conString);
        Task<string> ExecuteCommandString(string spQuery, string conString);
        Task<string> ExecuteCommandString(string spQuery, Hashtable ht, string conString);
        Task<string> ExecuteCommandString(string spQuery, OracleCommand ocmd, string conString);
        Task<DataTable> ExecuteCommandDataTable(string spQuery, OracleCommand ocmd, string conString);
        Task<string> ExecuteNonQueryOutString(string spQuery, OracleCommand ocmd, string OutParameter, string conString);
        Task<string> ExecuteNonQueryOutString(string spQuery, Hashtable ht, string OutParameter, string conString);
        Task<string> ExecuteNonQueryOutClob(string spQuery, OracleCommand ocmd, string OutParameter, string conString);
        Task<string> ExecuteNonQueryOutClob(string spQuery, Hashtable ht, string OutParameter, string conString);
        Task ExecuteNonQueryCommand(string spQuery, OracleCommand ocmd, string conString);
        Task<string> ExecuteCommandString(string spQuery, OracleParameter[] param, string conString);        
        Task<List<T>> ExecuteCommandList(string spQuery, Hashtable ht, string conString);
        Task<List<T>> ExecuteCommandList(string spQuery, OracleCommand cmd, string conString);
        Task<List<T>> ExecuteCommandList(string spQuery, OracleParameter[] oparameter, string conString);
        Task<T> ExecuteCommandSingle(string spQuery, Hashtable ht, string conString);
        Task<T> ExecuteCommandSingle(string spQuery, OracleCommand cmd, string conString);
        Task<T> ExecuteCommandSingle(string spQuery, OracleParameter[] oparameter, string conString);
        Task<T> ExecuteQuerySingle(string spQuery, Hashtable ht, string conString);
        Task<T> ExecuteQuerySingle(string spQuery, OracleCommand cmd, string conString);
        Task<T> ExecuteQuerySingle(string spQuery, OracleParameter[] oparameter, string conString);
        Task<List<T>> ExecuteQuery(string spQuery, Hashtable ht, string conString);
        Task<List<T>> ExecuteQuery(string spQuery, OracleCommand cmd, string conString);
        Task<List<T>> ExecuteQuery(string spQuery, OracleParameter[] oparameter, string conString);
        Task<string> GetByQueryString(string Query, Hashtable ht, string conString);
        Task<string> GetByQueryJsonString(string Query, Hashtable ht, string conString);
        Task<List<T>> GetListByQueryString(string Query, Hashtable ht, string conString);
        Task<string> GetByQuerySingleString(string spQuery, string conString);
        Task<string> GetByQueryJsonString(string spQuery, string conString);
        Task<string> SetByQueryString(string spQuery, Hashtable ht, string conString);
        Task<string> SetByQueryString(string spQuery, string conString);
        //List<T> DataReaderMapToList<Tentity>(IDataReader reader);
    }
}
