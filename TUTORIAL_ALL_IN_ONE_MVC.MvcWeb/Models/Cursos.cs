using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TUTORIAL_ALL_IN_ONE_MVC.MvcWeb.Models
{
    public class Cursos 
    {
        [Key]
        public int CursoId { get; set; }

        [Display(Name ="Data")]
        [Column(TypeName ="datetime")]
        [Required]
        public DateTime DataRegistro { get; set; }

        [Display(Name = "Curso")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Curso { get; set; }

        [Display(Name = "Valor")]
        [Column(TypeName = "decimal")]
        [Required]
        public decimal valor { get; set; }
    }
}