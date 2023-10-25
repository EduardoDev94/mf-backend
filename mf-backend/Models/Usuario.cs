using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Perfil Perfil { get; set; } 

    }

    public enum Perfil
    {
        Admin,
        User
    }
}
