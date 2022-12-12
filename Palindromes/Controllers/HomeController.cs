using Microsoft.AspNetCore.Mvc;
using Palindromes.Models;

namespace Palindromes.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/result")]
    public ActionResult Result(string input)
    {
      PalChecker palchecker = new PalChecker();
      palchecker.IsItAPalindrome(input);
      return View(palchecker);
    }

  }
}