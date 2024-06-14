namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 2:");
            
            Booking b1 = new Booking(1, new DateTime(2024, 6, 14, 14, 0, 0), new DateTime(2024, 6, 14, 16, 0, 0), 14);
            Booking b2 = new Booking(1, new DateTime(2024, 6, 15, 14, 0, 0), new DateTime(2024, 6, 15, 16, 0, 0), 14);
            Booking b3 = new Booking(1, new DateTime(2024, 6, 14, 10, 0, 0), new DateTime(2024, 6, 14, 12, 0, 0), 14);
            Booking b4 = new Booking(1, new DateTime(2024, 6, 20, 12, 0, 0), new DateTime(2024, 6, 20, 14, 0, 0), 14);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
            Console.ReadKey();
            Console.Clear();


            

        }
    }
}
