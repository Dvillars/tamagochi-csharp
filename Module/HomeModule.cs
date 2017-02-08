using Nancy;
using System.Collections.Generic;
using Tamagochi.Objects;

namespace Tamagochi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/create-tamagochi"] = _ =>
      {
        string name = Request.Form["name"];
        Tamagochi newTamagochi = new Tamagochi(name, 10, 10, 10);
        return View["pet-page.cshtml", newTamagochi];
      };
    }
  }
}
