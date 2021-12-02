using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace redesign4chan.Controllers
{
    public class BoardController : Controller
    {
        ny4chanEntities databaseManager = new ny4chanEntities();//jeg erklærer en entiti af min database til objektet "databaseManager"
        // GET: Board
        public ActionResult Show(int id)//
        {
            //Debug.WriteLine(id);
            Board board = databaseManager.Boards.SingleOrDefault(x => x.Board_ID == id);//
            return View(board);//jeg retunere et view med variablen "board" som argument til showsiden
        }
    }
}