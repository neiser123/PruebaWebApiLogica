using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories
{
   public interface ICoverphotosRepository : IGenericRepository<Coverphotos>
    {
        public void DeleteAll2(List<Coverphotos> Coverphotos);

    }
}
