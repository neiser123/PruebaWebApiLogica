using logica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Repositories
{
   public interface IUsersRepository : IGenericRepository<Users>
    {
        public void DeleteAll2(List<Users> Users);

    }
}
