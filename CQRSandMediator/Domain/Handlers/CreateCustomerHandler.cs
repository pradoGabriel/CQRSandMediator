using CQRSandMediator.Domain.Commands.Requests;
using CQRSandMediator.Domain.Commands.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSandMediator.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Aqui ficam as regras de negócios e validações
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Gabriel",
                Email = "test@email.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
