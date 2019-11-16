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

 ПачкаКарт:
  - карты[]
  - перетасовать()

 КолодаКарт: пачкаКарт
  - тип колоды (игральная 36, таро, игральная 52)

  КартыНаСтоле: ПачкаКарт



 Карта:
  - масть
  - значение
  - тип рубашки


 * */

namespace pi183_20190914_Classes.PlayCard
{
  public class Card
  {
    public int cardType;
    public int cardValue;
    public int backType;
  }
}
