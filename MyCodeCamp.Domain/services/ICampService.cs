using System.Collections.Generic;
using System.Threading.Tasks;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Domain.services
{
    public interface ICampService : IBaseService<Camp>
    {
        Task<Camp> GetById(int id, bool includeSpeakers);
    }
}