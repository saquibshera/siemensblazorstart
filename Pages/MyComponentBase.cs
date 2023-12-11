using Microsoft.AspNetCore.Components;
using Siemensblazorserverapp.Models;

namespace Siemensblazorserverapp.Pages
{
    public class MyComponentBase:ComponentBase
    {
        public List<Person> persons = null;
        public string Initialsnames = "Hello names";
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
            Person pr1 = new Person { Id = 1, Name = "hamid", Address = "Newyork" };
            Person pr2 = new Person { Id = 2, Name = "Tyler", Address = "Los Angeles" };
            Person pr3 = new Person { Id = 3, Name = "Indu", Address = "Bangalore" };
            persons = new List<Person> { pr1, pr2, pr3 };

        }
    }
}
