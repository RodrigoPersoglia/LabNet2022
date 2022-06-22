using System.ComponentModel.DataAnnotations;

namespace LabNet2022.TP7.Domain.EntitiesDTO
{
    public class CategoryDTO
    {

        public CategoryDTO()
        {
        }

        [Required]
        [Key]
        [Display(Name = "id")]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Nombre")]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }


    }
}
