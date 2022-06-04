using logica.Models;
using logica.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services.Implements
{
   public class AuthorsService : GenericService<Authors>, IAuthorsService
    {
        private readonly IAuthorsRepository authorsRepository;
        public AuthorsService(IAuthorsRepository authorsRepository) : base(authorsRepository)
        {
            this.authorsRepository = authorsRepository;
        }
        public void DeleteAll2(List<Authors> Authors)
        {
            authorsRepository.DeleteAll2(Authors);
        }
    }
}
