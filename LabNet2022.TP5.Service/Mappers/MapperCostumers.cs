using LabNet2022.TP5.Domain;

namespace LabNet2022.TP5.Service.Mappers
{
    public class MapperCostumers
    {
        public CustomersDTO EntityToDto(Customers costomer)
        {
            var dto = new CustomersDTO();
            dto.CustomerID = costomer.CustomerID;
            dto.CompanyName = costomer.CompanyName;
            dto.ContactName = costomer.ContactName;
            dto.ContactTitle = costomer.ContactTitle;
            dto.Address = costomer.Address;
            dto.City = costomer.City;
            dto.Region = costomer.Region;
            dto.PostalCode = costomer.PostalCode;
            dto.Country = costomer.Country;
            dto.Phone = costomer.Phone;
            dto.Fax = costomer.Fax;
            return dto;
        }
    }
}
