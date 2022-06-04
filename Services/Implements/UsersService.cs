using logica.Models;
using logica.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services.Implements
{
   public class UsersService : GenericService<Users>, IUsersService
    {
        private readonly IUsersRepository usersRepository1;
        public UsersService(IUsersRepository usersRepository) : base(usersRepository)
        {
            this.usersRepository1 = usersRepository;
        }
 

        public void DeleteAll2(List<Users> Users)
        {
            usersRepository1.DeleteAll2(Users);
        }
    }
}
