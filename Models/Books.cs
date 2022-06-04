using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace logica.Models
{
    public partial class Books
    {

        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? PageCount { get; set; }
        public string Excerpt { get; set; }
        public string PublishDate { get; set; }


    }
}
