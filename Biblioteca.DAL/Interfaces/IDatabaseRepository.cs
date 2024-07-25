using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL.Interfaces
{
    public interface IDatabaseRepository
    {
        Task<List<T>> GetDataByQueryAsync<T>(string query, DynamicParameters? parameters = null);
        Task<int> InsertAsync(string storeProcedure, DynamicParameters? parameters = null);
        Task<T> UpdateAsync<T>(string storeProcedure, DynamicParameters? parameters = null);
        Task<bool> DeleteAsync(string storeProcedure, DynamicParameters? parameters = null);
    }
}
