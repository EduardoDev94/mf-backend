using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace mf_backend.Models

{
    [Table("Consumos")] //Referência o nome no banco de dados
    public class Consumo
    {
        [Key] // referência chave primária
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar descrição")] // Validação de dados e mesnagem de erro
        [Display(Name = "Descrição")]
        public string Descricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Kilometragem")]

        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }


        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }
    public enum TipoCombustivel
    {
        Gasolina, Etanol, Diesel
    }


}
