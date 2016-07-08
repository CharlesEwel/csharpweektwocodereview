using Nancy;
using System;
using RepeatCount.Objects;
using System.Collections.Generic;

namespace RepeatCount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/count_repeats"] = _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter();
        int repeats = newRepeatCounter.CountRepeats(Request.Form["search-string"], Request.Form["search-word"]);
        string repeatDisplay = newRepeatCounter.DisplayNumberOfRepeats(repeats);
        return View["result.cshtml", repeatDisplay];
      };
    }
  }
}
