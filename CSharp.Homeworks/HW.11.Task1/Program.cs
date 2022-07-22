using HW._11.Task1;

MotorcycleRepository bikes = new MotorcycleRepository();

Motorcycle moto1 = bikes.CreateMotorcycle("VW", "rLine", 2023, 25_000);
Motorcycle moto2 = bikes.CreateMotorcycle("BMW", "redLine", 2019, 20_000);
bikes.CreateMotorcycle("Honda", "x5", 2012, 5_000);

Console.WriteLine(bikes.GetMotorcycleByID(moto1.Id));

Console.WriteLine((moto2.Id) + " " + bikes.UpdateMotorcycle(moto2, "Yamaha", "s580", 2021, 35_000));