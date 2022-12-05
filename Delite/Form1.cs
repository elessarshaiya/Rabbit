// Decompiled with JetBrains decompiler
// Type: Delite_Last_Try.Form1
// Assembly: Delite Last Try, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 35571870-3CCB-4AA5-A17B-99B9C02579A2
// Assembly location: E:\Hack\Programs\Delite.exe

using Memory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Delite_Last_Try
{
  public class Form1 : Form
  {
    public Mem m = new Mem();
    private IContainer components = (IContainer) null;
    private BackgroundWorker backgroundWorker1;
    private CheckBox skillCutCheckBox;
    private CheckBox xrayCheckBox;
    private Label label1;
    private CheckBox fuckcooldownsCheckBox;
    private CheckBox fuckzoomlimitCheckBox;
    private CheckBox fuckstunsCheckBox;
    private CheckBox wallclimbCheckBox;
    private Label label2;
    private CheckBox fuckluresCheckBox;
    private TextBox textBox1;
    private Button submitButton;
    private CheckBox fuckrangeCheckBox;
    private CheckBox mobsHpCheckBox;
    private CheckBox fuckJumpingCheckBox;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      if (this.backgroundWorker1.IsBusy)
        return;
      this.backgroundWorker1.RunWorkerAsync();
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      while (true)
      {
        int procIdFromName = this.m.getProcIDFromName("game");
        bool flag = false;
        if (procIdFromName > 0)
          flag = this.m.OpenProcess(procIdFromName);
        if (flag)
        {
          if (this.skillCutCheckBox.Checked)
          {
            this.m.writeMemory("0x0043DAE8", "byte", "0x90");
            this.m.writeMemory("0x0043DAE9", "byte", "0x90");
            this.m.writeMemory("0x0043DAEA", "byte", "0x90");
            this.m.writeMemory("0x0043DAEB", "byte", "0x90");
            this.m.writeMemory("0x0043DAEC", "byte", "0x90");
            this.m.writeMemory("0x0043DAED", "byte", "0x90");
          }
          else
          {
            this.m.writeMemory("0x0043DAE8", "byte", "0x8B");
            this.m.writeMemory("0x0043DAE9", "byte", "0x81");
            this.m.writeMemory("0x0043DAEA", "byte", "0xDC");
            this.m.writeMemory("0x0043DAEB", "byte", "0x00");
            this.m.writeMemory("0x0043DAEC", "byte", "0x00");
            this.m.writeMemory("0x0043DAED", "byte", "0x00");
          }
          if (this.xrayCheckBox.Checked)
          {
            this.m.writeMemory("0x004CC279", "byte", "0x90");
            this.m.writeMemory("0x004CC27A", "byte", "0x90");
            this.m.writeMemory("0x004CC27B", "byte", "0x90");
            this.m.writeMemory("0x004CC27C", "byte", "0x90");
            this.m.writeMemory("0x004CC27D", "byte", "0x90");
            this.m.writeMemory("0x004CC27E", "byte", "0x90");
            this.m.writeMemory("0x004CC27F", "byte", "0x90");
            this.m.writeMemory("0x004CC280", "byte", "0x90");
            this.m.writeMemory("0x004CC281", "byte", "0x90");
            this.m.writeMemory("0x004CC282", "byte", "0x90");
          }
          else
          {
            this.m.writeMemory("0x004CC279", "byte", "0xC7");
            this.m.writeMemory("0x004CC27A", "byte", "0x87");
            this.m.writeMemory("0x004CC27B", "byte", "0x88");
            this.m.writeMemory("0x004CC27C", "byte", "0x02");
            this.m.writeMemory("0x004CC27D", "byte", "0x00");
            this.m.writeMemory("0x004CC27E", "byte", "0x00");
            this.m.writeMemory("0x004CC27F", "byte", "0x01");
            this.m.writeMemory("0x004CC280", "byte", "0x00");
            this.m.writeMemory("0x004CC281", "byte", "0x00");
            this.m.writeMemory("0x004CC282", "byte", "0x00");
          }
          if (this.fuckcooldownsCheckBox.Checked)
            this.m.writeMemory("0x004DF048", "byte", "0xEB");
          else
            this.m.writeMemory("0x004DF048", "byte", "0x74");
          if (this.fuckzoomlimitCheckBox.Checked)
          {
            this.m.writeMemory("0x004397DB", "byte", "0x90");
            this.m.writeMemory("0x004397DC", "byte", "0x90");
            this.m.writeMemory("0x004397EB", "byte", "0x90");
            this.m.writeMemory("0x004397EC", "byte", "0x90");
            this.m.writeMemory("0x004397F3", "byte", "0x90");
            this.m.writeMemory("0x004397F4", "byte", "0x90");
            this.m.writeMemory("0x004397FD", "byte", "0x90");
            this.m.writeMemory("0x004397FE", "byte", "0x90");
          }
          else
          {
            this.m.writeMemory("0x004397DB", "byte", "0x85");
            this.m.writeMemory("0x004397DC", "byte", "0xC0");
            this.m.writeMemory("0x004397EB", "byte", "0x74");
            this.m.writeMemory("0x004397EC", "byte", "0x1A");
            this.m.writeMemory("0x004397F3", "byte", "0x85");
            this.m.writeMemory("0x004397F4", "byte", "0xC0");
            this.m.writeMemory("0x004397FD", "byte", "0x75");
            this.m.writeMemory("0x004397FE", "byte", "0x08");
          }
          if (this.fuckstunsCheckBox.Checked)
            this.m.writeMemory("0x00561CEE", "byte", "0xEB");
          else
            this.m.writeMemory("0x00561CEE", "byte", "0x74");
          if (this.wallclimbCheckBox.Checked)
          {
            this.m.writeMemory("0x00442990", "byte", "0x90");
            this.m.writeMemory("0x00442991", "byte", "0xE9");
          }
          else
          {
            this.m.writeMemory("0x00442990", "byte", "0x0F");
            this.m.writeMemory("0x00442991", "byte", "0x85");
          }
          if (this.mobsHpCheckBox.Checked)
          {
            this.m.writeMemory("0x0050C0BF", "byte", "0x90");
            this.m.writeMemory("0x0050C0C0", "byte", "0x90");
            this.m.writeMemory("0x0050C0C1", "byte", "0x90");
            this.m.writeMemory("0x0050C0C2", "byte", "0x90");
          }
          else
          {
            this.m.writeMemory("0x0050C0BF", "byte", "0x85");
            this.m.writeMemory("0x0050C0C0", "byte", "0xC0");
            this.m.writeMemory("0x0050C0C1", "byte", "0x74");
            this.m.writeMemory("0x0050C0C2", "byte", "0x3E");
          }
          if (this.fuckJumpingCheckBox.Checked)
          {
            this.m.writeMemory("0x00560F02", "byte", "0xE9");
            this.m.writeMemory("0x00560F03", "byte", "0x6E");
            this.m.writeMemory("0x00560F04", "byte", "0x02");
            this.m.writeMemory("0x00560F05", "byte", "0x00");
            this.m.writeMemory("0x00560F06", "byte", "0x00");
            this.m.writeMemory("0x00560F07", "byte", "0x90");
          }
          else
          {
            this.m.writeMemory("0x00560F02", "byte", "0x0F");
            this.m.writeMemory("0x00560F03", "byte", "0x84");
            this.m.writeMemory("0x00560F04", "byte", "0x6D");
            this.m.writeMemory("0x00560F05", "byte", "0x02");
            this.m.writeMemory("0x00560F06", "byte", "0x00");
            this.m.writeMemory("0x00560F07", "byte", "0x00");
          }
        }
      }
    }

    private void label1_Click(object sender, EventArgs e) => new Form2().Show();

    private void label2_Click(object sender, EventArgs e) => new Form3().Show();

    private void submitButton_Click(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.backgroundWorker1 = new BackgroundWorker();
      this.skillCutCheckBox = new CheckBox();
      this.xrayCheckBox = new CheckBox();
      this.label1 = new Label();
      this.fuckcooldownsCheckBox = new CheckBox();
      this.fuckzoomlimitCheckBox = new CheckBox();
      this.fuckstunsCheckBox = new CheckBox();
      this.wallclimbCheckBox = new CheckBox();
      this.label2 = new Label();
      this.fuckluresCheckBox = new CheckBox();
      this.textBox1 = new TextBox();
      this.submitButton = new Button();
      this.fuckrangeCheckBox = new CheckBox();
      this.mobsHpCheckBox = new CheckBox();
      this.fuckJumpingCheckBox = new CheckBox();
      this.SuspendLayout();
      this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.skillCutCheckBox.AutoSize = true;
      this.skillCutCheckBox.Location = new Point(12, 12);
      this.skillCutCheckBox.Name = "skillCutCheckBox";
      this.skillCutCheckBox.Size = new Size(73, 17);
      this.skillCutCheckBox.TabIndex = 0;
      this.skillCutCheckBox.Text = "Fuck stop";
      this.skillCutCheckBox.UseVisualStyleBackColor = true;
      this.xrayCheckBox.AutoSize = true;
      this.xrayCheckBox.Location = new Point(12, 35);
      this.xrayCheckBox.Name = "xrayCheckBox";
      this.xrayCheckBox.Size = new Size(47, 17);
      this.xrayCheckBox.TabIndex = 1;
      this.xrayCheckBox.Text = "Xray";
      this.xrayCheckBox.UseVisualStyleBackColor = true;
      this.label1.AutoSize = true;
      this.label1.Cursor = Cursors.Help;
      this.label1.Location = new Point(647, 377);
      this.label1.Name = "label1";
      this.label1.Size = new Size(25, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Info";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.fuckcooldownsCheckBox.AutoSize = true;
      this.fuckcooldownsCheckBox.Checked = true;
      this.fuckcooldownsCheckBox.CheckState = CheckState.Checked;
      this.fuckcooldownsCheckBox.Location = new Point(12, 59);
      this.fuckcooldownsCheckBox.Name = "fuckcooldownsCheckBox";
      this.fuckcooldownsCheckBox.Size = new Size(104, 17);
      this.fuckcooldownsCheckBox.TabIndex = 3;
      this.fuckcooldownsCheckBox.Text = "Fuck cooldowns";
      this.fuckcooldownsCheckBox.UseVisualStyleBackColor = true;
      this.fuckzoomlimitCheckBox.AutoSize = true;
      this.fuckzoomlimitCheckBox.Checked = true;
      this.fuckzoomlimitCheckBox.CheckState = CheckState.Checked;
      this.fuckzoomlimitCheckBox.Location = new Point(12, 84);
      this.fuckzoomlimitCheckBox.Name = "fuckzoomlimitCheckBox";
      this.fuckzoomlimitCheckBox.Size = new Size(98, 17);
      this.fuckzoomlimitCheckBox.TabIndex = 4;
      this.fuckzoomlimitCheckBox.Text = "Fuck zoom limit";
      this.fuckzoomlimitCheckBox.UseVisualStyleBackColor = true;
      this.fuckstunsCheckBox.AutoSize = true;
      this.fuckstunsCheckBox.Location = new Point(12, 107);
      this.fuckstunsCheckBox.Name = "fuckstunsCheckBox";
      this.fuckstunsCheckBox.Size = new Size(78, 17);
      this.fuckstunsCheckBox.TabIndex = 5;
      this.fuckstunsCheckBox.Text = "Fuck stuns";
      this.fuckstunsCheckBox.UseVisualStyleBackColor = true;
      this.wallclimbCheckBox.AutoSize = true;
      this.wallclimbCheckBox.Checked = true;
      this.wallclimbCheckBox.CheckState = CheckState.Checked;
      this.wallclimbCheckBox.Location = new Point(12, 131);
      this.wallclimbCheckBox.Name = "wallclimbCheckBox";
      this.wallclimbCheckBox.Size = new Size(71, 17);
      this.wallclimbCheckBox.TabIndex = 6;
      this.wallclimbCheckBox.Text = "Wallclimb";
      this.wallclimbCheckBox.UseVisualStyleBackColor = true;
      this.label2.AutoSize = true;
      this.label2.Cursor = Cursors.Help;
      this.label2.Location = new Point(13, 377);
      this.label2.Name = "label2";
      this.label2.Size = new Size(55, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Thanks to";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.fuckluresCheckBox.AutoSize = true;
      this.fuckluresCheckBox.Location = new Point(126, 107);
      this.fuckluresCheckBox.Name = "fuckluresCheckBox";
      this.fuckluresCheckBox.Size = new Size(92, 17);
      this.fuckluresCheckBox.TabIndex = 8;
      this.fuckluresCheckBox.Text = "Fuck lures/bh";
      this.fuckluresCheckBox.UseVisualStyleBackColor = true;
      this.fuckluresCheckBox.Visible = false;
      this.textBox1.Location = new Point(308, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(374, 20);
      this.textBox1.TabIndex = 9;
      this.textBox1.Text = "pw";
      this.textBox1.Visible = false;
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.submitButton.Location = new Point(607, 35);
      this.submitButton.Name = "submitButton";
      this.submitButton.Size = new Size(75, 23);
      this.submitButton.TabIndex = 10;
      this.submitButton.Text = "Submit";
      this.submitButton.UseVisualStyleBackColor = true;
      this.submitButton.Visible = false;
      this.submitButton.Click += new EventHandler(this.submitButton_Click);
      this.fuckrangeCheckBox.AutoSize = true;
      this.fuckrangeCheckBox.Enabled = false;
      this.fuckrangeCheckBox.Location = new Point(126, 130);
      this.fuckrangeCheckBox.Name = "fuckrangeCheckBox";
      this.fuckrangeCheckBox.Size = new Size(80, 17);
      this.fuckrangeCheckBox.TabIndex = 11;
      this.fuckrangeCheckBox.Text = "Fuck range";
      this.fuckrangeCheckBox.UseVisualStyleBackColor = true;
      this.fuckrangeCheckBox.Visible = false;
      this.mobsHpCheckBox.AutoSize = true;
      this.mobsHpCheckBox.Checked = true;
      this.mobsHpCheckBox.CheckState = CheckState.Checked;
      this.mobsHpCheckBox.Location = new Point(12, 155);
      this.mobsHpCheckBox.Name = "mobsHpCheckBox";
      this.mobsHpCheckBox.Size = new Size(70, 17);
      this.mobsHpCheckBox.TabIndex = 12;
      this.mobsHpCheckBox.Text = "Mobs HP";
      this.mobsHpCheckBox.UseVisualStyleBackColor = true;
      this.fuckJumpingCheckBox.AutoSize = true;
      this.fuckJumpingCheckBox.Location = new Point(12, 179);
      this.fuckJumpingCheckBox.Name = "fuckJumpingCheckBox";
      this.fuckJumpingCheckBox.Size = new Size(89, 17);
      this.fuckJumpingCheckBox.TabIndex = 13;
      this.fuckJumpingCheckBox.Text = "Fuck jumping";
      this.fuckJumpingCheckBox.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(694, 399);
      this.Controls.Add((Control) this.fuckJumpingCheckBox);
      this.Controls.Add((Control) this.mobsHpCheckBox);
      this.Controls.Add((Control) this.fuckrangeCheckBox);
      this.Controls.Add((Control) this.submitButton);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.fuckluresCheckBox);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.wallclimbCheckBox);
      this.Controls.Add((Control) this.fuckstunsCheckBox);
      this.Controls.Add((Control) this.fuckzoomlimitCheckBox);
      this.Controls.Add((Control) this.fuckcooldownsCheckBox);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.xrayCheckBox);
      this.Controls.Add((Control) this.skillCutCheckBox);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Delite";
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
