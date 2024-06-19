using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalApi.Models
{
    [Table("Objeto")]
    public class Objeto
    {
        [Column("ObjetoId")]
        [Display(Name = "Código do Objeto")]
        public int ObjetoId { get; set; }

        [Column("ObjetoNome")]
        [Display(Name = "Nome do Objeto")]
        public string ObjetoNome { get; set; } = string.Empty;

        [Column("ObjetoCor")]
        [Display(Name = "Cor do Objeto")]
        public string ObjetoCor { get; set; } = string.Empty;

        [Column("ObjetoObservacao")]
        [Display(Name = "Observação do Objeto")]
        public string ObjetoObservacao { get; set; } = string.Empty;

        [Column("ObjetoLocalDesaparecimeto")]
        [Display(Name = "Local do Objeto")]
        public string ObjetoLocalDesaparecimeto { get; set; } = string.Empty;

        [Column("ObjetoFoto")]
        [Display(Name = "Foto do Objeto")]
        public string? ObjetoFoto { get; set; }

        [Column("ObjetoDtDesaparecimeto")]
        [Display(Name = "Data desaparecimento do Objeto")]
        public DateTime ObjetoDtDesaparecimeto { get; set; }

        [Column("ObjetoDtEncontro")]
        [Display(Name = "Data encontro do Objeto")]
        public DateTime? ObjetoDtEncontro { get; set; }

        [Column("ObjetoStatus")]
        [Display(Name = "Status do Objeto")]
        public byte ObjetoStatus { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
