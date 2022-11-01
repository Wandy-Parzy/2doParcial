using Microsoft.EntityFrameworkCore;
using Parcial2_Wandy.Models;
using Parcial2_Wandy.Data;

public class VitaminasBLL
    {
        private Contexto _contexto;
        public VitaminasBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Vitaminas? Buscar(int Id)
        {
            return _contexto.Vitaminas
                .Where(p => p.VitaminaId == Id)
                .AsNoTracking()
                .SingleOrDefault();
         }
    
       
    }



    
