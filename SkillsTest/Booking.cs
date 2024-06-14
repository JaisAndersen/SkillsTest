using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Booking
    {
        public int ID { get; private set; }
        public DateTime Start {  get; private set; }
        public DateTime End { get; private set; }
        public int Participants {  get; private set; }

        public Booking(int iD, DateTime start, DateTime end, int participants)
        {
            ID = iD;
            Start = start;
            End = end;
            Participants = participants;
        }

        public override string ToString()
        {
            return $"Booking ID:\t\t{ID}\nStart tidspunkt:\t{Start}\nSlut tidspunkt:\t\t{End}\nAntal deltagere:\t{Participants}\n";
        }
    }
}
