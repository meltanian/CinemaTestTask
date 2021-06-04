using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.ModelsDB
{
    public class CinemaPlaces
    {
        public int ID { get; set; }

        public int HallID { get; set; }

        public int Row { get; set; }

        public int Col { get; set;}

        public int? Zone { get; set; }

        public string ZoneName { get; set; }

    }
}
