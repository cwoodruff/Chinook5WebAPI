using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class TrackRepository : ITrackRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Track>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Track> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Track> Add(Track entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Track entity)
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

        public Task<List<Track>> GetByAlbumId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Track>> GetByGenreId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Track>> GetByMediaTypeId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Track>> GetByInvoiceId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Track>> GetByPlaylistId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Track>> GetByArtistId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}