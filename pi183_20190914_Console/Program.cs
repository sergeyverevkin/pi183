using System;

namespace pi183_20190914_Console
{
  class Program
  {
    static void Main(String[] args)
    {
      h_PrintString();
      // string sString = String.Empty;
      Console.ReadKey();
    }

    private static void h_PrintString()
    {
      // ...
      /*
       ...
       ...
       */
      int i1 = 1;
      string sT = "Gdsf";
      char ch = 'F';
      DateTime dt = DateTime.Now;
      DateTime dt2 = dt.AddYears(1);


      Int32 iMax = 5;
      iMax = iMax + 1;
      Console.WriteLine("Печать произвольной строки. Нажмите любую клавишу");
    }
  }
}
