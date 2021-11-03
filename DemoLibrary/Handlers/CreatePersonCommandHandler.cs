using DemoLibrary.Commands;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, bool>
    {
        private readonly IDataAccess data;

        public CreatePersonCommandHandler(IDataAccess data)
        {
            this.data = data;
        }

        public Task<bool> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.InsertPerson(request.FirstName, request.LastName) != null);
        }
    }
}
