using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace logica.Repositories
{
   public interface IActivitiesRepository: IGenericRepository<Activities>
    {
        Task<bool> DeleteCheckOnEntry(int id);
         public void DeleteAll(Activities activities);
         public void DeleteAll2(List<Activities> activities);
    }
}
