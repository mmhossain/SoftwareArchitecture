using DataAccessLayer.Models;
using DataAccessLayer.Queries;
using DataAccessLayer.Repositories;
using MediatR;

namespace DataAccessLayer.Handlers;

public class GetEmployeesHandler : IRequestHandler<GetEmployeesQuery, IList<Employee>>
{
    private readonly IEmployeeRepository _employeeRepo;

    public GetEmployeesHandler(IEmployeeRepository employeeRepo)
    {
        _employeeRepo = employeeRepo;
    }

    public async Task<IList<Employee>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_employeeRepo.GetEmployees());
    }
}
