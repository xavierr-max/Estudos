using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required (ErrorMessage = "Informe o título")]
    [MinLength(3, ErrorMessage = "A categoria deve conter no mínimo 3 caracteres")]
    [MaxLength(60, ErrorMessage = "A categoria deve conter no máximo 60 caracteres")]
    public string Title { get; set; }
}