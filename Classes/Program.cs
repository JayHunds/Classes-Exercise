namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();

            mycar.Make = "Toyota";
            mycar.Model = "Tacoma";
            mycar.Year = 2006;

            Console.WriteLine("Make: " + mycar.Make);
            Console.WriteLine("Model: " + mycar.Model);
            Console.WriteLine("Year: " + mycar.Year);




        }
    }
}
