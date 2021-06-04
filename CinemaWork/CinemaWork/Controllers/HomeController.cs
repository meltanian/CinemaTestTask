using CinemaWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OpenHall(int hallId)
        {
            var hall = DBWoker.DBWoker.GetHallByID(hallId);
            var sessions = DBWoker.DBWoker.GetSessionByHallID(hallId);
            return View("Hall", new Tuple<ModelsDB.CinemaHall, List<ModelsDB.CinemaSession>>(hall, sessions));
        }

        [HttpPost]
        public IActionResult OpenSession(int sessionId)
        {
            var session = DBWoker.DBWoker.GetSessionByID(sessionId);
            var hall = DBWoker.DBWoker.GetHallByID(session.CinemaHallID);
            var places = DBWoker.DBWoker.GetPlacesByHallID(session.CinemaHallID);
            return View("Session", new Tuple<ModelsDB.CinemaSession, ModelsDB.CinemaHall,
                List<ModelsDB.CinemaPlaces>>(session, hall, places));
        }

        [HttpPost]
        public IActionResult BookPlace(int hallId, int sessionId, int placeIdBook = -1, int placeIdRelease = -1)
        {
            if (placeIdBook > 0)
            { DBWoker.DBWoker.BookPlace(placeIdBook, sessionId); }
            if(placeIdRelease > 0)
            { DBWoker.DBWoker.ReleasePlace(placeIdRelease, sessionId); }
            //
            var session = DBWoker.DBWoker.GetSessionByID(sessionId);
            var hall = DBWoker.DBWoker.GetHallByID(session.CinemaHallID);
            var places = DBWoker.DBWoker.GetPlacesByHallID(session.CinemaHallID);
            return View("Session", new Tuple<ModelsDB.CinemaSession, ModelsDB.CinemaHall,
                List<ModelsDB.CinemaPlaces>>(session, hall, places));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
