#region usings
using System;
using System.Collections;
using System.Collections.Generic;
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
    private static void Main(string[] args)
    {
      #region console
      h_PrintString();
      #endregion

      // h_ControlStructures();

      // h_DemoStaticArrays();
      // h_DemoDynamicArrayList();
      // h_DemoList();
      // h_DemoDictionary();

      h_DemoWordsDictionary();

      Console.ReadKey();
    }

    private static void h_DemoWordsDictionary()
    {
      
    }

    private static void h_DemoDictionary()
    {
      Dictionary<
        /*TKey:*/ string,
        /*TValue:*/ string>
        arDictionary =
        new Dictionary<string, string>();

      arDictionary["this"] = "это";
      arDictionary["that"] = "то";
      arDictionary["those"] = "те";
      arDictionary["these"] = "эти";

      string sText = "These objectives are important to those persons";
      string[] arText =
        sText.Split(
          new[] { ',', '.', ' ', ';' },
          StringSplitOptions.RemoveEmptyEntries);
      for (int ii = 0; ii < arText.Length; ii++) {
        string sOutWord = arText[ii];
        string sLowerWord = sOutWord.ToLower();
        if (arDictionary.ContainsKey(sLowerWord)) {
          sOutWord = arDictionary[sLowerWord];
        }
        Console.Write(sOutWord + " ");
      }

      Dictionary<int, int> arDictionary2 =
        new Dictionary<int, int>();
      for (int ii = 1; ii <= 10; ii++) {
        arDictionary2[ii] = 100;
        // arDictionary2[ii] = 200;
        arDictionary2.Add(ii * 10, 100);
      }
      // arDictionary2.Clear();
      // arDictionary2.Remove(20);


      Dictionary<int, int>.KeyCollection arKeys =
        arDictionary2.Keys;
      // arDictionary2.Values
      foreach (int ii in arKeys) {
        Console.WriteLine(arDictionary2[ii]);
      }

    }

    private static void h_DemoList()
    {
      // 3# типизированные динамические массивы
      List<int> arList = new List<int>();
      arList.Add(1);
      arList.Add(2);
      arList.Add(56);

      int iSum = 0;
      for (int ii = 0; ii < arList.Count; ii++) {
        int iValue = arList[ii];
        iSum += iValue;
      }
      double dAvg = iSum / arList.Count;
      Console.WriteLine(dAvg);
    }

    private static void h_DemoDynamicArrayList()
    {
      // 2# Динамический нетипизированный массив
      ArrayList arList;
      arList = new ArrayList();
      arList.Add(1);
      arList.Add(2);
      arList.Insert(0, 10);
      arList.RemoveAt(0);
      arList.Add("55)");
      arList.Add(56);
      arList.Remove("55)");

      int iSum = 0;
      int iCount = 0;
      for (int ii = 0; ii < arList.Count; ii++) {
        if (!(arList[ii] is int)) {
          continue;
        }
        int iValue = (int)arList[ii];
        iSum += iValue;
        iCount++;
      }
      double dAvg = iSum / iCount;
      Console.WriteLine(dAvg);
    }

    private static void h_DemoStaticArrays()
    {
      // #1. статические массивы
      int[] arInts1 =
        new int[] { 1, 2, 3, 45 };
      int[] arInts2 =
        new int[4] { 1, 2, 3, 45 };
      int[] arInts3 =
        new int[4];
      // [0; n-1]
      for (
        int ii = 0;
        ii < arInts1.Length;
        ii++) {
        Console.WriteLine(arInts1[ii]);
      }

      // Console.WriteLine(default(int));
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
        int ii = 0;   // 1# init
        ii < iCount;  // 2# check condition
        ii++          // 3# after action
      ) { // 4#
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
      while (jj < 10) {
        Console.WriteLine(jj++);
      }

      jj = 0;
      do {
        Console.WriteLine(jj++);
      }
      while (jj < 10);

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

