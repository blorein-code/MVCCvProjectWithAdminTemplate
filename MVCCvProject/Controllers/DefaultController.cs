using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCvProject.Models.Entity;

namespace MVCCvProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var information = db.InformationTable.ToList();
            return View(information);
        }


        public PartialViewResult Experience()
        {
            var experience = db.ExperienceTable.ToList();
            return PartialView(experience);
        }

        public PartialViewResult Education()
        {
            var education = db.EducationTable.ToList();
            return PartialView(education);
        }

        public PartialViewResult Certificate()
        {
            var certificate = db.CertificateTable.ToList();
            return PartialView(certificate);
        }
    }
}