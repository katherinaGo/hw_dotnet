using HW._11.Task1;
using Serilog;
using static HW._11.Task1.Logger;

string programStarts = DateTime.UtcNow + " UTC; Program starts";
string programEnds = DateTime.UtcNow + " UTC; Program finished";

CreateLogger();
Log.Information(programStarts);

MotorcycleRepository bikes = new MotorcycleRepository();

Motorcycle moto1 = bikes.CreateMotorcycle("VW", "rLine", 2023, 25_000);
Motorcycle moto2 = bikes.CreateMotorcycle("BMW", "redLine", 2019, 20_000);
Motorcycle moto3 = bikes.CreateMotorcycle("Honda", "x5", 2012, 5_000);
Motorcycle moto4 = bikes.CreateMotorcycle("Minsk", "200S", 1994, 4_500);

Console.WriteLine(bikes.GetMotorcycleByID(Guid.Empty));

CreateLogger();
Log.Information($"Bike '{moto2.Id}', {moto2} is going to be updated... Wait a second. It's changed to: \n");
Console.WriteLine(moto2.Id + " " + bikes.UpdateMotorcycle(moto2.Id, "Yamaha", "s580", 2021, 35_000));

CreateLogger();
Log.Information($"Bike '{moto3.Id}', {moto3} is going to be updated... Wait a second. It's changed to: \n");
Console.WriteLine(moto3.Id + " " + bikes.UpdateMotorcycle(moto3.Id, moto3.Name, "TT", 2020, 3_000));

CreateLogger();
Log.Information($"Bike '{moto4.Id}', {moto4} is going to be updated... Wait a second. It's changed to: \n");
moto4 = bikes.UpdateMotorcycleModel(moto4.Id, "Star");
Console.WriteLine(moto4);

bikes.GetAllMotorcycles();

bikes.DeleteMotorcycle(moto4);

bikes.GetAllMotorcycles();

CreateLogger();
Log.Information(programEnds);