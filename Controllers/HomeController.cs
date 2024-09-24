using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Selamlama = saat>12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul, Net Kongre Merkezi",
                Date = new DateTime(2024, 12,24,20,0,0),
                NumberOfPeople = UserCount
            };


            return View(meetingInfo);
        }

    }
}