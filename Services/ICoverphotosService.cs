using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services
{
  public interface ICoverphotosService : IGenericService<Coverphotos>
     {
        public void DeleteAll2(List<Coverphotos> Coverphotos);
    }
}
