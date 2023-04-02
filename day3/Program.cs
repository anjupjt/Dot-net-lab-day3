using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //try//exception handling
          //  {
          //      Console.WriteLine("enter a number");
          //      string givenString=Console.ReadLine();
          //      int myNmuber=Convert.ToInt32(givenString);
          //      Console.WriteLine(myNmuber);
          //      string[] names = new string[3];
          //      names[0] = "Bilapa";
          //      names[1] = "Anju";
          //      names[2] = "Astik";
          //      //names[3] = "Ranju";
          //      foreach (string item in names)
          //      {
          //          Console.WriteLine(item);
          //      }
          //   }
          //   catch(InsufficientMemoryException ex)
          //  {
          //      Console.WriteLine(ex.Message);
          //  }
          //  catch(Exception ex)
          //  {
          //      Console.WriteLine(ex.Message);
          //  }
          Cow cow=new Cow();
            cow.WhatIeat();
            cow.WhatIeat("straw");
            cow.WhatIeat("straw", "grass");
            Console.ReadKey();
        }
    }
}
