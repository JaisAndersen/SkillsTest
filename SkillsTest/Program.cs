namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 2:\n");
            
            Booking b1 = new Booking(1, new DateTime(2024, 6, 14, 14, 0, 0), new DateTime(2024, 6, 14, 16, 0, 0), 14);
            Booking b2 = new Booking(2, new DateTime(2024, 6, 15, 14, 0, 0), new DateTime(2024, 6, 15, 16, 0, 0), 14);
            Booking b3 = new Booking(3, new DateTime(2024, 6, 14, 10, 0, 0), new DateTime(2024, 6, 14, 12, 0, 0), 14);
            Booking b4 = new Booking(4, new DateTime(2024, 6, 20, 12, 0, 0), new DateTime(2024, 6, 20, 14, 0, 0), 14);

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
            Console.WriteLine("\nTryk en knap for næste opgave.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Opgave 3:\n");
            GymHall g1 = new GymHall(1, "Lille Hal", "Hal Vej 1", "0045 12345678", "hal1@hal.dk");
            GymHall g2 = new GymHall(2, "Store Hal", "Hal Vej 2", "0045 87654321", "hal2@hal.dk");

            Console.WriteLine(g1);
            Console.WriteLine(g2);
            
            Console.WriteLine("\nTryk en knap for næste opgave.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Opgave 4:\n");
            Console.WriteLine("Registrerer og udskriver bookninger:\n");
            g1.RegisterBooking(b1);
            g2.RegisterBooking(b2);
            g1.RegisterBooking(b3);
            g2.RegisterBooking(b4);

            g1.PrintBooking();
            g2.PrintBooking();

            Console.WriteLine("Sletter 2 bookninger og udskriver igen:\n");
            g1.RemoveBooking(b1);
            g2.RemoveBooking(b3);

            g1.PrintBooking();
            g2.PrintBooking();

            Console.WriteLine("\nTryk en knap for næste opgave.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Opgave 6:\n");
            Console.WriteLine("Tester bool og udskriver:\n");
            Booking toLong = new Booking(5, new DateTime(2024, 6, 14, 10, 0, 0), new DateTime(2024, 6, 14, 16, 0, 0), 15);
            Console.WriteLine($"Booking: {toLong.ID} - Er OK: {toLong.BookingDurationOK}");
            Console.WriteLine($"Booking: {b1.ID} - Er OK: {b1.BookingDurationOK}");

            Console.WriteLine("\nTryk en knap for næste opgave.");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
