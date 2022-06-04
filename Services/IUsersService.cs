using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services
{
  public interface IUsersService : IGenericService<Users>
     {
        public void DeleteAll2(List<Users> Users);
    }
}
