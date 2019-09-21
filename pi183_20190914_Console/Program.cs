#region usings
using System;
#endregion

namespace pi183_20190914_Console
{
  /// <summary>
  /// Класс программы
  /// </summary>
  internal class Program
  {
    /// <summary>
    /// Метод - единая точка входа в приложение
    /// </summary>
    /// <param name="args">входные параметры командной строки</param>
    private static void Main(String[] args)
    {
      #region console
      h_PrintString();
      #endregion

      h_ControlStructures();

    }

    private static int h_ControlStructures()
    {
      /*
      #region if else
      // =    assign
      // ==   whether equals
      // !=   not equals
      // ||   OR
      // &&   AND
      // %    mod
      // ++VAR  pred-increment : VAR = VAR + 1; 
      // VAR++  post-increment
      // --VAR  pred-decrement : VAR = VAR - 1;
      // VAR--  post-decrement

      int iM1 = 10;
      int iM2 = 20;
      if (
        (iM1 == 10) ||
        (iM1 % 2 == 1)
        ) {
        Console.WriteLine(iM1);
      }
      else if (iM1 != 20) {
        Console.WriteLine(iM2);
      }

      // Math.Round(1.23);
      #endregion

      #region ?:
      int iMM = 1;
      //if (iMM % 2 == 1) {
      //  return 1;
      //} else {
      //  return iMM;
      //}

      return
        (
          (iMM % 2 == 1)
          ? 1     // true
          : iMM   // false
        );


      #endregion
      */

      #region for, break, continue
      int iCount = 10;
      int jj = 0;
      for (
        int ii = 0;   // init
        ii < iCount;  // check condition
        ii++          // after action
      ) {
        Console.WriteLine(jj++);
      }

      for (
        ;   // init
        ;   // check condition
            // after action
      ) {
        if (jj > 10) {
          // прекратить и выйти из цикла
          break;
        }
        if (jj == 1) {
          // прекратить и перейти к следующей итерации
          continue;
        }
        Console.WriteLine(jj++);
      }
      #endregion

      #region while
      jj = 0;
      while(jj < 10) {
        Console.WriteLine(jj++);
      }
      #endregion
      /*
       Задание: 
        Запрос нажатия клавиши
        Зафиксировать время1 нажатия на клавишу
        Запрос нажатия клавиши
        Зафиксировать время2 нажатия на клавишу
        Если секунды время1 % 10 == секунды время2 % 10, 
          то поздравить пользователя
        Запрос нажатия клавиши
        
        https://github.com/sergeyverevkin/pi183
       */


      return 0;
    }

    /// <summary>
    /// Работа с консолью
    /// </summary>
    private static void h_PrintString()
    {
      #region comments
      // ...
      /*
       ...
       ...
       */

      #endregion

      // System.Object p = null;

      int i1 = 10;
      int i2 = 1;
      string sT = null;// "Gdsf";
      char ch = 'F';
      System.DateTime dt = System.DateTime.Now;
      System.DateTime dt2 = dt.AddYears(1);


      System.Int32 iMax = 5 + i1;
      iMax = iMax + 1;
      Console.WriteLine("Печать произвольной строки. Нажмите любую клавишу");
      string sString = String.Empty;
      if (String.IsNullOrEmpty(sString)) {
        Console.WriteLine("Печать произвольной строки....");
      }
      Console.ReadKey();
    }
  }
}

