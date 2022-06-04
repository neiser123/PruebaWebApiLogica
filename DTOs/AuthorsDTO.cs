using System;
using System.Collections.Generic;
using System.Text;

namespace logica.DTOs
{
    public class AuthorsDTO
    {
     
            public int? Id { get; set; }
            public string IdBook { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        public string fullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        // DESVOLVEMOS PROPIEDADES DE LOS OTRO DTOS
        public BooksDTO Books { get; set; }
        
    }
}
