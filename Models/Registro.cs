using System.ComponentModel.DataAnnotations;
namespace PetLover.Models
{
    public class Registro
    {
        [Required]
        [Display(Name="Nombre")]
        public string nombre { get; set; }

        [Required]        
        [Display(Name="Apellido")]
        public string apellido { get; set; }
        
        [Required]
        [Display(Name="Email")]
        public string email { get; set; }
        [Required]
        [Display(Name="Contraseña nueva")]
        public string contraseña { get; set; }

        [Required]
        [Display(Name="Fecha de nacimiento")]
        public string  fecha { get; set; }

        [Required]
        [Display(Name="Sexo")]
        public string  sexo { get; set; }
    }
}