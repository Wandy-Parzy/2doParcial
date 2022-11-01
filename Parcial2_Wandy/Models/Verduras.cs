using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2_Wandy.Models{
    public class Verduras{
       [Key]
       public int VerduraId { get; set; }
       public DateTime FechaCreacion { get; set; }
       public string? Nombre { get; set; }
       public string? Observaciones { get; set; }
     
        [ForeignKey("VitaminaId")]
       public virtual List<VerdurasDetalles> Detalle {get; set;} = new List<VerdurasDetalles>();
    }
}
