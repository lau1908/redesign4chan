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
        public ActionResult Show(int id)//bliver kørt når en bruger har trykket på et board på indexsiden
        {
            //Debug.WriteLine(id);
            Board board = databaseManager.Boards.SingleOrDefault(x => x.Board_ID == id);//denne linje kode gennemgår databasen for at finde informationerne omkring det board med den id som brugeren har trykket på
            return View(board);//jeg retunere et view med variablen "board" som argument til showsiden
        }
    }
}