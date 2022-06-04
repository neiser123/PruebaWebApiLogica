using logica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica.Repositories.Implements
{
   public class ActivitiesRepository : GenericRepository<Activities>,IActivitiesRepository
    {

        private readonly PruebasSatelitesContext pruebasSatelitesContext;
        public ActivitiesRepository (PruebasSatelitesContext pruebasSatelitesContext) : base(pruebasSatelitesContext)
        {
            this.pruebasSatelitesContext = pruebasSatelitesContext;

        }

        public void  DeleteAll(Activities activities)
        {
           var flag1 = pruebasSatelitesContext.Activities.Remove(activities);
            pruebasSatelitesContext.SaveChanges();
        }

        public void DeleteAll2(List<Activities> activities)
        {
            using (var db = new PruebasSatelitesContext())
            {
              //  db.Database.ExecuteSqlCommand("");
                db.Database.ExecuteSqlCommand("DELETE  FROM [PruebasSatelites].[dbo].[activities]");
            }
        }

        public async Task<bool> DeleteCheckOnEntry(int id)
        {
            //validamos si son foraneas de alguna otra tabla en este caso autores
            var flag = await pruebasSatelitesContext.Authors.AnyAsync(x => x.Id == id);
            return flag;
        }
    }
}
