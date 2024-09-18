using DataAccessLayer.Models;
using DataAccessLayer.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetEmployees")]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _mediator.Send(new GetEmployeesQuery());
        }
    }
}
