// Decompiled with JetBrains decompiler
// Type: Delite_Last_Try.Program
// Assembly: Delite Last Try, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 35571870-3CCB-4AA5-A17B-99B9C02579A2
// Assembly location: E:\Hack\Programs\Delite.exe

using System;
using System.Windows.Forms;

namespace Delite_Last_Try
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
