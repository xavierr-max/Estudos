using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{   
    [Key]
    public int Id { get; set; }
    
    [Required (ErrorMessage = "Informe o ttítulo")]
    [MinLength(3, ErrorMessage = "A categoria deve conter no mínimo 3 caracteres")]
    [MaxLength(120, ErrorMessage = "A categoria deve conter no máximo 120 caracteres")]
    public string Title { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    [Required (ErrorMessage = "Informe o preço do produto")]
    [DataType(DataType.Currency)] // quando estamos trabalhando com moeda
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}