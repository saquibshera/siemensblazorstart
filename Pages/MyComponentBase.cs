using Microsoft.AspNetCore.Components;
using Siemensblazorserverapp.Data;
using Siemensblazorserverapp.Dtos;
using Siemensblazorserverapp.Models;
using Siemensblazorserverapp.Services;

namespace Siemensblazorserverapp.Pages
{
    public class MyComponentBase:ComponentBase
    {
        [Inject]
        public IPersonService personservice { get; set; }
        public string Myname { get; set; }  
        
       // public DataContext _context { get; set; }
        //dependency injection
        public List<Persondto> persons = null;
        public string Initialsnames = "Hello names";
        public string colour { get; set; } = "background-color:red";

        public string Description { get; set; } = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            Initialsnames = "Hello names there";
           
        }
        public string address = "Newyork";
        public string name = "saquib";
        public void getdata()
        {
            loaddata();
            name = "Stephen";
        }
        public void loaddata()
        {

            persons=personservice.GetAllPersons();
        }
        public async Task Employeedeleted()
        {

            persons = personservice.GetAllPersons();
        }
    }
}
