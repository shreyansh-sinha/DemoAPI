using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Query
{
    public record GetPersonQuery() : IRequest<List<PersonModel>>
    {
    }
}
