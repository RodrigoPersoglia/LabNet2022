using LabNet2022.TP5.Service;
using Microsoft.AspNetCore.Mvc;


namespace Presentation.Controllers
{
    [Route("NorthWind")]
    [ApiController]

    public class ControllerNorthWind : ControllerBase
    {
        private readonly IService _service;
        public ControllerNorthWind(IService service)
        {
            _service = service;
        }

        [HttpGet("/query1")]
        public IActionResult GetCostumers()
        {
            return StatusCode(200, _service.GetCustomers());
        }


        [HttpGet("/query2")]
        public IActionResult GetListado()
        {
            return StatusCode(200, _service.ProductosSinStock());
        }

        [HttpGet("/query3")]
        public IActionResult GetListadoStock()
        {
            return StatusCode(200, _service.ProductosConStock());
        }

        [HttpGet("/query4")]
        public IActionResult GetCostumersWA()
        {
            return StatusCode(200, _service.GetCustomersWA());
        }

        [HttpGet("/query5")]
        public IActionResult GetProductID()
        {
            var product = _service.ProductosID();
            if (product != null) { return StatusCode(200, product); }
            else { return StatusCode(404, product); }
        }

        [HttpGet("/query6")]
        public IActionResult GetNameCostomers()
        {
            return StatusCode(200, _service.GetNameCustomers());
        }

        [HttpGet("/query7")]
        public IActionResult GetOrders()
        {
            return StatusCode(200, _service.GetOrders());
        }

        [HttpGet("/query8")]
        public IActionResult GetTopCustomers()
        {
            return StatusCode(200, _service.GetTopCustomers());
        }

        [HttpGet("/query9")]
        public IActionResult ProductosOrdenadosNombre()
        {
            return StatusCode(200, _service.ProductosOrdenadosNombre());
        }

        [HttpGet("/query10")]
        public IActionResult ProductosOrdenadosStock()
        {
            return StatusCode(200, _service.ProductosOrdenadosStock());
        }

        [HttpGet("/query11")]
        public IActionResult GetCategoryProduct()
        {
            return StatusCode(200, _service.GetCategoryProduct());
        }

        [HttpGet("/query12")]
        public IActionResult PrimerProducto()
        {
            return StatusCode(200, _service.PrimerProducto());
        }

        [HttpGet("/query13")]
        public IActionResult GetCustomerOrders()
        {
            return StatusCode(200, _service.GetCustomerOrders());
        }

    }
}
