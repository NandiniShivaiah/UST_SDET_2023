// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/

using Assignment1;
using Assignment1.UserException;



/*
RoomReservation<HotelRoom> SingleRoom = new RoomReservation<HotelRoom>();
SingleRoom.RoomNumber = 100;
SingleRoom.RoomType = "single";
SingleRoom.IsBooked = true;

RoomReservation<HotelRoom> DoubleRoom = new RoomReservation<HotelRoom>();
DoubleRoom.RoomNumber = 101;
DoubleRoom.RoomType = "double";
DoubleRoom.IsBooked = false;

RoomReservation<HotelRoom> SuiteRoom = new RoomReservation<HotelRoom>();
SuiteRoom.RoomNumber = 102;
SuiteRoom.RoomType = "suite";
SuiteRoom.IsBooked = true;

Console.WriteLine("Single");
SingleRoom.Booking<HotelRoom>(102);
SingleRoom.Cancelation<HotelRoom>(101);
Console.WriteLine();
Console.WriteLine("Suite");
SuiteRoom.Booking<HotelRoom>(101);
SuiteRoom.Cancelation<HotelRoom>(101);
Console.WriteLine();
Console.WriteLine("Double");
DoubleRoom.Booking<HotelRoom>(102);
DoubleRoom.Cancelation<HotelRoom>(101);
*/

