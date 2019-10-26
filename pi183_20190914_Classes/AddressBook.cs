﻿using System.Collections.Generic;

namespace pi183_20190914_Classes
{
  /// <summary>
  /// Адресная книга
  /// </summary>
  public class AddressBook
  {
    //Телефонная книга
    //    - идентификатор владельца
    //    - тип телефонной книги
    //        (мобильный / книга / тетрадь)
    //    - контакт[]
    #region variables
    public string OwnerIdentifier;
    // TODO: enum
    public int AddressBookType;
    public List<Contact> ContactList;
    #endregion

    #region constructor
    /// <summary>
    /// Создает экземпляр класса
    /// </summary>
    public AddressBook(
      string sOwnerIdentifier, 
      int iType) 
    {
      OwnerIdentifier = sOwnerIdentifier;
      AddressBookType = iType;
      ContactList = new List<Contact>();
    }
    #endregion

  }
}
