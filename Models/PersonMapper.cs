using AutoMapper;
using Siemensblazorserverapp.Dtos;

namespace Siemensblazorserverapp.Models
{
    public class PersonMapper:Profile
    {
        public PersonMapper()
        {
            CreateMap<Person,Persondto>().ReverseMap();
        }
    }
}
