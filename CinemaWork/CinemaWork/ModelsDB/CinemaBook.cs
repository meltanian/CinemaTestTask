using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.ModelsDB
{
    public class CinemaBook
    {
        public int Id { get; set; }
        public  int PlaceID  { get; set; }
        public int SessionID { get; set; }
        public decimal Price { get; set; }
        public bool Booked { get; set; }
        public bool Reserved { get; set; }
    }
}
