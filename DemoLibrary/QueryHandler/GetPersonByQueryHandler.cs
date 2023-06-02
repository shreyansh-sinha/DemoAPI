using DemoLibrary.Models;
using DemoLibrary.Query;
using MediatR;

namespace DemoLibrary.QueryHandler
{
    public class GetPersonByQueryHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess dataAccess;

        public GetPersonByQueryHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetPersonById(request.Id));   
        }
    }
}
