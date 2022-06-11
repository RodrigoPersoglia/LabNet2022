using LabNet2022.TP5.Domain;

namespace LabNet2022.TP5.Service.Mappers
{
    public class MapperProducts
    {
        public ProductDTO EntityToDto(Products product)
        {
            var dto = new ProductDTO();
            dto.ProductID = product.ProductID;
            dto.ProductName = product.ProductName;
            dto.Supplier = product.Suppliers.CompanyName;
            dto.Category = product.Categories.CategoryName;
            dto.QuantityPerUnit = product.QuantityPerUnit;
            dto.UnitPrice = product.UnitPrice;
            dto.UnitsInStock = product.UnitsInStock;
            dto.UnitsOnOrder = product.UnitsOnOrder;
            dto.ReorderLevel = product.ReorderLevel;
            dto.Discontinued = product.Discontinued;
            return dto;
        }
    }
}
