using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace logica.Models
{
        [Table("Actividades", Schema = "dbo")]
    public class Actividades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]// le decimos que el id no va ser autoincrementable
        public int Id { get; set; }
        [Required(ErrorMessage = "Obligatorio"), MaxLength(100, ErrorMessage = "No más de 100 caracteres")]
        public string title { get; set; }

        [Required(ErrorMessage = "Obligatorio")]
        [Display(Name = "dueDate")]
        public string dueDate { get; set; }
        public Boolean completed { get; set; }

    }
}
