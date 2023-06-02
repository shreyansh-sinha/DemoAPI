using DemoLibrary.Command;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.CommandHandler
{
    public class AddPersonCommandHandler : IRequestHandler<AddPersonCommand, PersonModel>
    {
        private readonly IDataAccess dataAccess;

        public AddPersonCommandHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<PersonModel> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.AddPerson(request.FirstName, request.LastName));
        }
    }
}
