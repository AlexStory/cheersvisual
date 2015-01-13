using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers {
  class Program {
    static void Main(string[] args) {
      System.Console.WriteLine("Hello World!");
      System.Console.WriteLine("What is your name?");
      System.Text.StringBuilder name = new System.Text.StringBuilder(System.Console.ReadLine());
      System.Console.WriteLine("Welcome, " + name);

      for (int i = 0; i < name.Length; i++) {
        string article = "an";
        if ("halfnorsemix".IndexOf(System.Char.ToLower(name[i])) == -1) {
          article = "a";
        }
          System.Console.WriteLine("Give me " + article + "..." + System.Char.ToLower(name[i]));
      }
      System.Console.WriteLine(name + "  is Grand!");
      System.Console.WriteLine("When is your birthday?");
      string birthday = System.Console.ReadLine();

      DateTime bdayTime = DateTime.Parse(birthday);
      DateTime now = DateTime.Today;
      TimeSpan difference = bdayTime.Subtract(now);
      

      if(bdayTime.Add(TimeSpan.Parse("14")) > now && now > bdayTime ){
        System.Console.WriteLine("We missed it! Your birthday was " + -difference.Days + " days ago");
      }
      else
      {
        System.Console.WriteLine("Cool! your birthday is in "  + difference.Days + " days!");
      }
      System.Console.WriteLine("Press Any Key To Exit");
      System.Console.ReadKey();
    }
  }
}
