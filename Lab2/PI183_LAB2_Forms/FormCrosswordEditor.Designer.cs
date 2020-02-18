namespace PI183_LAB2_Forms
{
  partial class FormCrosswordEditor
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panButtons = new System.Windows.Forms.Panel();
      this.btnOpen = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // panButtons
      // 
      this.panButtons.Dock = System.Windows.Forms.DockStyle.Top;
      this.panButtons.Location = new System.Drawing.Point(0, 0);
      this.panButtons.Name = "panButtons";
      this.panButtons.Size = new System.Drawing.Size(405, 226);
      this.panButtons.TabIndex = 0;
      // 
      // btnOpen
      // 
      this.btnOpen.Location = new System.Drawing.Point(237, 233);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(75, 23);
      this.btnOpen.TabIndex = 1;
      this.btnOpen.Text = "Открыть";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(318, 233);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Сохранить";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // FormCrosswordEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(405, 268);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnOpen);
      this.Controls.Add(this.panButtons);
      this.Name = "FormCrosswordEditor";
      this.Text = "FormCrosswordEditor";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panButtons;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.Button btnSave;
  }
}