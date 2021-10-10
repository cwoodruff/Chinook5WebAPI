using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Playlist>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Playlist> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Playlist> Add(Playlist entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Playlist entity)
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

        public Task<List<Playlist>> GetByTrackId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}