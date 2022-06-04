using logica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories.Implements
{
   public class AuthorsRepository : GenericRepository<Authors>, IAuthorsRepository
    {

        private readonly PruebasSatelitesContext pruebasSatelitesContext;
        public AuthorsRepository(PruebasSatelitesContext pruebasSatelitesContext) : base(pruebasSatelitesContext)
        {
        }

        public void DeleteAll2(List<Authors> Authors)
        {
            using (var db = new PruebasSatelitesContext())
            {
                //  db.Database.ExecuteSqlCommand("");
                db.Database.ExecuteSqlCommand("DELETE  FROM [PruebasSatelites].[dbo].[authors]");
            }
        }
    }
}
