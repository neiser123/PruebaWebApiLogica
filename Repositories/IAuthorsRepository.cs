using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories
{
   public interface IAuthorsRepository : IGenericRepository<Authors>
    {
        public void DeleteAll2(List<Authors> Authors);
    }
}
