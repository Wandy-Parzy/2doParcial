 using Microsoft.EntityFrameworkCore;
 using System.Linq.Expressions;
using Parcial2_Wandy.Models;
using Parcial2_Wandy.Data;

public class VerdurasBLL
    {
       private Contexto _contexto;
        public VerdurasBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int Id)
        {
            return _contexto.Verduras.Any(c => c.VerduraId == Id);
        }
       
        public bool Guardar(Verduras verdura)
        {
            bool paso = false;

            if (!Existe(verdura.VerduraId))
                paso = Insertar(verdura);
            else
                paso = Modificar(verdura);
               return paso;

        }
        private bool Insertar(Verduras verdura)
        {
            _contexto.Verduras.Add(verdura);
            bool insertar = _contexto.SaveChanges() >0;
            return insertar;           
        }
        
         private bool Modificar(Verduras verdura)
        {
            
            _contexto.Entry(verdura).State = EntityState.Modified;
            return  _contexto.SaveChanges() > 0;
        }
       public bool Eliminar(Verduras verdura)
        {
            _contexto.Entry(verdura).State = EntityState.Deleted;
            return  _contexto.SaveChanges() > 0;
        } 

        public Verduras? Buscar(int verduraId)
        {
           return  _contexto.Verduras
            .Where(o=> o.VerduraId == verduraId)
            .AsNoTracking()
            .SingleOrDefault();
        }
         public List<Verduras> GetList(Expression<Func<Verduras, bool>> Criterio)
          {
               return  _contexto.Verduras
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
          }
}