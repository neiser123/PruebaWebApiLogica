using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services
{
  public interface IBooksService : IGenericService<Books>
     {
        public void DeleteAll2(List<Books> Books);
    }
}
