using HW._09.Booking.Com.Models;

Server server = new Server();
Account account1 = new Account("Lady Whistledown", "AB999111", "29999111",
    "kateG", "test12345");

Account account2 = new Account("John Fixer", "AB111334ff", "2577745656",
    "john1234", "test12345");

server.CreateAccount(account1);
server.LoginToAccount(account1, account1.Login, account1.Password);
server.Search("Vancouver", "02.08", 14, 2);   
server.BookAndPurchase(account1, false, new Hotel(2, true));

Console.WriteLine();
server.CreateAccount(account2);
server.LoginToAccount(account2, account2.Login, account2.Password);
server.Search("Huston", "05.08", 5, 1);  
server.BookAndPurchase(account2, true, new Apartment(2,1));