using DemoLibrary.Models;

namespace DemoLibrary
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();
        public DemoDataAccess()
        {
            people.Add(new PersonModel() { FirstName = "Shreyansh", LastName = "Sinha", Id = 1 });
            people.Add(new PersonModel() { FirstName = "Arijit", LastName = "Singh", Id = 2 });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel GetPersonById(int id)
        {
            var person = people.FirstOrDefault(x => x.Id == id);
            return person;
        }

        public PersonModel AddPerson(string firstName, string lastName)
        {
            PersonModel personModel = new PersonModel();
            personModel.FirstName = firstName;
            personModel.LastName = lastName;
            personModel.Id = people.Max(p => p.Id) + 1;

            people.Add(personModel);
            return personModel;
        }
    }
}
