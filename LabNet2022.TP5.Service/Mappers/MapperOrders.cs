using LabNet2022.TP5.Domain;

namespace LabNet2022.TP5.Service.Mappers
{
    public class MapperOrders
    {
        public OrdersDTO EntityToDto(Orders pedido)
        {
            var dto = new OrdersDTO();
            dto.OrderID = pedido.OrderID;
            dto.Customer = pedido.Customers.CompanyName;
            dto.Employee = $"{pedido.Employees.LastName} {pedido.Employees.FirstName}";
            dto.OrderDate = pedido.OrderDate;
            dto.RequiredDate = pedido.RequiredDate;
            dto.ShippedDate = pedido.ShippedDate;
            dto.ShipVia = pedido.ShipVia;
            dto.Freight = pedido.Freight;
            dto.ShipName = pedido.ShipName;
            dto.ShipAddress = pedido.ShipAddress;
            dto.ShipCity = pedido.ShipCity;
            dto.ShipRegion = pedido.ShipRegion;
            return dto;

        }
    }
}
