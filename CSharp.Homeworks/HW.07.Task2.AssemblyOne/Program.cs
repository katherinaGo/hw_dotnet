using HW._07.Task2.AssemblyOne;

Motorcycle yamaha = new Motorcycle();
SportBike bike = new SportBike();

// Элемент доступен только в том типе, в котором определен.
// yamaha.ChangeColor("white");

// public method
yamaha.StartEngine();

// private = Доступен только в классе Motorcycle. 
//yamaha.StartEngine("faster");
//yamaha.StartEngine(320);

// protected method
//bike.ChangeColor();
//bike.BrokeBike();
//yamaha.BrokeBike();

bike.FixBike();

yamaha.FixBikeCheap();

bike.FixBikeCheap();
yamaha.FixBikeCheap();

bike.CheckFixes();
yamaha.CheckFixes();

// private protected method
//yamaha.IsFixed();
//bike.IsFixed();

bike.StartEngine();