using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoOficina.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required, Column("Nome")]
        [DisplayName("Nome Cliente")]
        public string? Nome { get; set; }

        [Column("Documento")]
        public string? Documento { get; set; }

        [Column("Endereco")]
        [DisplayName("Rua/Avenida")]
        public string? Endereco { get; set; }

        [Column("Numero")]
        [DisplayName("N°")]
        public int Numero { get; set; }

        [Column("Cidade")]
        public string? Cidade { get; set; }

        [Column("Bairro")]
        public string? Bairro { get; set; }

        [Column("Complemento")]
        public string? Complemento { get; set; }

        [Required, Column("Telefone")]
        public string? Telefone { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime Data { get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string? Usuario { get; set; }
    }
}
