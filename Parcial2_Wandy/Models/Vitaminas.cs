using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_Wandy.Models{
    public class Vitaminas{
       [Key] 
       public int VitaminaId { get; set; }
       public string? Nombre  { get; set; }
    }
}
