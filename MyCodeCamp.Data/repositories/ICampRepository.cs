using System.Threading.Tasks;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data.repositories
{
    public interface ICampRepository : IBaseRepository<Camp>
    {
        Task<Camp> GetById(int id, bool includeSpeakers);
    }
}