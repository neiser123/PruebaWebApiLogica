using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace logica.Services
{
  public interface IActivitiesService : IGenericService<Activities>
     {
        Task<bool> DeleteCheckOnEntry(int id);
    }
}
