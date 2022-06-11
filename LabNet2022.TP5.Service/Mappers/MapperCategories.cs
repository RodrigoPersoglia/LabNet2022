using LabNet2022.TP5.Domain;

namespace LabNet2022.TP5.Service.Mappers
{
    public class MapperCategories
    {
        public CategoriesDTO EntityToDto(Categories categoria)
        {
            var dto = new CategoriesDTO();
            dto.CategoryID = categoria.CategoryID;
            dto.CategoryName = categoria.CategoryName;  
            dto.Description = categoria.Description;
            dto.Picture = categoria.Picture;
            return dto;

        }
    }
}
