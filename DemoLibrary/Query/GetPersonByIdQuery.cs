using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Query
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;
}
