using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi183_20190914_Classes.PlayCard
{
  /// <summary>
  /// КолодаКарт
  /// </summary>
  public class SimpleCardBatch: CardBatch
  {
    /// <summary>
    ///   - тип колоды (игральная 36, таро, игральная 52)
    /// </summary>
    public int BatchType;

    public SimpleCardBatch(int iBatchType)
    {
      // TODO: заполнение картами в зависимости от типа колоды
      CardList.Add(new Card() { backType = 1, cardType = 1, cardValue = 6});
    }
  }
}
