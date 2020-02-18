using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace PI183_Lab2_Classes.FieldEditor
{
  /// <summary>
  /// Схема кроссворда
  /// </summary>
  public class CSchema
  {
    #region public properties
    public List<Field> Fields { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    #endregion

    #region constructors

    public CSchema(int iWidth, int iHeight)
    {
      Fields = new List<Field>();
      Width = iWidth;
      Height = iHeight;
      h_Fill();
    }

    #endregion

    #region private methods

    private void h_Fill()
    {
      Fields.Clear();
      for (int ii = 0; ii < Width; ii++)
      {
        for (int jj = 0; jj < Height; jj++)
        {
          Fields.Add(new EmptyField(ii, jj));
        }
      }
    }
    #endregion


    #region public methods

    /// <summary>
    /// Получение объекта-клетки по координате
    /// </summary>
    /// <param name="ii"></param>
    /// <param name="jj"></param>
    /// <returns></returns>
    public Field Get(int ii, int jj)
    {
      foreach (Field p in Fields)
      {
        if (p.X == ii && p.Y == jj) return p;
      }

      return null;
    }


    public void Clear()
    {
      h_Fill();
    }

    public void Exchange(Field pF, Field pLetterField)
    {
      Fields.Remove(pF);
      Fields.Add(pLetterField);
    }

    public void Save(string sFileName)
    {
      // ../data/crossword.csv
      using (Stream pFile = File.Create(sFileName))
      using (StreamWriter pSw = new StreamWriter(pFile))
      {
        for (int ii = 0; ii < Height; ii++) {
          string sLine = String.Empty;
          for (int jj = 0; jj < Width; jj++) {
            Field p = Get(jj, ii);
            sLine += (p == null) ? "" : p.GetForFile();
            sLine += ";";
          }
          pSw.WriteLine(sLine);
        }
      }
    }


    public void Load(string sFileName)
    {
      Fields.Clear();
      string[] arLines = File.ReadAllLines(sFileName);

      var pEmptyField = new EmptyField(0, 0);
      var pLetterField = new LetterField(0, 0);
      var sEmpty = pEmptyField.GetForFile();
      var sLetter = pLetterField.GetForFile();

      for (int ii = 0; ii < arLines.Length; ii++) {
        string sLine = arLines[ii];
        string[] arCells = sLine.Split(new[] { ';' });
        for (int jj = 0; jj < arCells.Length; jj++) {
          if (arCells[jj] == sLetter) {
            var pF = new LetterField(jj, ii);
            Fields.Add(pF);
          }
          else { //if (arCells[jj] == sEmpty) {
            var pF = new EmptyField(jj, ii);
            Fields.Add(pF);
          }
        }
      }
    }
    #endregion
  }
}
