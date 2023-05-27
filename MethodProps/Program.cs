// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Bad bad customer
using MethodProps;

CookieCustomer customer = new(1, "ravi");
Console.WriteLine(customer);

char firstCh = customer.NameFirstChar;
Console.WriteLine("Customer's name starts with "+ firstCh);

CookieCustomer pluralsight = new(1, "Pluralsight");
CookieCustomer ravi = new(2, "Ravi who loves cookies");
CookieCustomer browserRobot = new(3, "Browser Robot");

SalesList sales = new();
   sales.AddSale(new(ravi, 200))
        .AddSale(new(pluralsight, 80))
        .AddSale(new(ravi, 50))
        .AddSale(new(browserRobot, 500))
        .AddSale(new(pluralsight, 1000))
        .AddSale(new(browserRobot, 50))
        .AddSale(new(pluralsight, 20));

//(string name, decimal totalValue, int nSales) = sales.GetHighestValueCustomer();

decimal totalSpent = 0;
var nTransactions = 0;
string name = sales.GetHighestValueCustomer(out totalSpent, out nTransactions);

Console.WriteLine($"Highest spender: {name}");
//Console.WriteLine($"{name} Spent {totalValue} in {nSales} purchases");
Console.WriteLine($"{name} Spent {totalSpent} in {nTransactions} purchases");

bool eligible = BusinessRules.EligibleForVoucher(nTransactions, in totalSpent);
Console.WriteLine($"Is {name} eligible for voucher? {eligible}");

//Fluent coding in linq
var highValueSales = sales.EnumerateItems()
                          .Where(sale => sale.Value > 100)
                          .OrderBy(sale => sale.Customer.Name);

foreach (var item in highValueSales)
    Console.WriteLine($"Value of item bought by customer {item.Customer} is {item.Value}");

//just a small segway
Console.WriteLine("Intptr.size " + IntPtr.Size);
Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(decimal));

return;

