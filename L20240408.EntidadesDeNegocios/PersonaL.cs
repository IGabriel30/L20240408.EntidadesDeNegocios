using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20240408.EntidadesDeNegocios
{
    public class PersonaL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido")]
        [StringLength(60)]
        public string NombreL { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido")]
        [StringLength(60)]
        public string ApellidoL { get; set; }
        [Required(ErrorMessage ="La fecha de nacimiento es requerido")]
        public DateTime FechaNacimientoL { get; set; }

        [Required(ErrorMessage = "El sueldo es requerido")]
        public decimal SueldoL { get; set; }

        [Required(ErrorMessage = "El estatus es requerido")]
        public byte Status { get; set; }

    }
}