int op;
List<Products<string>> inventory = new List<Products<string>>();
do
{
    Console.WriteLine("1-> Add Products\n 2-> View Product\n 3->Update Product\n " +
        "4-> Delete Product\n 5-> search product by name\n 6->  search product by id" +
        "7-> Exit");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("enter the ProductID");
            int proID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Product name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Stock Quantity");
            int stock = Convert.ToInt32(Console.ReadLine());
            AddProduct(new Products<string>(proID, name, price, stock));
            Console.WriteLine("Products Added");
            break;
        case 2:
            foreach (var product in inventory)
            {
                Console.WriteLine("Product Id: " + product.ProductId +
                    " Product Name: " + product.ProductName +
                    " Price: " + product.Price + " Stock: " + product.QuantityInStock);
            }
            break;
        case 3:
            Console.WriteLine("Enter the product Id you want to update");

            UpdateProduct(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Updated");
            break;
        case 4:
            Console.WriteLine("Enter the product Id you want to delete");
            RemoveProduct(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Deleted");
            break;
        case 5:
            Console.WriteLine("Enter the product name");
            FindBy(Console.ReadLine());
            break;
        case 6:
            Console.WriteLine("Enter the product Id ");
            FindById(Convert.ToInt32(Console.ReadLine()));
            break;
        case 7:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid");
            break;

    }
    Console.WriteLine("do you need to continue\n 1-> yes \n 2-> no");
    op = Convert.ToInt32(Console.ReadLine());

} while (op == 1);

void AddProduct(Products<string> prod)
{

    inventory.Add(prod);

}

void UpdateProduct(int prodId)
{
    foreach (var product in inventory)
    {
        if (inventory.Count > 0 & product.ProductId == prodId)
        {
            Console.WriteLine("enter Product ID");
            product.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the price");
            product.Price = Convert.ToInt64(Console.ReadLine());


        }
        else
        {
            Console.WriteLine(prodId + " doesn't exit");
            break;
        }
    }


}

void RemoveProduct(int prodId)
{
    foreach (var product in inventory)
    {
        if (inventory.Count > 0 && product.ProductId == prodId)
        {
            inventory.Remove(product);
        }
        else
        {
            Console.WriteLine(prodId + "doesn't exist");
            break;
        }
    }

}

void FindBy(string productName)
{
    foreach (var product in inventory)
    {
        if (productName.Equals(product.ProductName))
        {
            Console.WriteLine("ProductName" + product.ProductName +
                " Product ID: " + product.ProductId +
                " Price: " + product.Price + " Stock: " + product.QuantityInStock);
        }
        else
        {
            Console.WriteLine(productName + "doesn't exist");
            break;
        }
    }

}

void FindById(int productId)
{
    foreach (var product in inventory)
    {
        if (product.ProductId == productId)
        {
            Console.WriteLine("ProductName" + product.ProductName +
                " Product ID: " + product.ProductId +
                " Price: " + product.Price + " Stock: " + product.QuantityInStock);
        }
        else
        {
            Console.WriteLine(productId + "doesn't exist");
            break;
        }
    }

}





/*



//using Assignment1.UserException;

/*List<CallRecord> callRecords = new List<CallRecord>()
{
    new(123,"98675","7 min"),
    new(456,"12345","4 min"),
    new(789,"65432","6 min")

};
Console.WriteLine("The Call Records Details");

foreach (CallRecord call in callRecords)
{
    Console.WriteLine("Call Id: " + call.CallID + " Phone Number: " + call.PhoneNumber +
        " CallTime: " + call.CallTime);

}
Console.WriteLine();
Console.WriteLine("Calls with the specific Phone Number");
foreach (CallRecord calls in callRecords)
{
    calls.CallHistory(calls);

}

Dictionary<string, int> callCount = new Dictionary<string, int>();
foreach (CallRecord calls in callRecords)
{
    if (callCount.ContainsKey(calls.PhoneNumber))
    {
        callCount[calls.PhoneNumber]++;
    }
    else
    {
        callCount[calls.PhoneNumber] = 1;
    }
}

Console.WriteLine();
Console.WriteLine("Total Calls with the specific Phone Number");
foreach (var i in callCount)
{
    Console.WriteLine(" Phone Number: " + i.Key + " - Total Calls: " + i.Value);
}
Console.WriteLine();




/*try
{
    Patient patient1 = new(11, "aa", 25, "diabetics");
    patient1.AddPatient(patient1);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Patient patient2 = new(11, "aa", 125, "diabetics");
    patient2.AddPatient(patient2);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
*/
/*try
{
    MedicalRecord medicalRecord2 = new MedicalRecord(1, "SAM", 25, "HIGHFEVER", 111, -10000);
    medicalRecord2.AddRecord(medicalRecord2);
}
catch (InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}*/


/*MedicalHistory medicalHistory = new MedicalHistory();
medicalHistory.RecordId = 11;
medicalHistory.PatientId = 102;
medicalHistory.Description = " Paracetamol for 2 days";
medicalHistory.Date = DateTime.UtcNow;


Console.WriteLine("Choose");
Console.WriteLine("1->Add Medical History\n2->View Medical History\n 3-> exit");
int ch = Convert.ToInt32(Console.ReadLine());
switch (ch)
{
    case 1:

        medicalHistory.AddMedicalHistoryToFile(medicalHistory);
        break;

    case 2:
        Console.WriteLine("Enter the Patient Id to read");
        medicalHistory.ReadMedicalHistoryFromFile(Convert.ToInt32(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("You got exited from execution");
        break;
    default:
        Console.WriteLine("Please check the number");
        break;
}

/*Customer customer1 = new Customer(1,"Jin",98897654,2000.00);
Customer customer2 = new Customer(2, "Jimin", 12897654, 1000.00);
Customer customer3 = new Customer(3, "Junkook", 789897654, 1200.00);
List<Customer> customers = new List<Customer>();
customers.Add(customer1);
customers.Add(customer2);
customers.Add(customer3);




foreach (Customer customer in customers)
{
  
    Console.WriteLine("CustomerName:" +customer.Name + "CustomerId:" + customer.CustomerId + "Phonenumber:" + customer.PhoneNumber + "Balance:" + customer.Balance);
}


/*CallRecord call1 = new CallRecord(1, 2345, "4min");
CallRecord call2 = new CallRecord(1, 2345, "4min");
CallRecord call3= new CallRecord(1, 2345, "4min");

List<CallRecord> calls = new List<CallRecord>();
calls.Add(call1);
calls.Add(call2);
calls.Add(call3);

foreach (CallRecord call
    in calls)
{
    Console.WriteLine("CallId:" + calls.CallId + "CallTime:" + calls.CallTime);

}

/*try
{
    Patient patient1 = new(1, "Jimin", 20, "diabetics");
    patient1.AddPatient(patient1);
}
catch(AgeException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Patient patient2 = new(1, "jimin", 20, "diabetics");
    patient1.AddPatient(patient2);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
}
















/*InsurancePolicy ip=new("general",12,1000);

ip.RenewPolicy(2300);

Console.WriteLine("Renewal amount:");
ip.RenewPolicy();*/




/*LifeInsurance lifeInsurance = new("life insurance", 12, 500000, 12);
lifeInsurance.CalculatePremium();
lifeInsurance.display();

CarInsurance carInsurance = new("car insurance", 2, 1000.00,"TATA");
carInsurance.CalculatePremium();
carInsurance.display();




//ip.RenewPolicy(2300);

//Console.WriteLine("Renewal amount:");
//  ip.RenewPolicy();





/*Circle circle = new Circle(3.0);
Rectangle rectangle = new Rectangle(2.0,8.0);
circle.Draw();
Console.WriteLine(circle);
rectangle.Draw();





//Person person = new Person();
/*Employee employee = new Employee("jin","jam",23,56);
employee.DisplayInfo();*/




/*ElectronicsProduct electronicsProduct = new(3, "mobile", 30000, 1);
electronicsProduct.DisplayProduct();
electronicsProduct.ElectronicsProductDisplay();

DigitalProduct digitalProduct = new(3, "Camera", 20000, 4, "MP4");
digitalProduct.DisplayProduct();
digitalProduct.ElectronicsProductDisplay();

Console.WriteLine("Choose");
Console.WriteLine("1->DigitalProduct\n 2->ElectronicsProduct\n" + "3->ClothingProduct");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        DigitalProduct digitalProduct = new(3, "Camera", 20000, 4, "MP4");
        digitalProduct.DisplayProduct();
        digitalProduct.ElectronicsProductDisplay();
        digitalProduct.DisplayDigitalProduct();
        break;
    case 2:
        ElectronicsProduct electronicsProduct = new(3, "mobile", 30000, 1);
        electronicsProduct.DisplayProduct();
        electronicsProduct.ElectronicsProductDisplay();
        break;
    case 3:
        ClothingProduct clothingProduct = new("Dress", 3000, 3, "s");
        ClothingProduct.DisplayProduct();
        ClothingProduct.DisplayClothing();
        break;
    default:Console.WriteLine("Please check the numberyou have entered");
        break;





}


/*Student[] student = new Student[3];
student[0] = new Student("NAM", new int[] { 20, 30, 10 }, "A");
student[1] = new Student("SAM", new int[] { 10, 10, 10 }, "B");
student[2] = new Student("GAM", new int[] { 11, 9, 3 }, "C");

foreach(Student s in student)
{
    s.DisplayStudentInfo();
    s.GetMarksSummary();
}

/*Product product1 = new Product("aaa", 30, 2);
Product product2 = new Product("xxx", 10, 3);
Product product3 = new Product("aaa", 45, 4);

Product[] products = { product1, product2, product3 };

for(int i=0;i<products.Length;i++)
{
    Console.WriteLine("Product Name:" + products[i].ProductName);
    Console.WriteLine("Price:" + products[i].Price);
    Console.WriteLine("Quantity:" + products[i].Quantity);
    Console.WriteLine("Total Value:" + products[i].ProductValue());

}*/