using Umbraco.Web.Mvc;
using System.Web.Mvc;
using System.Linq;
using UmbracoTeste.Models;
using System.Collections.Generic;

namespace UmbracoTeste.Controllers
{
    public class CompaniesSurfaceController : SurfaceController
    {

        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/List/";

        public ActionResult ListCompanies()
        {
            ViewBag.Title = "List Companies";
            List<Companies> companiesList;
            using (var context = new DatabaseEntities())
            {
                companiesList = context.Companies.ToList();
            }

            return PartialView(PARTIAL_VIEW_FOLDER + "_ListCompanies.cshtml", companiesList);
        }

        public ActionResult ListOffices()
        {
            ViewBag.Title = "List Offices";
            List<Offices> officesList;
            using (var context = new DatabaseEntities())
            {
                officesList = context.Offices.ToList();
            }

            return PartialView(PARTIAL_VIEW_FOLDER + "_ListOffices.cshtml", officesList);
        }

        public ActionResult ListEmployee()
        {
            ViewBag.Title = "List Employees";

            List<Employees> employeeList;
            using (var context = new DatabaseEntities())
            {
                employeeList = context.Employees.ToList();
            }

            return PartialView(PARTIAL_VIEW_FOLDER + "_ListEmployee.cshtml", employeeList);
        }
    }
}