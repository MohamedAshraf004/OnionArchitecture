using Domainlayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicelayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public void CreateEmployee(Employee employee)
        {
            repository.Insert(employee);
            repository.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var emp = repository.Get(id);
            repository.Remove(emp);
            repository.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            return repository.Get(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repository.GetAll();
        }

        public void UpdateEmployee(Employee employee)
        {
            repository.Update(employee);
            repository.SaveChanges();
        }
    }
}
