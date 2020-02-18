using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI183_Lab2_Classes.FieldEditor
{
  /// <summary>
  /// Пустое поле
  /// </summary>
  public class EmptyField : Field
  {
    #region constructors

    public EmptyField(int iX, int iY) : base(iX, iY)
    {
    }

    #endregion
    public override string GetForFile()
    {
      return ".";
    }

  }

  /// <summary>
  /// Поле для заполнения буквой
  /// </summary>
  public class LetterField : Field
  {
    #region public properties

    /// <summary>
    /// Выбранная буква
    /// </summary>
    public char Symbol;
    /// <summary>
    /// Буква выбрана не точно 
    /// </summary>
    public bool IsDraft;
    

    #endregion

    #region constructors

    public LetterField(int iX, int iY): base(iX, iY)
    {
    }

    #endregion

    public override string GetForFile()
    {
      return "+";
    }
  }


  /// <summary>
  /// Поле кроссворда
  /// </summary>
  public class Field
  {
    #region public properties

    /// <summary>
    /// X
    /// </summary>
    public int X { get; set; }
    /// <summary>
    /// Y
    /// </summary>
    public int Y { get; set; }
    #endregion

    #region constructor

    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Field(int x, int y)
    {
      X = x;
      Y = y;
    }

    #endregion

    public virtual string GetForFile()
    {
      return "";
    }


  }
}
