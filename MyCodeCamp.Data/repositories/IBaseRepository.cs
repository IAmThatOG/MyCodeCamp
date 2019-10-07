using System.Collections.Generic;
using System.Threading.Tasks;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data.repositories
{
    public interface IBaseRepository<T> where T: BaseEntity 
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetById(int id);
    }
}