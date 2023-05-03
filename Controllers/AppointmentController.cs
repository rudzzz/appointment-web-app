using AppointmentWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentWebApp.Controllers
{
    public class AppointmentController : Controller
    {
        public static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(AppointmentModel appointment)
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }
    }
}
