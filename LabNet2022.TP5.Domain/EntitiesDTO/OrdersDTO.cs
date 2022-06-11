namespace LabNet2022.TP5.Domain
{
    using System;

    public partial class OrdersDTO
    {

        public int OrderID { get; set; }


        public string Customer { get; set; }

        public string? Employee { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public string ShipName { get; set; }


        public string ShipAddress { get; set; }


        public string ShipCity { get; set; }


        public string ShipRegion { get; set; }


        public string ShipPostalCode { get; set; }


        public string ShipCountry { get; set; }

    }
}
