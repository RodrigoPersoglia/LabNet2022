using LabNet2022.TP7.Domain;
using LabNet2022.TP7.Domain.EntitiesDTO;

namespace LabNet2022.TP8.Service.Mappers
{
    public class MapperCategories
    {
        public CategoryDTO EntityToDto(Categories categoria)
        {
            var dto = new CategoryDTO();
            dto.CategoryID = categoria.CategoryID;
            dto.CategoryName = categoria.CategoryName;
            dto.Description = categoria.Description;
            return dto;

        }
    }
}
