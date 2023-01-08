using System;
using System.ComponentModel.DataAnnotations;

namespace ModelAdmin
{

    public class usuarios
    {
        //Atributos de clase
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        [StringLength(50, ErrorMessage = "El Campo {0} Debe contener entre {2} y {1}  Caracteres", MinimumLength = 5)]
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "El campo {0} debe de un correo valido")]
        public string CorreoElectronico { get; set; }
        public int IdRol { get; set; }
        public byte[] Firma { get; set; }
        public decimal Autorizacion { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string UsuarioAutoriza { get; set; }
        public string Estado { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModifica { get; set; }
        public string Skin { get; set; }
    }
}
