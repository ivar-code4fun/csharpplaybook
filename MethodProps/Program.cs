// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Bad bad customer
using MethodProps;

CookieCustomer customer = new(0, "ravi");
Console.WriteLine(customer);

char firstCh = customer.NameFirstChar;
Console.WriteLine("Customer's name starts with "+ firstCh);

return;

