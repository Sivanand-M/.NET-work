using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLogicLibrary
{
    public enum SeatType
    {
        Recliner,
        Classic,
        Premium
    }
    public class Movie
    {
        public void BookTicket(string moviename)
        {
            Console.WriteLine($"Booking for {moviename}");
        }

        public void BookTicket(string moviename, int cnt)
        {
            Console.WriteLine($"Booking for {moviename} , {cnt} tickets");
        }

        public double BookTicket(string moviename, int cnt, SeatType seatType)
        {
            float price = 0;
            double totalAmt = 0;


            switch (seatType)
            {
                case SeatType.Recliner:
                    price = 1000;
                    totalAmt = price * cnt;
                    break;
                case SeatType.Classic:
                    price = 500;
                    totalAmt = price * cnt;
                    break;
                case SeatType.Premium:
                    price = 700;
                    totalAmt = price * cnt;
                    break;
                default:
                    break;
            }

            return totalAmt;
        }

    }
}
