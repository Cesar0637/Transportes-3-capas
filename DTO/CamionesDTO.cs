using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CamionesDTO
    {
        //DTO DATA Transfer Object
        [Key]
        public int Id_Camion { get; set; }
        [Required]
        [Display(Name = "Matricula")]
        public string matricula { get; set; }
        [Required]
        [Display(Name = "Capacidad")]
        public int capacidad { get; set; }
        [Required]
        [Display(Name = "Tipo de Camion")]
        public string tipo_camion { get; set; }
        
        [DataType(DataType.ImageUrl)]
        public string urlfoto { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public string marca { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public string modelo { get; set; }
        [Required]
        [Display(Name = "Kilometraje")]
        public double kilometraje { get; set; }
        [Required]
        [Display(Name = "Disponibilidad")]
        public bool disponibilidad { get; set; }
    }
}
