using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial2_Wandy.Models;

namespace Parcial2_Wandy.Data;

public class Contexto : IdentityDbContext
{
    public DbSet<Vitaminas> Vitaminas {get; set;}
    public DbSet<Verduras> Verduras {get; set;}

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

protected override void OnModelCreating(ModelBuilder modelBuilder){
    base.OnModelCreating(modelBuilder);
    
    modelBuilder.Entity<Vitaminas>().HasData(
        new Vitaminas { VitaminaId = 1, Nombre ="Vitamina A"},
        new Vitaminas { VitaminaId = 2, Nombre ="Betaina "},
        new Vitaminas { VitaminaId = 3, Nombre ="Vitamina B "}, 
        new Vitaminas { VitaminaId = 4, Nombre ="Vitamina C "}, 
        new Vitaminas { VitaminaId = 5, Nombre ="Vitamina D "}
    );
}
 
}

