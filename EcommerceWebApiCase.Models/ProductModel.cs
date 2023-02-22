namespace EcommerceWebApiCase.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Length { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string Brand { get; set; }
        public string PartNumber { get; set; }       
        public string OperatingSystem { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }
        public int Storage { get; set; }
        public int BatteryCapacity { get; set; }      
        public string Display { get; set; }
    }
}