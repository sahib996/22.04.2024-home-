using _22._04._2024_home_.Models;
using Newtonsoft.Json;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

/*namespace _22._04._2024_home*//*_*/
/*{
    internal class Program
    {
        static void Main(string[] args)
        {*/

            /*Directory.CreateDirectory(@"C:\Users\ADMIN\Desktop\Test1");*/
            /*if (Directory.Exists(@"C:\\Users\\ADMIN\\Desktop\\Test1"))
             {
                 Directory.Delete(@"C:\Users\ADMIN\Desktop\Test1"); 
             }*/
            /*File.Create(@"C:\Users\ADMIN\Desktop\Test1\text.txt").Close();*/
            /*File.Delete(@"C:\Users\ADMIN\Desktop\Test1\text.txt");*/

            /*if (!File.Exists(@"C:\Users\ADMIN\Desktop\Test1\text.txt")) 
            {
                
            }*/

            /*FileInfo file = new FileInfo(@"C:\Users\ADMIN\Desktop\Test1\text.txt");
            file.Create();
            file.Delete();
            File.Exists;

            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\ADMIN\Desktop\Test1\text.txt");*/

            /*StreamReader sr= new StreamReader(@"C:\Users\ADMIN\Desktop\Test1\text.txt");
            
            try
            {              
                int result=int.Parse(sr.ReadLine());
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }*/



            /* StreamWriter sw = new StreamWriter(@"C:\Users\ADMIN\Desktop\Test1\text.txt", true);
             sw.WriteLine("Murad");
             sw.WriteLine("Cavidan");
             sw.Close();*/

            /*using (StreamReader sr =new StreamReader(@"C:\Users\ADMIN\Desktop\Test1\text.txt"))
            {
                Console.WriteLine(sr.ReadLine());
            }
             using (StreamWriter sw=new StreamWriter(@"C:\Users\ADMIN\Desktop\Test1\text.txt"))
            {
                sw.WriteLine("Salam");
            }*/

            /* Category category = new Category { Name = "Mobile" };
             Product product = new Product { Id = 1, Name = "Iphone15", Price = 2000m, Category = category};
             Product product2 = new Product { Id = 1, Name = "SamsungS23", Price = 2400m, Category = category };
             Product product3 = new Product { Id = 1, Name = "Xiaomi poco 5x", Price = 1000m, Category = category };

             List<Product> products = new List<Product> { product, product2, product3 };*/

            /*string json=JsonConvert.SerializeObject(products);

            using (StreamWriter sw = new StreamWriter(@"C:\\Users\\ADMIN\\Desktop\\22.04.2024(home)\\Files\\Products.json")) 
            {
                sw.Write(json);
            }*/

           /* string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\ADMIN\Desktop\22.04.2024(home)\Files\Products.json"))
            {
                result=sr.ReadToEnd();
            }
            List<Product> objects=JsonConvert.DeserializeObject<List<Product>>(result);
        
            foreach(Product product in objects)
            {
                product.Price += 100;
                Console.WriteLine(product.Price) ;
            }
        
        }
    }
}
*/