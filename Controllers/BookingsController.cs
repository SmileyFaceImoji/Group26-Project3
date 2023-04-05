using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GRP26Project.Models;

namespace GRP26Project.Controllers
{
    public class BookingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult GetDates(DateTime? checkin, DateTime? checkout)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Availability()
        {
            var checkin = Request.QueryString["checkin"];
            var checkout = Request.QueryString["checkout"];

            ViewBag.Checkin = checkin;
            ViewBag.Checkout = checkout;

            ////from here we are querying all the available rooms based on the dates inputted

            //var dbContext = new ApplicationDbContext();
            //var rooms = dbContext.Rooms.ToList();
            //// Query the database for available rooms
            //var availableRooms = dbContext.Rooms.Where(r => r.IsAvailable).ToList();

            //// Query the database for available rooms based on checkin and checkout dates
            //var checkinDate = DateTime.Now.AddDays(1);
            //var checkoutDate = DateTime.Now.AddDays(3);
            //var availableRooms = dbContext.Rooms
            //    .Where(r => r.IsAvailable && !r.Bookings.Any(b =>
            //        (checkinDate >= b.CheckinDate && checkinDate < b.CheckoutDate) ||
            //        (checkoutDate > b.CheckinDate && checkoutDate <= b.CheckoutDate)))
            //    .ToList();

            ////this is dapper code, it is faster then linq(circle back to using it when you have time)
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    var result = connection.Query<Room>("SELECT * FROM MyTable WHERE SomeColumn = @param", new { param = "value" });
            //}


            //ViewBag.Checkin = checkin;
            //ViewBag.Checkout = checkout;

            return View();
        }


        //////CRUD Operations.(Ignore)
        //// GET: Bookings
        //public ActionResult Index()
        //{
        //    return View(db.Bookings.ToList());
        //}

        //// GET: Bookings/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Booking booking = db.Bookings.Find(id);
        //    if (booking == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(booking);
        //}

        //// GET: Bookings/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Bookings/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "BookingID,CheckIN,CheckOUT")] Booking booking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Bookings.Add(booking);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(booking);
        //}

        //// GET: Bookings/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Booking booking = db.Bookings.Find(id);
        //    if (booking == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(booking);
        //}

        //// POST: Bookings/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "BookingID,CheckIN,CheckOUT")] Booking booking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(booking).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(booking);
        //}

        //// GET: Bookings/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Booking booking = db.Bookings.Find(id);
        //    if (booking == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(booking);
        //}

        //// POST: Bookings/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Booking booking = db.Bookings.Find(id);
        //    db.Bookings.Remove(booking);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
