using LabNet2022.TP5.Domain;
using LabNet2022.TP5.Domain.Entities;
using static LabNet2022.TP5.DataAccess.Repository;

namespace LabNet2022.TP5.DataAccess
{
    public interface IRepository
    {
        List<Customers> GetCustomers();
        List<Customers> GetCustomersWA();
        List<Products> ProductosSinStock();
        List<Products> ProductosConStock();
        Products ProductosID();
        List<string> GetNameCustomers();
        List<Orders> GetOrders();
        List<Customers> GetTopCustomers();
        List<Products> ProductosOrdenadosNombre();
        List<Products> ProductosOrdenadosStock();
        Products PrimerProducto();
        List<CustomerOrders> GetCustomerOrders();

        List<Categories> GetCategoryProduct();
    }
    public class Repository : ContextLogic, IRepository
    {
        public List<Customers> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        public List<Customers> GetCustomersWA()
        {
            return _context.Customers.Where(c => c.Region == "WA").ToList();
        }

        public List<Products> ProductosSinStock()
        {
            return (from p in _context.Products
                    join c in _context.Categories on p.CategoryID equals c.CategoryID
                    join s in _context.Suppliers on p.SupplierID equals s.SupplierID
                    where p.UnitsInStock < 1
                    select p).ToList();
        }

        public List<Products> ProductosConStock()
        {
            return (from p in _context.Products
                    join c in _context.Categories on p.CategoryID equals c.CategoryID
                    join s in _context.Suppliers on p.SupplierID equals s.SupplierID
                    where p.UnitsInStock >= 1 && p.UnitPrice > 3
                    select p
                         ).ToList();
        }

        public Products ProductosID()
        {
            return _context.Products.FirstOrDefault(p => p.ProductID == 789);
        }

        public List<string> GetNameCustomers()
        {
            return _context.Customers.Select(c => c.CompanyName.ToLower()).ToList();
        }

        public List<Orders> GetOrders()
        {
            return (from o in _context.Orders
                    join c in _context.Customers on o.CustomerID equals c.CustomerID
                    where o.OrderDate > new DateTime(1997, 1, 1)
                    && c.Region == "WA"
                    select o
                         ).ToList();
        }

        public List<Customers> GetTopCustomers()
        {
            return _context.Customers.Take(3).ToList();
        }

        public List<Products> ProductosOrdenadosNombre()
        {
            return (from p in _context.Products
                    orderby p.ProductName
                    select p).ToList();
        }
        public List<Products> ProductosOrdenadosStock()
        {
            return (from p in _context.Products
                    orderby p.UnitsInStock descending
                    select p).ToList();
        }

        public List<Categories> GetCategoryProduct()
        {
            var lista =  (from p in _context.Products
                    join c in _context.Categories on p.CategoryID equals c.CategoryID
                    group p by p.CategoryID into g
                    select  g.Key).ToList();
            var Categorias = new List<Categories>();
            foreach (var id in lista)
            {
                Categorias.Add(_context.Categories.Find(id));
            }

            return Categorias;
        }





        public Products PrimerProducto()
        {
            return _context.Products.FirstOrDefault();
        }

        public List<CustomerOrders> GetCustomerOrders()
        {
            return (from o in _context.Orders
                         join c in _context.Customers on o.CustomerID equals c.CustomerID
                         group c by c.CustomerID into g
                         select new CustomerOrders{ 
                             id = g.Key,
                             cantidad = g.Count()
                         }).ToList();
        }

    }

}
