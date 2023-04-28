using AshproStringExtension;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;

namespace Ashpro.ORM
{
    public class ORM
    {
        #region Public Method

        #region Async Method
        public static async Task<bool> BulkCopyAsync(string sTable, DataTable dt, bool isIdentity = true, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            if(sType.ToUpper()=="MSSQL")
            {
                return await MSSQL.BulkCopyAsync(sTable, dt, isIdentity, sCon);
            }
            else
            {
                return false;
            }
        }
        public static async Task<dynamic> GetSingleDataAsync(string Query, string sCon = null,string sType=null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetSingleDataAsync(Query, sCon);
                case "MYSQL":
                    return await MySQL.GetSingleDataAsync(Query, sCon);
                case "SQLITE":
                   return await SQLite.GetSingleDataAsync(Query, sCon);
                default:
                    return null;
            }
        }
        public static async Task<DataTable> GetDataTableAsync(string Query, string sCon = null,string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataTableAsync(Query, sCon);
                case "MYSQL":
                    return await MySQL.GetDataTableAsync(Query, sCon);
                case "SQLITE":
                    return await SQLite.GetDataTableAsync(Query, sCon);
                default:
                    return null;
            }
        }
        public static async Task<T> GetAsync<T>(string Query, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetAsync<T>(Query, sCon);
                case "MYSQL":
                    return await MySQL.GetAsync<T>(Query, sCon);
                case "SQLITE":
                    return await SQLite.GetAsync<T>(Query, sCon);
                default:
                    return default;
            }
        }
        public static async Task<List<T>> GetListAsync<T>(string commandText, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetListAsync<T>(commandText, sCon);
                case "MYSQL":
                    return await MySQL.GetListAsync<T>(commandText, sCon);
                case "SQLITE":
                    return await SQLite.GetListAsync<T>(commandText, sCon);
                default:
                    return default;
            }
        }
        public static async Task<List<string>> GetStringListAsync(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetStringListAsync(Query, sCon);
                case "MYSQL":
                    return await MySQL.GetStringListAsync(Query, sCon);
                case "SQLITE":
                    return await SQLite.GetStringListAsync(Query, sCon);
                default:
                    return null;
            }
        }
        public static async Task<bool> DatabaseMethodAsync(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.DatabaseMethodAsync(Query, sCon);
                case "MYSQL":
                    return await MySQL.DatabaseMethodAsync(Query, sCon);
                case "SQLITE":
                    return await SQLite.DatabaseMethodAsync(Query, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> InsertAsync(List<object> datas, string table, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.InsertAsync(datas, table, sCon);
                case "MYSQL":
                    return await MySQL.InsertAsync(datas, table, sCon);
                case "SQLITE":
                    return await SQLite.InsertAsync(datas, table, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> InsertAsync(object data, string table, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.InsertAsync(data, table, sCon);
                case "MYSQL":
                    return await MySQL.InsertAsync(data, table, sCon);
                case "SQLITE":
                    return await SQLite.InsertAsync(data, table, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> UpdateAsync(object data, string table, string column, int iValue, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.UpdateAsync(data, table, column, iValue, sCon);
                case "MYSQL":
                    return await MySQL.UpdateAsync(data, table, column, iValue, sCon);
                case "SQLITE":
                    return await SQLite.UpdateAsync(data, table, column, iValue, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> UpdateAsync(List<object> datas, string table, string column, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.UpdateAsync(datas, table, column, sCon);
                case "MYSQL":
                    return await MySQL.UpdateAsync(datas, table, column, sCon);
                case "SQLITE":
                    return await SQLite.UpdateAsync(datas, table, column, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> DeleteAsync(string table, string column, int iValue, string sCon = null,string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.DeleteAsync( table, column, iValue, sCon);
                case "MYSQL":
                    return await MySQL.DeleteAsync(table, column, iValue, sCon);
                case "SQLITE":
                    return await SQLite.DeleteAsync(table, column, iValue, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> DeleteAsync(string Query, string sCon = null) => await DatabaseMethodAsync(Query, sCon);
        public static async Task<bool> UpdateAsync(DataTable datas, DataTable oldDatas, string table, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.UpdateAsync(datas, oldDatas, table, sCon);
                case "MYSQL":
                    return await MySQL.UpdateAsync(datas, oldDatas, table, sCon);
                case "SQLITE":
                    return await SQLite.UpdateAsync(datas, oldDatas, table, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> UpdateAsync(List<object> newDatas, List<object> oldDatas, string sTable, string sColumn, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.UpdateAsync(newDatas, oldDatas, sTable, sCon);
                case "MYSQL":
                    return await MySQL.UpdateAsync(newDatas, oldDatas, sTable, sCon);
                case "SQLITE":
                    return await SQLite.UpdateAsync(newDatas, oldDatas, sTable, sCon);
                default:
                    return false;
            }
        }
        #endregion

        #region Normal Method
        public static bool BulkCopy(string sTable, DataTable dt, bool isIdentity = true, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return  MSSQL.BulkCopy(sTable, dt, isIdentity, sCon);
                default:
                    return false;
            }
        }
        public static dynamic GetSingleData(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetSingleData(Query,  sCon);
                case "MYSQL":
                    return MySQL.GetSingleData(Query, sCon);
                case "SQLITE":
                    return SQLite.GetSingleData(Query, sCon);
                default:
                    return null;
            }
        }
        public static T GetObjectDetails<T>(string Query, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetObjectDetails<T>(Query, sCon);
                case "MYSQL":
                    return MySQL.GetObjectDetails<T>(Query, sCon);
                case "SQLITE":
                    return SQLite.GetObjectDetails<T>(Query, sCon);
                default:
                    return default;
            }
        }
        public static DataTable GetDataTable(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetDataTable(Query, sCon);
                case "MYSQL":
                    return MySQL.GetDataTable(Query, sCon);
                case "SQLITE":
                    return SQLite.GetDataTable(Query, sCon);
                default:
                    return null;
            }
        }
        public static dynamic ValueFindMethod(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.ValueFindMethod(Query, sCon);
                case "MYSQL":
                    return MySQL.ValueFindMethod(Query, sCon);
                case "SQLITE":
                    return SQLite.ValueFindMethod(Query, sCon);
                default:
                    return null;
            }
        }
        public static List<T> GetList<T>(string commandText, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetList<T>(commandText, sCon);
                case "MYSQL":
                    return MySQL.GetList<T>(commandText, sCon);
                case "SQLITE":
                    return SQLite.GetList<T>(commandText, sCon);
                default:
                    return default;
            }
        }
        public static List<string> GetStringListMethod(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetStringListMethod(Query, sCon);
                case "MYSQL":
                    return MySQL.GetStringListMethod(Query, sCon);
                case "SQLITE":
                    return SQLite.GetStringListMethod(Query, sCon);
                default:
                    return null;
            }
        }
        public static bool DatabaseMethod(string Query, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.DatabaseMethod(Query, sCon);
                case "MYSQL":
                    return MySQL.DatabaseMethod(Query, sCon);
                case "SQLITE":
                    return SQLite.DatabaseMethod(Query, sCon);
                default:
                    return false;
            }
        }
        public static bool InsertToDatabase(List<object> datas, string table, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.InsertToDatabase(datas, table, sCon);
                case "MYSQL":
                    return MySQL.InsertToDatabase(datas, table, sCon);
                case "SQLITE":
                    return SQLite.InsertToDatabase(datas, table, sCon);
                default:
                    return false;
            }
        }
        public static bool InsertToDatabaseObj(object data, string table, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.InsertToDatabaseObj(data, table, sCon);
                case "MYSQL":
                    return MySQL.InsertToDatabaseObj(data, table, sCon);
                case "SQLITE":
                    return SQLite.InsertToDatabaseObj(data, table, sCon);
                default:
                    return false;
            }
        }
        public static bool UpdateToDatabase(List<object> datas, string table, string column, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.UpdateToDatabase(datas, table,column, sCon);
                case "MYSQL":
                    return MySQL.UpdateToDatabase(datas, table, column, sCon);
                case "SQLITE":
                    return SQLite.UpdateToDatabase(datas, table, column, sCon);
                default:
                    return false;
            }
        }
        public static bool UpdateToDatabaseObj(object data, string table, string column, int iValue, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.UpdateToDatabaseObj(data, table, column,iValue, sCon);
                case "MYSQL":
                    return MySQL.UpdateToDatabaseObj(data, table,column,iValue, sCon);
                case "SQLITE":
                    return SQLite.UpdateToDatabaseObj(data, table, column, iValue, sCon);
                default:
                    return false;
            }
        }
        public static bool DeleteFromDatabase(string table, string column, int iValue, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.DeleteFromDatabase(table, column, iValue, sCon);
                case "MYSQL":
                    return MySQL.DeleteFromDatabase(table,column,iValue, sCon);
                case "SQLITE":
                    return SQLite.DeleteFromDatabase(table, column, iValue, sCon);
                default:
                    return false;
            }
        }
        public static bool UpdateDatabase(DataTable datas, DataTable oldDatas, string table, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.UpdateDatabase(datas, oldDatas, table, sCon);
                case "MYSQL":
                    return MySQL.UpdateDatabase(datas, oldDatas, table, sCon);
                case "SQLITE":
                    return SQLite.UpdateDatabase(datas, oldDatas, table, sCon);
                default:
                    return false;
            }
        }
        public static bool UpdateDatabase(List<object> newDatas, List<object> oldDatas, string sTable, string sColumn, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.UpdateDatabase(newDatas, oldDatas, sTable, sCon);
                case "MYSQL":
                    return MySQL.UpdateDatabase(newDatas, oldDatas, sTable, sCon);
                case "SQLITE":
                    return SQLite.UpdateDatabase(newDatas, oldDatas, sTable, sCon);
                default:
                    return false;
            }
        }
        #endregion

        #endregion

        #region Public Method BySP

        #region Normal
        public static bool InsertMethod_SP(List<object> entities, string sStoredProceedure, string sCon = null, string sType = null)
        {
            bool result = false;
            try
            {
                foreach (object data in entities)
                {
                    InsertMethod_SP(data, sStoredProceedure, sCon,sType);
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public static bool InsertMethod_SP(object entity, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.InsertMethod_SP(entity, sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.InsertMethod_SP(entity, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static DBOutput InsertMethod_SP(object entity, DataSet ds, string sStoredProceedure, object Secondentity = null, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.InsertMethod_SP(entity,ds, sStoredProceedure, Secondentity, sCon);
                case "MYSQL":
                    return MySQL.InsertMethod_SP(entity, sStoredProceedure, Secondentity, sCon);
                default:
                    return null;
            }
        }
        public static bool UpdateMethod_SP(object entity, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.UpdateMethod_SP(entity, sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.UpdateMethod_SP(entity, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static bool UpdateMethod_SP(List<object> entities, string sStoredProceedure, string sCon = null, string sType = null)
        {
            try
            {
                foreach (object data in entities)
                {
                    UpdateMethod_SP(data, sStoredProceedure, sCon,sType);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool UpdateMethod_SP(List<object> newDatas, List<object> oldDatas, string sTable, string sColumn, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.UpdateMethod_SP(newDatas, oldDatas, sTable, sColumn, sCon);
                case "MYSQL":
                    return MySQL.UpdateMethod_SP(newDatas, oldDatas, sTable, sColumn, sCon);
                default:
                    return false;
            }
        }
        public static bool DeleteMethod_SP(object entity, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.DeleteMethod_SP(entity, sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.DeleteMethod_SP(entity, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static DataTable GetDataTable_SP(string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetDataTable_SP( sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.GetDataTable_SP( sStoredProceedure, sCon);
                default:
                    return null;
            }
        }
        public static DataTable GetDataTableWithIdParameter_SP(string sStoredProceedure, string Value, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetDataTableWithIdParameter_SP(sStoredProceedure, Value, sCon);
                case "MYSQL":
                    return MySQL.GetDataTableWithIdParameter_SP(sStoredProceedure, Value, sCon);
                default:
                    return null;
            }
        }
        public static DataTable GetDataTableWithIdParameter_SP(string sStoredProceedure, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetDataTableWithIdParameter_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return MySQL.GetDataTableWithIdParameter_SP(sStoredProceedure, entity, sCon);
                default:
                    return null;
            }
        }
        public static List<T> GetList_SP<T>(string sStoredProceedure, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetList_SP<T>(sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.GetList_SP<T>(sStoredProceedure, sCon);
                default:
                    return default;
            }
        }
        public static List<string> GetList_SP(string commandText, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetList_SP(commandText, entity, sCon);
                case "MYSQL":
                    return MySQL.GetList_SP(commandText, entity, sCon);
                default:
                    return null;
            }
        }
        public static List<T> GetList_SP<T>(string sStoredProceedure, string Value, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetList_SP<T>(sStoredProceedure, Value, sCon);
                case "MYSQL":
                    return MySQL.GetList_SP<T>(sStoredProceedure, Value, sCon);
                default:
                    return default;
            }
        }
        public static List<T> GetList_SP<T>(string commandText, object entity, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetList_SP<T>(commandText, entity, sCon);
                case "MYSQL":
                    return MySQL.GetList_SP<T>(commandText, entity, sCon);
                default:
                    return default;
            }
        }
        public static T GetObject_SP<T>(string sStoredProceedure, string Value, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetObject_SP<T>(sStoredProceedure, Value, sCon);
                case "MYSQL":
                    return MySQL.GetObject_SP<T>(sStoredProceedure, Value, sCon);
                default:
                    return default;
            }
        }
        public static T GetObjectWithparameter_SP<T>(string sStoredProceedure, object entity, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetObjectWithparameter_SP<T>(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return MySQL.GetObjectWithparameter_SP<T>(sStoredProceedure, entity, sCon);
                default:
                    return default;
            }
        }
        public static T GetObject_SP<T>(string sStoredProceedure, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetObject_SP<T>(sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.GetObject_SP<T>(sStoredProceedure, sCon);
                default:
                    return default;
            }
        }
        public static dynamic GetData_SP(string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetData_SP(sStoredProceedure, sCon);
                case "MYSQL":
                    return MySQL.GetData_SP(sStoredProceedure, sCon);
                default:
                    return null;
            }
        }
        public static dynamic GetDataWithParameter_SP(string sStoredProceedure, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetDataWithParameter_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return MySQL.GetDataWithParameter_SP(sStoredProceedure, entity, sCon);
                default:
                    return null;
            }
        }
        public static bool DatabaseExecution_SP(string sStoredProceedure, object entity = null, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.DatabaseExecution_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return MySQL.DatabaseExecution_SP(sStoredProceedure, entity, sCon);
                default:
                    return false;
            }
        }
        public static DataSet GetDataSet_SP(string sStoredProceedure, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return MSSQL.GetDataSet_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return MySQL.GetDataSet_SP(sStoredProceedure, entity, sCon);
                default:
                    return null;
            }
        }
        #endregion

        #region Async
        public static async Task<bool> InsertAsync_SP(List<object> entities, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.InsertAsync_SP(entities, sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.InsertAsync_SP(entities, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> InsertAsync_SP(object entity, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.InsertAsync_SP(entity, sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.InsertAsync_SP(entity, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static async Task<DBOutput> InsertAsync_SP(object entity, DataSet ds, string sStoredProceedure, object Secondentity = null, bool isSimple = false, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.InsertAsync_SP(entity,ds, sStoredProceedure, Secondentity, isSimple, sCon);
                case "MYSQL":
                    return await MySQL.InsertAsync_SP(entity, sStoredProceedure, Secondentity,isSimple, sCon);
                default:
                    return null;
            }
        }
        public static async Task<bool> UpdateAsync_SP(object entity, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.UpdateAsync_SP(entity, sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.UpdateAsync_SP(entity, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> UpdateAsync_SP(List<object> entities, string sStoredProceedure, string sCon = null, string sType = null)
        {
            try
            {
                foreach (object data in entities)
                {
                    await UpdateAsync_SP(data, sStoredProceedure, sCon,sType);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<bool> UpdateAsync_SP(List<object> newDatas, List<object> oldDatas, string sTable, string sColumn, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.UpdateAsync_SP(newDatas, oldDatas, sTable, sColumn,sCon);
                case "MYSQL":
                    return await MySQL.UpdateAsync_SP(newDatas, oldDatas, sTable, sColumn,sCon);
                default:
                    return false;
            }
        }
        public static async Task<bool> DeleteAsync_SP(object entity, string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.DeleteAsync_SP(entity, sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.DeleteAsync_SP(entity, sStoredProceedure, sCon);
                default:
                    return false;
            }
        }
        public static async Task<DataTable> GetDataTableAsync_SP(string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataTableAsync_SP(sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.GetDataTableAsync_SP(sStoredProceedure, sCon);
                default:
                    return null;
            }
        }
        public static async Task<DataTable> GetDataTableWithIdParameterAsync_SP(string sStoredProceedure, string Value, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataTableWithIdParameterAsync_SP(sStoredProceedure, Value, sCon);
                case "MYSQL":
                    return await MySQL.GetDataTableWithIdParameterAsync_SP(sStoredProceedure, Value, sCon);
                default:
                    return null;
            }
        }
        public static async Task<DataTable> GetDataTableWithIdParameterAsync_SP(string sStoredProceedure, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataTableWithIdParameterAsync_SP(sStoredProceedure, entity,  sCon);
                case "MYSQL":
                    return await MySQL.GetDataTableWithIdParameterAsync_SP(sStoredProceedure, entity, sCon);
                default:
                    return null;
            }
        }
        public static async Task<List<T>> GetListAsync_SP<T>(string commandText, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetListAsync_SP<T>(commandText,  sCon);
                case "MYSQL":
                    return await MySQL.GetListAsync_SP<T>(commandText,  sCon);
                default:
                    return default;
            }
        }
        public static async Task<List<string>> GetStringListAsync_SP(string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetStringListAsync_SP(sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.GetStringListAsync_SP(sStoredProceedure, sCon);
                default:
                    return null;
            }
        }
        public static async Task<List<T>> GetListAsync_SP<T>(string sStoredProceedure, string Value, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetListAsync_SP<T>(sStoredProceedure, Value, sCon);
                case "MYSQL":
                    return await MySQL.GetListAsync_SP<T>(sStoredProceedure, Value, sCon);
                default:
                    return default;
            }
        }
        public static async Task<List<T>> GetListAsync_SP<T>(string commandText, object entity, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetListAsync_SP<T>(commandText, entity,sCon);
                case "MYSQL":
                    return await MySQL.GetListAsync_SP<T>(commandText, entity, sCon);
                default:
                    return default;
            }
        }
        public static async Task<T> GetAsync_SP<T>(string sStoredProceedure, string Value, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetAsync_SP<T>(sStoredProceedure, Value,sCon);
                case "MYSQL":
                    return await MySQL.GetAsync_SP<T>(sStoredProceedure, Value, sCon);
                default:
                    return default;
            }
        }
        public static async Task<T> GetAsyncWithparameter_SP<T>(string sStoredProceedure, object entity, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetAsyncWithparameter_SP<T>(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return await MySQL.GetAsyncWithparameter_SP<T>(sStoredProceedure, entity, sCon);
                default:
                    return default;
            }
        }
        public static async Task<T> GetAsync_SP<T>(string sStoredProceedure, string sCon = null, string sType = null) where T : new()
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetAsync_SP<T>(sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.GetAsync_SP<T>(sStoredProceedure, sCon);
                default:
                    return default;
            }
        }
        public static async Task<dynamic> GetDataAsync_SP(string sStoredProceedure, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataAsync_SP(sStoredProceedure, sCon);
                case "MYSQL":
                    return await MySQL.GetDataAsync_SP(sStoredProceedure, sCon);
                default:
                    return null;
            }
        }
        public static async Task<dynamic> GetDataWithParameterAsync_SP(string sStoredProceedure, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataWithParameterAsync_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return await MySQL.GetDataWithParameterAsync_SP(sStoredProceedure, entity, sCon);
                default:
                    return null;
            }
        }
        public static async Task<bool> DatabaseExecutionAsync_SP(string sStoredProceedure, Object entity = null, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.DatabaseExecutionAsync_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return await MySQL.DatabaseExecutionAsync_SP(sStoredProceedure, entity, sCon);
                default:
                    return false;
            }
        }
        public static async Task<DataSet> GetDataSetAsync_SP(string sStoredProceedure, object entity, string sCon = null, string sType = null)
        {
            sType = sType ?? DBType.DatabaseType;
            switch (sType.ToUpper())
            {
                case "MSSQL":
                    return await MSSQL.GetDataSetAsync_SP(sStoredProceedure, entity, sCon);
                case "MYSQL":
                    return await MySQL.GetDataSetAsync_SP(sStoredProceedure, entity, sCon);
                default:
                    return null;
            }
        }
        #endregion

        #endregion

    }
}
