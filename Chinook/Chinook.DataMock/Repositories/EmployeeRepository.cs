using System.Collections.Generic;
using System.Threading.Tasks;
using Chinook.Domain.Entities;
using Chinook.Domain.Repositories;

namespace Chinook.DataMock.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<bool> EntityExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Employee>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> Add(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Employee entity)
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

        public Task<Employee> GetReportsTo(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Employee>> GetDirectReports(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}