using CinemaWork.DBContext;
using CinemaWork.ModelsDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWork.DBWoker
{
    public static class DBWoker
    {
        public static void BookPlace(int placeId, int sessionId)
        {
            var dbContex = new CinemaDBContext();
            var place = dbContex.CinemaBook.Where(a => a.PlaceID == placeId && a.SessionID == sessionId).FirstOrDefault();
            place.Booked = true;
            dbContex.SaveChanges();
        }

        public static void ReleasePlace(int placeId, int sessionId)
        {
            var dbContex = new CinemaDBContext();
            var place = dbContex.CinemaBook.Where(a => a.PlaceID == placeId && a.SessionID == sessionId).FirstOrDefault();
            place.Booked = false;
            dbContex.SaveChanges();
        }

        public static Cinema GetCinemaByName(string name)
        {
            var dbContex = new CinemaDBContext();
            var cinema = dbContex.CinemaList.Where(a => a.Name == name).FirstOrDefault();
            return cinema;
        }

        public static List<CinemaHall> GetHallsByCinemaID(int cinemaId)
        {
            var dbContex = new CinemaDBContext();
            var halls = dbContex.CinemaHall.Where(a => a.CinemaID == cinemaId);
            return halls.ToList();
        }

        public static CinemaHall GetHallByID(int hallId)
        {
            var dbContex = new CinemaDBContext();
            var hall = dbContex.CinemaHall.Where(a => a.ID == hallId).FirstOrDefault();
            return hall;
        }

        public static List<CinemaSession> GetSessionByHallID(int hallId)
        {
            var dbContex = new CinemaDBContext();
            var sessions = dbContex.CinemaSession.Where(a => a.CinemaHallID == hallId);
            return sessions.ToList();
        }

        public static CinemaSession GetSessionByID(int sessionId)
        {
            var dbContex = new CinemaDBContext();
            var session = dbContex.CinemaSession.Where(a => a.ID == sessionId).FirstOrDefault();
            return session;
        }

        public static List<CinemaBook> GetBookedBySEssionID(int sessionId)
        {
            var dbContex = new CinemaDBContext();
            var booked = dbContex.CinemaBook.Where(a => a.SessionID == sessionId);
            return booked.ToList();
        }

        public static List<CinemaPlaces> GetPlacesByHallID(int hallId)
        {
            var dbContex = new CinemaDBContext();
            var places = dbContex.CinemaPlaces.Where(a => a.HallID == hallId);
            return places.ToList();
        }
    }
}