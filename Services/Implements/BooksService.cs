using logica.Models;
using logica.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services.Implements
{
   public class BooksService : GenericService<Books>, IBooksService
    {
        private readonly IBooksRepository booksRepository1;

        public BooksService(IBooksRepository booksRepository) : base(booksRepository)
        {
            this.booksRepository1 = booksRepository;
        }
        public void DeleteAll2(List<Books> Books)
        {
            booksRepository1.DeleteAll2(Books);
        }
    }
}
