using Domainlayer.Models;
using System.Collections.Generic;

namespace Servicelayer.Services
{
    public interface IEmployeeService
    {
        void DeleteEmployee(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
    }
}