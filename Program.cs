// Decompiled with JetBrains decompiler
// Type: Elit_hesap_makinesi.Program
// Assembly: Elit hesap makinesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4D6C8C5-93B8-4BF1-B625-A1B6B24F84F4
// Assembly location: C:\Users\Administrator\Downloads\Kucuk_hesap_makinesi.exe

using System;
using System.Windows.Forms;

namespace Elit_hesap_makinesi
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
