using Microsoft.AspNetCore.Mvc;
using Task1MVC.Models;

namespace Task1MVC.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult BookAppointment()
        {
            SampleDataDoctor sample=new SampleDataDoctor();
            var result=sample.doctors.ToList();
            return View(result);
        }

        public ActionResult CompleteAppointment(int id)
        {
            SampleDataDoctor sample = new SampleDataDoctor();
            var result = sample.doctors.Find(e=>e.Id ==id);
            return View(result);
        }
        //Name.Equals(name)

    }
}
