using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class EMAIL
    {
        [Key]
        public int IdEmail { get; set; }
        public string Email { get; set; }

        //public ICollection<Docente> Docente { get; set; }

        //public ICollection<Estudiante> Estudiante { get; set; }
    }


}
