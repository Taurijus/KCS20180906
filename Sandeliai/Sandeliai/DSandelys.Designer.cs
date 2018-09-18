namespace Sandeliai
{
  partial class DSandelys
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
      if (disposing && (components != null))
      {
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
      this.LentynuListBox = new System.Windows.Forms.ListBox();
      this.BTN_ADD = new System.Windows.Forms.Button();
      this.BTN_REMOVE = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LentynuListBox
      // 
      this.LentynuListBox.FormattingEnabled = true;
      this.LentynuListBox.Location = new System.Drawing.Point(14, 2);
      this.LentynuListBox.Name = "LentynuListBox";
      this.LentynuListBox.Size = new System.Drawing.Size(159, 355);
      this.LentynuListBox.TabIndex = 0;
      this.LentynuListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // BTN_ADD
      // 
      this.BTN_ADD.Location = new System.Drawing.Point(14, 363);
      this.BTN_ADD.Name = "BTN_ADD";
      this.BTN_ADD.Size = new System.Drawing.Size(72, 28);
      this.BTN_ADD.TabIndex = 1;
      this.BTN_ADD.Text = "Pridėti";
      this.BTN_ADD.UseVisualStyleBackColor = true;
      this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
      // 
      // BTN_REMOVE
      // 
      this.BTN_REMOVE.Location = new System.Drawing.Point(101, 363);
      this.BTN_REMOVE.Name = "BTN_REMOVE";
      this.BTN_REMOVE.Size = new System.Drawing.Size(72, 28);
      this.BTN_REMOVE.TabIndex = 2;
      this.BTN_REMOVE.Text = "Išimti";
      this.BTN_REMOVE.UseVisualStyleBackColor = true;
      this.BTN_REMOVE.Click += new System.EventHandler(this.BTN_REMOVE_Click);
      // 
      // DSandelys
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BTN_REMOVE);
      this.Controls.Add(this.BTN_ADD);
      this.Controls.Add(this.LentynuListBox);
      this.Name = "DSandelys";
      this.Text = "DSandelys";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox LentynuListBox;
    private System.Windows.Forms.Button BTN_ADD;
    private System.Windows.Forms.Button BTN_REMOVE;
  }
}