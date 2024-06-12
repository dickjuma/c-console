namespace ConsoleApp9
{
  


    public class Product
    {
        public double price;
        public int quantity;
        public string name;
     
        void printProduct()
            {

                Console.WriteLine("Enter The Price");
                double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Quantity");
                int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of the product");
                Console.ReadLine();
              
            }

            
        }
    }  

