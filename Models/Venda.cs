using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoOficina.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        public int Id { get; set; }

        [Required, Column("Venda")]
        public bool Selecionar { get; set; }

        [Column("Total")]
        [DisplayName("Valor Total")]
        public string? Total { get; set; }

        [DisplayName("Data da Venda")]
        public DateTime Data { get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string? Usuario { get; set; }
    }
}
