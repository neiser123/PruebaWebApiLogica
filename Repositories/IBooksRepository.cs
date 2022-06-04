using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories
{
   public interface IBooksRepository : IGenericRepository<Books>
    {
        public void DeleteAll2(List<Books> Books);

    }
}
