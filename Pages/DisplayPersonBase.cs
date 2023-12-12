using Microsoft.AspNetCore.Components;
using Siemensblazorserverapp.Data;
using Siemensblazorserverapp.Models;

namespace Siemensblazorserverapp.Pages
{
    public class DisplayPersonBase:ComponentBase
    {
        [Inject]
        public DataContext _con { get;set; }

        [Parameter]
        public Person personitem { get; set; }

        [Parameter]
        public EventCallback<int> OnEmployeedeleted { get; set; }
        [Inject]
        public NavigationManager navigationmanager { get; set; }
        public void DeleteEmployee()
        {
            
            _con.tablepersons.Remove(personitem);
            _con.SaveChanges();
            OnEmployeedeleted.InvokeAsync(personitem.Id);
        }
    }
}
