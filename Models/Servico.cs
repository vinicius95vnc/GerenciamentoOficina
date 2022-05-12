using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoOficina.Models
{
    [Table("Serviço")]
    public class Servico
    {
        [Key]
        public int Id { get; set; } 

        [DisplayName("Serviço Prestado")]
        [Required, Column("Serviço")]
        public string? Service { get; set; }

        [DisplayName("Valor do Serviço")]
        [Required, Column("Valor")]
        public string? Valor { get; set; }

        [DisplayName("Descrição do Serviço")]
        [Column("Descricao")]
        public string? Descricao { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime Data { get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string? Usuario { get; set; }
    }
}
