// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/

using Assignment1;


Circle circle = new Circle(3.0);
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