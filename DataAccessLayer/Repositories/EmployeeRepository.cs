using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private IList<Employee> _employeeList;

    public EmployeeRepository()
    {
        _employeeList = [
            new Employee { Id = 1, FirstName = "John", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "David", LastName = "Ash" },
            new Employee { Id = 3, FirstName = "Jack", LastName = "Crawley" },
            new Employee { Id = 4, FirstName = "Steven", LastName = "Smith" },
            new Employee { Id = 5, FirstName = "Micheal", LastName = "Clark" }
        ];
    }

    public IList<Employee> GetEmployees()
    {
        return _employeeList;
    }
}
