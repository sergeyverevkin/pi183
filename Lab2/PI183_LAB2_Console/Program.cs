using System;
using System.Threading;
using PI183_Lab2_Classes.DrinkRef;

namespace PI183_LAB2_Console
{
  class Program
  {
    private static int global = 0;

    static void Main(string[] args)
    {
      /*
      Drink pD1 = new Drink("Молоко", EDrinkType.ForKid);
      Drink pD2 = new Drink("Кефир", EDrinkType.Alcoholic);
      h_WriteInfoAboutDrink(pD1);
      h_WriteInfoAboutDrink(pD2);
      */
      h_ThreadTest();
      Console.ReadKey();

    }

    private static void h_ThreadTest()
    {
      Console.WriteLine("begin" + DateTime.Now);
      Thread pThread1 = new Thread(h_Go);
      pThread1.Name = "test1";
      Thread pThread2 = new Thread(h_Go);
      pThread2.Name = "test2";
      pThread1.Start(DateTime.Now);
      pThread2.Start(DateTime.Now);
      Console.WriteLine("before start");
      Console.WriteLine("after start");
      // pThread.Abort();
      // pThread.Join();
    }

    private static void h_Go(object obj)
    {
      Thread.Sleep(100);
      for (int ii = 0; ii < 10; ii++)
      {
        global++;
        Console.WriteLine(Thread.CurrentThread.Name + " / ok: " + obj.ToString() + ": " + ii + " / " + global);
      }
    }

    private static void h_WriteInfoAboutDrink(Drink pD)
    {
      Console.WriteLine($"{pD.Title} / {pD.DrinkType}");
    }
  }
}
