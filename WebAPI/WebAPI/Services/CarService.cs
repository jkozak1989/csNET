using System;
using WebAPI.Models;


namespace WebAPI.Services
{
    public static class CarService
    {
        static List<Car> Cars { get; }
        static int nextId = 5;
        static CarService()
        {
            Cars = new List<Car>
            {
                new Car { Id = 1, BrandName = "Lamborghini", ModelName = "Centenario", ProductionYear = 2016, HorsePower = 770, Price = 1920000},
                new Car { Id = 2, BrandName = "McLaren", ModelName = "Senna", ProductionYear = 2019, HorsePower = 789, Price = 1000000},
                new Car { Id = 3, BrandName = "Mercedes", ModelName = "AMG One", ProductionYear = 2022, HorsePower = 1000, Price = 2720000},
                new Car { Id = 4, BrandName = "Ford Mustang", ModelName = "Mach-E", ProductionYear = 2020, HorsePower = 346, Price = 79000}
            };
        }
        public static List<Car> GetAll() => Cars;
        public static Car? Get(int id) => Cars.FirstOrDefault(c => c.Id == id);

        public static void Add(Car car)
        {
            car.Id = nextId++;
            Cars.Add(car);
        }

        public static void Delete(int id)
        {
            var car = Get(id);
            if (car is null)
                return;
            Cars.Remove(car);
        }

        public static void Update(Car car)
        {
            var index = Cars.FindIndex(c => c.Id == car.Id);
            if (index == -1)
                return;
            Cars[index] = car; 
        }
    }
}

