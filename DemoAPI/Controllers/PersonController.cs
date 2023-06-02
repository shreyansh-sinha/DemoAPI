using DemoLibrary.Command;
using DemoLibrary.Models;
using DemoLibrary.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await this.mediator.Send(new GetPersonQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await this.mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel person)
        {
            return await this.mediator.Send(new AddPersonCommand(person.FirstName, person.LastName));
        }
    }
}
