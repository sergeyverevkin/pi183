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
    private Drink _pD1;
    private Drink _pD2;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _pD1 = new Drink("Молоко", EDrinkType.ForKid);
      _pD2 = new Drink("Кефир", EDrinkType.Alcoholic);
      h_WriteInfoAboutDrink(_pD1, label1);
      h_WriteInfoAboutDrink(_pD2, label2);

      label1.Click += LabelOnClick;
      label2.Click += LabelOnClick;

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

    private void LabelOnClick(object sender, EventArgs e)
    {
      Label lb = sender as Label;
      Drink d = lb.Tag as Drink;
      MessageBox.Show(d.Title);
    }

    private void h_WriteInfoAboutDrink(Drink pD1, Label lab)
    {
      lab.Text = $"{pD1.Title} / {pD1.DrinkType}";
      lab.Tag = pD1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      using (FormCrosswordEditor pForm = new FormCrosswordEditor()) {
        pForm.ShowDialog();
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      using (FormCrosswordFighter pForm = new FormCrosswordFighter()) {
        pForm.ShowDialog();
      }
    }
  }
}
