using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Customer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> Add(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Customer entity)
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

        public Task<List<Customer>> GetBySupportRepId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}