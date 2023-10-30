// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/


using Case_study;
using Case_study.CustomExcep;


//OrderException orderException = new OrderException();


/*Product product = new Product();
product.ProductId = 1;
product.ProductName = "asd";
product.Price = 100.00;
product.StockQuantity = 200;*/



/*PhysicalProduct pr = new PhysicalProduct();
pr.ProductName ="Shoe";
pr.Price = 1000.00;
pr.ProductId = 1;
pr.Weight = 10;
p.Dimension = 12;

Console.WriteLine(product);

DigitalProduct product1 = new DigitalProduct();
product1.ProductName = "camera";
product1.Price = 9000.00;
product1.FileFormat = "txt";
product1.DownloadLink = "adchk.com";
Console.Write(product1);*/

string? pro, phNumber, response;
int quan, cusId;


PhysicalProduct product = new PhysicalProduct();
product.Name = "soap";
product.ProductID = 10;
product.Price = 20;
product.StockQuantity = 20;
product.Weight = 2;
product.Dimension = "2x2";



Product.Products.Add(product);


DigitalProduct digitalProduct = new DigitalProduct();
digitalProduct.Name = "photo";
digitalProduct.ProductID = 110;
digitalProduct.Price = 2000;
digitalProduct.StockQuantity = 20;
digitalProduct.DownloadLink = "https://photo.com";
digitalProduct.FileFormat = "jpeg";

Product.Products.Add(digitalProduct);

Order order = new Order();
Console.WriteLine("Welcome");
Console.WriteLine("Enter your details");
Console.WriteLine("Enter the customer Id");
order.CustomerId1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the phone number");
order.PhoneNumber1 = Console.ReadLine();

while (true)
{

    Console.WriteLine("1->To Shop\n2-> To view cart\n" +
        "3->for Payment\n 4-> Delivery details\n5->exit");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("Choose\n1->Physical Product\n 2-> Digital Product");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 == 1)
            {
                try
                {
                    Console.WriteLine("enter the product name you wish to buy");
                    pro = Console.ReadLine();


                    product.PhysicalCart(pro, Product.Products);
                    Console.WriteLine("enter the product quantity");
                    quan = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Do you want to order");
                    string? res = Console.ReadLine();
                    if (res.Equals("yes"))
                    {
                        try
                        {
                            product.PlaceOrders(quan,
                                Product.Products);
                        }

                        catch (PlaceOrderException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                catch (ProductNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            else
            {
                try
                {
                    Console.WriteLine("enter the product name " +
                        "you wish to buy");
                    pro = Console.ReadLine();
                    Console.WriteLine("enter the product quantity");
                    quan = Convert.ToInt32(Console.ReadLine());

                    digitalProduct.DigitalCart(pro,
                        Product.Products);
                    Console.WriteLine("Do you want to order");
                    string? res = Console.ReadLine();
                    if (res.Equals("yes"))
                    {
                        try
                        {
                            digitalProduct.PlaceOrders(quan,
                                Product.Products);
                        }

                        catch (PlaceOrderException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                }
                catch (ProductNotFoundException e)
                {
                    Console.WriteLine(e.Message);


                }
            }
            break;
        case 2:
            Console.WriteLine("Products in cart");
            if (product.AddToCartList.Count > 0)
            {

                Console.WriteLine("Product Name: " + product.Name + " Product ID: "
                    + product.ProductID + " Price: " + product.Price);

            }
            else
            {
                Console.WriteLine("No Physical Product added");
            }
            if (digitalProduct.AddToCartList1.Count > 0)
            {

                Console.WriteLine("Product Name: " + digitalProduct.Name + " Product ID: "
                    + digitalProduct.ProductID + " Price: " + digitalProduct.Price);

            }
            else
            {
                Console.WriteLine("No digital Product Added");
            }

            break;
        case 3:
            if (product.AddToCartList.Count == 0 &&
                digitalProduct.AddToCartList1.Count == 0)
            {
                Console.WriteLine("No Products to process the payment");
            }
            else if (product.AddToCartList.Count > 0)
            {
                Console.WriteLine("---Payment------");
                try
                {
                    Console.WriteLine("enter the customerId to" +
                        " process the payment");
                    cusId = Convert.ToInt32(Console.ReadLine());
                    product.ProcessPayment(cusId, order);
                }
                catch (ProcessPaymentException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            else if (digitalProduct.AddToCartList1.Count > 0)
            {
                Console.WriteLine("---Payment------");
                try
                {
                    Console.WriteLine("enter the customerId to" +
                        " process the payment");
                    cusId = Convert.ToInt32(Console.ReadLine());
                    digitalProduct.ProcessPayment(cusId, order);
                }
                catch (ProcessPaymentException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            break;
        case 4:
            if (product.AddToCartList.Count == 0 &&
                digitalProduct.AddToCartList1.Count == 0)
            {
                Console.WriteLine("No products to deliver");
            }
            else if (product.AddToCartList.Count > 0)
            {
                Console.WriteLine("---Delivery---");
                try
                {
                    Console.WriteLine("enter the Phone Number to receive your order");
                    phNumber = Console.ReadLine();
                    product.DeliverOrders(phNumber, order);
                }
                catch (Case_study.DeliverOrderException e)
                {
                    Console.WriteLine(e.Message);

                }
            }
            else if (digitalProduct.AddToCartList1.Count > 0)
            {
                Console.WriteLine("---Delivery---");
                try
                {
                    Console.WriteLine("enter the Phone Number to receive your order");
                    phNumber = Console.ReadLine();
                    digitalProduct.DeliverOrders(phNumber, order);
                }
                catch (Case_study.DeliverOrderException e)
                {
                    Console.WriteLine(e.Message);

                }
            }


            break;
        case 5:
            Console.WriteLine("you exited");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("check the number entered");
            break;

    }


}





/*using System.Diagnostics;

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






}*/






