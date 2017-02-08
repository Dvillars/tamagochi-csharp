using Nancy;
using System.Collections.Generic;
using TamagochiFarm.Objects;

namespace TamagochiFarm
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/feed"] = _ =>
      {
        int petId = Request.Form["feed-button"];
        var currentGochi = Tamagochi.GetTamagochis().Find(item => item.GetId() == petId);
        currentGochi.IncrementFood();
        currentGochi.Decrement();
        return View["pet-page.cshtml", Tamagochi.GetTamagochis()];
      };

      Post["/play"] = _ =>
      {
        int petId = Request.Form["play-button"];
        var currentGochi = Tamagochi.GetTamagochis().Find(item => item.GetId() == petId);
        currentGochi.IncrementHappiness();
        currentGochi.Decrement();
        return View["pet-page.cshtml", Tamagochi.GetTamagochis()];
      };

      Post["/sleep"] = _ =>
      {
        int petId = Request.Form["sleep-button"];
        var currentGochi = Tamagochi.GetTamagochis().Find(item => item.GetId() == petId);
        currentGochi.IncrementWakefullness();
        currentGochi.Decrement();
        return View["pet-page.cshtml", Tamagochi.GetTamagochis()];
      };

      Post["/create-tamagochi"] = _ =>
      {
        string name = Request.Form["name"];
        Tamagochi newTamagochi = new Tamagochi(name, 10, 10, 10);
        return View["pet-page.cshtml", Tamagochi.GetTamagochis()];
      };
      Post["/"] = _ =>
      {
        Tamagochi.ClearTamagochiList();
        return View["index.cshtml"];
      };
    }
  }
}
