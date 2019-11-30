using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI183_Lab2_Classes.DrinkRef;

namespace PI183_LAB2_Forms
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Drink pD1 = new Drink("Молоко", EDrinkType.ForKid);
      Drink pD2 = new Drink("Кефир", EDrinkType.Alcoholic);
      h_WriteInfoAboutDrink(pD1, label1);
      h_WriteInfoAboutDrink(pD2, label2);


      using (BlockForm pForm = new BlockForm())
      {
        DialogResult pDr = pForm.ShowDialog();
        switch (pDr)
        {
          case DialogResult.None:
            break;
          case DialogResult.OK:
            break;
          case DialogResult.Cancel:
            break;
        }
      }
    }

    private void h_WriteInfoAboutDrink(Drink pD1, Label lab)
    {
      lab.Text = $"{pD1.Title} / {pD1.DrinkType}";
    }
  }
}
