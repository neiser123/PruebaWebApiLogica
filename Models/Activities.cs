using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace logica.Models
{
    public partial class Activities
    {
        //public int? Id { get; set; }
        //public string Title { get; set; }
        //public string DueDate { get; set; }
        //public string Completed { get; set; }

        public int? id { get; set; }
        public string title { get; set; }
        public DateTime dueDate { get; set; }
        public Boolean completed { get; set; }
    }
}
