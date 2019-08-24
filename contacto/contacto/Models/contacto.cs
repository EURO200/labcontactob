

namespace contacto.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum Typecontact
    {
        telephone,
        email,
        facebook
    }
    public class contacto
    {
        [Key]
        public int ContactID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Typecontact Type { get; set; }
        [Required]
        [Display(Description ="Contact")]
        public string ContactValue { get; set; }
    }
}