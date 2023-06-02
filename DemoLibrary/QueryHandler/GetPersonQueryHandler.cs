using DemoLibrary.Models;
using DemoLibrary.Query;
using MediatR;

namespace DemoLibrary.QueryHandler
{
    public class GetPersonQueryHandler : IRequestHandler<GetPersonQuery, List<PersonModel>>
    {
        private readonly IDataAccess dataAccess;

        public GetPersonQueryHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<List<PersonModel>> Handle(GetPersonQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetPeople());
        }
    }
}
