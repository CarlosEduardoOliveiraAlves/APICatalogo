using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

// Classe Anêmica (Sem comportamento)
[Table("Categorias")]
public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; } //? usado para que o campo possa ser null
    
    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; } //? usado para que o campo possa ser null

    public ICollection<Produto>? Produtos { get; set; }
}
