using Umbraco.Web.Mvc;
using System.Web.Mvc;
using UmbracoTeste.Models;

namespace UmbracoTeste.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Contact/";

        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Contact.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(ContactModel model)
        {
            if(ModelState.IsValid)
            {
                TempData["ContactSuccess"] = true;
                return RedirectToCurrentUmbracoPage();
            }
            else
                return CurrentUmbracoPage();
        }
    }
}