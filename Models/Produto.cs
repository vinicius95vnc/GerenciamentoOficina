using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoOficina.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; } 

        [Required, Column("Nome")]
        public string? Nome { get; set; }

        [Column("Descricao")]
        [DisplayName("Descrição")]
        public string? Descricao { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime Data { get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string? Usuario { get; set; }
    }
}
