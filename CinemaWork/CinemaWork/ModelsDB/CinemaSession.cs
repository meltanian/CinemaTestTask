using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.ModelsDB
{
    public class CinemaSession
    {
        public int ID { get; set; }

        public int CinemaID { get; set; }

        public int CinemaHallID { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

    }
}
