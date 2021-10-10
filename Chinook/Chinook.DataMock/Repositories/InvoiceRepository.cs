using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Invoice>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Invoice> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Invoice> Add(Invoice entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Invoice entity)
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

        public Task<List<Invoice>> GetByCustomerId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Invoice>> GetByEmployeeId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}