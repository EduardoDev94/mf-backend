using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mf_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Placa obrigatória")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Ano de fabricação obrigatório")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
        [Display(Name = "Ano do Modelo")]
        [Required(ErrorMessage = "Ano do Modelo obrigatório")]
        public int AnoModelo { get; set; }
    }
}
