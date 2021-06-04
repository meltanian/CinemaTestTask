using CinemaWork.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork
{
    public static class Globals
    {
        public static Cinema SelectedCinema { get; set; }
        static Globals()
        {
            SelectedCinema = DBWoker.DBWoker.GetCinemaByName(Configurations.ConfigHelper.CimenaName);
        }
    }
}
