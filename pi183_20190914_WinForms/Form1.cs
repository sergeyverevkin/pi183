using pi183_20190914_Classes;
using System.Windows.Forms;

namespace pi183_20190914_WinForms
{
  public partial class Form1 : Form
  {
    AddressBook _addressBook;

    public Form1()
    {
      _addressBook = new TestAddressBook();
      InitializeComponent();
    }

    private void btnLoad_Click(object sender, System.EventArgs e)
    {
      labTitle.Text = _addressBook.OwnerIdentifier;
      lvPhones.Items.Clear();
      foreach(Contact pContact in _addressBook.ContactList) {
        ListViewItem lvi = lvPhones.Items.Add(pContact.PhoneNumber);
        lvi.SubItems.Add(pContact.Title);
        lvi.SubItems.Add(pContact.BirthDate.ToShortDateString());
      }
    }

    private void Form1_Load(object sender, System.EventArgs e)
    {

    }

    private void btnRemove_Click(object sender, System.EventArgs e)
    {
      if (_addressBook.ContactList.Count > 0) {
        _addressBook.ContactList.RemoveAt(0);
      }
    }
  }
}
