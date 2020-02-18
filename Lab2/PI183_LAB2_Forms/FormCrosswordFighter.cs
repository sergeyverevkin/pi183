using PI183_Lab2_Classes.FieldEditor;
using System;
using System.Drawing;
using System.Windows.Forms;
using PI183_Lab2_Classes.Crossword;

namespace PI183_LAB2_Forms
{
  public partial class FormCrosswordFighter : Form
  {
    private CrosswordFight _fight;

    public FormCrosswordFighter()
    {
      InitializeComponent();
      _fight = new CrosswordFight();
      h_RefreshField(true);
    }

    private void h_RefreshField(bool bRemoveButtons)
    {
      if (bRemoveButtons) {
        for (int index = panButtons.Controls.Count - 1; index >= 0; index--) {
          Control pControl = panButtons.Controls[index] as Control;
          if (!(pControl is Button)) {
            continue;
          }

          object pTag = (pControl as Control).Tag;
          if (pTag == null) {
            continue;
          }

          panButtons.Controls.Remove(pControl);
        }
      }
      for (int ii = 0; ii < _fight.Schema.Width; ii++) {
        for (int jj = 0; jj < _fight.Schema.Height; jj++) {
          var pp = _fight.Schema.Get(ii, jj);
          if (pp == null) {
            continue;
          }

          h_RefreshButton(pp);
        }
      }
    }

    private void h_RefreshButton(Field pField)
    {

      Button pB = h_FindButton(pField);
      if (pB == null) {
        const int iWidth = 24;
        const int iHeight = 24;
        const int iPadding = 2;
        int iX = pField.X * (iWidth + iPadding) + iPadding;
        int iY = pField.Y * (iHeight + iPadding) + iPadding;
        pB = new Button();
        pB.Parent = panButtons;
        pB.Location = new Point(iX, iY);
        pB.Width = iWidth;
        pB.Height = iHeight;
        pB.Tag = pField;
        pB.Click += PBOnClick;
      }

      if (pField is EmptyField) {
        pB.BackColor = Color.DarkGray;
        pB.Text = "";
      }
      else if (pField is LetterField) {
        pB.Text = (pField as LetterField).Symbol.ToString();
        pB.BackColor = Color.White;
      }
      else if (pField is PlayerField)
      {
        pB.Text = (pField as PlayerField).Owner?.Name;
        pB.BackColor = Color.White;
      }

    }

    private Button h_FindButton(Field pField)
    {
      foreach (object pControl in panButtons.Controls) {
        if (!(pControl is Button)) {
          continue;
        }

        object pTag = (pControl as Control).Tag;
        if (pTag == null) {
          continue;
        }

        if (pTag == pField) {
          return pControl as Button;
        }
      }

      return null;
    }

    private void PBOnClick(object sender, EventArgs e)
    {
      Field pF = (sender as Button).Tag as Field;
      if (pF == null) {
        return;
      }

      _fight.Click(pF);
       h_RefreshField(true);
      //  EmptyField pEmptyField = new EmptyField(pF.X, pF.Y);
      //  _fight.Schema.Exchange(pF, pEmptyField);
      //  (sender as Button).Tag = pEmptyField;
      //  h_RefreshField(false);
      //}
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _fight.StartGame();
      h_RefreshField(true);
    }
  }
}