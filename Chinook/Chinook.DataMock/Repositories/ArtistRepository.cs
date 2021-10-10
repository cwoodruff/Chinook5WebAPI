using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Artist>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Artist> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Artist> Add(Artist entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Artist entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}