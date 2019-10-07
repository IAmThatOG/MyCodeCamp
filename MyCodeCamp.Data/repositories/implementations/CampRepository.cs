using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data.repositories.implementations
{
    public class CampRepository : ICampRepository
    {
        private CampContext _campContext;
        public CampRepository(CampContext campContext)
        {
            _campContext = campContext;
        }
        public async Task<ICollection<Camp>> GetAllAsync()
            => await _campContext.Camps.Include(c => c.Location).ToListAsync();

        public async Task<Camp> GetById(int id, bool includeSpeakers)
        {
            if (includeSpeakers)
            {
                return await _campContext.Camps.Include(c => c.Location)
                                               .Include(c => c.Speakers)
                                               .SingleOrDefaultAsync(c => c.Id == id);
            }
            return await _campContext.Camps.Include(c => c.Location)
                                           .SingleOrDefaultAsync(c => c.Id == id);
        }

        public Task<Camp> GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}