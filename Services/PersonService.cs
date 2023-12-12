using Siemensblazorserverapp.Models;

namespace Siemensblazorserverapp.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAllPersons()
        {
            List<Person> persons;
            Person pr1 = new Person { Id = 1, Name = "hamid", Address = "Newyork" };
            Person pr2 = new Person { Id = 2, Name = "Tyler", Address = "Los Angeles" };
            Person pr3 = new Person { Id = 3, Name = "Indu", Address = "Bangalore" };
            persons = new List<Person> { pr1, pr2, pr3 };
            return persons;
        }
    }
}
