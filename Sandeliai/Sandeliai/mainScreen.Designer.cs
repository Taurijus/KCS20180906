namespace Sandeliai
{
  partial class mainScreen
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
      this.list_Sandeliai = new System.Windows.Forms.ListBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button_AddNew = new System.Windows.Forms.Button();
      this.button_Delete = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // list_Sandeliai
      // 
      this.list_Sandeliai.FormattingEnabled = true;
      this.list_Sandeliai.Location = new System.Drawing.Point(13, 13);
      this.list_Sandeliai.Name = "list_Sandeliai";
      this.list_Sandeliai.Size = new System.Drawing.Size(160, 394);
      this.list_Sandeliai.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(179, 13);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(241, 141);
      this.textBox1.TabIndex = 1;
      // 
      // button_AddNew
      // 
      this.button_AddNew.Location = new System.Drawing.Point(13, 414);
      this.button_AddNew.Name = "button_AddNew";
      this.button_AddNew.Size = new System.Drawing.Size(75, 23);
      this.button_AddNew.TabIndex = 2;
      this.button_AddNew.Text = "Add new";
      this.button_AddNew.UseVisualStyleBackColor = true;
      // 
      // button_Delete
      // 
      this.button_Delete.Location = new System.Drawing.Point(98, 415);
      this.button_Delete.Name = "button_Delete";
      this.button_Delete.Size = new System.Drawing.Size(75, 23);
      this.button_Delete.TabIndex = 3;
      this.button_Delete.Text = "Delete";
      this.button_Delete.UseVisualStyleBackColor = true;
      // 
      // mainScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(425, 450);
      this.Controls.Add(this.button_Delete);
      this.Controls.Add(this.button_AddNew);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.list_Sandeliai);
      this.Name = "mainScreen";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox list_Sandeliai;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button_AddNew;
    private System.Windows.Forms.Button button_Delete;
  }
}

