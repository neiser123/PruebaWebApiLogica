using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace logica.DTOs
{
   public class ActivitiesDTO
    {
        [Required(ErrorMessage = "Obligatorio")]
        public int? id { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        public string title { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        public bool completed { get; set; }

    }
}
