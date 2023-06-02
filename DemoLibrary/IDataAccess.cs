using DemoLibrary.Models;

namespace DemoLibrary
{
    public interface IDataAccess
    {
        PersonModel AddPerson(string firstName, string lastName);
        PersonModel GetPersonById(int id);
        List<PersonModel> GetPeople();
    }
}