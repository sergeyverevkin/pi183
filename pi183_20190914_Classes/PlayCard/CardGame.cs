using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Игра:
  - ПачкаКарт;
  - КартыНаСтоле;
  - выложитьКарту().
 */

namespace pi183_20190914_Classes.PlayCard
{
  /// <summary>
  /// Игра
  /// </summary>
  public class CardGame
  {
    /// <summary>
    /// ПачкаКарт
    /// </summary>
    public TableCardBatch tableCardBatch;
    /// <summary>
    /// КартыНаСтоле
    /// </summary>
    public SimpleCardBatch simpleCardBatch;

    public CardGame(int iBatchType)
    {
      simpleCardBatch = new SimpleCardBatch(iBatchType);
      tableCardBatch = new TableCardBatch();
    }
  }
}
