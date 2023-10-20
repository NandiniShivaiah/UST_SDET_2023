// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/

using Assignment1;


Student[] student = new Student[3];
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