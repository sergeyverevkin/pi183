using System;
using PI183_Lab2_Classes.DrinkRef;

namespace PI183_LAB2_Console
{
  class Program
  {
    static void Main(string[] args)
    {
      Drink pD1 = new Drink("Молоко", 1);
      Drink pD2 = new Drink("Кефир", 3);
      h_WriteInfoAboutDrink(pD1);
      h_WriteInfoAboutDrink(pD2);
    }

    private static void h_WriteInfoAboutDrink(Drink pD)
    {
      Console.WriteLine($"{pD.Title} / {pD.DrinkType}");
    }
  }
}
