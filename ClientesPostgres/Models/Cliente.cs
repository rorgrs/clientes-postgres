using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientesPostgres.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Column("DataCadastro")]
        [Display(Name = "DataCadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

    }
}
