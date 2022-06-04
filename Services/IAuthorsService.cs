using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services
{
  public interface IAuthorsService : IGenericService<Authors>
     {
        public void DeleteAll2(List<Authors> Authors);
    }
}
