using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Genre>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Genre> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Genre> Add(Genre entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Genre entity)
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