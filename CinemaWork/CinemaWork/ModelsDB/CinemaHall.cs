using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.ModelsDB
{
    public class CinemaHall
    {
        public int ID { get; set; }
        public int CinemaID { get; set; }
        public string HallName { get; set; }
        public int HallNumber { get; set; }
    }
}
