using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Siemensblazorserverapp.Data;
using Siemensblazorserverapp.Dtos;
using Siemensblazorserverapp.Models;
using System.Diagnostics;

namespace Siemensblazorserverapp.Services
{
    public class PersonService : IPersonService
    {
        private readonly DataContext _condatabase;
        private readonly IMapper _mapper;
       // public Person per = new Person();
        public PersonService(DataContext condatabase,IMapper mapper)
        {
            _condatabase = condatabase;
            this._mapper = mapper;
        }

        public void AddPerson(Person person)
        {
          // Person perso =_mapper.Map<Person>(person);
            //Person perso= new Person { Name = person.Name,Address=person.Address };
            if (person != null)
            {
                _condatabase.tablepersons.Add(person);
                _condatabase.SaveChanges();
            }
            else
            {
                Debug.WriteLine("Its null");
            }
            
        }

        public List<Persondto> GetAllPersons()
        {
            //List<Person> persons;
            //Person pr1 = new Person { Id = 1, Name = "hamid", Address = "Newyork" };
            //Person pr2 = new Person { Id = 2, Name = "Tyler", Address = "Los Angeles" };
            //Person pr3 = new Person { Id = 3, Name = "Indu", Address = "Bangalore" };
            //persons = new List<Person> { pr1, pr2, pr3 };
            var persons = _condatabase.tablepersons.ToList();
            List<Persondto> per=_mapper.Map<List<Persondto>>(persons);
           
            return per;
           
        }

    }
}
