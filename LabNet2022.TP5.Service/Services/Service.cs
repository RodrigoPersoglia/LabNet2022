using LabNet2022.TP5.DataAccess;
using LabNet2022.TP5.Domain;
using LabNet2022.TP5.Domain.Entities;
using LabNet2022.TP5.Service.Mappers;
using static LabNet2022.TP5.DataAccess.Repository;

namespace LabNet2022.TP5.Service
{
    public interface IService
    {
        List<CustomersDTO> GetCustomers();
        List<ProductDTO> ProductosSinStock();
        List<ProductDTO> ProductosConStock();
        List<CustomersDTO> GetCustomersWA();
        ProductDTO? ProductosID();
        List<string> GetNameCustomers();
        List<OrdersDTO> GetOrders();
        List<CustomersDTO> GetTopCustomers();
        List<ProductDTO> ProductosOrdenadosNombre();
        List<ProductDTO> ProductosOrdenadosStock();
        ProductDTO? PrimerProducto();
        List<CustomerOrders> GetCustomerOrders();

        List<CategoriesDTO> GetCategoryProduct();
    }
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public List<CustomersDTO> GetCustomers()
        {
            return MapeoListCostumers(_repository.GetCustomers());
        }

        public List<CustomersDTO> GetCustomersWA()
        {
            return MapeoListCostumers(_repository.GetCustomersWA());
        }

        public List<ProductDTO> ProductosSinStock()
        {
            return MapeoListProducts(_repository.ProductosSinStock());
        }

        public List<ProductDTO> ProductosConStock()
        {
            return MapeoListProducts(_repository.ProductosConStock());
        }


        public List<ProductDTO> MapeoListProducts(List<Products> lista)
        {
            var list = new List<ProductDTO>();
            var mapper = new MapperProducts();
            foreach (var product in lista)
            {
                list.Add(mapper.EntityToDto(product));
            }
            return list;
        }

        public List<CustomersDTO> MapeoListCostumers(List<Customers> lista)
        {
            var list = new List<CustomersDTO>();
            var mapper = new MapperCostumers();
            foreach (var costomer in lista)
            {
                list.Add(mapper.EntityToDto(costomer));
            }
            return list;
        }

        public List<OrdersDTO> MapeoListOrder(List<Orders> lista)
        {
            var list = new List<OrdersDTO>();
            var mapper = new MapperOrders();
            foreach (var order in lista)
            {
                list.Add(mapper.EntityToDto(order));
            }
            return list;
        }

        public ProductDTO? ProductosID()
        {
            var mapper = new MapperProducts();
            var producto = _repository.ProductosID();
            if (producto != null) { return mapper.EntityToDto(producto); }
            return null;
        }

        public List<string> GetNameCustomers()
        {
            var list = new List<string>();
            foreach (var item in _repository.GetNameCustomers())
            {
                list.Add(item);
                list.Add(item.ToUpper());
            }
            return list;
        }
        public List<OrdersDTO> GetOrders()
        {
            return MapeoListOrder(_repository.GetOrders());
        }

        public List<CustomersDTO> GetTopCustomers()
        {
            return MapeoListCostumers(_repository.GetTopCustomers());
        }

        public List<ProductDTO> ProductosOrdenadosNombre()
        {
            return MapeoListProducts(_repository.ProductosOrdenadosNombre());
        }

        public List<ProductDTO> ProductosOrdenadosStock()
        {
            return MapeoListProducts(_repository.ProductosOrdenadosStock());
        }

        public ProductDTO? PrimerProducto()
        {
            var mapper = new MapperProducts();
            var producto = _repository.PrimerProducto();
            if (producto != null) { return mapper.EntityToDto(producto); }
            return null;
        }

        public List<CustomerOrders> GetCustomerOrders()
        {
            return _repository.GetCustomerOrders();
        }

        public List<CategoriesDTO> GetCategoryProduct()
        {
            var list = new List<CategoriesDTO>();
            var mapper = new MapperCategories();
            foreach (var category in _repository.GetCategoryProduct())
            {
                list.Add(mapper.EntityToDto(category));
            }
            return list;
        }
    }
}
