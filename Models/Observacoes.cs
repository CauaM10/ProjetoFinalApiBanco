using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalApi.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código da Observacao")]
        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Observação Descrição")]
        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local da Observação")]
        public string ObservacoesLocal { get; set; } = string.Empty;


        [Column("ObservacoesData")]
        [Display(Name = "Data observação")]
        public DateTime ObservacoesData { get; set; }


        [ForeignKey("ObjetoId")]
        public int ObjetoId { get; set; }

        public Objeto? Objeto { get; set; }


        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
