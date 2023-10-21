// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/


using Case_study;
using System.Diagnostics;

Console.WriteLine("Select");
Console.WriteLine("1.Book 2.Fiction 3.NonFiction 4.Details of Customer 5.Order");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        Book book = new Book();
        Console.WriteLine("Enter the title");
        book.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
       book.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        book.ISBN= Console.ReadLine();
        Console.WriteLine("Enter the Price");
        book.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availability");
        book.Availability = Console.ReadLine();
        book.DisplayBook();
        book.SearchBook();
        break;

    case 2:
        Fiction fiction = new Fiction();
        Console.WriteLine("Enter the title");
        fiction.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        fiction.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        fiction.ISBN = Console.ReadLine();
        Console.WriteLine("Enter the Price");
        fiction.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availability");
        fiction.Availability = Console.ReadLine();
        Console.WriteLine("Enter the book");
        fiction.DisplayBook();
        fiction.SearchFictionBook();
        fiction.DisplayFictionDetails();
        break;


    case 3:
       NonFiction nonfiction = new NonFiction();
        Console.WriteLine("Enter the title");
        nonfiction.Title = Console.ReadLine();
        Console.WriteLine("Enter the Author");
        nonfiction.Author = Console.ReadLine();
        Console.WriteLine("Enter the ISBN");
        nonfiction.ISBN = Console.ReadLine();
        Console.WriteLine("Enter the Price");
        nonfiction.Price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Availability");
        nonfiction.Availability = Console.ReadLine();
        Console.WriteLine("Enter the book");
        nonfiction.DisplayBook();
        nonfiction.SearchNonFictionBook();
        nonfiction.DisplayNonFictionDetails();
        break;
    case 4:
        Customer customer = new Customer();
        Console.WriteLine("Enter the customerid");
        customer.CustomerId1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the customer name");
        customer.CustomerName1 =Console.ReadLine();
        Console.WriteLine("Enter the customer number");
        customer.CustomerNumber1 = Console.ReadLine();
        customer.DisplayCustomerDetails();
        customer.CustomerDetails("989765435");
        Console.WriteLine("After modification");
        customer.DisplayCustomerDetails();



        break;

    case 5:

        Order order = new Order();
        Book book1 = new Book();
        Console.WriteLine("Enter the customerid");
       order.CustomerId1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the customer name");
      order.CustomerName1 = Console.ReadLine();
        Console.WriteLine("Enter the customer number");
       order.CustomerNumber1 = Console.ReadLine();
        Console.WriteLine("enter the book details title and author name");
        book1.Title=Console.ReadLine();
        book1.Author = Console.ReadLine();
        Console.WriteLine("enter the cost of book");
        book1.Price=Convert.ToInt32(Console.ReadLine());
        order.DisplayCustomerDetails();
        order.ProcessOrder(book1);
        Console.WriteLine("Total cost:"+order.CalculateCost(book1));
        break;




    default:Console.WriteLine("POlease check the the number entered");
        break;






}






