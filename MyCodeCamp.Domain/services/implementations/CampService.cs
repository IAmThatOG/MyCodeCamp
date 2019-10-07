using System.Collections.Generic;
using System.Threading.Tasks;
using MyCodeCamp.Data.Entities;
using MyCodeCamp.Data.repositories;

namespace MyCodeCamp.Domain.services.implementations
{
    public class CampService : BaseImplementation<ICampRepository>, ICampService
    {
        public CampService(ICampRepository repo) : base(repo)
        {
        }

        public async Task<ICollection<Camp>> GetAll() => await base._repo.GetAllAsync();

        public async Task<Camp> GetById(int id, bool includeSpeakers) => await base._repo.GetById(id, includeSpeakers);

        public Task<Camp> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}