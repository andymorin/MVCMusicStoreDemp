using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from Store.Index()";
        }

        public string Browse(string genre)
        {
            //return "Hello from Store.Browse()";
            string Message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return Message;
        }

        public string Details(int id)
        {

              // return "Hello from Store.Details()";
            string Message = "Store.Details, ID = " + id;
            return Message;
        }

    }
}
