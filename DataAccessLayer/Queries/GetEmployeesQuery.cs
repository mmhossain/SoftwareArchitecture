using DataAccessLayer.Models;
using MediatR;

namespace DataAccessLayer.Queries;

public class GetEmployeesQuery : IRequest<IList<Employee>>
{
}
