using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "this is my <b>default</b> 动作";
        }
        //Get: HelloWorld/Welcome
        public string Welcome(string name, int ID)
        {
            return HttpUtility.HtmlEncode(" 好吧，" + name + "你抓到我了" + ID);
        }
    }
}