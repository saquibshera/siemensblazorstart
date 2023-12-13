using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Siemensblazorserverapp.Dtos;
using Siemensblazorserverapp.Models;
using Siemensblazorserverapp.Services;
using System.Diagnostics;

namespace Siemensblazorserverapp.Pages
{
    public class AddPersonBase:ComponentBase
    {
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public IMapper mapper { get; set; }
        [Inject]

        //public Person person { get; set; }= new Person();
        public IPersonService _service { get; set; }
        public Persondto personform { get; set; } = new Persondto();

        public void Handlevalidsubmit()
        {
          
                Debug.WriteLine(personform.Name);
                Debug.WriteLine(personform.Address);
                Person person = mapper.Map<Person>(personform);
                _service.AddPerson(person);
                Navigation.NavigateTo("/mycomponent");
            
        }
           

        
    }
}
