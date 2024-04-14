// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");

string message = "krediler";
int term = 12;
double amount = 1000.5;
bool isAuthenticated = false;

// variables --> camelCase kullanıyoruz.

Console.WriteLine(message);

if (isAuthenticated)
{
    Console.WriteLine("hoşgeldin ozan");
}
else
{
    Console.WriteLine("giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

int gun = 9;
switch (gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
        case 2:
        Console.WriteLine("Salı");
        break;
        case 3:
        Console.WriteLine("Çarşamba");
        break;
        case 4:
        Console.WriteLine("Perşembe");
        break;
        case 5:
        Console.WriteLine("Cuma");
        break;
        case 6:
        Console.WriteLine("Cumartesi");
        break;
       case 7:
        Console.WriteLine("Pazar");
        break;
        default:
        Console.WriteLine("Geçersiz gün girdiniz");
        break;
}


Console.WriteLine("kod bitti");

InvidualCustomer customer1 = new InvidualCustomer();
customer1.Id = 1;
customer1.FirstName = "Kodlamaio";
customer1.LastName = "Akin";
customer1.NationalIdentity = "123456789";
customer1.CustomerNumber = "123456";

InvidualCustomer customer2 = new InvidualCustomer();
customer2.Id = 2;
customer2.FirstName = "Anatolia";
customer2.LastName = "Yazilim";
customer2.NationalIdentity = "12341234";
customer2.CustomerNumber = "123123";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "abc";
customer3.CustomerNumber = "123231";
customer3.TaxNumber = "123456";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "cba";
customer4.CustomerNumber = "654321";
customer4.TaxNumber = "654321";

BaseCustomer[] customers = { customer1, customer2, customer3,customer4 };

// Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
