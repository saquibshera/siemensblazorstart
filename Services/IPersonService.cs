using Siemensblazorserverapp.Models;

namespace Siemensblazorserverapp.Services
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();
    }
}
