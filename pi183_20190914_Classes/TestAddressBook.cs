using System;

namespace pi183_20190914_Classes
{
  /// <summary>
  /// Контакт адресной книги
  /// </summary>
  public class TestAddressBook: AddressBook
  {
    #region constructors
    /// <summary>
    /// Создает экземпляр класса
    /// </summary>
    public TestAddressBook():
      base("mine", 1)
    {
      h_TestFill();
    }
    #endregion
   
    #region private methods
    private void h_TestFill()
    {
      // 2. Заполним ее
      Contact pContact1 = new Contact(
        "+79130001234", "Мой первый номер");
      Contact pContact2 = new Contact(
        "+79130004231", "Мой второй номер");
      this.ContactList.Add(pContact1);
      this.ContactList.Add(pContact2);
    }
    #endregion


  }
}
