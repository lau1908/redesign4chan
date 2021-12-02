using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redesign4chan.Controllers
{
    public class HomeController : Controller
    {
        ny4chanEntities databaseManager = new ny4chanEntities();//jeg erklærer en entiti af min database til objektet "databaseManager"

        public ActionResult Index()//dette kode bliver kørt når brugern åbner indexsiden
        {
            List<Board> board = databaseManager.Boards.ToList(); //her erklære jeg en liste som indeholder mine boards fra databasen og ligger dem i variablen "board"

            return View(board);//jeg retunere "board" variablen sammen med view til indexsiden
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
