using Siemensblazorserverapp.Dtos;
using Siemensblazorserverapp.Models;

namespace Siemensblazorserverapp.Services
{
    public interface IPersonService
    {
        List<Persondto> GetAllPersons();

        void AddPerson(Person person);
    }
}
