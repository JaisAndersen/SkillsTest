using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        //Opgave 3:
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Adress {  get; private set; }
        public string Phone {  get; private set; }
        public string Email {  get; private set; }

        Dictionary<int, Booking> _bookinger;

        public GymHall(int iD, string name, string adress, string phone, string email)
        {
            ID = iD;
            Name = name;
            Adress = adress;
            Phone = phone;
            Email = email;
            _bookinger = new Dictionary<int, Booking>();
        }
        public override string ToString()
        {
            string result = $"ID:\t\t\t{ID}\nNavn:\t\t\t{Name}\nAdresse:\t\t{Adress}\nTelefon:\t\t{Phone}\nEmail:\t\t\t{Email}\n";
            //result += "\r\n";
            result += "bookinger:";
            result += "\n";
            foreach (Booking booking in _bookinger.Values)
            {
                result += booking;
            }
            return result;
        }
        
        //Opgave 4:
        public void RegisterBooking(Booking booking)
        {         
            _bookinger.Add(booking.ID, booking);       
        }
        public void PrintBooking()
        {
            foreach (Booking booking in _bookinger.Values)
            {
                Console.WriteLine(booking);
            }
        }
        public void RemoveBooking(Booking booking)
        {
            _bookinger.Remove(ID);
        }
    }
}
