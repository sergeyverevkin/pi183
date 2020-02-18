using PI183_Lab2_Classes.FieldEditor;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PI183_LAB2_Forms
{
  public partial class FormCrosswordEditor : Form
  {
    private CSchema _schema;

    public FormCrosswordEditor()
    {
      InitializeComponent();
      _schema = new CSchema(10, 10);
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
      for (int ii = 0; ii < _schema.Width; ii++) {
        for (int jj = 0; jj < _schema.Height; jj++) {
          var pp = _schema.Get(ii, jj);
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

      if (pF is EmptyField) {
        LetterField pLetterField = new LetterField(pF.X, pF.Y);
        _schema.Exchange(pF, pLetterField);
        (sender as Button).Tag = pLetterField;
        h_RefreshField(false);
      }
      else
      if (pF is LetterField) {
        EmptyField pEmptyField = new EmptyField(pF.X, pF.Y);
        _schema.Exchange(pF, pEmptyField);
        (sender as Button).Tag = pEmptyField;
        h_RefreshField(false);
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveFileDialog pDialog = new SaveFileDialog();
      DialogResult pD = pDialog.ShowDialog();
      if (pD == DialogResult.OK) {
        _schema.Save(pDialog.FileName);
      }
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      OpenFileDialog pDialog = new OpenFileDialog();
      DialogResult pD = pDialog.ShowDialog();
      if (pD == DialogResult.OK) {
        _schema.Load(pDialog.FileName);
        h_RefreshField(true);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}