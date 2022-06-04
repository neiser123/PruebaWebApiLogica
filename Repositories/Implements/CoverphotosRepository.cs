using logica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories.Implements
{
   public class CoverphotosRepository : GenericRepository<Coverphotos>, ICoverphotosRepository
    {

        private readonly PruebasSatelitesContext pruebasSatelitesContext;
        public CoverphotosRepository(PruebasSatelitesContext pruebasSatelitesContext) : base(pruebasSatelitesContext)
        {


        }
        public void DeleteAll2(List<Coverphotos> Coverphotos)
        {
            using (var db = new PruebasSatelitesContext())
            {
                //  db.Database.ExecuteSqlCommand("");
                db.Database.ExecuteSqlCommand("DELETE  FROM [PruebasSatelites].[dbo].[coverphotos]");
            }
        }

    }
}
