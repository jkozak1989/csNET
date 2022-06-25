using System;
namespace WebAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? BrandName { get; set; }
        public string? ModelName { get; set; }
        public int ProductionYear { get; set; }
        public int HorsePower { get; set; }
        public int Price { get; set; }

        public Car()
        {
        }
    }
}

