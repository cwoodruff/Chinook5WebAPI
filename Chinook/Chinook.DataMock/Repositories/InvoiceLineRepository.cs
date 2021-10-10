using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class InvoiceLineRepository : IInvoiceLineRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<InvoiceLine>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<InvoiceLine> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<InvoiceLine> Add(InvoiceLine entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(InvoiceLine entity)
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

        public Task<List<InvoiceLine>> GetByInvoiceId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<InvoiceLine>> GetByTrackId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}