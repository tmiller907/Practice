using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Practice.Data; //imports and uses the data folder
using Practice.Models; //talks to the models folder

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private GameRepository _listOfGames = new GameRepository();    

        public IActionResult Index()   // This is an action function which matches up with the index page. It will return the "view" to the client.
        {

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Review()
        {
            ViewData["Message"] = "Your game review page.";

            return View();
        }


        public ActionResult GameReview(int? id)   //This will create either an error page, or a specific game page
        {
            if (id == null)
                return View("Error");      // "error" refers to the view "error" which gets returned in case of a null.

            var GameReview = _listOfGames.GetGameReview(id.Value); //sets the variable GameReview to be a value using "_listofclasses" in the "getWowClass" method using the "id.value" of the clicked object.

            if (GameReview == null)
            {
                return View("Error");
            }

            return View("Review", GameReview); //passes the "review" page and the variable "GameReview" to the view "class" then returns the information.
        }

        public IActionResult GameReviews() //this is the page with all the classes listed out. 
        {
            GameReview[][] gameReviews = _listOfGames.GetGameReviewsByThree(); //creates an instance of class "GameReview [][]" and sets the values in it to that of the list mentioned.

            return View(gameReviews); //passes the gameReview to the view "GameReviews" then displays to the client.
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
