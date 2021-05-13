using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudCursoCore.Models
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido"), MinLength(3, ErrorMessage = "Se requieren almenos 3 caracteres"), MaxLength(20, ErrorMessage = "El maximo de caracteres es 20")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El Apellido es requerido"),MinLength(3, ErrorMessage ="Se requieren almenos 3 caracteres"),MaxLength(20,ErrorMessage ="El maximo de caracteres es 20")]
        public string Apellido { get; set; }
    }
}
