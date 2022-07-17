using HW._09.Task3;

Films film1 = new Films("Shonda Rhimes", "Elen Pompeo", "Patrick Dempsey",
    "Grey's Anatomy", 4003, "TV-series", "18");

film1.Play();
film1.RetrieveInformation();

Music song1 = new Music("David Guetta", 4, "Titanium", 222, "pop music", "20");
song1.Play();
song1.Play("Sia", "Queen");
song1.RetrieveInformation();

ComputerPrograms program1 = new ComputerPrograms("Civilization VI", "game", 111, "Strategy", "45");
program1.RetrieveInformation();