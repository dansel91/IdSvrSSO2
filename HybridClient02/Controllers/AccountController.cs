using System.Web;
using System.Web.Mvc;

namespace HybridClient02.Controllers
{
    //If not logged in, this authorize attribute causes a 401 (Unauthorized) 
    //which the middleware will detect and 302 (Found) redirect to the IdentityServer login page.
    public class AccountController : Controller
    {
        [Authorize]
        public ActionResult SignIn()
        {
            return this.Redirect("/");
        }

        public ActionResult SignOut()
        {
            this.Request.GetOwinContext().Authentication.SignOut();
            return this.Redirect("/");
        }
    }
}