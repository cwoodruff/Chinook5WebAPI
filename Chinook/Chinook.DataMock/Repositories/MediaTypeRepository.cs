using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class MediaTypeRepository : IMediaTypeRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MediaType>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<MediaType> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<MediaType> Add(MediaType entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(MediaType entity)
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