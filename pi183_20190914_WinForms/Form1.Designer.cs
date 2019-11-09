namespace pi183_20190914_WinForms
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnLoad = new System.Windows.Forms.Button();
      this.lvPhones = new System.Windows.Forms.ListView();
      this.btnRemove = new System.Windows.Forms.Button();
      this.labTitle = new System.Windows.Forms.Label();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.SuspendLayout();
      // 
      // btnLoad
      // 
      this.btnLoad.Location = new System.Drawing.Point(338, 12);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(75, 23);
      this.btnLoad.TabIndex = 0;
      this.btnLoad.Text = "Загрузить";
      this.btnLoad.UseVisualStyleBackColor = true;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // lvPhones
      // 
      this.lvPhones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lvPhones.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lvPhones.GridLines = true;
      this.lvPhones.Location = new System.Drawing.Point(0, 83);
      this.lvPhones.Name = "lvPhones";
      this.lvPhones.Size = new System.Drawing.Size(643, 220);
      this.lvPhones.TabIndex = 1;
      this.lvPhones.UseCompatibleStateImageBehavior = false;
      this.lvPhones.View = System.Windows.Forms.View.Details;
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(338, 42);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(75, 23);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Удалить";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // labTitle
      // 
      this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labTitle.Location = new System.Drawing.Point(74, 17);
      this.labTitle.Name = "labTitle";
      this.labTitle.Size = new System.Drawing.Size(258, 48);
      this.labTitle.TabIndex = 3;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Номер телефона";
      this.columnHeader1.Width = 100;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Имя";
      this.columnHeader2.Width = 170;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Дата рождения";
      this.columnHeader3.Width = 120;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 303);
      this.Controls.Add(this.labTitle);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.lvPhones);
      this.Controls.Add(this.btnLoad);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.ListView lvPhones;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Label labTitle;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
  }
}

