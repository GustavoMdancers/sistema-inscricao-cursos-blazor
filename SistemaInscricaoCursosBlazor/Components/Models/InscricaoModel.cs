using System.ComponentModel.DataAnnotations;

namespace SistemaInscricaoCursosBlazor.Components.Models;

public class InscricaoModel
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um endereço de e-mail válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "A idade é obrigatória.")]
    [Range(16, 100, ErrorMessage = "A idade deve estar entre 16 e 100 anos.")]
    public int Idade { get; set; }

    [Required(ErrorMessage = "A seleção de um curso é obrigatória.")]
    public string CursoId { get; set; } = string.Empty;
}
