using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers 
{
public class HomeController : Controller 
{
  [Route("/hello")]
  public string Hello() { return "Hello friend!";}
  [Route("/goodbye")]
  public string Goodbye() { return "Goodbye friend.";}

  [Route("/")]
  public ActionResult Letter() 
  {
    LetterVariable myLetterVariable = new LetterVariable();
    myLetterVariable.Recipient = "Lima";
    myLetterVariable.Sender = "Jasmine";
    myLetterVariable.Location = "Paris";
    myLetterVariable.Souvenir = "Bracelet";
    return View( myLetterVariable);
    }
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.Souvenir = souvenir;


      return View(myLetterVariable);
    }

  }
}
