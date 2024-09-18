using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories;

public interface IEmployeeRepository
{
    IList<Employee> GetEmployees();
}