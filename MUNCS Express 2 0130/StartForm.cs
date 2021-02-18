// Decompiled with JetBrains decompiler
// Type: MUNCS_E2.StartForm
// Assembly: MUNCS Express 2 Rebuild, Version=2.0.1.25, Culture=neutral, PublicKeyToken=null
// MVID: 0D772052-686C-4562-BE2C-3873CFDD4BAE
// Assembly location: C:\Users\Kevin\Downloads\MUNCS Express 2 0130\MUNCS Express 2 0130.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MUNCS_E2.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MUNCS_E2
{
  [DesignerGenerated]
  public class StartForm : Form
  {
    private IContainer components;
    private Panel pnlLogo;
    private Timer tmrLogo;
    private Image imgLogo;
    private Image imgBackground;
    private int i;

    public StartForm()
    {
      this.Load += new EventHandler(this.StartForm_Load);
      this.tmrLogo = new Timer();
      this.InitializeComponent();
    }

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
    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(128, 0);
      this.Name = nameof (StartForm);
      this.Text = "MUNCS Express 2";
      this.ResumeLayout(false);
    }

    public static object Func_CreateObj(string Text, string kind)
    {
      object obj;
      if (Operators.CompareString(kind.ToUpper(), "LABEL", false) == 0)
      {
        Label label = new Label();
        label.Name = Text;
        obj = (object) label;
      }
      else if (Operators.CompareString(kind.ToUpper(), "PANEL", false) == 0)
      {
        Panel panel = new Panel();
        panel.Name = Text;
        obj = (object) panel;
      }
      else if (Operators.CompareString(kind.ToUpper(), "TEXTBOX", false) == 0)
      {
        TextBox textBox = new TextBox();
        textBox.Name = Text;
        obj = (object) textBox;
      }
      else
        obj = (object) new Label();
      return obj;
    }

    protected override CreateParams CreateParams
    {
      get
      {
        CreateParams createParams = base.CreateParams;
        createParams.ExStyle |= 33554432;
        return createParams;
      }
    }

    private void StartForm_Load(object sender, EventArgs e)
    {
      this.Visible = false;
      this.ShowInTaskbar = false;
      MyProject.Forms.MainForm.ShowInTaskbar = false;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Height = 400;
      this.Width = 640;
      this.Top = checked ((int) Math.Round(unchecked ((double) checked (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2.0)));
      this.Left = checked ((int) Math.Round(unchecked ((double) checked (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2.0)));
      Random random = new Random();
      int[] numArray = new int[2];
      StreamReader streamReader1 = new StreamReader((Stream) File.Open("Config\\Config_Skin.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      int index = 0;
      StreamReader streamReader2 = streamReader1;
      while (!streamReader1.EndOfStream)
      {
        numArray[index] = Conversions.ToInteger(Conversion.Int((object) streamReader2.ReadLine()));
        checked { ++index; }
      }
      streamReader2.Close();
      this.imgBackground = (Image) MUNCS_E2.My.Resources.Resources.ME_2;
      this.BackColor = Color.FromArgb(62, 109, 181);
      this.BackgroundImage = this.imgBackground;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.imgLogo = (Image) MUNCS_E2.My.Resources.Resources.Logo;
      this.pnlLogo = (Panel) StartForm.Func_CreateObj("pnlLogo", "Panel");
      this.Controls.Add((Control) this.pnlLogo);
      Panel pnlLogo = this.pnlLogo;
      pnlLogo.Height = this.Height;
      pnlLogo.Width = this.Width;
      pnlLogo.Top = 10;
      pnlLogo.Left = 0;
      pnlLogo.BackgroundImage = this.imgLogo;
      pnlLogo.BackgroundImageLayout = ImageLayout.Center;
      pnlLogo.BackColor = Color.Transparent;
      pnlLogo.Visible = false;
      this.tmrLogo.Tick += new EventHandler(this.tmrLogo_Tick);
      this.tmrLogo.Interval = 1000;
      this.i = 0;
      this.tmrLogo.Start();
      this.Visible = true;
    }

    private void tmrLogo_Tick(object sender, EventArgs e)
    {
      checked { ++this.i; }
      if (this.i <= 2)
        return;
      MyProject.Forms.MainForm.Top = 0;
      MyProject.Forms.MainForm.ShowInTaskbar = true;
      MyProject.Forms.MainForm.BringToFront();
      this.Close();
      this.tmrLogo.Stop();
    }
  }
}
