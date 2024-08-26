using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;

namespace api.Dtos.Stock{

    public class StockDto
    {
    public int Id { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    // [Column(TypeName = "decimal(18,2)")] //when working with money this line limit my database to 18 caracters and 2 decimal places
    public decimal Purchase { get; set; }
    // [Column(TypeName = "decimal(18,2)")] 
     public decimal LastDividend { get; set; }
     
     public string Industry { get; set; } = string.Empty;

     public long MarketCap { get; set; }

     public List<CommentDto> Comments {get; set;}

    }
}
