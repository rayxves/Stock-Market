using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
    
    [Required]
    [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
    public string Symbol { get; set; } = string.Empty;

        
    [Required]
    [MaxLength(20, ErrorMessage = "CompanyName cannot be over 20 characters")]
    public string CompanyName { get; set; } = string.Empty;
    // [Column(TypeName = "decimal(18,2)")] //when working with money this line limit my database to 18 caracters and 2 decimal places
    [Required]
    [Range(1, 100000000)]
    public decimal Purchase { get; set; }

    [Required]
    [Range(0.001, 100)]
     public decimal LastDividend { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Industry cannot be over 20 characters")]
     public string Industry { get; set; } = string.Empty;

    [Required]
    [Range(1, 5000000000)]
     public long MarketCap { get; set; }
    }
}