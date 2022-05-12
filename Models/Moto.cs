using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoOficina.Models
{
    [Table("Moto")]
    public class Moto
    {
        [Key]
        public int Id { get; set; }

        [Required, Column("Marca")]
        [DisplayName("Montadora")]
        public string? Marca { get; set; }

        [Required, Column("Modelo")]
        public string? Modelo { get; set; }

        [Required, Column("Cor")]
        public string? Cor { get; set; }

        [Column("Descricao")]
        [DisplayName("Descrição da Moto")]
        public string? Descricao { get; set; }

        [Column("Id_Cliente")]
        [DisplayName("Proprietário")]
        public string? Id_Cliente { get; set; }

        [DisplayName("Data de Cadastro")]
        public DateTime Data { get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string? Usuario { get; set; }
    }
}
