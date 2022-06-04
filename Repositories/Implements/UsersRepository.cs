using logica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories.Implements
{
   public class UsersRepository : GenericRepository<Users>, IUsersRepository
    {

        private readonly PruebasSatelitesContext pruebasSatelitesContext;
        public UsersRepository(PruebasSatelitesContext pruebasSatelitesContext) : base(pruebasSatelitesContext)
        {


        }

        public void DeleteAll2(List<Users> Users)
        {
            using (var db = new PruebasSatelitesContext())
            {
                //  db.Database.ExecuteSqlCommand("");
                db.Database.ExecuteSqlCommand("DELETE  FROM [PruebasSatelites].[dbo].[users]");
            }
        }
    }
}
