using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL.Interfaces
{

    public interface IAutorRepository
    {
        Task<List<Autor>> GetAutoresAsync();
        Task<Autor> GetAutorByIdAsync(int id);
        Task<int> InsertAutorAsync(Autor autor);
        Task<Autor> UpdateAutorAsync(Autor autor);
        Task<bool> DeleteAutorAsync(int id);
    }
}
