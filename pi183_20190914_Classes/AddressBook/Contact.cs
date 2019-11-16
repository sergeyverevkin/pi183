using System;

namespace pi183_20190914_Classes.AddressBook
{
  /// <summary>
  /// Контакт адресной книги
  /// </summary>
  public class Contact
  {
    //Контакт
    //    - № телефона;
    //    - название;
    //    - дата рождения.
    #region variables
    /// <summary>
    /// № телефона
    /// </summary>
    public string PhoneNumber;
    /// <summary>
    /// название
    /// </summary>
    public string Title;
    /// <summary>
    /// дата рождения
    /// </summary>
    public DateTime BirthDate;
    #endregion

    #region constructors
    /// <summary>
    /// Создает экземпляр класса
    /// </summary>
    /// <param name="phoneNumber"></param>
    /// <param name="title"></param>
    public Contact(
      string phoneNumber,
      string title)
    {
      PhoneNumber = phoneNumber;
      Title = title;
    }
    #endregion
  }
}
