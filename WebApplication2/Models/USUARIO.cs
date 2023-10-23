using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class USUARIO
    {
        [Key]
        public int IdUsuario { get; set; }
        public text Nombre { get; set; }
        public text Genero { get; set; }
        public int Edad { get; set; }
    }
}
