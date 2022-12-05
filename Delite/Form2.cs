// Decompiled with JetBrains decompiler
// Type: Delite_Last_Try.Form2
// Assembly: Delite Last Try, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 35571870-3CCB-4AA5-A17B-99B9C02579A2
// Assembly location: E:\Hack\Programs\Delite.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Delite_Last_Try
{
  public class Form2 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;

    public Form2() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(424, 311);
      this.label1.Name = "label1";
      this.label1.Size = new Size(30, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Stil©";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 80);
      this.label2.Name = "label2";
      this.label2.Size = new Size(380, 104);
      this.label2.TabIndex = 1;
      this.label2.Text = componentResourceManager.GetString("label2.Text");
      this.label3.AutoSize = true;
      this.label3.Location = new Point(12, 260);
      this.label3.Name = "label3";
      this.label3.Size = new Size(401, 39);
      this.label3.TabIndex = 2;
      this.label3.Text = "* has a bug that doesn't allow you to sit down\r\n** you can't tell when a staff member is invisible/visible. Will always be 100% opacity\r\n*** activate while your mov speed is very fast";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.label4.Location = new Point(12, 9);
      this.label4.Name = "label4";
      this.label4.Size = new Size(450, 15);
      this.label4.TabIndex = 3;
      this.label4.Text = "Delite is a tool made for Shaiya Elite due to the staff being incapable to detect shit.";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(465, 333);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form2);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Info";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
