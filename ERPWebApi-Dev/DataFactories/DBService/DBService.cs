using DataFactories.BaseFactory;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.DBService
{
    public class DBService<T>
    {
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;

        public async Task<object> InsertQuery(string query)
        {
            string sql = string.Empty;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                sql = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
                await OraGeneric_vmCmnParameter.GetByQueryJsonString("COMMIT", StaticInfos.conStringOracle);
                if (sql == "[]")
                {
                    sql = "1";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return sql;
        }

        public async Task<object> UpdateQuery(string query)
        {
            string sql = string.Empty;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                sql = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
                await OraGeneric_vmCmnParameter.GetByQueryJsonString("COMMIT", StaticInfos.conStringOracle);
                if (sql == "[]")
                {
                    sql = "1";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return sql;
        }

        public async Task<object> DeletQuery(string query)
        {
            string sql = string.Empty;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                sql = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
                await OraGeneric_vmCmnParameter.GetByQueryJsonString("COMMIT", StaticInfos.conStringOracle);
                if (sql == "[]")
                {
                    sql = "1";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return sql;
        }

        public async Task<T> GetSingleRow(string query)
        {
            string sql = string.Empty; T data = default(T);
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                sql = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
                data = JsonConvert.DeserializeObject<List<T>>(sql).FirstOrDefault();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return data;
        }

        public async Task<List<T>> GetListRow(string query)
        {
            string sql = string.Empty; List<T> data = new List<T>();
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                sql = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
                data = JsonConvert.DeserializeObject<List<T>>(sql).ToList();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return data;
        }

        public async Task<string> GetQueryString(string query)
        {
            string sql = string.Empty;
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            try
            {
                sql = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return sql;
        }
    }
}
