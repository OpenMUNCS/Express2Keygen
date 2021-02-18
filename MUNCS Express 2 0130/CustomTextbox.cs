// Decompiled with JetBrains decompiler
// Type: MUNCS_E2.CustomTextbox
// Assembly: MUNCS Express 2 Rebuild, Version=2.0.1.25, Culture=neutral, PublicKeyToken=null
// MVID: 0D772052-686C-4562-BE2C-3873CFDD4BAE
// Assembly location: C:\Users\Kevin\Downloads\MUNCS Express 2 0130\MUNCS Express 2 0130.exe

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MUNCS_E2
{
  [DesignerGenerated]
  public class CustomTextbox : TextBox
  {
    private IContainer components;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent() => this.components = (IContainer) new Container();

    public CustomTextbox()
    {
      this.InitializeComponent();
      this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.UpdateStyles();
      this.BackColor = Color.Transparent;
      this.BorderStyle = BorderStyle.None;
      this.Paint += new PaintEventHandler(this.CustomTextbox_Paint);
    }

    private void CustomTextbox_Paint(object sender, PaintEventArgs e) => e.Graphics.DrawString(this.Text, this.Font, (Brush) new SolidBrush(this.ForeColor), new PointF(0.0f, 0.0f));
  }
}
