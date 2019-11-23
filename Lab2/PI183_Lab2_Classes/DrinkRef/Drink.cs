using System.Collections.Generic;

namespace PI183_Lab2_Classes.DrinkRef
{
  /// <summary>
  /// Напиток
  /// </summary>
  public class Drink
  {
    #region properties

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    ///     Ингридиент[]
    /// </summary>
    public List<Ingridient> IngridientList { get; private set; }

    /// <summary>
    /// Тип(1 = детский/ 2 = безалкогольный/ 3 = алкогольный)
    /// </summary>
    public int DrinkType { get; set; }

    #endregion


    #region constructors

    public Drink(string title, int drinkType)
    {
      Title = title;
      DrinkType = drinkType;
      IngridientList =  new List<Ingridient>();
    }
    
    #endregion

    /// <summary>
    /// Есть ли заданный ингридент в напитке
    /// </summary>
    /// <param name="pIngridient"></param>
    /// <returns></returns>
    public bool HasIngridient(Ingridient pIngridient)
    {
      foreach (Ingridient pCurIngridient in IngridientList)
      {
        if (pCurIngridient.Title.Equals(pIngridient))
        {
          return true;
        }
      }

      return false;
    }

  }
}