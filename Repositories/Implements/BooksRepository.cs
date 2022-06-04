using logica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories.Implements
{
   public class BooksRepository : GenericRepository<Books>, IBooksRepository
    {

        private readonly PruebasSatelitesContext pruebasSatelitesContext;
        public BooksRepository(PruebasSatelitesContext pruebasSatelitesContext) : base(pruebasSatelitesContext)
        {


        }
        public void DeleteAll2(List<Books> Books)
        {
            using (var db = new PruebasSatelitesContext())
            {
                //  db.Database.ExecuteSqlCommand("");
                db.Database.ExecuteSqlCommand("DELETE  FROM [PruebasSatelites].[dbo].[books]");
            }
        }
    }
}
