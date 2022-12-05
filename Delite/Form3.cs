// Decompiled with JetBrains decompiler
// Type: Delite_Last_Try.Form3
// Assembly: Delite Last Try, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 35571870-3CCB-4AA5-A17B-99B9C02579A2
// Assembly location: E:\Hack\Programs\Delite.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Delite_Last_Try
{
  public class Form3 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;

    public Form3() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form3));
      this.label1 = new Label();
      this.label2 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(424, 311);
      this.label1.Name = "label1";
      this.label1.Size = new Size(30, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Stil©";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 31);
      this.label2.Name = "label2";
      this.label2.Size = new Size(111, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "All blind staff members";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(465, 333);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form3);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Thanks to";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
