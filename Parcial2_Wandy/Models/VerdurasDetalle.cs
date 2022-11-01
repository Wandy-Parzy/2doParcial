using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_Wandy.Models{
    public class VerdurasDetalles{
       [Key] 
       public int Id { get; set; }
       public int VerduraId { get; set; }
       public int VitaminaId { get; set; }
       public double Cantidad { get; set; }
    }
}
