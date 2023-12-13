using System.ComponentModel.DataAnnotations;

namespace Siemensblazorserverapp.Dtos
{
    public class Persondto
    {
        public int Id { get; set; }
       
        [EmailAddress]
        [MaxLength(20)]
        [Required(ErrorMessage ="Enter name")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
