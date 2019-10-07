using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCodeCamp.Domain.services
{
    public interface IBaseService<T>
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(int id);
    }
}