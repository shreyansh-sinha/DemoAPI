using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Command
{
    public record AddPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
}
