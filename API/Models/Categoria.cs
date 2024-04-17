namespace API.Models;

// Classe Anêmica (Sem comportamento)
public class Categoria
{
    public int CategoriaId { get; set; }
    public String? Nome { get; set; } //? usado para que o campo possa ser null
    public string? ImagemUrl { get; set; } //? usado para que o campo possa ser null
}
