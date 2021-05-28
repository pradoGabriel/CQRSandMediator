using CQRSandMediator.Domain.Commands.Requests;
using CQRSandMediator.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSandMediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromBody]CreateCustomerRequest command)
        {
            return _mediator.Send(command);
        } 
    }
}
