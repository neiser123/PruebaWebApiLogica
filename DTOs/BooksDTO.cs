using System;
using System.Collections.Generic;
using System.Text;

namespace logica.DTOs
{
    public class BooksDTO
    {
   
            public int? Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public long? PageCount { get; set; }
            public string Excerpt { get; set; }
            public string PublishDate { get; set; }
        
    }
}
