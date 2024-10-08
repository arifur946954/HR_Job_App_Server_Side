using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DataFactories.BaseFactory
{
    public interface IGenericFactoryMySql<T> where T : class
    {
        Task<int> ExecuteCommand(string spQuery, Hashtable ht, string conString);
        Task<int> ExecuteCommandInt(string spQuery, string conString);
        Task<string> ExecuteCommandString(string spQuery, Hashtable ht, string conString);
        Task<List<T>> ExecuteCommandList(string spQuery, Hashtable ht, string conString);
        Task<T> ExecuteCommandSingle(string spQuery, Hashtable ht, string conString);
        Task<T> ExecuteQuerySingle(string spQuery, Hashtable ht, string conString);
        Task<List<T>> ExecuteQuery(string spQuery, Hashtable ht, string conString);
        Task<List<T>> ExecuteQueryString(string spQuery, Hashtable ht, string conString);
        Task<List<T>> ExecuteQueryList(string spQuery, string conString);
        Task<string> ExecuteCommandJsonString(string spQuery, string conString);
        Task<string> ExecuteCommandString(string spQuery, string conString);
        List<T> DataReaderMapToList<Tentity>(IDataReader reader);
    }
}
