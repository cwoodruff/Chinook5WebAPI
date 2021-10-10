using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Album>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Album> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Album> Add(Album entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Album entity)
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

        public Task<List<Album>> GetByArtistId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}