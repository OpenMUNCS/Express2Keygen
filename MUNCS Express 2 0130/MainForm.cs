// Decompiled with JetBrains decompiler
// Type: MUNCS_E2.MainForm
// Assembly: MUNCS Express 2 Rebuild, Version=2.0.1.25, Culture=neutral, PublicKeyToken=null
// MVID: 0D772052-686C-4562-BE2C-3873CFDD4BAE
// Assembly location: C:\Users\Kevin\Downloads\MUNCS Express 2 0130\MUNCS Express 2 0130.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MUNCS_E2.My;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using USAA_Gen2Library;

namespace MUNCS_E2
{
  [DesignerGenerated]
  public class MainForm : Form
  {
    private const string VERSION = "0130";
    private Panel pnlGuideline;
    private Label lblGuidelineTitle;
    private Label lblGuideline;
    private Label btnDecision;
    private bool boolISInitialLaunch;
    private int intDecisionMagicNumber;
    private Panel pnlMainMenu;
    private Panel pnlMMenuSub;
    private Label[] btnMMenu;
    private Label[] btnMMenuSub;
    private Label[] btnMMenuSubDeco;
    private Panel pnlInstr;
    private Label[] lblInstr;
    private System.Windows.Forms.Timer tmrInstr;
    private Panel[] pnlSubMenu;
    private Panel[] pnlSMenuIn;
    private Label[] lblSMenuTitle;
    private Label[] btnSMenuClose;
    private Label[,] lblSMenuCaption;
    private Label[,] btnSMenuFormalBtn;
    private TextBox[,] txtSMenuAnswer;
    private Panel pnlMainInfo;
    private Panel[] pnlMInfo;
    private Panel[] pnlMInfoIn;
    private Label[] lblMInfoTitle;
    private Label[] lblMInfoPatch;
    private Label[,] lblMInfo;
    private Label[,] btnMInfo;
    private TextBox[,] txtMInfo;
    private System.Windows.Forms.Timer tmrRealTime;
    private System.Windows.Forms.Timer tmrMainCounter;
    private Panel pnlMainVote;
    private Panel[] pnlMVote;
    private Panel[] pnlMVoteIn;
    private Label[] lblMVoteTitle;
    private Label[,] lblMVote;
    private Label[] lblMVoteLine;
    private Label[,] lblMVoteLight;
    private Panel pnlMainRoll;
    private Panel[] pnlMRoll;
    private Panel[] pnlMRollIn;
    private Label[] lblMRollTitle;
    private Label[,] lblMRoll;
    private Label[] lblMRollLine;
    private Label[,] lblMRollLight;
    private Panel pnlMainLanguage;
    private Panel[] pnlMLan;
    private Label lblMLanTitle;
    private Label[] lblMLan;
    private Label lblMLanLogo;
    private Panel pnlMainBackground;
    private Panel[] pnlMBac;
    private Label[,] lblMBac;
    private Panel pnlMainWidget;
    private Panel[] pnlMWid;
    private Label[,] lblMWid;
    private Label[] lblMWidDrag;
    private Panel pnlMainKeyMenu;
    private Label[] lblMKeyMenu;
    private Label[] lblMKeyMenuDeco;
    private string[] strMKeyMenu;
    private Image[] imgMKeyMenuDeco;
    private Panel pnlMainConference;
    private Panel[] pnlMConf;
    private Label[,] lblMConf;
    private TextBox[,] txtMConf;
    private Panel pnlMainSettings;
    private Panel[] pnlMSet;
    private Label[] lblMSetTitle;
    private Label[,] lblMSetOption;
    private int[] intMSetMode;
    private string[,] strMSet;
    private string[,] strMSetSelection;
    private string[] strInstrLib;
    private string[] strSMenuTitle;
    private string[,] strSMenuCaption;
    private string[,] strSMenuAnswer;
    private string[,] strSMenuFormalBtn;
    private string[,] strSMenuDesc;
    private string[,] strMVote;
    private string[,] strMRoll;
    private string[] strMRollDelList;
    private string[] strMVoteDelList;
    private string[,] strMInfo;
    private string[,] strMBac;
    private string[,] strMWid;
    private string[,] strMConf;
    private Image[] imgSMenuDesc;
    private Image[] imgIcon;
    private Bitmap imgBackground;
    private Image[] imgLogo;
    private Image imgLogoIcon;
    private Image[] imgBackTrans;
    private Image[] imgMBackSel;
    private Image[,] imgMWid;
    private Image[] imgMWidDrag;
    private Image[] imgMConf;
    private bool IsKeyMenuAvailable;
    private bool IsDraging;
    private int senderX;
    private int senderY;
    private bool[] IsSubVisible;
    private bool IsSubRefreshing;
    private int IsSubActiving;
    private int intMRoll;
    private int intMRollSelect;
    private int intMRollMax;
    private string[] intMRollDelList;
    private int intMVote;
    private int intMVoteSelect;
    private int intMVoteMax;
    private int intMReVoteMax;
    private string[] intMVoteDelList;
    private string[] intMReVoteDelList;
    private int[,] intMMenuSub;
    private int intMMenuActive;
    private string strInstr;
    private int[] intInstr;
    private int[] intSMenuCaptionAmount;
    private int[] intSMenuAnswerAmount;
    private int[] intSMenuFormalBtnAmount;
    private int[,] intMWid;
    private int[] intMWidChosen;
    private string[] datDelList;
    private string[] datDelListPresent;
    private int[] datDelStatus;
    private int[] intMInfoCounter;
    private string Language;
    private int[] intMInfoMark;
    private string[] datConf;
    private string[] datDelObs;
    private string[] datDelVeto;
    private bool AutoComplete;
    private bool Accessibility_Support;
    private Color colInstr;
    private int SkinSelected;
    private Color ColorMain;
    private Color ColorMainDeep;
    private Font fnt9;
    private Font fnt12;
    private Font fnt18;
    private Font fnt18B;
    private Font fnt21;
    private Font fnt24;
    private Font fnt26;
    private Font fnt57;
    private Font fntCounter18;
    private Font fntCounter24;
    private Font fntCounter57;
    private Font fntDisplay;
    private int SkinAmount;
    private System.Windows.Forms.Timer tmrResolution;
    private Dictionary<string, string> Terms;
    private Dictionary<string, string[]> TermArrays;
    private Dictionary<string, string> Expressions;
    private string datToolBoxSetting;
    private string ChineseFont;
    private string WesternFont;
    private int DisplayedFontSize;
    private PrivateFontCollection FontTimer;
    private bool IsWideScreen;
    private string CurrentTopic;
    private Label btnInitiateModerator;
    private IContainer components;
    [SpecialName]
    private int \u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround;
    [SpecialName]
    private StaticLocalInitFlag \u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init;
    [SpecialName]
    private Size \u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024W;

    public MainForm()
    {
      this.Load += new EventHandler(this.MainForm_Load);
      this.FormClosing += new FormClosingEventHandler(this.MainForm_Unload);
      this.btnMMenu = new Label[8];
      this.btnMMenuSub = new Label[10];
      this.btnMMenuSubDeco = new Label[10];
      this.lblInstr = new Label[3];
      this.tmrInstr = new System.Windows.Forms.Timer();
      this.pnlSubMenu = new Panel[21];
      this.pnlSMenuIn = new Panel[21];
      this.lblSMenuTitle = new Label[21];
      this.btnSMenuClose = new Label[21];
      this.lblSMenuCaption = new Label[21, 6];
      this.btnSMenuFormalBtn = new Label[21, 6];
      this.txtSMenuAnswer = new TextBox[21, 6];
      this.pnlMInfo = new Panel[6];
      this.pnlMInfoIn = new Panel[7];
      this.lblMInfoTitle = new Label[6];
      this.lblMInfoPatch = new Label[3];
      this.lblMInfo = new Label[6, 16];
      this.btnMInfo = new Label[6, 6];
      this.txtMInfo = new TextBox[6, 6];
      this.tmrRealTime = new System.Windows.Forms.Timer();
      this.tmrMainCounter = new System.Windows.Forms.Timer();
      this.pnlMVote = new Panel[6];
      this.pnlMVoteIn = new Panel[6];
      this.lblMVoteTitle = new Label[6];
      this.lblMVote = new Label[6, 33];
      this.lblMVoteLine = new Label[33];
      this.lblMVoteLight = new Label[3, 33];
      this.pnlMRoll = new Panel[6];
      this.pnlMRollIn = new Panel[6];
      this.lblMRollTitle = new Label[6];
      this.lblMRoll = new Label[6, 33];
      this.lblMRollLine = new Label[33];
      this.lblMRollLight = new Label[3, 33];
      this.pnlMLan = new Panel[2];
      this.lblMLan = new Label[11];
      this.pnlMBac = new Panel[2];
      this.lblMBac = new Label[2, 21];
      this.pnlMWid = new Panel[5];
      this.lblMWid = new Label[5, 80];
      this.lblMWidDrag = new Label[2];
      this.lblMKeyMenu = new Label[5];
      this.lblMKeyMenuDeco = new Label[5];
      this.strMKeyMenu = new string[5];
      this.imgMKeyMenuDeco = new Image[5];
      this.pnlMConf = new Panel[3];
      this.lblMConf = new Label[3, 6];
      this.txtMConf = new TextBox[3, 6];
      this.pnlMSet = new Panel[4];
      this.lblMSetTitle = new Label[3];
      this.lblMSetOption = new Label[4, 6];
      this.intMSetMode = new int[6];
      this.strMSet = new string[3, 6];
      this.strMSetSelection = new string[6, 11];
      this.strInstrLib = new string[51];
      this.strSMenuTitle = new string[21];
      this.strSMenuCaption = new string[21, 6];
      this.strSMenuAnswer = new string[21, 6];
      this.strSMenuFormalBtn = new string[21, 6];
      this.strSMenuDesc = new string[201, 7];
      this.strMVote = new string[6, 33];
      this.strMRoll = new string[6, 33];
      this.strMRollDelList = new string[512];
      this.strMVoteDelList = new string[512];
      this.strMInfo = new string[6, 6];
      this.strMBac = new string[2, 21];
      this.strMWid = new string[1, 1];
      this.strMConf = new string[3, 6];
      this.imgSMenuDesc = new Image[5];
      this.imgIcon = new Image[8];
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      int width = workingArea.Width;
      workingArea = Screen.PrimaryScreen.WorkingArea;
      int height = workingArea.Height;
      this.imgBackground = new Bitmap(width, height, PixelFormat.Format32bppPArgb);
      this.imgLogo = new Image[2];
      this.imgBackTrans = new Image[2];
      this.imgMBackSel = new Image[21];
      this.imgMWid = new Image[5, 80];
      this.imgMWidDrag = new Image[2];
      this.imgMConf = new Image[2];
      this.IsSubVisible = new bool[21];
      this.intMRollDelList = new string[512];
      this.intMVoteDelList = new string[512];
      this.intMReVoteDelList = new string[512];
      this.intMMenuSub = new int[8, 11];
      this.intInstr = new int[2];
      this.intSMenuCaptionAmount = new int[21];
      this.intSMenuAnswerAmount = new int[21];
      this.intSMenuFormalBtnAmount = new int[21];
      this.intMWid = new int[2, 80];
      this.intMWidChosen = new int[2];
      this.datDelList = new string[512];
      this.datDelListPresent = new string[512];
      this.datDelStatus = new int[512];
      this.intMInfoCounter = new int[4];
      this.intMInfoMark = new int[3];
      this.datConf = new string[3];
      this.datDelObs = new string[512];
      this.datDelVeto = new string[512];
      this.Accessibility_Support = true;
      this.Terms = new Dictionary<string, string>();
      this.TermArrays = new Dictionary<string, string[]>();
      this.Expressions = new Dictionary<string, string>();
      this.FontTimer = new PrivateFontCollection();
      this.IsWideScreen = false;
      this.btnInitiateModerator = new Label();
      this.InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.Parameter_Main();
      this.Parameter_Rosetta();
      Random random = new Random();
      int index = 0;
      int[] numArray = new int[2];
      StreamReader streamReader1 = new StreamReader((Stream) File.Open("Config\\Config_Skin.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      StreamReader streamReader2 = streamReader1;
      while (!streamReader1.EndOfStream)
      {
        numArray[index] = Conversions.ToInteger(Conversion.Int((object) streamReader2.ReadLine()));
        checked { ++index; }
      }
      streamReader2.Close();
      if (numArray[0] == 0)
      {
        numArray[1] = Conversions.ToInteger(random.Next(12).ToString());
        MyProject.Computer.FileSystem.WriteAllText("Config\\Config_Skin.txt", Conversions.ToString(numArray[0]) + "\r\n" + Conversions.ToString(numArray[1]), false);
      }
      this.Parameter_Skin(numArray[1]);
      StreamReader streamReader3 = new StreamReader((Stream) File.Open("Config\\Config_Accessibility_Support.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      StreamReader streamReader4 = streamReader3;
      while (!streamReader3.EndOfStream)
        this.Accessibility_Support = Operators.CompareString(streamReader4.ReadLine(), "0", false) != 0;
      streamReader4.Close();
      this.Window_Base();
      this.Window_MainMenu();
      this.Window_Instr();
      this.Window_SubMenu();
      this.Window_Main_Info();
      this.Window_Main_Vote();
      this.Window_Main_RollCall();
      this.Window_Main_LanguageSelect();
      this.Window_Main_BackgroundSelect();
      this.Window_Main_Widget();
      this.Window_Main_KeyMenu();
      this.Window_Main_Conference();
      this.Window_Main_Settings();
      this.Window_Main_Guideline();
      this.Event_Watch_Resolution();
      this.Event_Main_Widget_Empty_Temp();
      this.Event_All_Visibility_Erase();
      this.Event_MainMenu_Visibility_Update(false);
      this.Event_Main_Initialize();
      this.pnlMainInfo.Visible = false;
      this.pnlGuideline.Visible = true;
      this.pnlGuideline.BringToFront();
      this.Event_Environment_Check();
    }

    public void Parameter_IO()
    {
      StreamReader streamReader1 = new StreamReader((Stream) File.Open("Config\\Config_Toolbox.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      while (!streamReader1.EndOfStream)
      {
        // ISSUE: variable of a reference type
        string& local;
        // ISSUE: explicit reference operation
        string str = ^(local = ref this.datToolBoxSetting) + streamReader1.ReadLine();
        local = str;
      }
      streamReader1.Close();
      StreamReader streamReader2 = new StreamReader((Stream) File.Open("Config\\Config_Font.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      this.ChineseFont = streamReader2.ReadLine();
      this.WesternFont = streamReader2.ReadLine();
      this.DisplayedFontSize = checked ((int) Math.Round(Conversion.Val(streamReader2.ReadLine())));
      streamReader2.Close();
      StreamReader streamReader3 = new StreamReader((Stream) File.Open("Config\\Config_WideScreen_Display.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      this.IsWideScreen = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(streamReader3.ReadLine(), "1", false) == 0, (object) true, (object) false));
      streamReader3.Close();
      int num = Information.UBound((Array) this.datDelList);
      int index1 = 0;
      while (index1 <= num)
      {
        this.datDelList[index1] = "";
        this.datDelListPresent[index1] = "";
        this.datDelObs[index1] = "";
        this.datDelVeto[index1] = "";
        this.datDelStatus[index1] = 0;
        checked { ++index1; }
      }
      StreamReader streamReader4 = new StreamReader((Stream) File.Open("Config\\Delegation_List.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      int index2 = 0;
      StreamReader streamReader5 = streamReader4;
      while (!streamReader4.EndOfStream)
      {
        this.datDelList[index2] = streamReader5.ReadLine();
        this.datDelListPresent[index2] = this.datDelList[index2];
        checked { ++index2; }
      }
      streamReader5.Close();
      StreamReader streamReader6 = new StreamReader((Stream) File.Open("Config\\Delegation_Observer.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      int index3 = 0;
      StreamReader streamReader7 = streamReader6;
      while (!streamReader6.EndOfStream)
      {
        this.datDelObs[index3] = streamReader7.ReadLine();
        checked { ++index3; }
      }
      streamReader7.Close();
      StreamReader streamReader8 = new StreamReader((Stream) File.Open("Config\\Config_Initial_Launch.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      StreamReader streamReader9 = streamReader8;
      while (!streamReader8.EndOfStream)
        this.boolISInitialLaunch = Conversions.ToBoolean(Interaction.IIf(Operators.CompareString(streamReader9.ReadLine().ToString(), "1", false) == 0, (object) true, (object) false));
      streamReader9.Close();
      StreamReader streamReader10 = new StreamReader((Stream) File.Open("Config\\Delegation_Veto.txt", FileMode.OpenOrCreate), Encoding.UTF8);
      int index4 = 0;
      StreamReader streamReader11 = streamReader10;
      while (!streamReader10.EndOfStream)
      {
        this.datDelVeto[index4] = streamReader11.ReadLine();
        checked { ++index4; }
      }
      streamReader11.Close();
    }

    public void Parameter_Main()
    {
      this.SkinAmount = 20;
      this.Parameter_IO();
      this.imgLogo[0] = (Image) MUNCS_E2.My.Resources.Resources.Logo;
      this.imgLogo[1] = (Image) MUNCS_E2.My.Resources.Resources.Logo_Trans;
      int index1 = 0;
      do
      {
        this.imgIcon[index1] = (Image) MUNCS_E2.My.Resources.Resources.ResourceManager.GetObject("I_" + Conversions.ToString(index1));
        checked { ++index1; }
      }
      while (index1 <= 7);
      this.imgBackTrans[0] = (Image) MUNCS_E2.My.Resources.Resources.Back_Trans;
      this.imgBackTrans[1] = (Image) MUNCS_E2.My.Resources.Resources.Back_Trans_Active;
      int num1 = checked (this.SkinAmount - 1);
      int index2 = 0;
      while (index2 <= num1)
      {
        this.imgMBackSel[index2] = (Image) MUNCS_E2.My.Resources.Resources.ResourceManager.GetObject("Background_" + Conversions.ToString(checked (index2 + 1)));
        checked { ++index2; }
      }
      int index3 = 0;
      do
      {
        this.imgSMenuDesc[index3] = (Image) MUNCS_E2.My.Resources.Resources.ResourceManager.GetObject("Widget_" + Conversions.ToString(checked (index3 + 1)));
        checked { ++index3; }
      }
      while (index3 <= 4);
      this.imgMConf[0] = (Image) MUNCS_E2.My.Resources.Resources.Arrow_Down;
      this.imgMConf[1] = (Image) MUNCS_E2.My.Resources.Resources.Arrow_Down_Active;
      this.FontTimer.AddFontFile("Digiface_Regular.ttf");
      this.fnt9 = new Font(this.ChineseFont, 9f);
      this.fnt12 = new Font(this.ChineseFont, 12f);
      this.fnt18 = new Font(this.ChineseFont, 18f);
      this.fnt18B = new Font(this.ChineseFont, 18f, FontStyle.Bold);
      this.fnt21 = new Font(this.ChineseFont, 21f);
      this.fnt24 = new Font(this.ChineseFont, 24f);
      this.fnt26 = new Font(this.ChineseFont, 26f);
      this.fnt57 = new Font(this.ChineseFont, 57f);
      this.fntCounter18 = new Font(this.FontTimer.Families[0], 18f);
      this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
      this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
      this.intSMenuCaptionAmount = new int[21]
      {
        3,
        1,
        0,
        0,
        0,
        0,
        1,
        0,
        0,
        0,
        0,
        0,
        1,
        0,
        0,
        2,
        1,
        0,
        2,
        1,
        2
      };
      this.intSMenuAnswerAmount = new int[21]
      {
        3,
        1,
        0,
        0,
        0,
        0,
        1,
        0,
        0,
        0,
        -1,
        -1,
        1,
        -1,
        0,
        2,
        1,
        0,
        2,
        1,
        2
      };
      this.intSMenuFormalBtnAmount = new int[21]
      {
        1,
        1,
        1,
        1,
        1,
        1,
        1,
        0,
        0,
        0,
        0,
        0,
        0,
        2,
        1,
        1,
        1,
        0,
        1,
        1,
        1
      };
      int index4 = 0;
      do
      {
        int index5 = 0;
        do
        {
          this.intMMenuSub[index4, index5] = checked ((int) Math.Round(Conversion.Val(Microsoft.VisualBasic.Strings.Split(Microsoft.VisualBasic.Strings.Split(this.datToolBoxSetting, ";")[index4], ",")[index5])));
          checked { ++index5; }
        }
        while (index5 <= 10);
        checked { ++index4; }
      }
      while (index4 <= 7);
      int num2 = Information.UBound((Array) this.datDelList);
      int index6 = 0;
      while (index6 <= num2)
      {
        int num3 = Information.UBound((Array) this.datDelVeto);
        int index5 = 0;
        while (index5 <= num3)
        {
          if (Operators.CompareString(this.datDelList[index6], this.datDelVeto[index5], false) == 0)
            this.datDelStatus[index6] = 1;
          checked { ++index5; }
        }
        checked { ++index6; }
      }
      int num4 = Information.UBound((Array) this.datDelList);
      int index7 = 0;
      while (index7 <= num4)
      {
        int num3 = Information.UBound((Array) this.datDelObs);
        int index5 = 0;
        while (index5 <= num3)
        {
          if (Operators.CompareString(this.datDelList[index7], this.datDelObs[index5], false) == 0)
            this.datDelStatus[index7] = 2;
          checked { ++index5; }
        }
        checked { ++index7; }
      }
      this.IsKeyMenuAvailable = false;
      this.AutoComplete = true;
    }

    public void Parameter_Skin(int Skin)
    {
      switch (Skin)
      {
        case 0:
          this.ColorMain = Color.FromArgb(62, 109, 181);
          this.ColorMainDeep = Color.FromArgb(43, 87, 154);
          break;
        case 1:
          this.ColorMain = Color.FromArgb(198, 85, 90);
          this.ColorMainDeep = Color.FromArgb(165, 52, 57);
          break;
        case 2:
          this.ColorMain = Color.FromArgb(141, 88, 155);
          this.ColorMainDeep = Color.FromArgb(103, 33, 122);
          break;
        case 3:
          this.ColorMain = Color.FromArgb(240, 98, 62);
          this.ColorMainDeep = Color.FromArgb(210, 71, 38);
          break;
        case 4:
          this.ColorMain = Color.FromArgb(67, 148, 103);
          this.ColorMainDeep = Color.FromArgb(33, 115, 70);
          break;
        case 5:
          this.ColorMain = Color.FromArgb(234, 152, 74);
          this.ColorMainDeep = Color.FromArgb(227, 118, 13);
          break;
        case 6:
          this.ColorMain = Color.FromArgb(62, 109, 182);
          this.ColorMainDeep = Color.FromArgb(43, 87, 155);
          break;
        case 7:
          this.ColorMain = Color.FromArgb(198, 85, 91);
          this.ColorMainDeep = Color.FromArgb(165, 52, 58);
          break;
        case 8:
          this.ColorMain = Color.FromArgb(141, 88, 156);
          this.ColorMainDeep = Color.FromArgb(103, 33, 123);
          break;
        case 9:
          this.ColorMain = Color.FromArgb(240, 98, 63);
          this.ColorMainDeep = Color.FromArgb(210, 71, 39);
          break;
        case 10:
          this.ColorMain = Color.FromArgb(67, 148, 104);
          this.ColorMainDeep = Color.FromArgb(33, 115, 71);
          break;
        case 11:
          this.ColorMain = Color.FromArgb(234, 152, 75);
          this.ColorMainDeep = Color.FromArgb(227, 118, 14);
          break;
        case 12:
          this.ColorMain = Color.FromArgb(75, 82, 66);
          this.ColorMainDeep = Color.FromArgb(44, 48, 34);
          break;
        case 13:
          this.ColorMain = Color.FromArgb(100, 130, 141);
          this.ColorMainDeep = Color.FromArgb(34, 62, 76);
          break;
        case 14:
          this.ColorMain = Color.FromArgb(240, 98, 63);
          this.ColorMainDeep = Color.FromArgb(210, 72, 38);
          break;
        case 15:
          this.ColorMain = Color.FromArgb(67, 148, 104);
          this.ColorMainDeep = Color.FromArgb(33, 116, 71);
          break;
        case 16:
          this.ColorMain = Color.FromArgb(62, 109, 182);
          this.ColorMainDeep = Color.FromArgb(43, 88, 155);
          break;
        case 17:
          this.ColorMain = Color.FromArgb(234, 152, 75);
          this.ColorMainDeep = Color.FromArgb(227, 119, 14);
          break;
        case 18:
          this.ColorMain = Color.FromArgb(75, 82, 67);
          this.ColorMainDeep = Color.FromArgb(44, 49, 35);
          break;
        case 19:
          this.ColorMain = Color.FromArgb(18, 68, 137);
          this.ColorMainDeep = Color.FromArgb(34, 46, 88);
          break;
        case 20:
          this.ColorMain = Color.FromArgb(18, 68, 137);
          this.ColorMainDeep = Color.FromArgb(34, 46, 88);
          break;
      }
      try
      {
        this.Event_ImgBackground_Resize(Skin);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void Parameter_Rosetta()
    {
    }

    public void TryParse()
    {
      string str = "Name=Fred;Birthday=19-June-1906;ID=12345";
      string[] strArray = str.Split(';');
      Func<string, string[]> selector;
      // ISSUE: reference to a compiler-generated field
      if (MainForm._Closure\u0024__.\u0024I170\u002D0 != null)
      {
        // ISSUE: reference to a compiler-generated field
        selector = MainForm._Closure\u0024__.\u0024I170\u002D0;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        MainForm._Closure\u0024__.\u0024I170\u002D0 = selector = (Func<string, string[]>) (atd => atd.Split('='));
      }
      IEnumerable<string[]> source = ((IEnumerable<string>) strArray).Select<string, string[]>(selector);
      Func<string[], string> keySelector;
      // ISSUE: reference to a compiler-generated field
      if (MainForm._Closure\u0024__.\u0024I170\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        keySelector = MainForm._Closure\u0024__.\u0024I170\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        MainForm._Closure\u0024__.\u0024I170\u002D1 = keySelector = (Func<string[], string>) (atd => atd[0]);
      }
      Func<string[], string> elementSelector;
      // ISSUE: reference to a compiler-generated field
      if (MainForm._Closure\u0024__.\u0024I170\u002D2 != null)
      {
        // ISSUE: reference to a compiler-generated field
        elementSelector = MainForm._Closure\u0024__.\u0024I170\u002D2;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        MainForm._Closure\u0024__.\u0024I170\u002D2 = elementSelector = (Func<string[], string>) (atd => atd[1]);
      }
      source.ToDictionary<string[], string, string>(keySelector, elementSelector);
      int num1 = (int) MessageBox.Show(str.Split('=').GetType().ToString());
      int num2 = (int) MessageBox.Show(Regex.Match("roll-call-term", "array", RegexOptions.IgnoreCase).Value);
    }

    public void Load_Language_Packs()
    {
      string language = this.Language;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(language))
      {
        case 1051869328:
          if (Operators.CompareString(language, "FRA", false) == 0)
          {
            this.Terms["doc-name-term"] = "Document";
            this.Terms["main-menu-theme-term"] = "Peau";
            this.Terms["main-menu-language-term"] = "Langue";
            this.Terms["main-menu-toolbox-term"] = "Widgets";
            this.Terms["main-menu-settings-term"] = "Paramètres";
            this.Terms["main-menu-close-term"] = "Fermer";
            this.Terms["delegation-term"] = "Délégation";
            this.Terms["topic-term"] = "Thème";
            this.Terms["total-time-term"] = "Temps Total";
            this.Terms["speech-time-term"] = "Temps/Délégué(e)";
            this.Terms["time-term"] = "Temps";
            this.Terms["passed-term"] = "Adoptée";
            this.Terms["failed-term"] = "Rejetée";
            this.Terms["ok-term"] = "D'accord";
            this.Terms["initialize-term"] = "Initialiser";
            this.Terms["start-term"] = "Commencer";
            this.Terms["pause-term"] = "Pause";
            this.Terms["stop-term"] = "Recommencer";
            this.Terms["present-term"] = "Présent";
            this.Terms["absent-term"] = "Absent";
            this.Terms["guest-term"] = "Invité(e)";
            this.Terms["target-term"] = "Intimé(e)";
            this.Terms["permission-granted-term"] = "Adoptée";
            this.Terms["permission-denied-term"] = "Rejetée";
            this.Terms["committee-term"] = "Comité";
            this.Terms["committee-topic-term"] = "Thème";
            this.Terms["speakers-list-term"] = "Liste ";
            this.Terms["copyright-comments"] = "MUNCS, Tous droits réservés.";
            this.Terms["welcome-comments"] = "Bienvenue à utiliser MUNCS Express.";
            this.Terms["initialize-comments"] = "Cliquer sur le bouton pour initialiser.";
            this.Terms["main-timer-console-comments"] = "Cliquer sur le bouton pour contrôler le Compteur Principal.";
            this.Terms["vote-term-array"] = "Procédure de Vote\\\\Voter pour le document\\\\Le nombre total\\\\Le 20 % des membres\\\\La majorité simple\\\\La majorité des deux tiers\\\\Oui\\\\Non\\\\Abstention\\\\Sauter\\\\Veto\\\\Retirer\\\\Annuler\\\\Appliquer\\\\Veto";
            this.Terms["roll-call-term-array"] = "Procédure d'Appel\\\\Manuel/ En ordre\\\\Le 20 % des membres\\\\La majorité simple\\\\La majorité des deux tiers\\\\Présent\\\\Absent\\\\Retirer\\\\Annuler\\\\Appliquer";
            this.Terms["theme-term-array"] = "Océan\\\\Vieillissement\\\\Pays des rêves\\\\Flamme\\\\Feuille\\\\Lumière du soleil\\\\Tissu-Bleu\\\\Tissu-Rouge\\\\Tissu-Violet\\\\Tissu-Orange\\\\Tissu-Vert\\\\Tissu-Jaune\\\\Paysage\\\\Jiangnan\\\\Érable\\\\Printemps\\\\Été\\\\Automne\\\\Hiver\\\\Montagne";
            this.Terms["moderated-caucus-toolbox-array"] = "Caucus Modéré\\\\0\\\\ \\\\ \\\\Déposer une motion pour un caucus modéré.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "Caucus Non Modéré\\\\1\\\\ \\\\ \\\\Déposer une motion pour un caucus non modéré.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "Fermer la Liste générale des Orateurs\\\\2\\\\ \\\\ \\\\Déposer une motion pour fermer la liste générale des orateurs.\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "Clôturer le débat\\\\3\\\\ \\\\ \\\\Déposer une motion pour fermer la liste générale des orateurs.\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "Suspendre la séance\\\\4\\\\ \\\\ \\\\Déposer une motion pour suspendre la séance.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "Ouvrir la Liste générale des Orateurs\\\\5\\\\ \\\\ \\\\Déposer une motion pour ouvrir la liste générale des orateurs.\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "Débat Libre\\\\6\\\\ \\\\ \\\\Déposer une motion pour lancer un débat libre.\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "Point d'Ordre\\\\7\\\\ \\\\ \\\\Point d'Ordre\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "Point d'Information parlementaire\\\\8\\\\ \\\\ \\\\Point d'Information parlementaire\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "Point de Privilège\\\\9\\\\ \\\\ \\\\Point de Privilège\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "Initialiser Procédure d'Appel\\\\10\\\\ \\\\ \\\\Initialiser le procédure d'Appel.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "Initialiser Procédure de Vote\\\\11\\\\ \\\\ \\\\Initialiser le procédure de Vote.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "Initialiser Compteur Principal\\\\12\\\\ \\\\ \\\\Initialiser le Compteur Principal.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "Console du Compteur Principal\\\\13\\\\ \\\\ \\\\Console du Compteur Principal.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "Présence\\\\14\\\\ \\\\ \\\\Modifier la liste de la présence.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "Débat Modéré\\\\15\\\\ \\\\ \\\\Déposer une motion pour un débat modéré.\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "Le Droit de Réponse\\\\16\\\\ \\\\ \\\\Présenter une déclaration en réponse qui peut être adoptée par le Président.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "Discours\\\\17\\\\ \\\\ \\\\Un Discours Illimité.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "Lire le Document\\\\18\\\\ \\\\ \\\\Fournir un certain temps pour lire un document.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "Voter pour le Document\\\\19\\\\ \\\\ \\\\Voter pour un document, généralement par appel nominal.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "Droit d'Interpellation\\\\20\\\\ \\\\ \\\\Demander à interpeller le délégué d'un pays.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ Caucus Modéré ]\\\\  {0} dépose une motion pour un caucus modéré.\\\\  Le thème est {1}.\\\\  Le temps total est de {2} secondes et chaque délégué a {3} secondes.";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ Caucus Non Modéré ]\\\\  {0} dépose une motion pour un caucus non modéré.\\\\  Le temps total est de {1} secondes.";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ Fermer la Liste générale des Orateurs ]\\\\  {0} dépose une motion pour fermer la liste générale des orateurs.";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ Clôture du Débat ]\\\\  {0} dépose une motion pour clôturer le débat.";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ Ajournement de la Séance ]\\\\  {0} dépose une motion pour ajourner la séance.";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ Ouvrir la Liste générale des Orateurs ]\\\\  {0} dépose une motion pour ouvrir la liste générale des orateurs.";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ Débat Libre ]\\\\  {0} dépose une motion pour lancer un débat libre.\\\\  Le temps total est de {1} secondes.";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ Point d’Ordre ]\\\\  {0} pose un point d’ordre.";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ Point d’Information parlementaire ]\\\\  {0} pose un point d’information parlementaire.";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ Procédure d’Appel ]\\\\  {0} pose un point de privilège.";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ Nom ]\\\\  {0} de {1} délégations présentes.\\\\  Le 20 % des membres est de {2}.\\\\  La majorité simple est de {3}.\\\\  La majorité des deux tiers est de {4}.";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ Résultat du Vote ]\\\\  Oui {0}. Non {1}. Abstention {2}.";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ Présence ]";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ Débat Modéré ]\\\\  {0} dépose une motion pour lancer un débat modéré.\\\\  Le thème est {1}.\\\\  Le temps total est de {2} secondes.";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ Le Droit de Réponse ]\\\\  {0} applique un droit de réponse.\\\\  Le temps total est de {1} secondes.";
            this.Expressions["address-expression"] = "\\\\\\\\[ Discours ]\\\\  Bienvenue au délégué de {0} pour prononcer un discours.";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ Lire le Document ]\\\\  {0} dépose une motion pour lire le document {1}.\\\\  Le temps total est de {2} secondes.";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ Voter pour le Document ]\\\\  {0} dépose une motion pour voter pour le document {1}.";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ Droit d'Interpellation ]\\\\  {0} demande à interpeller {1}.\\\\  Le temps total est de {2} secondes.";
            this.Expressions["motion-pass-expression"] = "\\\\  Cette motion est adoptée.";
            this.Expressions["motion-fail-expression"] = "\\\\  Cette motion est rejetée.";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  Ce document est adopté.";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  Ce document est rejeté.";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  Une délégation a voté pour le veto.";
            this.Expressions["attendance-present-expression"] = "\\\\  {0} est présent(e).";
            this.Expressions["attendance-absent-expression"] = "\\\\  {0} est absent(e).";
            this.Expressions["attendance-result-expression"] = "\\\\  La présence totale est maintenant de {0}.\\\\  Le 20 % des membres est de {1}.\\\\  La majorité simple est de {2}.\\\\  La majorité des deux tiers est de {3}.";
            this.Expressions["permission-granted-expression"] = "\\\\  Cette application est adoptée.";
            this.Expressions["permission-denied-expression"] = "\\\\  Cette applocation est rejetée.";
            break;
          }
          break;
        case 1264566126:
          if (Operators.CompareString(language, "CHT", false) == 0)
          {
            this.Terms["doc-name-term"] = "文件名";
            this.Terms["main-menu-theme-term"] = "主題";
            this.Terms["main-menu-language-term"] = "語言";
            this.Terms["main-menu-toolbox-term"] = "工具箱";
            this.Terms["main-menu-settings-term"] = "設置";
            this.Terms["main-menu-close-term"] = "退出";
            this.Terms["delegation-term"] = "代表團";
            this.Terms["topic-term"] = "主題";
            this.Terms["total-time-term"] = "總時長";
            this.Terms["speech-time-term"] = "單位時長";
            this.Terms["time-term"] = "時長";
            this.Terms["passed-term"] = "通過";
            this.Terms["failed-term"] = "未通過";
            this.Terms["ok-term"] = "好";
            this.Terms["initialize-term"] = "開始";
            this.Terms["start-term"] = "開始";
            this.Terms["pause-term"] = "暫停";
            this.Terms["stop-term"] = "重置";
            this.Terms["present-term"] = "出席";
            this.Terms["absent-term"] = "缺席";
            this.Terms["guest-term"] = "嘉賓";
            this.Terms["target-term"] = "對象";
            this.Terms["permission-granted-term"] = "允許";
            this.Terms["permission-denied-term"] = "不允許";
            this.Terms["committee-term"] = "委員會";
            this.Terms["committee-topic-term"] = "議題";
            this.Terms["speakers-list-term"] = "名單 ";
            this.Terms["copyright-comments"] = "MUNCS保留所有權利。";
            this.Terms["welcome-comments"] = "歡迎使用MUNCS Express。";
            this.Terms["initialize-comments"] = "點擊按鈕開始。";
            this.Terms["main-timer-console-comments"] = "點擊按鈕以控制計時器。";
            this.Terms["vote-term-array"] = "正在進行投票…\\\\對檔投票\\\\總數\\\\20% 數\\\\簡單多數\\\\三分之二多數\\\\贊同\\\\反對\\\\棄權\\\\跳過\\\\一票否決\\\\撤銷\\\\取消\\\\應用\\\\一票否決";
            this.Terms["roll-call-term-array"] = "正在進行點名…\\\\按順序點名\\\\20% 數\\\\簡單多數\\\\三分之二多數\\\\出席\\\\缺席\\\\撤銷\\\\取消\\\\應用";
            this.Terms["theme-term-array"] = "海洋\\\\陳釀\\\\夢鄉\\\\火焰\\\\新葉\\\\陽光\\\\織物-藍\\\\織物-紅\\\\織物-紫\\\\織物-橙\\\\織物-綠\\\\織物-黃\\\\山水\\\\江南\\\\紅葉\\\\春\\\\夏\\\\秋\\\\冬\\\\高山";
            this.Terms["moderated-caucus-toolbox-array"] = "有主持核心磋商\\\\0\\\\ \\\\ \\\\動議一個有主持核心磋商。\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "自由磋商\\\\1\\\\ \\\\ \\\\動議一個自由磋商。\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "關閉主發言名單\\\\2\\\\ \\\\ \\\\動議關閉主發言名單。\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "結束辯論\\\\3\\\\ \\\\ \\\\動議結束辯論。\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "休會\\\\4\\\\ \\\\ \\\\動議休會。\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "開啟主發言名單\\\\5\\\\ \\\\ \\\\動議開啟主發言名單。\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "自由辯論\\\\6\\\\ \\\\ \\\\動議一個自由辯論。\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "程式性問題\\\\7\\\\ \\\\ \\\\提出一個程式性問題。\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "諮詢性問題\\\\8\\\\ \\\\ \\\\提出一個諮詢性問題。\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "個人特權問題\\\\9\\\\ \\\\ \\\\提出一個個人特權問題。\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "點名\\\\10\\\\ \\\\ \\\\開始點名。\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "投票\\\\11\\\\ \\\\ \\\\開始投票。\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "設置計時器\\\\12\\\\ \\\\ \\\\設置計時器。\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "計時器控制台\\\\13\\\\ \\\\ \\\\控制計時器的開始、暫停、重置。\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "變更出席情況\\\\14\\\\ \\\\ \\\\修改當前出席代表資訊和出席代表總數。\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "有主題辯論\\\\15\\\\ \\\\ \\\\動議一個有主題辯論。\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "答辯權\\\\16\\\\ \\\\ \\\\提出答辯權。\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "發表致辭\\\\17\\\\ \\\\ \\\\邀請嘉賓發表一個致辭演講。\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "閱讀文件\\\\18\\\\ \\\\ \\\\動議閱讀文件。\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "對文件投票\\\\19\\\\ \\\\ \\\\動議對文件投票。\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "質詢權\\\\20\\\\ \\\\ \\\\對另一位代表提出質詢。\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ 有主持核心磋商 ]\\\\  {0}動議一個有主持核心磋商。\\\\  主題為{1}。\\\\  總時長為{2}秒，每位代表{3}秒。";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ 自由磋商 ]\\\\  {0}動議一個自由磋商。\\\\  總時長為{1}秒。";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ 關閉主發言名單 ]\\\\  {0}動議關閉主發言名單。";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ 結束辯論 ]\\\\  {0}動議結束辯論。";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ 休會 ]\\\\  {0}動議休會。";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ 開啟主發言名單 ]\\\\  {0}開啟主發言名單。";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ 自由辯論 ]\\\\  {0}動議開啟自由辯論。\\\\  總時長為{1}秒。";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ 程式性問題 ]\\\\  {0}提出了一個程式性問題。";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ 諮詢性問題 ]\\\\  {0}提出了一個諮詢性問題。";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ 個人特權問題 ]\\\\  {0}提出了一個個人特權問題。";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ 點名 ]\\\\  本次會議共有{1}個代表團，當前有{0}個代表團出席。\\\\  當前的20% 數為{2}，簡單多數為{3}，三分之二多數為{4}。";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ 投票 ]\\\\  本次投票共有{0}票贊同，{1}票反對，{2}票棄權。";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ 出席情況變更 ]\\\\  當前會場出席情況有所變更：";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ 有主題辯論 ]\\\\  {0}動議開啟有主題辯論。\\\\  主題為{1}。\\\\  總時長為{2}秒。";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ 答辯權 ]\\\\  {0}申請一個答辯權。\\\\  總時長為{1}秒。";
            this.Expressions["address-expression"] = "\\\\\\\\[ 致辭 ]\\\\  現在由{0}發表致辭。";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ 閱讀文件 ]\\\\  {0}動議閱讀{1}。\\\\  總時長為{2}秒。";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ 對文件投票 ]\\\\  {0}動議對{1}進行投票。";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ 質詢權 ]\\\\  {0}申請對{1}進行質詢。\\\\  總時長為{2}秒。";
            this.Expressions["motion-pass-expression"] = "\\\\  這一動議獲得通過。";
            this.Expressions["motion-fail-expression"] = "\\\\  這一動議未獲得通過。";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  經過投票，這一文件獲得通過。";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  經過投票，這一文件未獲得通過。";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  經過投票，這一文件被一票否決，未獲得通過。";
            this.Expressions["attendance-present-expression"] = "{0}現已出席。";
            this.Expressions["attendance-absent-expression"] = "{0}現已離席。";
            this.Expressions["attendance-result-expression"] = "\\\\  當前有{0}個代表團出席。當前的20% 數為{1}，簡單多數為{2}，三分之二多數為{3}。";
            this.Expressions["permission-granted-expression"] = "\\\\  這一申請獲得主席團允許。";
            this.Expressions["permission-denied-expression"] = "\\\\  這一申請未獲得主席團允許。";
            break;
          }
          break;
        case 1314898983:
          if (Operators.CompareString(language, "CHS", false) == 0)
          {
            this.Terms["doc-name-term"] = "文件名";
            this.Terms["main-menu-theme-term"] = "主题";
            this.Terms["main-menu-language-term"] = "语言";
            this.Terms["main-menu-toolbox-term"] = "工具箱";
            this.Terms["main-menu-settings-term"] = "设置";
            this.Terms["main-menu-close-term"] = "退出";
            this.Terms["delegation-term"] = "代表团";
            this.Terms["topic-term"] = "主题";
            this.Terms["total-time-term"] = "总时长";
            this.Terms["speech-time-term"] = "单位时长";
            this.Terms["time-term"] = "时长";
            this.Terms["passed-term"] = "通过";
            this.Terms["failed-term"] = "未通过";
            this.Terms["ok-term"] = "好";
            this.Terms["initialize-term"] = "开始";
            this.Terms["start-term"] = "开始";
            this.Terms["pause-term"] = "暂停";
            this.Terms["stop-term"] = "重置";
            this.Terms["present-term"] = "出席";
            this.Terms["absent-term"] = "缺席";
            this.Terms["guest-term"] = "嘉宾";
            this.Terms["target-term"] = "对象";
            this.Terms["permission-granted-term"] = "允许";
            this.Terms["permission-denied-term"] = "不允许";
            this.Terms["committee-term"] = "委员会";
            this.Terms["committee-topic-term"] = "议题";
            this.Terms["speakers-list-term"] = "名单 ";
            this.Terms["copyright-comments"] = "MUNCS保留所有权利。";
            this.Terms["welcome-comments"] = "欢迎使用MUNCS Express。";
            this.Terms["initialize-comments"] = "点击按钮开始。";
            this.Terms["main-timer-console-comments"] = "点击按钮以控制计时器。";
            this.Terms["vote-term-array"] = "正在进行投票…\\\\对文件投票\\\\总数\\\\20% 数\\\\简单多数\\\\三分之二多数\\\\赞同\\\\反对\\\\弃权\\\\跳过\\\\一票否决\\\\撤销\\\\取消\\\\应用\\\\一票否决";
            this.Terms["roll-call-term-array"] = "正在进行点名…\\\\按顺序点名\\\\20% 数\\\\简单多数\\\\三分之二多数\\\\出席\\\\缺席\\\\撤销\\\\取消\\\\应用";
            this.Terms["theme-term-array"] = "海洋\\\\陈酿\\\\梦乡\\\\火焰\\\\新叶\\\\阳光\\\\织物-蓝\\\\织物-红\\\\织物-紫\\\\织物-橙\\\\织物-绿\\\\织物-黄\\\\山水\\\\江南\\\\红叶\\\\春\\\\夏\\\\秋\\\\冬\\\\高山";
            this.Terms["moderated-caucus-toolbox-array"] = "有主持核心磋商\\\\0\\\\ \\\\ \\\\动议一个有主持核心磋商。\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "自由磋商\\\\1\\\\ \\\\ \\\\动议一个自由磋商。\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "关闭主发言名单\\\\2\\\\ \\\\ \\\\动议关闭主发言名单。\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "结束辩论\\\\3\\\\ \\\\ \\\\动议结束辩论。\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "休会\\\\4\\\\ \\\\ \\\\动议休会。\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "开启主发言名单\\\\5\\\\ \\\\ \\\\动议开启主发言名单。\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "自由辩论\\\\6\\\\ \\\\ \\\\动议一个自由辩论。\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "程序性问题\\\\7\\\\ \\\\ \\\\提出一个程序性问题。\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "咨询性问题\\\\8\\\\ \\\\ \\\\提出一个咨询性问题。\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "个人特权问题\\\\9\\\\ \\\\ \\\\提出一个个人特权问题。\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "点名\\\\10\\\\ \\\\ \\\\开始点名。\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "投票\\\\11\\\\ \\\\ \\\\开始投票。\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "设置计时器\\\\12\\\\ \\\\ \\\\设置计时器。\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "计时器控制台\\\\13\\\\ \\\\ \\\\控制计时器的开始、暂停、重置。\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "变更出席情况\\\\14\\\\ \\\\ \\\\修改当前出席代表信息和出席代表总数。\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "有主题辩论\\\\15\\\\ \\\\ \\\\动议一个有主题辩论。\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "答辩权\\\\16\\\\ \\\\ \\\\提出答辩权。\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "发表致辞\\\\17\\\\ \\\\ \\\\邀请嘉宾发表一个致辞演讲。\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "阅读文件\\\\18\\\\ \\\\ \\\\动议阅读文件。\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "对文件投票\\\\19\\\\ \\\\ \\\\动议对文件投票。\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "质询权\\\\20\\\\ \\\\ \\\\对另一位代表提出质询。\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ 有主持核心磋商 ]\\\\  {0}动议一个有主持核心磋商。\\\\  主题为{1}。\\\\  总时长为{2}秒， 每位代表{3}秒。";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ 自由磋商 ]\\\\  {0}动议一个自由磋商。\\\\  总时长为{1}秒。";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ 关闭主发言名单 ]\\\\  {0}动议关闭主发言名单。";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ 结束辩论 ]\\\\  {0}动议结束辩论。";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ 休会 ]\\\\  {0}动议休会。";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ 开启主发言名单 ]\\\\  {0}开启主发言名单。";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ 自由辩论 ]\\\\  {0}动议开启自由辩论。\\\\  总时长为{1}秒。";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ 程序性问题 ]\\\\  {0}提出了一个程序性问题。";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ 咨询性问题 ]\\\\  {0}提出了一个咨询性问题。";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ 个人特权问题 ]\\\\  {0}提出了一个个人特权问题。";
            this.Expressions["initialize-roll-Call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ 点名 ]\\\\  本次会议共有{1}个代表团， 当前有{0}个代表团出席。\\\\  当前的20% 数为{2}， 简单多数为{3}， 三分之二多数为{4}。";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ 投票 ]\\\\  本次投票共有{0}票赞同， {1}票反对， {2}票弃权。";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ 出席情况变更 ]\\\\  当前会场出席情况有所变更：";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ 有主题辩论 ]\\\\  {0}动议开启有主题辩论。\\\\  主题为{1}。\\\\  总时长为{2}秒。";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ 答辩权 ]\\\\  {0}申请一个答辩权。\\\\  总时长为{1}秒。";
            this.Expressions["address-expression"] = "\\\\\\\\[ 致辞 ]\\\\  现在由{0}发表致辞。";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ 阅读文件 ]\\\\  {0}动议阅读{1}。\\\\  总时长为{2}秒。";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ 对文件投票 ]\\\\  {0}动议对{1}进行投票。";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ 质询权 ]\\\\  {0}申请对{1}进行质询。\\\\  总时长为{2}秒。";
            this.Expressions["motion-pass-expression"] = "\\\\  这一动议获得通过。";
            this.Expressions["motion-fail-expression"] = "\\\\  这一动议未获得通过。";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  经过投票，这一文件获得通过。";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  经过投票，这一文件未获得通过。";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  经过投票，这一文件被一票否决，未获得通过。";
            this.Expressions["attendance-present-expression"] = "{0}现已出席。";
            this.Expressions["attendance-absent-expression"] = "{0}现已离席。";
            this.Expressions["attendance-result-expression"] = "\\\\  当前有{0}个代表团出席。当前的20% 数为{1}，简单多数为{2}，三分之二多数为{3}。";
            this.Expressions["permission-granted-expression"] = "\\\\  这一申请获得主席团允许。";
            this.Expressions["permission-denied-expression"] = "\\\\  这一申请未获得主席团允许。";
            break;
          }
          break;
        case 1753121147:
          if (Operators.CompareString(language, "JPN", false) == 0)
          {
            this.Terms["doc-name-term"] = "ドキュメント";
            this.Terms["main-menu-theme-term"] = "スキン";
            this.Terms["main-menu-language-term"] = "ことば";
            this.Terms["main-menu-toolbox-term"] = "ツールボックス";
            this.Terms["main-menu-settings-term"] = "設置";
            this.Terms["main-menu-close-term"] = "やめる";
            this.Terms["delegation-term"] = "代表団";
            this.Terms["topic-term"] = "テーマ";
            this.Terms["total-time-term"] = "総時間";
            this.Terms["speech-time-term"] = "ひとびとの時間";
            this.Terms["time-term"] = "時間";
            this.Terms["passed-term"] = "採択する";
            this.Terms["failed-term"] = "採択しない";
            this.Terms["ok-term"] = "良い";
            this.Terms["initialize-term"] = "初期化";
            this.Terms["start-term"] = "スタート";
            this.Terms["pause-term"] = "一時停止";
            this.Terms["stop-term"] = "リセット";
            this.Terms["present-term"] = "出席";
            this.Terms["absent-term"] = "欠席";
            this.Terms["guest-term"] = "貴賓";
            this.Terms["target-term"] = "対象";
            this.Terms["permission-granted-term"] = "許可する";
            this.Terms["permission-denied-term"] = "却下する";
            this.Terms["committee-term"] = "会場";
            this.Terms["committee-topic-term"] = "トピック";
            this.Terms["speakers-list-term"] = "リスト ";
            this.Terms["copyright-comments"] = "MUNCSチームすべての権利を保有。";
            this.Terms["welcome-comments"] = "MUNCS Expressへようこそ。";
            this.Terms["initialize-comments"] = "初期化するために、ボタンをクリックしてください。";
            this.Terms["main-timer-console-comments"] = "制御タイマ、ボタンをクリックしてください。";
            this.Terms["vote-term-array"] = "投票\\\\投票システム\\\\合計\\\\20％の数\\\\過半数\\\\2/3人超過\\\\賛成\\\\反対\\\\弃権\\\\スキップ\\\\一票で却下\\\\後退\\\\取り消す\\\\アプリケーション\\\\一票で却下";
            this.Terms["roll-call-term-array"] = "点名\\\\手動 / オーダー\\\\20％の数\\\\過半数\\\\2/3人超過\\\\出席\\\\欠席\\\\後退\\\\取り消す\\\\アプリケーション";
            this.Terms["theme-term-array"] = "オーシャン\\\\レセルバ\\\\夢の国\\\\炎\\\\新葉\\\\日光\\\\織物-藍\\\\織物-赤\\\\織物-紫\\\\織物-橙\\\\織物-緑\\\\織物-黄\\\\山水\\\\江南\\\\紅葉\\\\春\\\\夏\\\\秋\\\\冬\\\\高山";
            this.Terms["moderated-caucus-toolbox-array"] = "核心問題を打ち合わせする\\\\0\\\\ \\\\ \\\\Motion for a moderated caucus.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "自由に打ち合わせする\\\\1\\\\ \\\\ \\\\Motion for an unmoderated caucus.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "主なスポークスマン クローズ\\\\2\\\\ \\\\ \\\\Motion to close speakers list.\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "弁論を終了する\\\\3\\\\ \\\\ \\\\Motion to close speakers list.\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "休会\\\\4\\\\ \\\\ \\\\Motion to suspended the meeting.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "主なスポークスマン オープン\\\\5\\\\ \\\\ \\\\Motion to open speakers list.\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "ディベート\\\\6\\\\ \\\\ \\\\Motion to set a debate.\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "規則についての質疑\\\\7\\\\ \\\\ \\\\Point of order.\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "規則についての質問\\\\8\\\\ \\\\ \\\\Point of inquiry.\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "プライベートな願い\\\\9\\\\ \\\\ \\\\Point of personal privilege\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "点呼\\\\10\\\\ \\\\ \\\\Initialise the system for roll call procedure in detailed function.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "投票\\\\11\\\\ \\\\ \\\\Initialise the system for voting procedure in detailed function.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "タイマの設定\\\\12\\\\ \\\\ \\\\Initialise the Main Timer.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "制御タイマ\\\\13\\\\ \\\\ \\\\Console of the Main Timer.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "改正出席情報\\\\14\\\\ \\\\ \\\\Edit the list of presence.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "動議有主題辯論\\\\15\\\\ \\\\ \\\\Motion for a moderated debate.\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "答弁權\\\\16\\\\ \\\\ \\\\The right of reply.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "挨拶を述べる\\\\17\\\\ \\\\ \\\\An address by the guest.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "動議閱讀文件\\\\18\\\\ \\\\ \\\\Motion for reading the document.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "動議對文件投票\\\\19\\\\ \\\\ \\\\Motion to vote on a document.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "質問權\\\\20\\\\ \\\\ \\\\A challenge to another delegate.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ 核心問題を打ち合わせする ]\\\\  {0}は核心問題を打ち合わせすることを提案します。\\\\  議論内容は次のとおりです{1}。\\\\  総時間は{2}秒， 一人ごとにの発表する時間は{3}秒。";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ 自由に打ち合わせする ]\\\\  {0}は自由に打ち合わせすることを提案します。\\\\  総時間は{1}秒。";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ 主なスポークスマンオープン ]\\\\  {0}は主なスポークスマン オープンことを提案します。";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ 弁論を終了する ]\\\\  {0}は弁論を終了することを提案します。";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ 休会 ]\\\\  {0}は休会することを提案します。";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ 主なスポークスマン クローズ ]\\\\  {0}は主なスポークスマンクローズことを提案します。";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ ディベート ]\\\\  {0}はディベートことを提案します。\\\\  総時間は{1}秒。";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ 規則についての質疑 ]\\\\  {0}は規則についての質疑を行います。";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ 規則についての質問 ]\\\\  {0}は規則についての質問を出します。";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[  プライベートな願い ]\\\\  {0}プライベートな願いを出します。";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ 点呼 ]\\\\  {1}の代表団の合計。{0}の代表団の出席。\\\\  20％の数ことが{2}。\\\\  過半数ことが{3}。\\\\  2/3人超過の数ことが{4}。";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ 投票 ]\\\\  {0}賛成。{1}反対。{2}弃権。";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ 出席情况变更 ]\\\\  当前会场出席情况有所变更：";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ 有主题辩论 ]\\\\  {0}动议开启有主题辩论。\\\\  主题为{1}。\\\\  总时长为{2}秒。";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ 答辩权 ]\\\\  {0}申请一个答辩权。\\\\  总时长为{1}秒。";
            this.Expressions["address-expression"] = "\\\\\\\\[ 致辞 ]\\\\  现在由{0}发表致辞。";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ 阅读文件 ]\\\\  {0}动议阅读{1}。\\\\  总时长为{2}秒。";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ 对文件投票 ]\\\\  {0}动议对{1}进行投票。";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ 质询权 ]\\\\  {0}申请对{1}进行质询。\\\\  总时长为{2}秒。";
            this.Expressions["motion-pass-expression"] = "\\\\  採択する。";
            this.Expressions["motion-fail-expression"] = "\\\\  採択しない。";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  採択する。";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  採択しない。";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  一票で却下。";
            this.Expressions["attendance-present-expression"] = "{0}现已出席。";
            this.Expressions["attendance-absent-expression"] = "{0}现已离席。";
            this.Expressions["attendance-result-expression"] = "\\\\  当前有{0}个代表团出席。当前的20% 数为{1}，简单多数为{2}，三分之二多数为{3}。";
            this.Expressions["permission-granted-expression"] = "\\\\  这一申请获得主席团允许。";
            this.Expressions["permission-denied-expression"] = "\\\\  这一申请未获得主席团允许。";
            break;
          }
          break;
        case 2498149201:
          if (Operators.CompareString(language, "GER", false) == 0)
          {
            this.Terms["doc-name-term"] = "Dokument";
            this.Terms["main-menu-theme-term"] = "Themen";
            this.Terms["main-menu-language-term"] = "Sprache";
            this.Terms["main-menu-toolbox-term"] = "Widgets";
            this.Terms["main-menu-settings-term"] = "Parameter";
            this.Terms["main-menu-close-term"] = "Schließen";
            this.Terms["delegation-term"] = "Delegation";
            this.Terms["topic-term"] = "Thema";
            this.Terms["total-time-term"] = "Gesamtdauer";
            this.Terms["speech-time-term"] = "Redezeit";
            this.Terms["time-term"] = "Zeit";
            this.Terms["passed-term"] = "Angenommen";
            this.Terms["failed-term"] = "Abgelehnt";
            this.Terms["ok-term"] = "OK";
            this.Terms["initialize-term"] = "Instalisieren";
            this.Terms["start-term"] = "Start";
            this.Terms["pause-term"] = "Pause";
            this.Terms["stop-term"] = "Zurücksetzen";
            this.Terms["present-term"] = "Anwesend";
            this.Terms["absent-term"] = "Abwesend";
            this.Terms["guest-term"] = "Gast";
            this.Terms["target-term"] = "Antwortende";
            this.Terms["permission-granted-term"] = "Angenommen";
            this.Terms["permission-denied-term"] = "Abgelehnt";
            this.Terms["committee-term"] = "Gremium";
            this.Terms["committee-topic-term"] = "Tagesordnung";
            this.Terms["speakers-list-term"] = "Liste ";
            this.Terms["copyright-comments"] = "MUNCS. Alle Rechte vorbehalten.";
            this.Terms["welcome-comments"] = "Willkommen bei MUNCS Express.";
            this.Terms["initialize-comments"] = "Klicken Sie auf den Knopf zu instalisieren.";
            this.Terms["main-timer-console-comments"] = "Klicken Sie auf den Knopf, indem Sie den Hauptzeitgeber bedienen.";
            this.Terms["vote-term-array"] = "Abstimmungsverfahren\\\\Abstimmung des Dokuments\\\\Gesamt\\\\20 % Anzahl\\\\Einfache Mehrheit\\\\Zweidrittelmehrheit\\\\Dafür\\\\Dagegen\\\\Enthaltung\\\\Vorbei\\\\Veto\\\\Zurück\\\\Abbrechen\\\\Festlegen\\\\Veto";
            this.Terms["roll-call-term-array"] = "Appellverfahren\\\\Manuell / nach Reihenfolge\\\\20 % Anzahl\\\\Einfache Mehrheit\\\\Zweidrittelmehrheit\\\\Anwesend\\\\Abwesend\\\\Zurück\\\\Abbrechen\\\\Festlegen";
            this.Terms["theme-term-array"] = "Ozean\\\\Wein\\\\Träume\\\\Flamme\\\\Blätter\\\\Sonnenschein\\\\Textil-Blau\\\\Textil-Rot\\\\Textil-Lila\\\\Textil-Orange\\\\Textil-Grün\\\\Textil-Gelb\\\\Landschaft\\\\Yangtze\\\\Ahornblatt\\\\Frühling\\\\Sommer\\\\Herbst\\\\Winter\\\\Berg";
            this.Terms["moderated-caucus-toolbox-array"] = "Moderierte Debatte\\\\0\\\\ \\\\ \\\\Stellen Sie einen Antrag auf eine moderierte Debatte.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "Unmoderierte Debatte\\\\1\\\\ \\\\ \\\\Stellen Sie einen Antrag auf eine unmoderierte Debatte.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "Redeliste schließen\\\\2\\\\ \\\\ \\\\Stellen Sie einen Antrag, die Redelist zu schließen.\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "Ende der Debatte\\\\3\\\\ \\\\ \\\\Stellen Sie einen Antrag, die Redelist zu schließen.\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "Vertagung\\\\4\\\\ \\\\ \\\\Stellen Sie einen Antrag auf die Vertagung.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "Redeliste öffnen\\\\5\\\\ \\\\ \\\\Stellen Sie einen Antrag, die Redelist zu öffnen.\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "Freie Debatte\\\\6\\\\ \\\\ \\\\Stellen Sie einen Antrag auf eine freie Debatte.\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "Recht auf Widerherstellung\\\\7\\\\ \\\\ \\\\Stellen Sie einen Antrag des Recht auf Widerherstellung.\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "Recht auf Information/Klärung\\\\8\\\\ \\\\ \\\\Stellen Sie einen Antrag des Recht auf Information oder des Recht auf Klärung eines Missverständnisses.\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "Persönliches Privileg\\\\9\\\\ \\\\ \\\\Stellen Sie einen Antrag des persönlichen Privileges.\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "Init. des Appellverfahrens\\\\10\\\\ \\\\ \\\\Das System wird initialisiert, indem Sie mit einem Appellverfahren anfangen können.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "Init. des Abstimmungsverfahrens\\\\11\\\\ \\\\ \\\\Das System wird initialisiert, indem Sie mit einem Abstimmungsverfahren anfangen können.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "Initialisierung des Hauptzeitgebers\\\\12\\\\ \\\\ \\\\Der Hauptzeitgeber wird initialisiert.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "Konsole des Hauptzeitgebers\\\\13\\\\ \\\\ \\\\Bedienen Sie den Hauptzeitgeber, indem Sie den Hauptzeitgeber starten, pausieren und zurücksetzen.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "Änderung der Anwesenheit\\\\14\\\\ \\\\ \\\\Aktualisieren die aktuelle Anzahl und die Informationen der Anwesende.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "Debatte mit Themen\\\\15\\\\ \\\\ \\\\Stellen Sie einen Antrag auf eine Debatte mit Themen.\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "Gegendarstellung\\\\16\\\\ \\\\ \\\\Beantragen Sie beim Vorsitz eine Gegendarstellung.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "Ansprechen\\\\17\\\\ \\\\ \\\\Laden Sie den Gast ein, um eine Rede zu richten.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "Ein Dokument lesen\\\\18\\\\ \\\\ \\\\Stellen Sie einen Antrag, Zeit zu erteilen, um ein Dokument zu lesen.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "Antrag auf Abstimmung\\\\19\\\\ \\\\ \\\\Stellen Sie einen Antrag auf die Abstimmung über ein Dokument, in der Regel durch einen Appell.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "Anfragerecht\\\\20\\\\ \\\\ \\\\Beantragen Sie eine Anfragerecht an einer anderen Delegation.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ Moderierte Debatte ]\\\\  {0} stellt einen Antrag auf eine moderierte Debatte.\\\\  Das Thema dieser Debatte ist – {1}.\\\\  Die Gesamtdauer dieser Debatte beträgt {2} Sekunden, Die Redezeit pro RednerIn beträgt {3} Sekunden.";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ Unmoderierte Debatte ]\\\\  {0} stellt einen Antrag auf eine unmoderierte Debatte.\\\\  Die Gesamtdauer dieser Debatte beträgt {1} Sekunden.";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ Schluss der Redeliste ]\\\\  {0} stellt einen Antrag auf den Schluss der Redeliste.";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ Schluss der Debatte ]\\\\  {0} stellt einen Antrag auf den Schluss der Debatte.";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ Vertagung ]\\\\  {0} stellt einen Antrag auf die Vertagung.";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ Öffnung der Redeliste ]\\\\  {0} stellt einen Antrag auf die Öffnung der Redeliste.";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ Freie Debatte ]\\\\  {0} stellt einen Antrag auf eine freie Debatte.\\\\  Die Gesamtdauer dieser Debatte beträgt {1} Sekunden.";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ Recht auf Wiederherstellung der Ordnung ]\\\\  {0} stellt einen Antrag des Recht auf Wiederherstellung der Ordnung.";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ Recht auf Information / Recht auf Klärung eines Missverständnisses ]\\\\  {0} stellt einen Antrag des Recht auf Information / auf Klärung eines Missverständnisses.";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ Persönliches Privileg ]\\\\  {0} stellt einen Antrag des persönlichen Privileges.";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ Appellverfahren ]\\\\  {0} Delegationen von {1} Delegationen sind zurzeit anwesend.\\\\  Die 20%-Anzahl beträgt {2}, die einfache Mehrheit beträgt {3}, die Zweidrittelmehrheit beträgt {4}.";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ Abstimmungsergebnis ]\\\\  Pro – {0}, Contra – {1}, Enthaltung – {2}.";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ Änderung der Anwesenheit ]\\\\  Die Anwesenheit hat sich geändert: ";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ Debatte mit Themen ]\\\\  {0} stellt einen Antrag auf eine Debatte mit Themen.\\\\  Das Thema dieser Debatte ist – {1}.\\\\  Die Gesamtdauer dieses Antrags beträgt {2} Sekunden.";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ Gegendarstellung ]\\\\  {0} stellt einen Antrag auf eine Gegendarstellung.\\\\  Die Redezeit beträgt {1} Sekunden.";
            this.Expressions["address-expression"] = "\\\\\\\\[ Ansprache ]\\\\  Wir begrüßen {0}, um an uns zu richten.";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ Lesen des Dokuments ]\\\\  {0}  stellt einen Antrag, Zeit zu erteilen, um das Dokument {1} zu lesen.\\\\  Die Gesamtdauer beträgt {2} Sekunden.";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ Abstimmung des Dokuments ]\\\\  {0} stellt einen Antrag auf die Abstimmung über das Dokument {1}.";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ Anfragerecht ]\\\\  {0} beantragt eine Anfragerecht an {1}.\\\\  Die Redezeit beträgt {2} Sekunden.";
            this.Expressions["motion-pass-expression"] = "\\\\  Dieser Antrag wurde angenommen.";
            this.Expressions["motion-fail-expression"] = "\\\\  Dieser Antrag wurde abgelehnt.";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  Dieses Dokument wurde verabschiedet.";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  Dieses Dokument wurde abgelehnt.";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  Dieses Dokument wurde aufgrund des Vetorechts abgelehnt.";
            this.Expressions["attendance-present-expression"] = "{0} wurde anwesend.";
            this.Expressions["attendance-absent-expression"] = "{0} wurde abwesend.";
            this.Expressions["attendance-result-expression"] = "\\\\  Die aktuelle Anzahl der Anwesende beträgt {0}. Die 20%-Anzahl beträgt {1}, die einfache Mehrheit beträgt {2}, die Zweidrittelmehrheit beträgt {3}.";
            this.Expressions["permission-granted-expression"] = "\\\\  Dieser Antrag wurde angenommen.";
            this.Expressions["permission-denied-expression"] = "\\\\  Dieser Antrag wurde abgelehnt.";
            break;
          }
          break;
        case 2923663479:
          if (Operators.CompareString(language, "ENG", false) == 0)
          {
            this.Terms["doc-name-term"] = "Document";
            this.Terms["main-menu-theme-term"] = "Skin";
            this.Terms["main-menu-language-term"] = "Language";
            this.Terms["main-menu-toolbox-term"] = "Toolbox";
            this.Terms["main-menu-settings-term"] = "Settings";
            this.Terms["main-menu-close-term"] = "Close";
            this.Terms["delegation-term"] = "Delegation";
            this.Terms["topic-term"] = "Topic";
            this.Terms["total-time-term"] = "Total Time";
            this.Terms["speech-time-term"] = "Time";
            this.Terms["time-term"] = "Time";
            this.Terms["passed-term"] = "Pass";
            this.Terms["failed-term"] = "Fail";
            this.Terms["ok-term"] = "OK";
            this.Terms["initialize-term"] = "Initialize";
            this.Terms["start-term"] = "Start";
            this.Terms["pause-term"] = "Pause";
            this.Terms["stop-term"] = "Reset";
            this.Terms["present-term"] = "Present";
            this.Terms["absent-term"] = "Absent";
            this.Terms["guest-term"] = "Guest";
            this.Terms["target-term"] = "Replier";
            this.Terms["permission-granted-term"] = "Pass";
            this.Terms["permission-denied-term"] = "Fail";
            this.Terms["committee-term"] = "Committee";
            this.Terms["committee-topic-term"] = "Topic";
            this.Terms["speakers-list-term"] = "List ";
            this.Terms["copyright-comments"] = "MUNCS Team All Rights Reserved.";
            this.Terms["welcome-comments"] = "Welcome to MUNCS Express.";
            this.Terms["initialize-comments"] = "Click button below to initialize.";
            this.Terms["main-timer-console-comments"] = "Click button below to control.";
            this.Terms["vote-term-array"] = "Voting Procedure\\\\Vote on Documents\\\\Total\\\\20% Number\\\\Simple Majority\\\\2/3 Majority\\\\Yes\\\\No\\\\Abstain\\\\Pass\\\\Veto\\\\Undo\\\\Cancel\\\\Apply\\\\Veto";
            this.Terms["roll-call-term-array"] = "Roll Call Procedure\\\\Manual / In Order\\\\20% Number\\\\Simple Majority\\\\2/3 Majority\\\\Present\\\\Absent\\\\Undo\\\\Cancel\\\\Apply";
            this.Terms["theme-term-array"] = "Ocean\\\\Wine\\\\Dream\\\\Flame\\\\Leaf\\\\Sunshine\\\\Fabric-Blue\\\\Fabric-Red\\\\Fabric-Purple\\\\Fabric-Orange\\\\Fabric-Green\\\\Fabric-Yellow\\\\Landscape\\\\Jiangnan\\\\Maple\\\\Spring\\\\Summer\\\\Autumn\\\\Winter\\\\Mountain";
            this.Terms["moderated-caucus-toolbox-array"] = "Moderated Caucus\\\\0\\\\ \\\\ \\\\Motion for a moderated caucus.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "Unmoderated Caucus\\\\1\\\\ \\\\ \\\\Motion for an unmoderated caucus.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "Close Speakers List\\\\2\\\\ \\\\ \\\\Motion to close speakers list.\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "Close the Debate\\\\3\\\\ \\\\ \\\\Motion to close speakers list.\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "Suspend the Meeting\\\\4\\\\ \\\\ \\\\Motion to suspended the meeting.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "Open Speakers List\\\\5\\\\ \\\\ \\\\Motion to open speakers list.\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "Free Debate\\\\6\\\\ \\\\ \\\\Motion to set a debate.\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "Point of Order\\\\7\\\\ \\\\ \\\\Point of order.\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "Point of Inquiry\\\\8\\\\ \\\\ \\\\Point of inquiry.\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "Point of Personal Privilege\\\\9\\\\ \\\\ \\\\Point of personal privilege\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "Initialise Roll Call Procedure\\\\10\\\\ \\\\ \\\\Initialise the system for roll call procedure in detailed function.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "Initialise Voting Procedure\\\\11\\\\ \\\\ \\\\Initialise the system for voting procedure in detailed function.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "Initialise Main Timer\\\\12\\\\ \\\\ \\\\Initialise the Main Timer.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "Console of Main Timer\\\\13\\\\ \\\\ \\\\Console of the Main Timer.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "Attendance\\\\14\\\\ \\\\ \\\\Edit the list of presence.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "Moderated Debate\\\\15\\\\ \\\\ \\\\Motion for a moderated debate.\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "Right of Reply\\\\16\\\\ \\\\ \\\\The right of reply.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "Address\\\\17\\\\ \\\\ \\\\An address by the guest.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "Read Document\\\\18\\\\ \\\\ \\\\Motion for reading the document.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "Vote on Document\\\\19\\\\ \\\\ \\\\Motion to vote on a document.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "Challenge\\\\20\\\\ \\\\ \\\\A challenge to another delegate.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ Moderated Caucus ]\\\\  {0} moves for a moderated caucus.\\\\  The topic is {1}.\\\\  The total time is {2} sec and {3} sec for each delegate.";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ Unmoderated Caucus ]\\\\  {0} moves for an unmoderated caucus.\\\\  The total time is {1} sec.";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ Close Speakers List ]\\\\  {0} moves to close the speakers list.";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ Close the Debate ]\\\\  {0} moves to close the debate.";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ Suspend the Meeting ]\\\\  {0} moves to suspended the meeting.";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ Open Speakers List ]\\\\  {0} moves to open speakers list.";
            this.Expressions["free-debate-expression"] = "\\\\\\\\ [ Free Debate ]\\\\  {0} moves to set a free debate.\\\\  The total time is {1} sec.";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ Point Of Order ]\\\\  {0} raised a point Of order.";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ Point Of Inquiry ]\\\\  {0} raised a point Of inquiry.";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ Point Of Personal Privilege ]\\\\ {0} raised a point Of personal privilege.";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ Roll Call Procedure ]\\\\  {0} of {1} delegations are present.\\\\  The 20% number is {2}, the simple majority is {3} and the 2/3 majority is {4}.";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ Voting Procedure ]\\\\ {0} voted in favor, {1} voted against and {2} abstained.";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ Attendance ]";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ Moderated Debate ]\\\\  {0} moves For a moderated debate.\\\\  The topic is {1}.\\\\  The total time is {2} sec.";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ Right of Reply ]\\\\  {0} request for the right of reply.\\\\  The total time is {1} sec.";
            this.Expressions["address-expression"] = "\\\\\\\\[ Address ]\\\\  Welcome {0} to deliver address.";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ Read Document ]\\\\  {0} moves To read {1}.\\\\  The total time is {2} sec.";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ Vote on Document ]\\\\  {0} moves to vote on {1}.";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ Right to Inquiry ]\\\\  {0} applied to inquire {1}.\\\\  The total time is {2} seconds.";
            this.Expressions["motion-pass-expression"] = "\\\\  This motion passed.";
            this.Expressions["motion-fail-expression"] = "\\\\  This motion failed.";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  After voting, this document was adopted.";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  After voting, this document was not adopted.";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  After voting, this document was vetoed and was not adopted.";
            this.Expressions["attendance-present-expression"] = "\\\\  {0} is now present.";
            this.Expressions["attendance-absent-expression"] = "\\\\  {0} is now absent.";
            this.Expressions["attendance-result-expression"] = "\\\\  The total attendance now is {0}. The 20% number is {1}, the simple majority is {2} and the 2/3 majority is {3}.";
            this.Expressions["permission-granted-expression"] = "\\\\  Permission granted.";
            this.Expressions["permission-denied-expression"] = "\\\\  Request denied.";
            break;
          }
          break;
        case 2997342857:
          if (Operators.CompareString(language, "RUS", false) == 0)
          {
            this.Terms["doc-name-term"] = "документ";
            this.Terms["main-menu-theme-term"] = "Темы";
            this.Terms["main-menu-language-term"] = "Языки";
            this.Terms["main-menu-toolbox-term"] = "Виджеты";
            this.Terms["main-menu-settings-term"] = "Параметры";
            this.Terms["main-menu-close-term"] = "Выходить";
            this.Terms["delegation-term"] = "Делегации";
            this.Terms["topic-term"] = "Цель";
            this.Terms["total-time-term"] = "Общее время";
            this.Terms["speech-time-term"] = "Время оратора";
            this.Terms["time-term"] = "Время";
            this.Terms["passed-term"] = "Принято";
            this.Terms["failed-term"] = "Отклонено";
            this.Terms["ok-term"] = "Да";
            this.Terms["initialize-term"] = "Инициализировать";
            this.Terms["start-term"] = "Запуск";
            this.Terms["pause-term"] = "Приостановление";
            this.Terms["stop-term"] = "Сброс";
            this.Terms["present-term"] = "Присутствие";
            this.Terms["absent-term"] = "Отсутствие";
            this.Terms["guest-term"] = "Гость";
            this.Terms["target-term"] = "Отвечающий";
            this.Terms["permission-granted-term"] = "Разрешить";
            this.Terms["permission-denied-term"] = "Отказать";
            this.Terms["committee-term"] = "Комитет";
            this.Terms["committee-topic-term"] = "Повестка дня";
            this.Terms["speakers-list-term"] = "Список ";
            this.Terms["copyright-comments"] = "MUNCS. Все права защищены.";
            this.Terms["welcome-comments"] = "Добро пожаловать в MUNCS Экспресс.";
            this.Terms["initialize-comments"] = "Нажмите кнопку, чтобы инициализировать.";
            this.Terms["main-timer-console-comments"] = "Нажмите кнопку, чтобы управлять таймером.";
            this.Terms["vote-term-array"] = "Процедуры голосования\\\\Голосование по проектам\\\\Итог\\\\20 % голосов\\\\Простое больш.\\\\2/3 больш.\\\\За\\\\Против\\\\Воздержаться\\\\Пропустить\\\\Вето\\\\Возврат\\\\Отмена\\\\Применить\\\\Вето";
            this.Terms["roll-call-term-array"] = "Перекличка\\\\Ручная / По порядку\\\\20 % голосов\\\\Простое больш.\\\\2/3 больш.\\\\Присутствие\\\\Отсутствие\\\\Возврат\\\\Отмена\\\\Применить";
            this.Terms["theme-term-array"] = "Океан\\\\Вино\\\\Мечта\\\\Пламя\\\\Листья\\\\Солнышко\\\\Ткань-Синий\\\\Ткань-Красный\\\\Ткань-Фиолетовый\\\\Tкань-Оранжевый\\\\Ткань-Зелёный\\\\Ткань-Жёлтый\\\\Пейзаж\\\\Янцзы\\\\Клён\\\\Весна\\\\Лето\\\\Осень\\\\Зима\\\\Гора";
            this.Terms["moderated-caucus-toolbox-array"] = "Неформ. дебаты под пред.\\\\0\\\\ \\\\ \\\\Вносить предложение о переходе к неформальным дебатам под председательством.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "Неформ. дебаты без пред.\\\\1\\\\ \\\\ \\\\Вносить предложение о переходе к неформальным дебатам без председательства.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "Закрытие списка ораторов\\\\2\\\\ \\\\ \\\\Вносить предложение о закрытии списка ораторов.\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "Прекращение прений\\\\3\\\\ \\\\ \\\\Вносить предложение о закрытии списка ораторов.\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "Перерыв в заседании\\\\4\\\\ \\\\ \\\\Вносить предложение о перерыве в заседании.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "Открытие списка ораторов\\\\5\\\\ \\\\ \\\\Вносить предложение об открытии списка ораторов.\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "Свободные дебаты (без предс.)\\\\6\\\\ \\\\ \\\\Вносить предложение о переходе к свободным дебатам (не означает неформальные дебаты без председательства).\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "Вопрос по ведению заседания\\\\7\\\\ \\\\ \\\\Задать вопрос по ведению заседания.\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "Вопрос к Председателю/Эксперту\\\\8\\\\ \\\\ \\\\Задать вопрос к Председателю или вопрос к Эксперту.\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "Вопрос личной привилегии\\\\9\\\\ \\\\ \\\\Задать вопрос личной привилегии.\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "Иниц. переклички\\\\10\\\\ \\\\ \\\\Инициализировать систем, чтобы проводилась перекличка.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "Иниц. голосования\\\\11\\\\ \\\\ \\\\Инициализировать систем, чтобы проводились процедуры голосования.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "Иниц. Глав. таймера\\\\12\\\\ \\\\ \\\\Инициализировать главный таймер.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "Управление главным таймером\\\\13\\\\ \\\\ \\\\Управление главным таймером, чтобы запускать, приостанавливать и сбросать.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "Присутствие\\\\14\\\\ \\\\ \\\\Обновить настоящее количество и информацию присутствующих делегаций.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "Дебаты под предс.\\\\15\\\\ \\\\ \\\\Вносить предложение о переходе к дебатам под председательством (это не означает неформальные дебаты под председательством).\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "Право на ответ\\\\16\\\\ \\\\ \\\\Просить Президиум предоставлять право на ответ.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "Выступление\\\\17\\\\ \\\\ \\\\Пригласить гостя выступить с речью.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "Представление проекта\\\\18\\\\ \\\\ \\\\Вносить предложение, чтобы уделять время представить или прочитать проект.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "Голосование по проектам\\\\19\\\\ \\\\ \\\\Вносить предложение о голосовании по проектам, обычно поименно.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "Право на запрос\\\\20\\\\ \\\\ \\\\Просить предоставлять право на запрос к одной делегации.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ Неформальные дебаты под председательством ]\\\\  {0} внес(ла) предложение о переходе к неформальным дебатам под председательством.\\\\  Цель предлагаемых дебатов – {1}.\\\\  Общее время составляет {2} секунд(ов), по оратору {3} секунд(ов).";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ Неформальные дебаты без председательства ]\\\\  {0} внес(ла) предложение о переходе к неформальным дебатам без председательства.\\\\  Общее время составляет {1} секунд(ов).";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ Закрытие списка ораторов ]\\\\  {0} внес(ла) предложение о закрытии списка ораторов.";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ Прекращение прений ]\\\\  {0} внес(ла) предложение прекращения прений.";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ Перерыв в заседании ]\\\\  {0} внес(ла) предложение о перерыве в заседании.";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ Открытие списка ораторов ]\\\\  {0} внес(ла) предложение об открытии списка ораторов.";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ Свободные дебаты / Дебаты без председательства ]\\\\  {0} внес(ла) предложение о переходе к свободным дебатам / дебатам без председательства.\\\\  Общее время составляет {1} секунд(ов).";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ Вопрос по ведению заседания ]\\\\  {0} задал(а) вопрос по ведению заседания.";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ Вопрос к Председателю / Эксперту ]\\\\  {0} задал(а) вопрос к Председателю / Эксперту.";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ Вопрос личной привилегии ]\\\\  {0} задал(а) вопрос личной привилегии.";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ Перекличка ]\\\\  {0} из {1} делегаций присутствуют.\\\\  20% количества делегаций составляет {2}. Простое большинство составляет {3}. Квалифицированное большинство (2/3) составляет {4}.";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ Результат голосования ]\\\\  За – {0}. Против – {1}. Воздержалось – {2}.";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ Присутствие ]\\\\  Настоящее положение присутствия изменилось: ";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ Дебаты под председательством ]\\\\  {0} внес(ла) предложение о переходе к дебатам под председательством.\\\\  Цель предлагаемых дебатов – {1}.\\\\  Общее время составляет {2} секунд(ов).";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ Право на ответ ]\\\\  {0} просил(а) право на ответ.\\\\  Общее время составляет {1} секунд(ов).";
            this.Expressions["address-expression"] = "\\\\\\\\[ Речи ]\\\\  Позвольте пригласить {0} выступить к нам с речью.";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ Представление проекта ]\\\\  {0} внес(ла) предложение о представлении проекта {1}.\\\\  Общее время составляет {2} секунд(ов).";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ Голосование по проектам ]\\\\  {0} внес(ла) предложение о голосовании по проекту {1}.";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ Право на запрос ]\\\\  {0} просил(а) запрашивать делегацию {1}.\\\\  Общее время составляет {2} секунд(ов).";
            this.Expressions["motion-pass-expression"] = "\\\\  Предложение было принято.";
            this.Expressions["motion-fail-expression"] = "\\\\  Предложение было отклонено.";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  Проект был принят.\\\\ Ура!";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  Проект был отклонён.";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  Проект был отклонён в результате применения права вето.";
            this.Expressions["attendance-present-expression"] = "{0} присутствовал(а).";
            this.Expressions["attendance-absent-expression"] = "{0} отсутствовал(а).";
            this.Expressions["attendance-result-expression"] = "\\\\  Настоящее количество присутствующих делегаций состаявляет {0}. 20% количества делегаций составляет {1}. Простое большинство составляет {2}. Квалифицированное большинство (2/3) составляет {3}.";
            this.Expressions["permission-granted-expression"] = "\\\\  Право предоставляется.";
            this.Expressions["permission-denied-expression"] = "\\\\  Право не позволяется.";
            break;
          }
          break;
        case 3309695811:
          if (Operators.CompareString(language, "EOL", false) == 0)
          {
            this.Terms["doc-name-term"] = "Dokumento";
            this.Terms["main-menu-theme-term"] = "Haŭtoj";
            this.Terms["main-menu-language-term"] = "Lingvoj";
            this.Terms["main-menu-toolbox-term"] = "Akcesoraĵoj";
            this.Terms["main-menu-settings-term"] = "Parametroj";
            this.Terms["main-menu-close-term"] = "Eliri";
            this.Terms["delegation-term"] = "Delegitaro";
            this.Terms["topic-term"] = "Temo";
            this.Terms["total-time-term"] = "Tuta daŭro";
            this.Terms["speech-time-term"] = "Poparolanta Daŭro";
            this.Terms["time-term"] = "Daŭro";
            this.Terms["passed-term"] = "Akceptita";
            this.Terms["failed-term"] = "Malakceptita";
            this.Terms["ok-term"] = "Bone";
            this.Terms["initialize-term"] = "Pravalorizi";
            this.Terms["start-term"] = "Komencigi";
            this.Terms["pause-term"] = "Paŭzi";
            this.Terms["stop-term"] = "Rekomencigi";
            this.Terms["present-term"] = "Ĉeestas";
            this.Terms["absent-term"] = "Forestas";
            this.Terms["guest-term"] = "Gasto";
            this.Terms["target-term"] = "Respondanto";
            this.Terms["permission-granted-term"] = "Akceptita";
            this.Terms["permission-denied-term"] = "Malakceptita";
            this.Terms["committee-term"] = "Komitato";
            this.Terms["committee-topic-term"] = "Tagordo";
            this.Terms["speakers-list-term"] = "Listo ";
            this.Terms["copyright-comments"] = "MUNCS. Ĉiuj rajtoj rezervitaj.";
            this.Terms["welcome-comments"] = "Bonvenon al MUNCS Ekspreso.";
            this.Terms["initialize-comments"] = "Alklaku butonon por pravalorizi.";
            this.Terms["main-timer-console-comments"] = "Alklaku butonon pri regi la tempumilon.";
            this.Terms["vote-term-array"] = "Procedo de voĉdonado\\\\Voĉdonado pri dokumento\\\\Sumo\\\\20 % nombro\\\\Simpla plimulto\\\\Absoluta plimulto\\\\Favori\\\\Oponi\\\\Sindeteni\\\\Pasi\\\\Vetoi\\\\Malfari\\\\Nuligi\\\\Validi\\\\Vetoi";
            this.Terms["roll-call-term-array"] = "Nomvokado\\\\Mane / Vice\\\\20 % nombro\\\\Simpla plimulto\\\\Absoluta plimulto\\\\Ĉeestas\\\\Forestas\\\\Malfari\\\\Nuligi\\\\Validi";
            this.Terms["theme-term-array"] = "Oceano\\\\Vino\\\\Sonĝo\\\\Flamo\\\\Folioj\\\\Sunbrilo\\\\Teksaĵo-Bluo\\\\Teksaĵo-Roĝo\\\\Teksaĵo-Purpuro\\\\Teksaĵo-Oranĝo\\\\Teksaĵo-Verdo\\\\Teksaĵo-Flavo\\\\Pejzaĝo\\\\Jangzio\\\\Acero\\\\Printempo\\\\Somero\\\\Aŭtuno\\\\Vintro\\\\Monto";
            this.Terms["moderated-caucus-toolbox-array"] = "Moderigita debato\\\\0\\\\ \\\\ \\\\Proponi mocion pri moderigita debato.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "Senmoderigita debato\\\\1\\\\ \\\\ \\\\Proponi mocion pri senmoderigita debato.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "Fermo de Parolantlisto\\\\2\\\\ \\\\ \\\\Proponi mocion pri fermi la parolantliston.\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "Fino de debatoj\\\\3\\\\ \\\\ \\\\Proponi mocion pri fermi la parolantliston.\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "Interrompo de kunveno\\\\4\\\\ \\\\ \\\\Proponi mocion pri interrompo de kunveno.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "Malfermo de Parolantlisto\\\\5\\\\ \\\\ \\\\Proponi mocion pri malfermi la parolantliston.\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "Libera debato\\\\6\\\\ \\\\ \\\\Proponi mocion pri libera debato.\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "Priorda Demando\\\\7\\\\ \\\\ \\\\Demandi priordan demandon.\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "Informa Demando\\\\8\\\\ \\\\ \\\\Demandi informan demandon.\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "Privilegia Demando\\\\9\\\\ \\\\ \\\\Demandi privilegian demandon.\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "Pravalorizo por nomvokado\\\\10\\\\ \\\\ \\\\Pravalorizi la sistemon por la nomvokada proceduro.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "Pravalorizo por voĉdonado\\\\11\\\\ \\\\ \\\\Pravalorizi la sistemon por la voĉdonada proceduro.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "Privalorizo de tempumilo\\\\12\\\\ \\\\ \\\\Pravalorizi la tempumilon.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "Regilo de tempumilo\\\\13\\\\ \\\\ \\\\Regi la tempumilon por komencigi, paŭzi kaj rekomencigi.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "Ĉeestantaro\\\\14\\\\ \\\\ \\\\Ĝisdatigi la informon kaj la numeron de la nune ĉeestaj delegitaroj.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "Tema debato\\\\15\\\\ \\\\ \\\\Proponi mocion pri tema debato.\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "Respondrajto\\\\16\\\\ \\\\ \\\\Peti al la Prezidio la Respondrajton.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "Parolado\\\\17\\\\ \\\\ \\\\Inviti la gaston por alparoli.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "Legado de dokumento\\\\18\\\\ \\\\ \\\\Proponi mocion pri doni tempon al legi dokumenton.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "Voĉdonada mocio\\\\19\\\\ \\\\ \\\\Proponi mocion pri voĉdonado pri dokumento, ĝenerale nome.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "Enketrajto\\\\20\\\\ \\\\ \\\\Peti al la Prezidio Enketrajton al alian delegitaron.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ Moderigita Debato ]\\\\  {0} proponis mocion pri moderigita debato.\\\\  La temo de la debato estas – {1}.\\\\  La debato daŭras {2} sekundojn. La poparolanta tempo estas {3} sekundoj.";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ Senmoderigita Debato ]\\\\  {0} proponis mocion pri senmoderigita debato.\\\\  La debato daŭras {1} sekundojn.";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ Fermo de Parolantlisto ]\\\\  {0} proponis mocion pri fermi la parolantliston.";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ Fino de debatoj ]\\\\  {0} proponis mocion pri fini la debatojn.";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ Interrompo de kunveno ]\\\\  {0} proponis mocion pri la interrompo de kunveno.";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ Malfermo de Parolantlisto ]\\\\  {0} proponis mocion pri malfermi la parolantliston.";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ Libera debato ]\\\\  {0} proponis mocion pri libera debato.\\\\  La debato daŭras {1} sekundojn.";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ Priorda Demando ]\\\\  {0} demandis priordan demandon.";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ Informa Demando ]\\\\  {0} demandis informan demandon.";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ Privilegia Demando ]\\\\  {0} demandis privilegian demandon.";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ Nomvokado ]\\\\  Nune {0} de {1} delegitaroj ĉeestas.\\\\  La kvinono (20%) egalas al {2}, la simpla plimulto egalas al {3}, la absoluta plimulto (2/3) egalas al {4}.";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ Rezulto de la voĉdonado ]\\\\  Favoroj: {0}, Oponoj: {1}, Sindetenoj: {2}.";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ Ĉeestantaro ]\\\\  La nuna ĉeesto ŝanĝiĝis: ";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ Tema debato ]\\\\  {0} proponis mocion pri tema debato.\\\\  La temo de la debato estas – {1}.\\\\  La debato daŭras {2} sekundojn.";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ Respondrajto ]\\\\  {0} petis al prezidio respondrajton.\\\\  La respondo daŭras {1} sekundojn.";
            this.Expressions["address-expression"] = "\\\\\\\\[ Parolado ]\\\\  Bonvenon al la parolado de {0} !";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ Legado de dokumento ]\\\\  {0} proponis mocion pri doni tempon al legi la dokumenton {1}.\\\\  La debato daŭras {2} sekundojn.";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ Voĉdonada mocio ]\\\\  {0} proponis mocion pri voĉdoni pri la dokumento {1}.";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ Enketrajto ]\\\\  {0} petis al prezidio enketrajton al {1}.\\\\  La enketo daŭras {2} sekundojn.";
            this.Expressions["motion-pass-expression"] = "\\\\  La mocio estas akceptita.";
            this.Expressions["motion-fail-expression"] = "\\\\  La mocio estas malakceptita.";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  La dokumento estas aprobita.";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  La dokumento estas malaprobita.";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  La dokumento estas malaprobita pro la Veto.";
            this.Expressions["attendance-present-expression"] = "{0} jam ĉeestis.";
            this.Expressions["attendance-absent-expression"] = "{0} jam forlasis.";
            this.Expressions["attendance-result-expression"] = "\\\\  La nuna ĉeestonombro egalas al {0}. Nune la kvinono (20%) egalas al {1}, la simpla plimulto egalas al {2}, la absoluta plimulto (2/3) egalas al {3}.";
            this.Expressions["permission-granted-expression"] = "\\\\  La peto estas akceptita.";
            this.Expressions["permission-denied-expression"] = "\\\\  La peto estas malakceptita.";
            break;
          }
          break;
        case 4182823547:
          if (Operators.CompareString(language, "ESP", false) == 0)
          {
            this.Terms["doc-name-term"] = "Documento";
            this.Terms["main-menu-theme-term"] = "Temas";
            this.Terms["main-menu-language-term"] = "Idioma";
            this.Terms["main-menu-toolbox-term"] = "Widget";
            this.Terms["main-menu-settings-term"] = "Opciones";
            this.Terms["main-menu-close-term"] = "Salir";
            this.Terms["delegation-term"] = "Delegación";
            this.Terms["topic-term"] = "Propósito";
            this.Terms["total-time-term"] = "Duración";
            this.Terms["speech-time-term"] = "Tiempo de Orador";
            this.Terms["time-term"] = "Tiempo";
            this.Terms["passed-term"] = "Adoptado";
            this.Terms["failed-term"] = "Rechazado";
            this.Terms["ok-term"] = "Bien";
            this.Terms["initialize-term"] = "Inicializar";
            this.Terms["start-term"] = "Iniciar";
            this.Terms["pause-term"] = "Suspender";
            this.Terms["stop-term"] = "Reiniciar";
            this.Terms["present-term"] = "Presente";
            this.Terms["absent-term"] = "Ausente";
            this.Terms["guest-term"] = "Invitado";
            this.Terms["target-term"] = "Respondedor";
            this.Terms["permission-granted-term"] = "Otorgado";
            this.Terms["permission-denied-term"] = "Rechazado";
            this.Terms["committee-term"] = "Comisión";
            this.Terms["committee-topic-term"] = "Agenda";
            this.Terms["speakers-list-term"] = "Lista ";
            this.Terms["copyright-comments"] = "MUNCS. Todos los derechos reservados.";
            this.Terms["welcome-comments"] = "Bienvenidos al MUNCS Express.";
            this.Terms["initialize-comments"] = "Presione el butón para inicializar.";
            this.Terms["main-timer-console-comments"] = "Presione el butón para controlar.";
            this.Terms["vote-term-array"] = "Procedimiento de Votación\\\\Votación del documento\\\\Total\\\\20 % número\\\\Mayoría simple\\\\Mayoría calificada (2/3)\\\\A favor\\\\En contra\\\\Abstenerse\\\\Pasar\\\\Veto\\\\Deshacer\\\\Cancelar\\\\Aplicar\\\\Veto";
            this.Terms["roll-call-term-array"] = "Cuórum\\\\Manualmente / En orden\\\\20 % número\\\\Mayoría simple\\\\Mayoría calificada (2/3)\\\\Presente\\\\Ausente\\\\Deshacer\\\\Cancelar\\\\Aplicar";
            this.Terms["theme-term-array"] = "Oceano\\\\Vino\\\\Sueño\\\\Llama\\\\Hojas\\\\Sol\\\\Tela Azul\\\\Tela Roja\\\\Tela Púrpura\\\\Tela Naranja\\\\Tela Verde\\\\Tela Amarilla\\\\Paisaje\\\\Yangtze\\\\Arce\\\\Primavera\\\\Verano\\\\Otoño\\\\Invierno\\\\Montaña";
            this.Terms["moderated-caucus-toolbox-array"] = "Caucus Moderado\\\\0\\\\ \\\\ \\\\Hacer una moción para abrir un caucus moderado.\\\\ \\\\0";
            this.Terms["unmoderated-caucus-toolbox-array"] = "Caucus Simple\\\\1\\\\ \\\\ \\\\Hacer una moción para abrir un caucus simple.\\\\ \\\\0";
            this.Terms["close-speakers-list-toolbox-array"] = "Cerrar el Foro\\\\2\\\\ \\\\ \\\\Hacer una moción para cerrar el Foro (la Lista de Oradores).\\\\ \\\\0";
            this.Terms["close-the-debate-toolbox-array"] = "Cerrar el debate\\\\3\\\\ \\\\ \\\\Hacer una moción para cerrar el Foro (la Lista de Oradores).\\\\ \\\\0";
            this.Terms["suspend-the-meeting-toolbox-array"] = "Suspender la Sesión\\\\4\\\\ \\\\ \\\\Hacer una moción para suspender la sesión.\\\\ \\\\0";
            this.Terms["open-speakers-list-toolbox-array"] = "Abrir el Foro\\\\5\\\\ \\\\ \\\\Hacer una moción para abrir el Foro (la Lista de Oradores).\\\\ \\\\0";
            this.Terms["free-debate-toolbox-array"] = "Debate Libre\\\\6\\\\ \\\\ \\\\Hacer una moción para abrir un debate libre.\\\\ \\\\0";
            this.Terms["point-of-order-toolbox-array"] = "Punto de Orden\\\\7\\\\ \\\\ \\\\Pedir un punto de orden.\\\\ \\\\1";
            this.Terms["point-of-inquiry-toolbox-array"] = "Punto de Información Parlamentaria\\\\8\\\\ \\\\ \\\\Pedir un punto de información parlamentaria.\\\\ \\\\1";
            this.Terms["point-of-personal-priviliege-toolbox-array"] = "Punto de Privilegio personal\\\\9\\\\ \\\\ \\\\Pedir un punto de privilegio personal.\\\\ \\\\1";
            this.Terms["initialize-roll-call-procedure-toolbox-array"] = "Inicialización para pasar lista\\\\10\\\\ \\\\ \\\\Inicializar el sistema para pasar lista en la función detallada.\\\\ \\\\2";
            this.Terms["initialize-voting-procedure-toolbox-array"] = "Inicialización para Votación\\\\11\\\\ \\\\ \\\\Inicializar el sistema para el procedimiento de votación en la función detallada.\\\\ \\\\2";
            this.Terms["initialize-main-timer-toolbox-array"] = "Inicialización del Temporizador principal\\\\12\\\\ \\\\ \\\\Inicializar el temporizador.\\\\ \\\\2";
            this.Terms["console-of-main-timer-toolbox-array"] = "Consola del Temporizador principal\\\\13\\\\ \\\\ \\\\Controlar el temporizador para iniciar, suspender y reiniciar.\\\\ \\\\3";
            this.Terms["attendance-toolbox-array"] = "Presencia\\\\14\\\\ \\\\ \\\\Modificar el número actual y la información de las delegaciones presentes.\\\\ \\\\2";
            this.Terms["moderated-debate-toolbox-array"] = "Debate Moderado\\\\15\\\\ \\\\ \\\\Hacer una moción para abrir un debate moderado.\\\\ \\\\0";
            this.Terms["right-of-reply-toolbox-array"] = "Derecho de investigación\\\\16\\\\ \\\\ \\\\Solicitar a la Mesa un derecho de réplica.\\\\ \\\\1";
            this.Terms["address-toolbox-array"] = "Discurso\\\\17\\\\ \\\\ \\\\Invitar al invitado para pronunciar un discurso.\\\\ \\\\1";
            this.Terms["read-document-toolbox-array"] = "Leer el documento\\\\18\\\\ \\\\ \\\\Hacer una moción para ofrecer tiempo a leer un documento.\\\\ \\\\0";
            this.Terms["vote-on-document-toolbox-array"] = "Votación del documento\\\\19\\\\ \\\\ \\\\Hacer una moción para votar sobre un documento, generalmente nominalmente.\\\\ \\\\0";
            this.Terms["challenge-toolbox-array"] = "Derecho de réplica\\\\20\\\\ \\\\ \\\\Solicitar a la Mesa un derecho de investigación a una otra delegación.\\\\ \\\\1";
            this.Expressions["moderated-caucus-expression"] = "\\\\\\\\[ Caucus Moderado ]\\\\  {0} hace una moción para abrir un caucus moderado.\\\\  El propósito del Caucus es – {1}.\\\\  La duración es {2} segundos, el tiempo de orador es {3} segundos.";
            this.Expressions["unmoderated-caucus-expression"] = "\\\\\\\\[ Caucus Simple ]\\\\  {0} hace una moción para abrir un caucus simple.\\\\  La duración es {1} segundos.";
            this.Expressions["close-speakers-list-expression"] = "\\\\\\\\[ Clausura del Foro ]\\\\  {0} hace una moción para cerrar la Lista de Oradores.";
            this.Expressions["close-the-debate-expression"] = "\\\\\\\\[ Clausura del Debate ]\\\\  {0} hace una moción para cerrar el debate.";
            this.Expressions["suspend-the-meeting-expression"] = "\\\\\\\\[ Suspensión de la Sesión ]\\\\  {0} hace una moción para suspender la Sesión.";
            this.Expressions["open-speakers-list-expression"] = "\\\\\\\\[ Apertura del Foro ]\\\\  {0} hace una moción para abrir la Lista de Oradores.";
            this.Expressions["free-debate-expression"] = "\\\\\\\\[ Debate Libre ]\\\\  {0} hace una moción para abrir un debate libre.\\\\  La duración es {1} segundos.";
            this.Expressions["point-of-order-expression"] = "\\\\\\\\[ Punto de Orden ]\\\\  {0} pide un punto de orden.";
            this.Expressions["point-of-inquiry-expression"] = "\\\\\\\\[ Punto de Información Parlamentaria ]\\\\  {0} pide un punto de información parlamentaria.";
            this.Expressions["point-of-personal-priviliege-expression"] = "\\\\\\\\[ Punto de Privilegio Personal ]\\\\  {0} pide un punto de privilegio personal.";
            this.Expressions["initialize-roll-call-procedure-expression"] = "";
            this.Expressions["initialize-voting-procedure-expression"] = "";
            this.Expressions["roll-call-procedure-result-expression"] = "\\\\\\\\[ Cuórum ]\\\\  Ahora {0} de {1} delegaciones se presentan.\\\\  El 20% número es {2}, la mayoría simple es {3}, la mayoría calificada (2/3) es {4}.";
            this.Expressions["voting-procedure-result-expression"] = "\\\\\\\\[ Resultado de la Votación ]\\\\  A favor – {0}, En contra – {1}, Abstenciones – {2}.";
            this.Expressions["initialize-main-timer-expression"] = "";
            this.Expressions["console-of-main-timer-expression"] = "";
            this.Expressions["attendance-expression"] = "\\\\\\\\[ Presencia ]\\\\  La presencia ha cambiado: ";
            this.Expressions["moderated-debate-expression"] = "\\\\\\\\[ Debate Moderado ]\\\\  {0} hace una moción para abrir el debate moderado.\\\\  El propósito del Debate es – {1}.\\\\  La duración es {2} segundos.";
            this.Expressions["right-of-reply-expression"] = "\\\\\\\\[ Derecho de réplica ]\\\\  {0} solicita un derecho de réplica.\\\\  La duración es {1} segundos.";
            this.Expressions["address-expression"] = "\\\\\\\\[ Discurso ]\\\\  Bienvenido a {0} a pronunciar un discurso.";
            this.Expressions["read-document-expression"] = "\\\\\\\\[ Leer el documento ]\\\\  {0} hace una moción para leer el documento {1}.\\\\  La duración es {2} segundos.";
            this.Expressions["vote-on-document-expression"] = "\\\\\\\\[ Votación del documento ]\\\\  {0} hace una moción para votar sobre el documento {1}.";
            this.Expressions["challenge-expression"] = "\\\\\\\\[ Derecho de Investigación ]\\\\  {0} solicita un derecho de investigación a {1}.\\\\  La duración es {2} segundos.";
            this.Expressions["motion-pass-expression"] = "\\\\  La moción se adopta.";
            this.Expressions["motion-fail-expression"] = "\\\\  La moción se rechaza.";
            this.Expressions["voting-procedure-pass-expression"] = "\\\\  El documento se adopta.";
            this.Expressions["voting-procedure-fail-expression"] = "\\\\  El documento se rechaza.";
            this.Expressions["voting-procedure-veto-expression"] = "\\\\  El documento se rechaza debido al uso del derecho de Veto.";
            this.Expressions["attendance-present-expression"] = "{0} está presente.";
            this.Expressions["attendance-absent-expression"] = "{0} está ausente.";
            this.Expressions["attendance-result-expression"] = "\\\\  La actual asistencia es de {0} delegaciones. El 20% número es {1}, la mayoría simple es {2}, la mayoría calificada (2/3) es {3}.";
            this.Expressions["permission-granted-expression"] = "\\\\  La solicitud se otorga.";
            this.Expressions["permission-denied-expression"] = "\\\\  La solicitud se rechaza.";
            break;
          }
          break;
      }
      try
      {
        foreach (KeyValuePair<string, string> term in this.Terms)
        {
          if (Operators.CompareString(Regex.Match(term.Key, "array", RegexOptions.IgnoreCase).Value, "array", false) == 0)
            this.TermArrays[term.Key] = Microsoft.VisualBasic.Strings.Split(term.Value, "\\\\");
        }
      }
      finally
      {
        Dictionary<string, string>.Enumerator enumerator;
        enumerator.Dispose();
      }
      List<string> stringList = new List<string>();
      stringList.AddRange((IEnumerable<string>) this.Expressions.Keys);
      try
      {
        foreach (string key in stringList)
          this.Expressions[key] = this.Expressions[key].Replace("\\\\", string.Format("{0}", (object) Environment.NewLine));
      }
      finally
      {
        List<string>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }

    public void Expression_Phrases(bool IsInitial)
    {
      this.strMKeyMenu = new string[5]
      {
        this.Terms["main-menu-theme-term"],
        this.Terms["main-menu-language-term"],
        this.Terms["main-menu-toolbox-term"],
        this.Terms["main-menu-settings-term"],
        this.Terms["main-menu-close-term"]
      };
      string[] strArray = new string[21]
      {
        "moderated-caucus-toolbox-array",
        "unmoderated-caucus-toolbox-array",
        "close-speakers-list-toolbox-array",
        "close-the-debate-toolbox-array",
        "suspend-the-meeting-toolbox-array",
        "open-speakers-list-toolbox-array",
        "free-debate-toolbox-array",
        "point-of-order-toolbox-array",
        "point-of-inquiry-toolbox-array",
        "point-of-personal-priviliege-toolbox-array",
        "initialize-roll-call-procedure-toolbox-array",
        "initialize-voting-procedure-toolbox-array",
        "initialize-main-timer-toolbox-array",
        "console-of-main-timer-toolbox-array",
        "attendance-toolbox-array",
        "moderated-debate-toolbox-array",
        "right-of-reply-toolbox-array",
        "address-toolbox-array",
        "read-document-toolbox-array",
        "vote-on-document-toolbox-array",
        "challenge-toolbox-array"
      };
      int num1 = Information.UBound((Array) strArray);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.strSMenuTitle[index1] = this.TermArrays[strArray[index1]][0];
        int index2 = 0;
        do
        {
          this.strSMenuDesc[index1, index2] = this.TermArrays[strArray[index1]][index2];
          checked { ++index2; }
        }
        while (index2 <= 6);
        checked { ++index1; }
      }
      int num2 = checked (Information.UBound((Array) strArray) + 1);
      int num3 = Information.UBound((Array) this.strSMenuDesc);
      int index3 = num2;
      while (index3 <= num3)
      {
        this.strSMenuDesc[index3, 0] = (string) null;
        this.strSMenuDesc[index3, 1] = "-1";
        checked { ++index3; }
      }
      this.strSMenuCaption[0, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[0, 1] = this.Terms["topic-term"];
      this.strSMenuCaption[0, 2] = this.Terms["total-time-term"];
      this.strSMenuCaption[0, 3] = this.Terms["speech-time-term"];
      this.strSMenuFormalBtn[0, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[0, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[1, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[1, 1] = this.Terms["total-time-term"];
      this.strSMenuFormalBtn[1, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[1, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[2, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[2, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[2, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[3, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[3, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[3, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[4, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[4, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[4, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[5, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[5, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[5, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[6, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[6, 1] = this.Terms["total-time-term"];
      this.strSMenuFormalBtn[6, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[6, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[7, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[7, 0] = this.Terms["ok-term"];
      this.strSMenuCaption[8, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[8, 0] = this.Terms["ok-term"];
      this.strSMenuCaption[9, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[9, 0] = this.Terms["ok-term"];
      this.strSMenuCaption[10, 0] = this.Terms["initialize-comments"];
      this.strSMenuFormalBtn[10, 0] = this.Terms["initialize-term"];
      this.strSMenuCaption[11, 0] = this.Terms["initialize-comments"];
      this.strSMenuFormalBtn[11, 0] = this.Terms["initialize-term"];
      this.strSMenuCaption[12, 0] = this.Terms["total-time-term"];
      this.strSMenuCaption[12, 1] = this.Terms["speech-time-term"];
      this.strSMenuFormalBtn[12, 0] = this.Terms["initialize-term"];
      this.strSMenuCaption[13, 0] = this.Terms["main-timer-console-comments"];
      this.strSMenuFormalBtn[13, 0] = this.Terms["start-term"];
      this.strSMenuFormalBtn[13, 1] = this.Terms["pause-term"];
      this.strSMenuFormalBtn[13, 2] = this.Terms["stop-term"];
      this.strSMenuCaption[14, 0] = this.Terms["delegation-term"];
      this.strSMenuFormalBtn[14, 0] = this.Terms["present-term"];
      this.strSMenuFormalBtn[14, 1] = this.Terms["absent-term"];
      this.strSMenuCaption[15, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[15, 1] = this.Terms["topic-term"];
      this.strSMenuCaption[15, 2] = this.Terms["total-time-term"];
      this.strSMenuFormalBtn[15, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[15, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[16, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[16, 1] = this.Terms["total-time-term"];
      this.strSMenuFormalBtn[16, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[16, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[17, 0] = this.Terms["guest-term"];
      this.strSMenuFormalBtn[17, 0] = this.Terms["ok-term"];
      this.strSMenuCaption[18, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[18, 1] = this.Terms["doc-name-term"];
      this.strSMenuCaption[18, 2] = this.Terms["total-time-term"];
      this.strSMenuFormalBtn[18, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[18, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[19, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[19, 1] = this.Terms["doc-name-term"];
      this.strSMenuFormalBtn[19, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[19, 1] = this.Terms["failed-term"];
      this.strSMenuCaption[20, 0] = this.Terms["delegation-term"];
      this.strSMenuCaption[20, 1] = this.Terms["target-term"];
      this.strSMenuCaption[20, 2] = this.Terms["total-time-term"];
      this.strSMenuFormalBtn[20, 0] = this.Terms["passed-term"];
      this.strSMenuFormalBtn[20, 1] = this.Terms["failed-term"];
      this.strMVote = new string[6, 8]
      {
        {
          this.TermArrays["vote-term-array"][0],
          this.TermArrays["vote-term-array"][1],
          "",
          "",
          "",
          "",
          "",
          ""
        },
        {
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          ""
        },
        {
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          ""
        },
        {
          this.TermArrays["vote-term-array"][2],
          this.TermArrays["vote-term-array"][3],
          this.TermArrays["vote-term-array"][4],
          this.TermArrays["vote-term-array"][5],
          "-",
          "-",
          "-",
          "-"
        },
        {
          this.TermArrays["vote-term-array"][6],
          this.TermArrays["vote-term-array"][7],
          this.TermArrays["vote-term-array"][8],
          this.TermArrays["vote-term-array"][9],
          "-",
          "-",
          "-",
          "-"
        },
        {
          this.TermArrays["vote-term-array"][6],
          this.TermArrays["vote-term-array"][7],
          this.TermArrays["vote-term-array"][8],
          this.TermArrays["vote-term-array"][9],
          this.TermArrays["vote-term-array"][11],
          this.TermArrays["vote-term-array"][12],
          this.TermArrays["vote-term-array"][13],
          this.TermArrays["vote-term-array"][14]
        }
      };
      this.strMRoll = new string[6, 8]
      {
        {
          this.TermArrays["roll-call-term-array"][0],
          this.TermArrays["roll-call-term-array"][1],
          "",
          "",
          "",
          "",
          "",
          ""
        },
        {
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          ""
        },
        {
          "",
          "",
          "",
          "",
          "",
          "",
          "",
          ""
        },
        {
          this.TermArrays["roll-call-term-array"][2],
          this.TermArrays["roll-call-term-array"][3],
          this.TermArrays["roll-call-term-array"][4],
          "",
          "-",
          "-",
          "-",
          ""
        },
        {
          this.TermArrays["roll-call-term-array"][5],
          this.TermArrays["roll-call-term-array"][6],
          "",
          "",
          "-",
          "-",
          "",
          ""
        },
        {
          this.TermArrays["roll-call-term-array"][5],
          this.TermArrays["roll-call-term-array"][6],
          "",
          "",
          this.TermArrays["roll-call-term-array"][7],
          this.TermArrays["roll-call-term-array"][8],
          this.TermArrays["roll-call-term-array"][9],
          ""
        }
      };
      this.strMInfo[1, 0] = this.Terms["speakers-list-term"];
      this.strMInfo[4, 0] = this.Terms["copyright-comments"];
      this.strMInfo[5, 0] = this.Terms["welcome-comments"];
      this.strMBac[0, 0] = this.Terms["main-menu-theme-term"];
      int num4 = checked (this.SkinAmount - 1);
      int index4 = 0;
      while (index4 <= num4)
      {
        this.strMBac[1, index4] = this.TermArrays["theme-term-array"][index4];
        checked { ++index4; }
      }
      this.strMWid[0, 0] = this.Terms["main-menu-toolbox-term"];
      this.strMConf[0, 0] = this.Terms["committee-term"];
      this.strMConf[0, 1] = this.Terms["committee-topic-term"];
      this.strMConf[0, 5] = this.Terms["initialize-term"];
      int index5 = 0;
      do
      {
        this.strSMenuAnswer[0, index5] = this.strSMenuCaption[0, index5];
        checked { ++index5; }
      }
      while (index5 <= 3);
      int index6 = 0;
      do
      {
        this.strSMenuAnswer[1, index6] = this.strSMenuCaption[1, index6];
        checked { ++index6; }
      }
      while (index6 <= 1);
      int index7 = 0;
      do
      {
        this.strSMenuAnswer[2, index7] = this.strSMenuCaption[2, index7];
        checked { ++index7; }
      }
      while (index7 <= 0);
      int index8 = 0;
      do
      {
        this.strSMenuAnswer[3, index8] = this.strSMenuCaption[3, index8];
        checked { ++index8; }
      }
      while (index8 <= 0);
      int index9 = 0;
      do
      {
        this.strSMenuAnswer[4, index9] = this.strSMenuCaption[4, index9];
        checked { ++index9; }
      }
      while (index9 <= 0);
      int index10 = 0;
      do
      {
        this.strSMenuAnswer[5, index10] = this.strSMenuCaption[5, index10];
        checked { ++index10; }
      }
      while (index10 <= 0);
      int index11 = 0;
      do
      {
        this.strSMenuAnswer[6, index11] = this.strSMenuCaption[6, index11];
        checked { ++index11; }
      }
      while (index11 <= 1);
      int index12 = 0;
      do
      {
        this.strSMenuAnswer[7, index12] = this.strSMenuCaption[7, index12];
        checked { ++index12; }
      }
      while (index12 <= 0);
      int index13 = 0;
      do
      {
        this.strSMenuAnswer[8, index13] = this.strSMenuCaption[8, index13];
        checked { ++index13; }
      }
      while (index13 <= 0);
      int index14 = 0;
      do
      {
        this.strSMenuAnswer[9, index14] = this.strSMenuCaption[9, index14];
        checked { ++index14; }
      }
      while (index14 <= 0);
      int index15 = 0;
      do
      {
        this.strSMenuAnswer[12, index15] = this.strSMenuCaption[12, index15];
        checked { ++index15; }
      }
      while (index15 <= 1);
      int index16 = 0;
      do
      {
        this.strSMenuAnswer[14, index16] = this.strSMenuCaption[14, index16];
        checked { ++index16; }
      }
      while (index16 <= 0);
      int index17 = 0;
      do
      {
        this.strSMenuAnswer[15, index17] = this.strSMenuCaption[15, index17];
        checked { ++index17; }
      }
      while (index17 <= 2);
      int index18 = 0;
      do
      {
        this.strSMenuAnswer[16, index18] = this.strSMenuCaption[16, index18];
        checked { ++index18; }
      }
      while (index18 <= 1);
      int index19 = 0;
      do
      {
        this.strSMenuAnswer[17, index19] = this.strSMenuCaption[17, index19];
        checked { ++index19; }
      }
      while (index19 <= 0);
      int index20 = 0;
      do
      {
        this.strSMenuAnswer[18, index20] = this.strSMenuCaption[18, index20];
        checked { ++index20; }
      }
      while (index20 <= 2);
      int index21 = 0;
      do
      {
        this.strSMenuAnswer[19, index21] = this.strSMenuCaption[19, index21];
        checked { ++index21; }
      }
      while (index21 <= 1);
      int index22 = 0;
      do
      {
        this.strSMenuAnswer[20, index22] = this.strSMenuCaption[20, index22];
        checked { ++index22; }
      }
      while (index22 <= 2);
      int num5 = IsInitial ? 1 : 0;
      int index23 = 0;
      do
      {
        this.lblMInfo[1, index23].Text = this.strMInfo[1, 0] + Conversions.ToString(checked (index23 + 1));
        checked { ++index23; }
      }
      while (index23 <= 2);
      if (this.txtMInfo[4, 0].Text.Length <= 40)
        this.txtMInfo[4, 0].Text = this.txtMInfo[4, 0].Text;
      this.lblMInfo[5, 1].Text = this.strMInfo[5, 0];
    }

    public void Expression_Sentences(
      int mainclause,
      int subclause,
      string arg1,
      string arg2,
      string arg3,
      string arg4,
      string arg5)
    {
      switch (mainclause)
      {
        case 0:
          switch (subclause)
          {
            case -1:
              TextBox textBox1;
              string str1 = (textBox1 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["moderated-caucus-expression"], (object) arg1, (object) arg2, (object) arg3, (object) arg4);
              textBox1.Text = str1;
              this.CurrentTopic = arg2;
              break;
            case 0:
              TextBox textBox2;
              string str2 = (textBox2 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox2.Text = str2;
              break;
            case 1:
              TextBox textBox3;
              string str3 = (textBox3 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox3.Text = str3;
              break;
          }
          break;
        case 1:
          switch (subclause)
          {
            case -1:
              TextBox textBox4;
              string str4 = (textBox4 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["unmoderated-caucus-expression"], (object) arg1, (object) arg2);
              textBox4.Text = str4;
              break;
            case 0:
              TextBox textBox5;
              string str5 = (textBox5 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox5.Text = str5;
              break;
            case 1:
              TextBox textBox6;
              string str6 = (textBox6 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox6.Text = str6;
              break;
          }
          break;
        case 2:
          switch (subclause)
          {
            case -1:
              TextBox textBox7;
              string str7 = (textBox7 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["close-speakers-list-expression"], (object) arg1);
              textBox7.Text = str7;
              break;
            case 0:
              TextBox textBox8;
              string str8 = (textBox8 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox8.Text = str8;
              break;
            case 1:
              TextBox textBox9;
              string str9 = (textBox9 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox9.Text = str9;
              break;
          }
          break;
        case 3:
          switch (subclause)
          {
            case -1:
              TextBox textBox10;
              string str10 = (textBox10 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["close-the-debate-expression"], (object) arg1);
              textBox10.Text = str10;
              break;
            case 0:
              TextBox textBox11;
              string str11 = (textBox11 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox11.Text = str11;
              break;
            case 1:
              TextBox textBox12;
              string str12 = (textBox12 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox12.Text = str12;
              break;
          }
          break;
        case 4:
          switch (subclause)
          {
            case -1:
              TextBox textBox13;
              string str13 = (textBox13 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["suspend-the-meeting-expression"], (object) arg1);
              textBox13.Text = str13;
              break;
            case 0:
              TextBox textBox14;
              string str14 = (textBox14 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox14.Text = str14;
              break;
            case 1:
              TextBox textBox15;
              string str15 = (textBox15 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox15.Text = str15;
              break;
          }
          break;
        case 5:
          switch (subclause)
          {
            case -1:
              TextBox textBox16;
              string str16 = (textBox16 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["open-speakers-list-expression"], (object) arg1);
              textBox16.Text = str16;
              break;
            case 0:
              TextBox textBox17;
              string str17 = (textBox17 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox17.Text = str17;
              break;
            case 1:
              TextBox textBox18;
              string str18 = (textBox18 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox18.Text = str18;
              break;
          }
          break;
        case 6:
          switch (subclause)
          {
            case -1:
              TextBox textBox19;
              string str19 = (textBox19 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["free-debate-expression"], (object) arg1, (object) arg2);
              textBox19.Text = str19;
              break;
            case 0:
              TextBox textBox20;
              string str20 = (textBox20 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox20.Text = str20;
              break;
            case 1:
              TextBox textBox21;
              string str21 = (textBox21 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox21.Text = str21;
              break;
          }
          break;
        case 7:
          TextBox textBox22;
          string str22 = (textBox22 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["point-of-order-expression"], (object) arg1);
          textBox22.Text = str22;
          break;
        case 8:
          TextBox textBox23;
          string str23 = (textBox23 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["point-of-inquiry-expression"], (object) arg1);
          textBox23.Text = str23;
          break;
        case 9:
          TextBox textBox24;
          string str24 = (textBox24 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["point-of-personal-priviliege-expression"], (object) arg1);
          textBox24.Text = str24;
          break;
        case 10:
          TextBox textBox25;
          string str25 = (textBox25 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["roll-call-procedure-result-expression"], (object) arg1, (object) Conversion.Val(arg2), (object) arg3, (object) arg4, (object) arg5);
          textBox25.Text = str25;
          break;
        case 11:
          switch (subclause)
          {
            case -1:
              TextBox textBox26;
              string str26 = (textBox26 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["voting-procedure-result-expression"], (object) arg1, (object) arg2, (object) arg3);
              textBox26.Text = str26;
              break;
            case 0:
              TextBox textBox27;
              string str27 = (textBox27 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["voting-procedure-pass-expression"]);
              textBox27.Text = str27;
              break;
            case 1:
              TextBox textBox28;
              string str28 = (textBox28 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["voting-procedure-fail-expression"]);
              textBox28.Text = str28;
              break;
            case 2:
              TextBox textBox29;
              string str29 = (textBox29 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["voting-procedure-veto-expression"]);
              textBox29.Text = str29;
              break;
          }
          break;
        case 14:
          switch (subclause)
          {
            case -1:
              TextBox textBox30;
              string str30 = (textBox30 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["attendance-expression"]);
              textBox30.Text = str30;
              break;
            case 0:
              TextBox textBox31;
              string str31 = (textBox31 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["attendance-present-expression"], (object) arg1);
              textBox31.Text = str31;
              break;
            case 1:
              TextBox textBox32;
              string str32 = (textBox32 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["attendance-absent-expression"], (object) arg1);
              textBox32.Text = str32;
              break;
            case 2:
              TextBox textBox33;
              string str33 = (textBox33 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["attendance-result-expression"], (object) arg1, (object) arg2, (object) arg3, (object) arg4);
              textBox33.Text = str33;
              break;
          }
          break;
        case 15:
          switch (subclause)
          {
            case -1:
              TextBox textBox34;
              string str34 = (textBox34 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["moderated-debate-expression"], (object) arg1, (object) arg2, (object) arg3);
              textBox34.Text = str34;
              break;
            case 0:
              TextBox textBox35;
              string str35 = (textBox35 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox35.Text = str35;
              break;
            case 1:
              TextBox textBox36;
              string str36 = (textBox36 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox36.Text = str36;
              break;
          }
          break;
        case 16:
          switch (subclause)
          {
            case -1:
              TextBox textBox37;
              string str37 = (textBox37 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["right-of-reply-expression"], (object) arg1, (object) arg2);
              textBox37.Text = str37;
              break;
            case 0:
              TextBox textBox38;
              string str38 = (textBox38 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["permission-granted-expression"]);
              textBox38.Text = str38;
              break;
            case 1:
              TextBox textBox39;
              string str39 = (textBox39 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["permission-denied-expression"]);
              textBox39.Text = str39;
              break;
          }
          break;
        case 17:
          if (subclause == -1)
          {
            TextBox textBox40;
            string str40 = (textBox40 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["address-expression"], (object) arg1);
            textBox40.Text = str40;
            break;
          }
          break;
        case 18:
          switch (subclause)
          {
            case -1:
              TextBox textBox41;
              string str41 = (textBox41 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["read-document-expression"], (object) arg1, (object) arg2, (object) arg3);
              textBox41.Text = str41;
              break;
            case 0:
              TextBox textBox42;
              string str42 = (textBox42 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox42.Text = str42;
              break;
            case 1:
              TextBox textBox43;
              string str43 = (textBox43 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox43.Text = str43;
              break;
          }
          break;
        case 19:
          switch (subclause)
          {
            case -1:
              TextBox textBox44;
              string str44 = (textBox44 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["vote-on-document-expression"], (object) arg1, (object) arg2);
              textBox44.Text = str44;
              break;
            case 0:
              TextBox textBox45;
              string str45 = (textBox45 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-pass-expression"]);
              textBox45.Text = str45;
              break;
            case 1:
              TextBox textBox46;
              string str46 = (textBox46 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["motion-fail-expression"]);
              textBox46.Text = str46;
              break;
          }
          break;
        case 20:
          switch (subclause)
          {
            case -1:
              TextBox textBox47;
              string str47 = (textBox47 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["challenge-expression"], (object) arg1, (object) arg2, (object) arg3);
              textBox47.Text = str47;
              break;
            case 0:
              TextBox textBox48;
              string str48 = (textBox48 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["permission-granted-expression"]);
              textBox48.Text = str48;
              break;
            case 1:
              TextBox textBox49;
              string str49 = (textBox49 = this.txtMInfo[4, 0]).Text + string.Format(this.Expressions["permission-denied-expression"]);
              textBox49.Text = str49;
              break;
          }
          break;
      }
      this.txtMInfo[4, 0].SelectionStart = Microsoft.VisualBasic.Strings.Len(this.txtMInfo[4, 0].Text);
      this.txtMInfo[4, 0].ScrollToCaret();
    }

    public void Window_Base()
    {
      MyProject.Forms.StartForm.Show();
      this.Hide();
      this.FormBorderStyle = FormBorderStyle.None;
      this.Height = Screen.PrimaryScreen.WorkingArea.Height;
      this.Width = Screen.PrimaryScreen.WorkingArea.Width;
      this.Top = Screen.PrimaryScreen.WorkingArea.Top;
      this.Left = Screen.PrimaryScreen.WorkingArea.Left;
      this.BackColor = this.ColorMainDeep;
      this.BackgroundImage = (Image) this.imgBackground;
      this.BackgroundImageLayout = ImageLayout.Tile;
    }

    public void Window_MainMenu()
    {
      this.pnlMainMenu = (Panel) MainForm.Func_CreateObj("pnlMainMenu", "Panel");
      this.Controls.Add((Control) this.pnlMainMenu);
      int index1 = 0;
      do
      {
        this.btnMMenu[index1] = (Label) MainForm.Func_CreateObj("btnMMenu(" + Conversions.ToString(index1) + ")", "Label");
        this.pnlMainMenu.Controls.Add((Control) this.btnMMenu[index1]);
        this.btnMMenu[index1].MouseEnter += new EventHandler(this.btnMMenu_MouseEnter);
        this.btnMMenu[index1].MouseLeave += new EventHandler(this.btnMMenu_MouseLeave);
        checked { ++index1; }
      }
      while (index1 <= 7);
      this.pnlMMenuSub = (Panel) MainForm.Func_CreateObj("pnlMMenuSub", "Panel");
      this.Controls.Add((Control) this.pnlMMenuSub);
      int index2 = 0;
      do
      {
        this.btnMMenuSub[index2] = (Label) MainForm.Func_CreateObj("btnMMenuSub(" + Conversions.ToString(index2) + ")", "Label");
        this.btnMMenuSubDeco[index2] = (Label) MainForm.Func_CreateObj("btnMMenuSubDeco(" + Conversions.ToString(index2) + ")", "Label");
        this.pnlMMenuSub.Controls.Add((Control) this.btnMMenuSub[index2]);
        this.pnlMMenuSub.Controls.Add((Control) this.btnMMenuSubDeco[index2]);
        this.btnMMenuSub[index2].MouseEnter += new EventHandler(this.btnMMenuSub_MouseEnter);
        this.btnMMenuSub[index2].MouseLeave += new EventHandler(this.btnMMenuSub_MouseLeave);
        this.btnMMenuSub[index2].MouseClick += new MouseEventHandler(this.btnMMenuSub_MouseClick);
        this.btnMMenuSubDeco[index2].MouseEnter += new EventHandler(this.btnMMenuSub_MouseEnter);
        this.btnMMenuSubDeco[index2].MouseLeave += new EventHandler(this.btnMMenuSub_MouseLeave);
        this.btnMMenuSubDeco[index2].MouseClick += new MouseEventHandler(this.btnMMenuSub_MouseClick);
        checked { ++index2; }
      }
      while (index2 <= 9);
      this.Scene_MainMenu_Update(true, true, true);
    }

    public void Window_SubMenu()
    {
      int index1 = 0;
      do
      {
        this.pnlSubMenu[index1] = (Panel) MainForm.Func_CreateObj("pnlSubMenu(" + Conversions.ToString(index1) + ")", "Panel");
        this.Controls.Add((Control) this.pnlSubMenu[index1]);
        this.lblSMenuTitle[index1] = (Label) MainForm.Func_CreateObj("lblSMenuTitle(" + Conversions.ToString(index1) + ")", "Label");
        this.pnlSubMenu[index1].Controls.Add((Control) this.lblSMenuTitle[index1]);
        this.lblSMenuTitle[index1].MouseDown += new MouseEventHandler(this.SubMenuTitle_MouseDown);
        this.lblSMenuTitle[index1].MouseMove += new MouseEventHandler(this.SubMenuTitle_MouseMove);
        this.lblSMenuTitle[index1].MouseUp += new MouseEventHandler(this.SubMenuTitle_MouseUp);
        this.btnSMenuClose[index1] = (Label) MainForm.Func_CreateObj("btnSMenuClose(" + Conversions.ToString(index1) + ")", "Label");
        this.btnSMenuClose[index1].MouseEnter += new EventHandler(this.btnSMenuFormalBtn_MouseEnter);
        this.btnSMenuClose[index1].MouseLeave += new EventHandler(this.btnSMenuFormalBtn_MouseLeave);
        this.btnSMenuClose[index1].MouseDown += new MouseEventHandler(this.btnSMenuFormalBtn_MouseDown);
        this.btnSMenuClose[index1].MouseUp += new MouseEventHandler(this.btnSMenuFormalBtn_MouseUp);
        this.pnlSubMenu[index1].Controls.Add((Control) this.btnSMenuClose[index1]);
        this.pnlSMenuIn[index1] = (Panel) MainForm.Func_CreateObj("pnlSMenuIn(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlSubMenu[index1].Controls.Add((Control) this.pnlSMenuIn[index1]);
        checked { ++index1; }
      }
      while (index1 <= 20);
      int index2 = 0;
      do
      {
        if (this.intSMenuCaptionAmount[index2] >= 0)
        {
          int num = this.intSMenuCaptionAmount[index2];
          int index3 = 0;
          while (index3 <= num)
          {
            this.lblSMenuCaption[index2, index3] = (Label) MainForm.Func_CreateObj("lblSMenuCaption(" + Conversions.ToString(index2) + "," + Conversions.ToString(index3) + ")", "Label");
            this.pnlSMenuIn[index2].Controls.Add((Control) this.lblSMenuCaption[index2, index3]);
            checked { ++index3; }
          }
        }
        if (this.intSMenuAnswerAmount[index2] >= 0)
        {
          int num = this.intSMenuAnswerAmount[index2];
          int index3 = 0;
          while (index3 <= num)
          {
            this.txtSMenuAnswer[index2, index3] = (TextBox) MainForm.Func_CreateObj("txtSMenuAnswer(" + Conversions.ToString(index2) + "," + Conversions.ToString(index3) + ")", "Textbox");
            this.pnlSMenuIn[index2].Controls.Add((Control) this.txtSMenuAnswer[index2, index3]);
            this.txtSMenuAnswer[index2, index3].GotFocus += new EventHandler(this.txtSMenuAnswer_GotFocus);
            this.txtSMenuAnswer[index2, index3].LostFocus += new EventHandler(this.txtSMenuAnswer_LostFocus);
            checked { ++index3; }
          }
        }
        if (this.intSMenuFormalBtnAmount[index2] >= 0)
        {
          int num = this.intSMenuFormalBtnAmount[index2];
          int index3 = 0;
          while (index3 <= num)
          {
            this.btnSMenuFormalBtn[index2, index3] = (Label) MainForm.Func_CreateObj("btnSMenuFormalBtn(" + Conversions.ToString(index2) + "," + Conversions.ToString(index3) + ")", "Label");
            this.pnlSMenuIn[index2].Controls.Add((Control) this.btnSMenuFormalBtn[index2, index3]);
            this.btnSMenuFormalBtn[index2, index3].MouseEnter += new EventHandler(this.btnSMenuFormalBtn_MouseEnter);
            this.btnSMenuFormalBtn[index2, index3].MouseLeave += new EventHandler(this.btnSMenuFormalBtn_MouseLeave);
            this.btnSMenuFormalBtn[index2, index3].MouseDown += new MouseEventHandler(this.btnSMenuFormalBtn_MouseDown);
            this.btnSMenuFormalBtn[index2, index3].MouseUp += new MouseEventHandler(this.btnSMenuFormalBtn_MouseUp);
            checked { ++index3; }
          }
        }
        checked { ++index2; }
      }
      while (index2 <= 20);
      int index4 = 0;
      do
      {
        this.Func_AddControl((Control) this.pnlSubMenu[index4]);
        checked { ++index4; }
      }
      while (index4 <= 20);
      this.Scene_SubMenu_Update_I(true, true, true);
      this.Scene_SubMenu_Update_II(false, 0);
    }

    public void Window_Instr()
    {
      this.pnlInstr = (Panel) MainForm.Func_CreateObj("pnlInstr", "Panel");
      this.Controls.Add((Control) this.pnlInstr);
      int index = 0;
      do
      {
        this.lblInstr[index] = (Label) MainForm.Func_CreateObj("lblInstr(" + Conversions.ToString(index) + ")", "Label");
        this.pnlInstr.Controls.Add((Control) this.lblInstr[index]);
        checked { ++index; }
      }
      while (index <= 2);
      this.tmrInstr.Interval = 40;
      this.lblInstr[0].MouseEnter += new EventHandler(this.btnKeyMenu_MouseEnter);
      this.lblInstr[0].MouseLeave += new EventHandler(this.btnKeyMenu_MouseLeave);
      this.tmrInstr.Tick += new EventHandler(this.tmrInstr_Tick);
      this.Scene_Instr_Update(true, true, true);
    }

    public void Window_Main_Guideline()
    {
      this.pnlGuideline = new Panel();
      this.Controls.Add((Control) this.pnlGuideline);
      this.pnlGuideline.Height = checked (this.Height - this.pnlMainMenu.Height);
      this.pnlGuideline.Width = 1024;
      this.pnlGuideline.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - this.pnlGuideline.Height) / 2.0)));
      this.pnlGuideline.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - this.pnlGuideline.Width) / 2.0)));
      this.pnlGuideline.BackColor = Color.Transparent;
      this.pnlGuideline.BringToFront();
      this.lblGuidelineTitle = new Label();
      this.pnlGuideline.Controls.Add((Control) this.lblGuidelineTitle);
      this.lblGuidelineTitle.Height = 40;
      this.lblGuidelineTitle.Top = 65;
      this.lblGuidelineTitle.Left = 108;
      this.lblGuidelineTitle.Width = 300;
      this.lblGuidelineTitle.BackColor = Color.Transparent;
      this.lblGuidelineTitle.ForeColor = Color.White;
      this.lblGuidelineTitle.Text = "初始化向导";
      this.lblGuidelineTitle.Font = this.fnt21;
      this.lblGuideline = new Label();
      this.pnlGuideline.Controls.Add((Control) this.lblGuideline);
      this.lblGuideline.BackColor = Color.Transparent;
      this.lblGuideline.Size = new Size(800, 350);
      this.lblGuideline.Location = new Point(108, 160);
      this.lblGuideline.Font = this.fnt12;
      this.lblGuideline.Text = "欢迎您使用 MUNCS Express 2，我们正在检查您的运行环境。\r\n\r\n";
      this.btnDecision = new Label();
      this.pnlGuideline.Controls.Add((Control) this.btnDecision);
      this.btnDecision.MouseEnter += new EventHandler(this.btnDecision_MouseEnter);
      this.btnDecision.MouseLeave += new EventHandler(this.btnDecision_MouseLeave);
      this.btnDecision.MouseClick += new MouseEventHandler(this.btnDecision_MouseClick);
      this.btnDecision.BackColor = Color.Transparent;
      this.btnDecision.BackgroundImage = this.imgBackTrans[0];
      this.btnDecision.Size = new Size(150, 35);
      this.btnDecision.Location = new Point(this.lblGuideline.Left, checked (this.lblGuideline.Bottom + 10));
      this.btnDecision.Font = this.fnt12;
      this.btnDecision.TextAlign = ContentAlignment.MiddleLeft;
      this.btnDecision.Text = "";
      this.Scene_Main_Info_Update(true, true, true);
    }

    public void Window_Main_Info()
    {
      this.pnlMainInfo = (Panel) MainForm.Func_CreateObj("pnlMainInfo", "Panel");
      this.Controls.Add((Control) this.pnlMainInfo);
      int index1 = 0;
      do
      {
        this.pnlMInfo[index1] = (Panel) MainForm.Func_CreateObj("pnlMInfo(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainInfo.Controls.Add((Control) this.pnlMInfo[index1]);
        this.lblMInfoTitle[index1] = (Label) MainForm.Func_CreateObj("lblMInfoTitle(" + Conversions.ToString(index1) + ")", "Label");
        this.pnlMInfo[index1].Controls.Add((Control) this.lblMInfoTitle[index1]);
        this.pnlMInfoIn[index1] = (Panel) MainForm.Func_CreateObj("pnlMInfoIn(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMInfo[index1].Controls.Add((Control) this.pnlMInfoIn[index1]);
        checked { ++index1; }
      }
      while (index1 <= 5);
      this.pnlMInfoIn[0].MouseEnter += new EventHandler(this.btnMInfoCounter_MouseEnter);
      this.pnlMInfoIn[0].MouseLeave += new EventHandler(this.btnMInfoCounter_MouseLeave);
      int index2 = 0;
      do
      {
        this.lblMInfoPatch[index2] = (Label) MainForm.Func_CreateObj("lblMInfoPatch(" + Conversions.ToString(index2) + ")", "Label");
        checked { ++index2; }
      }
      while (index2 <= 2);
      this.pnlMInfo[2].Controls.Add((Control) this.lblMInfoPatch[0]);
      this.pnlMInfo[5].Controls.Add((Control) this.lblMInfoPatch[1]);
      this.pnlMainInfo.Controls.Add((Control) this.lblMInfoPatch[2]);
      int index3 = 0;
      do
      {
        this.lblMInfo[0, index3] = (Label) MainForm.Func_CreateObj("lblMInfo(0," + Conversions.ToString(index3) + ")", "Label");
        this.pnlMInfoIn[0].Controls.Add((Control) this.lblMInfo[0, index3]);
        this.lblMInfo[0, index3].MouseEnter += new EventHandler(this.btnMInfoCounter_MouseEnter);
        this.lblMInfo[0, index3].MouseLeave += new EventHandler(this.btnMInfoCounter_MouseLeave);
        checked { ++index3; }
      }
      while (index3 <= 2);
      int index4 = 0;
      do
      {
        this.btnMInfo[0, index4] = (Label) MainForm.Func_CreateObj("lblMInfo(0," + Conversions.ToString(index4) + ")", "Label");
        this.pnlMInfo[0].Controls.Add((Control) this.btnMInfo[0, index4]);
        this.btnMInfo[0, index4].MouseEnter += new EventHandler(this.btnMInfoCounterSub_MouseEnter);
        this.btnMInfo[0, index4].MouseLeave += new EventHandler(this.btnMInfoCounterSub_MouseLeave);
        this.btnMInfo[0, index4].MouseClick += new MouseEventHandler(this.btnMInfoCounterSub_MouseClick);
        checked { ++index4; }
      }
      while (index4 <= 3);
      int index5 = 0;
      do
      {
        this.txtMInfo[1, index5] = (TextBox) MainForm.Func_CreateObj("txtMInfo(1," + Conversions.ToString(index5) + ")", "TextBox");
        this.pnlMInfoIn[1].Controls.Add((Control) this.txtMInfo[1, index5]);
        this.lblMInfo[1, index5] = (Label) MainForm.Func_CreateObj("lblMInfo(1," + Conversions.ToString(index5) + ")", "Label");
        this.pnlMInfoIn[1].Controls.Add((Control) this.lblMInfo[1, index5]);
        this.lblMInfo[1, index5].MouseEnter += new EventHandler(this.btnMInfoDelSelect_MouseEnter);
        this.lblMInfo[1, index5].MouseLeave += new EventHandler(this.btnMInfoDelSelect_MouseLeave);
        this.lblMInfo[1, index5].MouseDown += new MouseEventHandler(this.btnMInfoDelSelect_MouseDown);
        this.lblMInfo[1, index5].MouseUp += new MouseEventHandler(this.btnMInfoDelSelect_MouseUp);
        checked { ++index5; }
      }
      while (index5 <= 2);
      int index6 = 5;
      do
      {
        this.lblMInfo[1, index6] = (Label) MainForm.Func_CreateObj("lblMInfo(1," + Conversions.ToString(index6) + ")", "Label");
        this.pnlMInfoIn[1].Controls.Add((Control) this.lblMInfo[1, index6]);
        this.lblMInfo[1, index6].MouseEnter += new EventHandler(this.lblMInfoMark_MouseEnter);
        this.lblMInfo[1, index6].MouseLeave += new EventHandler(this.lblMInfoMark_MouseLeave);
        this.lblMInfo[1, index6].MouseClick += new MouseEventHandler(this.lblMInfoMark_MouseClick);
        checked { ++index6; }
      }
      while (index6 <= 15);
      int index7 = 0;
      do
      {
        this.lblMInfo[2, index7] = (Label) MainForm.Func_CreateObj("lblMInfo(2," + Conversions.ToString(index7) + ")", "Label");
        this.pnlMInfoIn[2].Controls.Add((Control) this.lblMInfo[2, index7]);
        checked { ++index7; }
      }
      while (index7 <= 3);
      int index8 = 0;
      do
      {
        this.lblMInfo[3, index8] = (Label) MainForm.Func_CreateObj("lblMInfo(3," + Conversions.ToString(index8) + ")", "Label");
        this.pnlMInfoIn[3].Controls.Add((Control) this.lblMInfo[3, index8]);
        checked { ++index8; }
      }
      while (index8 <= 2);
      this.txtMInfo[4, 0] = (TextBox) MainForm.Func_CreateObj("txtMInfo(4,0)", "TextBox");
      this.pnlMInfoIn[4].Controls.Add((Control) this.txtMInfo[4, 0]);
      int index9 = 0;
      do
      {
        this.lblMInfo[5, index9] = (Label) MainForm.Func_CreateObj("lblMInfo(5," + Conversions.ToString(index9) + ")", "Label");
        this.pnlMInfoIn[5].Controls.Add((Control) this.lblMInfo[5, index9]);
        checked { ++index9; }
      }
      while (index9 <= 1);
      this.tmrMainCounter.Tick += new EventHandler(this.tmrMainCounter_Tick);
      this.tmrMainCounter.Interval = 1000;
      this.btnInitiateModerator.Size = new Size(25, 25);
      this.btnInitiateModerator.Text = "M";
      this.btnInitiateModerator.BackColor = this.ColorMain;
      this.pnlMInfoIn[1].Controls.Add((Control) this.btnInitiateModerator);
      this.btnInitiateModerator.BringToFront();
      this.btnInitiateModerator.MouseEnter += new EventHandler(this.btnMInfoDelSelect_MouseEnter);
      this.btnInitiateModerator.MouseLeave += new EventHandler(this.btnMInfoDelSelect_MouseLeave);
      this.btnInitiateModerator.MouseDown += new MouseEventHandler(this.btnMInfoDelSelect_MouseDown);
      this.btnInitiateModerator.MouseUp += new MouseEventHandler(this.btnInitiateModerator_Click);
      this.Scene_Main_Info_Update(true, true, true);
    }

    public void Window_Main_Vote()
    {
      this.pnlMainVote = (Panel) MainForm.Func_CreateObj("pnlMainVote", "Panel");
      this.Controls.Add((Control) this.pnlMainVote);
      int index1 = 0;
      do
      {
        this.pnlMVote[index1] = (Panel) MainForm.Func_CreateObj("pnlMVote(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainVote.Controls.Add((Control) this.pnlMVote[index1]);
        this.pnlMVoteIn[index1] = (Panel) MainForm.Func_CreateObj("pnlMVoteIn(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMVote[index1].Controls.Add((Control) this.pnlMVoteIn[index1]);
        checked { ++index1; }
      }
      while (index1 <= 5);
      int index2 = 0;
      do
      {
        this.lblMVote[0, index2] = (Label) MainForm.Func_CreateObj("lblMVote(0," + Conversions.ToString(index2) + ")", "Label");
        this.pnlMVoteIn[0].Controls.Add((Control) this.lblMVote[0, index2]);
        checked { ++index2; }
      }
      while (index2 <= 1);
      int index3 = 0;
      do
      {
        this.lblMVote[1, index3] = (Label) MainForm.Func_CreateObj("lblMVote(1," + Conversions.ToString(index3) + ")", "Label");
        this.pnlMVoteIn[1].Controls.Add((Control) this.lblMVote[1, index3]);
        this.lblMVoteLine[index3] = (Label) MainForm.Func_CreateObj("lblMVoteLine(" + Conversions.ToString(index3) + ")", "Label");
        this.pnlMVoteIn[1].Controls.Add((Control) this.lblMVoteLine[index3]);
        this.lblMVoteLight[0, index3] = (Label) MainForm.Func_CreateObj("lblMVoteLight(0," + Conversions.ToString(index3) + ")", "Label");
        this.pnlMVoteIn[1].Controls.Add((Control) this.lblMVoteLight[0, index3]);
        checked { ++index3; }
      }
      while (index3 <= 32);
      int index4 = 0;
      do
      {
        this.lblMVote[2, index4] = (Label) MainForm.Func_CreateObj("lblMVote(2," + Conversions.ToString(index4) + ")", "Label");
        this.pnlMVoteIn[2].Controls.Add((Control) this.lblMVote[2, index4]);
        checked { ++index4; }
      }
      while (index4 <= 0);
      int index5 = 0;
      do
      {
        this.lblMVote[3, index5] = (Label) MainForm.Func_CreateObj("lblMVote(3," + Conversions.ToString(index5) + ")", "Label");
        this.pnlMVoteIn[3].Controls.Add((Control) this.lblMVote[3, index5]);
        this.lblMVote[4, index5] = (Label) MainForm.Func_CreateObj("lblMVote(4," + Conversions.ToString(index5) + ")", "Label");
        this.pnlMVoteIn[4].Controls.Add((Control) this.lblMVote[4, index5]);
        checked { ++index5; }
      }
      while (index5 <= 7);
      int index6 = 0;
      do
      {
        this.lblMVoteLight[1, index6] = (Label) MainForm.Func_CreateObj("lblMVoteLight(1," + Conversions.ToString(index6) + ")", "Label");
        this.pnlMVoteIn[3].Controls.Add((Control) this.lblMVoteLight[1, index6]);
        this.lblMVoteLight[2, index6] = (Label) MainForm.Func_CreateObj("lblMVoteLight(2," + Conversions.ToString(index6) + ")", "Label");
        this.pnlMVoteIn[4].Controls.Add((Control) this.lblMVoteLight[2, index6]);
        checked { ++index6; }
      }
      while (index6 <= 3);
      int index7 = 0;
      do
      {
        this.lblMVote[5, index7] = (Label) MainForm.Func_CreateObj("lblMVote(5," + Conversions.ToString(index7) + ")", "Label");
        this.pnlMVoteIn[5].Controls.Add((Control) this.lblMVote[5, index7]);
        this.lblMVote[5, index7].MouseEnter += new EventHandler(this.btnMVote_MouseEnter);
        this.lblMVote[5, index7].MouseLeave += new EventHandler(this.btnMVote_MouseLeave);
        this.lblMVote[5, index7].MouseDown += new MouseEventHandler(this.btnMVote_MouseDown);
        this.lblMVote[5, index7].MouseUp += new MouseEventHandler(this.btnMVote_MouseUp);
        checked { ++index7; }
      }
      while (index7 <= 6);
      this.Scene_Main_Vote_Update(true, true, true);
    }

    public void Window_Main_RollCall()
    {
      this.pnlMainRoll = (Panel) MainForm.Func_CreateObj("pnlMainRoll", "Panel");
      this.Controls.Add((Control) this.pnlMainRoll);
      int index1 = 0;
      do
      {
        this.pnlMRoll[index1] = (Panel) MainForm.Func_CreateObj("pnlMRoll(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainRoll.Controls.Add((Control) this.pnlMRoll[index1]);
        this.pnlMRollIn[index1] = (Panel) MainForm.Func_CreateObj("pnlMRollIn(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMRoll[index1].Controls.Add((Control) this.pnlMRollIn[index1]);
        checked { ++index1; }
      }
      while (index1 <= 5);
      int index2 = 0;
      do
      {
        this.lblMRoll[0, index2] = (Label) MainForm.Func_CreateObj("lblMRoll(0," + Conversions.ToString(index2) + ")", "Label");
        this.pnlMRollIn[0].Controls.Add((Control) this.lblMRoll[0, index2]);
        checked { ++index2; }
      }
      while (index2 <= 1);
      int index3 = 0;
      do
      {
        this.lblMRoll[1, index3] = (Label) MainForm.Func_CreateObj("lblMRoll(1," + Conversions.ToString(index3) + ")", "Label");
        this.pnlMRollIn[1].Controls.Add((Control) this.lblMRoll[1, index3]);
        this.lblMRollLine[index3] = (Label) MainForm.Func_CreateObj("lblMRollLine(" + Conversions.ToString(index3) + ")", "Label");
        this.pnlMRollIn[1].Controls.Add((Control) this.lblMRollLine[index3]);
        this.lblMRollLight[0, index3] = (Label) MainForm.Func_CreateObj("lblMRollLight(0," + Conversions.ToString(index3) + ")", "Label");
        this.pnlMRollIn[1].Controls.Add((Control) this.lblMRollLight[0, index3]);
        checked { ++index3; }
      }
      while (index3 <= 19);
      int index4 = 0;
      do
      {
        this.lblMRoll[2, index4] = (Label) MainForm.Func_CreateObj("lblMRoll(2," + Conversions.ToString(index4) + ")", "Label");
        this.pnlMRollIn[2].Controls.Add((Control) this.lblMRoll[2, index4]);
        checked { ++index4; }
      }
      while (index4 <= 0);
      int index5 = 0;
      do
      {
        this.lblMRoll[3, index5] = (Label) MainForm.Func_CreateObj("lblMRoll(3," + Conversions.ToString(index5) + ")", "Label");
        this.pnlMRollIn[3].Controls.Add((Control) this.lblMRoll[3, index5]);
        this.lblMRoll[4, index5] = (Label) MainForm.Func_CreateObj("lblMRoll(4," + Conversions.ToString(index5) + ")", "Label");
        this.pnlMRollIn[4].Controls.Add((Control) this.lblMRoll[4, index5]);
        checked { ++index5; }
      }
      while (index5 <= 7);
      int index6 = 0;
      do
      {
        this.lblMRollLight[1, index6] = (Label) MainForm.Func_CreateObj("lblMRollLight(1," + Conversions.ToString(index6) + ")", "Label");
        this.pnlMRollIn[3].Controls.Add((Control) this.lblMRollLight[1, index6]);
        this.lblMRollLight[2, index6] = (Label) MainForm.Func_CreateObj("lblMRollLight(2," + Conversions.ToString(index6) + ")", "Label");
        this.pnlMRollIn[4].Controls.Add((Control) this.lblMRollLight[2, index6]);
        checked { ++index6; }
      }
      while (index6 <= 3);
      int index7 = 0;
      do
      {
        this.lblMRoll[5, index7] = (Label) MainForm.Func_CreateObj("lblMRoll(5," + Conversions.ToString(index7) + ")", "Label");
        this.pnlMRollIn[5].Controls.Add((Control) this.lblMRoll[5, index7]);
        this.lblMRoll[5, index7].MouseEnter += new EventHandler(this.btnMRollCall_MouseEnter);
        this.lblMRoll[5, index7].MouseLeave += new EventHandler(this.btnMRollCall_MouseLeave);
        this.lblMRoll[5, index7].MouseDown += new MouseEventHandler(this.btnMRollCall_MouseDown);
        this.lblMRoll[5, index7].MouseUp += new MouseEventHandler(this.btnMRollCall_MouseUp);
        checked { ++index7; }
      }
      while (index7 <= 6);
      this.Scene_Main_RollCall_Update(true, true, true);
    }

    public void Window_Main_LanguageSelect()
    {
      this.pnlMainLanguage = (Panel) MainForm.Func_CreateObj("pnlMainLanguage", "Panel");
      this.Controls.Add((Control) this.pnlMainLanguage);
      int index1 = 0;
      do
      {
        this.pnlMLan[index1] = (Panel) MainForm.Func_CreateObj("pnlMLan(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainLanguage.Controls.Add((Control) this.pnlMLan[index1]);
        checked { ++index1; }
      }
      while (index1 <= 1);
      this.lblMLanTitle = (Label) MainForm.Func_CreateObj("lblMLanTitle", "Label");
      this.pnlMLan[0].Controls.Add((Control) this.lblMLanTitle);
      int index2 = 0;
      do
      {
        this.lblMLan[index2] = (Label) MainForm.Func_CreateObj("lblMLan(" + Conversions.ToString(index2) + ")", "Label");
        this.pnlMLan[0].Controls.Add((Control) this.lblMLan[index2]);
        this.lblMLan[index2].MouseEnter += new EventHandler(this.btnLanSel_MouseEnter);
        this.lblMLan[index2].MouseLeave += new EventHandler(this.btnLanSel_MouseLeave);
        this.lblMLan[index2].MouseClick += new MouseEventHandler(this.btnLanSel_MouseClick);
        checked { ++index2; }
      }
      while (index2 <= 8);
      this.lblMLanLogo = (Label) MainForm.Func_CreateObj("lblMLanLogo", "Label");
      this.pnlMLan[1].Controls.Add((Control) this.lblMLanLogo);
      this.Scene_Main_LanguageSelect_Update(true, true, true);
    }

    public void Window_Main_BackgroundSelect()
    {
      this.pnlMainBackground = (Panel) MainForm.Func_CreateObj("pnlMainBackground", "Panel");
      this.Controls.Add((Control) this.pnlMainBackground);
      int index1 = 0;
      do
      {
        this.pnlMBac[index1] = (Panel) MainForm.Func_CreateObj("pnlMBac(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainBackground.Controls.Add((Control) this.pnlMBac[index1]);
        checked { ++index1; }
      }
      while (index1 <= 1);
      this.lblMBac[0, 0] = (Label) MainForm.Func_CreateObj("lblMBac(0,0)", "Label");
      this.pnlMBac[0].Controls.Add((Control) this.lblMBac[0, 0]);
      int num = checked (this.SkinAmount - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        this.lblMBac[1, index2] = (Label) MainForm.Func_CreateObj("lblMBac(1," + Conversions.ToString(index2) + ")", "Label");
        this.pnlMBac[1].Controls.Add((Control) this.lblMBac[1, index2]);
        this.lblMBac[1, index2].MouseEnter += new EventHandler(this.btnMBac_MouseEnter);
        this.lblMBac[1, index2].MouseLeave += new EventHandler(this.btnMBac_MouseLeave);
        this.lblMBac[1, index2].MouseDown += new MouseEventHandler(this.btnMBac_MouseDown);
        this.lblMBac[1, index2].MouseUp += new MouseEventHandler(this.btnMBac_MouseUp);
        checked { ++index2; }
      }
      this.Scene_Main_BackgroundSelect_Update(true, true, true);
    }

    public void Window_Main_Widget()
    {
      this.pnlMainWidget = (Panel) MainForm.Func_CreateObj("pnlMainWidget", "Panel");
      this.Controls.Add((Control) this.pnlMainWidget);
      int index1 = 0;
      do
      {
        this.pnlMWid[index1] = (Panel) MainForm.Func_CreateObj("pnlMWid(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainWidget.Controls.Add((Control) this.pnlMWid[index1]);
        checked { ++index1; }
      }
      while (index1 <= 4);
      this.lblMWid[0, 0] = (Label) MainForm.Func_CreateObj("lblMWid(0,0)", "Label");
      this.pnlMWid[0].Controls.Add((Control) this.lblMWid[0, 0]);
      this.lblMWid[0, 0].MouseClick += new MouseEventHandler(this.btnMWidTitle_MouseClick);
      int index2 = 0;
      do
      {
        this.lblMWid[1, index2] = (Label) MainForm.Func_CreateObj("lblMWid(1," + Conversions.ToString(index2) + ")", "Label");
        this.pnlMWid[1].Controls.Add((Control) this.lblMWid[1, index2]);
        checked { ++index2; }
      }
      while (index2 <= 7);
      int index3 = 0;
      do
      {
        this.lblMWid[2, index3] = (Label) MainForm.Func_CreateObj("lblMWid(2," + Conversions.ToString(index3) + ")", "Label");
        this.pnlMWid[2].Controls.Add((Control) this.lblMWid[2, index3]);
        this.lblMWid[2, index3].MouseEnter += new EventHandler(this.btnMWidTarget_MouseEnter);
        checked { ++index3; }
      }
      while (index3 <= 79);
      int index4 = 0;
      do
      {
        this.lblMWid[3, index4] = (Label) MainForm.Func_CreateObj("lblMWid(3," + Conversions.ToString(index4) + ")", "Label");
        this.pnlMWid[3].Controls.Add((Control) this.lblMWid[3, index4]);
        this.lblMWid[3, index4].MouseEnter += new EventHandler(this.btnMWidEmpty_MouseEnter);
        checked { ++index4; }
      }
      while (index4 <= 53);
      int index5 = 0;
      do
      {
        this.lblMWid[4, index5] = (Label) MainForm.Func_CreateObj("lblMWid(4," + Conversions.ToString(index5) + ")", "Label");
        this.pnlMWid[4].Controls.Add((Control) this.lblMWid[4, index5]);
        checked { ++index5; }
      }
      while (index5 <= 4);
      int index6 = 0;
      do
      {
        this.lblMWidDrag[index6] = (Label) MainForm.Func_CreateObj("lblMWidDrag(" + Conversions.ToString(index6) + ")", "Label");
        this.pnlMainWidget.Controls.Add((Control) this.lblMWidDrag[index6]);
        this.lblMWidDrag[index6].MouseDown += new MouseEventHandler(this.lblMWidDrag_MouseDown);
        this.lblMWidDrag[index6].MouseMove += new MouseEventHandler(this.lblMWidDrag_MouseMove);
        this.lblMWidDrag[index6].MouseUp += new MouseEventHandler(this.lblMWidDrag_MouseUp);
        this.lblMWidDrag[index6].MouseLeave += new EventHandler(this.lblMWidDrag_MouseLeave);
        checked { ++index6; }
      }
      while (index6 <= 1);
      this.Scene_Main_Widget_Update(true, true, true);
    }

    public void Window_Main_KeyMenu()
    {
      this.pnlMainKeyMenu = (Panel) MainForm.Func_CreateObj("pnlMainKeyMenu", "Panel");
      this.Controls.Add((Control) this.pnlMainKeyMenu);
      int index = 0;
      do
      {
        this.lblMKeyMenu[index] = (Label) MainForm.Func_CreateObj("lblMKeyMenu(" + Conversions.ToString(index) + ")", "Label");
        this.pnlMainKeyMenu.Controls.Add((Control) this.lblMKeyMenu[index]);
        this.lblMKeyMenuDeco[index] = (Label) MainForm.Func_CreateObj("lblMKeyMenuDeco(" + Conversions.ToString(index) + ")", "Label");
        this.pnlMainKeyMenu.Controls.Add((Control) this.lblMKeyMenuDeco[index]);
        this.lblMKeyMenu[index].MouseEnter += new EventHandler(this.btnKeyMenuSub_MouseEnter);
        this.lblMKeyMenu[index].MouseLeave += new EventHandler(this.btnKeyMenuSub_MouseLeave);
        this.lblMKeyMenu[index].MouseClick += new MouseEventHandler(this.btnKeyMenuSub_MouseClick);
        this.lblMKeyMenuDeco[index].MouseEnter += new EventHandler(this.btnKeyMenuSub_MouseEnter);
        this.lblMKeyMenuDeco[index].MouseLeave += new EventHandler(this.btnKeyMenuSub_MouseLeave);
        this.lblMKeyMenuDeco[index].MouseClick += new MouseEventHandler(this.btnKeyMenuSub_MouseClick);
        checked { ++index; }
      }
      while (index <= 4);
      this.Scene_Main_KeyMenu();
    }

    public void Window_Main_Conference()
    {
      this.pnlMainConference = (Panel) MainForm.Func_CreateObj("pnlMainConference", "Panel");
      this.Controls.Add((Control) this.pnlMainConference);
      int index1 = 0;
      do
      {
        this.pnlMConf[index1] = (Panel) MainForm.Func_CreateObj("pnlMConf(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainConference.Controls.Add((Control) this.pnlMConf[index1]);
        checked { ++index1; }
      }
      while (index1 <= 0);
      int index2 = 0;
      do
      {
        this.lblMConf[0, index2] = (Label) MainForm.Func_CreateObj("lblMConf(0," + Conversions.ToString(index2) + ")", "Label");
        this.pnlMConf[0].Controls.Add((Control) this.lblMConf[0, index2]);
        this.txtMConf[0, index2] = (TextBox) MainForm.Func_CreateObj("txtMConf(0," + Conversions.ToString(index2) + ")", "TEXTBOX");
        this.pnlMConf[0].Controls.Add((Control) this.txtMConf[0, index2]);
        checked { ++index2; }
      }
      while (index2 <= 1);
      this.lblMConf[0, 4] = (Label) MainForm.Func_CreateObj("lblMConf(0,4)", "Label");
      this.pnlMConf[0].Controls.Add((Control) this.lblMConf[0, 4]);
      this.lblMConf[0, 5] = (Label) MainForm.Func_CreateObj("lblMConf(0,5)", "Label");
      this.pnlMConf[0].Controls.Add((Control) this.lblMConf[0, 5]);
      this.lblMConf[0, 5].MouseEnter += new EventHandler(this.btnMConf_MouseEnter);
      this.lblMConf[0, 5].MouseLeave += new EventHandler(this.btnMConf_MouseLeave);
      this.lblMConf[0, 5].MouseClick += new MouseEventHandler(this.btnMConf_MouseClick);
      this.Scene_Main_Conference_Update(true, true, true);
    }

    public void Window_Main_Settings()
    {
      this.pnlMainSettings = (Panel) MainForm.Func_CreateObj("pnlMainSettings", "Panel");
      this.Controls.Add((Control) this.pnlMainSettings);
      int index1 = 0;
      do
      {
        this.pnlMSet[index1] = (Panel) MainForm.Func_CreateObj("pnlMSet(" + Conversions.ToString(index1) + ")", "Panel");
        this.pnlMainSettings.Controls.Add((Control) this.pnlMSet[index1]);
        checked { ++index1; }
      }
      while (index1 <= 1);
      int index2 = 0;
      do
      {
        this.lblMSetTitle[index2] = (Label) MainForm.Func_CreateObj("lblMSetTitle(" + Conversions.ToString(index2) + ")", "Label");
        this.pnlMSet[0].Controls.Add((Control) this.lblMSetTitle[index2]);
        checked { ++index2; }
      }
      while (index2 <= 1);
      int index3 = 0;
      do
      {
        int index4 = 0;
        do
        {
          this.lblMSetOption[index3, index4] = (Label) MainForm.Func_CreateObj("lblMSetOption(" + Conversions.ToString(index3) + "," + Conversions.ToString(index4) + ")", "Label");
          this.pnlMSet[1].Controls.Add((Control) this.lblMSetOption[index3, index4]);
          checked { ++index4; }
        }
        while (index4 <= 3);
        checked { ++index3; }
      }
      while (index3 <= 2);
      this.Scene_Main_Settings_Update(true, true, true);
    }

    public void Scene_Main_Settings_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      if (IsSizeChanging)
      {
        Panel pnlMainSettings = this.pnlMainSettings;
        pnlMainSettings.Visible = true;
        pnlMainSettings.Height = checked (this.Height - this.pnlMainMenu.Height);
        pnlMainSettings.Width = 1024;
        pnlMainSettings.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainSettings.Height) / 2.0)));
        pnlMainSettings.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainSettings.Width) / 2.0)));
        Panel panel1 = this.pnlMSet[0];
        panel1.Height = 50;
        panel1.Width = 800;
        panel1.Top = 30;
        panel1.Left = 90;
        Panel panel2 = this.pnlMSet[1];
        panel2.Height = 600;
        panel2.Width = 800;
        panel2.Top = 125;
        panel2.Left = 112;
        Label label = this.lblMSetTitle[0];
        label.Height = 50;
        label.Width = 800;
        label.Top = 0;
        label.Left = 0;
        label.TextAlign = ContentAlignment.MiddleLeft;
      }
      if (IsColorChanging)
      {
        this.pnlMainSettings.BackColor = Color.Transparent;
        this.pnlMSet[0].BackColor = Color.Transparent;
        Label label = this.lblMSetTitle[0];
        label.BackColor = Color.Transparent;
        label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
      if (!IsTextChanging)
        return;
      Label label1 = this.lblMSetTitle[0];
      label1.Text = this.strMSet[0, 0];
      label1.Font = this.fnt26;
    }

    public void Scene_MainMenu_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      if (IsSizeChanging)
      {
        Panel pnlMainMenu = this.pnlMainMenu;
        pnlMainMenu.Height = 25;
        pnlMainMenu.Width = checked (8 * pnlMainMenu.Height + 10);
        pnlMainMenu.Top = checked (this.Height - pnlMainMenu.Height);
        pnlMainMenu.Left = checked (this.Width - 8 * (pnlMainMenu.Height + 10));
        int index1 = 0;
        do
        {
          Label label = this.btnMMenu[index1];
          label.Height = 25;
          label.Width = checked (label.Height + 10);
          label.Top = 0;
          label.Left = checked (index1 * label.Width);
          label.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index1; }
        }
        while (index1 <= 7);
        Panel pnlMmenuSub = this.pnlMMenuSub;
        pnlMmenuSub.Height = 250;
        pnlMmenuSub.Width = 300;
        pnlMmenuSub.Top = checked (this.Height - this.pnlMainMenu.Height - pnlMmenuSub.Height);
        pnlMmenuSub.Left = checked (this.Width - pnlMmenuSub.Width);
        pnlMmenuSub.Visible = false;
        int index2 = 0;
        do
        {
          Label label1 = this.btnMMenuSub[index2];
          label1.Height = 25;
          label1.Width = 275;
          label1.Top = checked (index2 * label1.Height);
          label1.Left = 0;
          label1.TextAlign = ContentAlignment.MiddleLeft;
          Label label2 = this.btnMMenuSubDeco[index2];
          label2.Height = 25;
          label2.Width = 25;
          label2.Top = checked (index2 * label2.Height);
          label2.Left = this.btnMMenuSub[index2].Width;
          label2.TextAlign = ContentAlignment.MiddleLeft;
          checked { ++index2; }
        }
        while (index2 <= 9);
      }
      if (IsColorChanging)
      {
        Panel pnlMainMenu = this.pnlMainMenu;
        int index1 = 0;
        do
        {
          Label label = this.btnMMenu[index1];
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.BackgroundImage = this.imgIcon[index1];
          label.BackgroundImageLayout = ImageLayout.Center;
          checked { ++index1; }
        }
        while (index1 <= 7);
        Panel pnlMmenuSub = this.pnlMMenuSub;
        pnlMmenuSub.BackColor = this.ColorMain;
        pnlMmenuSub.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        int index2 = 0;
        do
        {
          Label label1 = this.btnMMenuSub[index2];
          label1.BackColor = this.ColorMain;
          label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          Label label2 = this.btnMMenuSubDeco[index2];
          label2.BackColor = this.ColorMain;
          label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index2; }
        }
        while (index2 <= 9);
      }
      if (!IsTextChanging)
        return;
      int index = 0;
      do
      {
        Label label1 = this.btnMMenuSub[index];
        label1.Font = this.fnt9;
        label1.Text = " Main Menu Option " + Conversions.ToString(checked (index + 1));
        Label label2 = this.btnMMenuSubDeco[index];
        label2.Font = this.fnt9;
        label2.Text = ">";
        checked { ++index; }
      }
      while (index <= 9);
    }

    public void Scene_SubMenu_Update_I(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      if (IsSizeChanging)
      {
        int index1 = 0;
        do
        {
          Panel panel1 = this.pnlSubMenu[index1];
          panel1.Height = 276;
          panel1.Width = 252;
          panel1.Top = checked (300 + 10 * (index1 + 1));
          panel1.Left = checked (600 + 10 * (index1 + 1));
          this.IsSubVisible[index1] = true;
          Label label1 = this.lblSMenuTitle[index1];
          label1.Height = 22;
          label1.Width = checked (this.pnlSubMenu[index1].Width - label1.Height);
          label1.Top = 0;
          label1.Left = 0;
          label1.TextAlign = ContentAlignment.MiddleLeft;
          Label label2 = this.btnSMenuClose[index1];
          label2.Height = checked (this.lblSMenuTitle[index1].Height - 1);
          label2.Width = label2.Height;
          label2.Top = 1;
          label2.Left = this.lblSMenuTitle[index1].Width;
          label2.TextAlign = ContentAlignment.MiddleCenter;
          Panel panel2 = this.pnlSMenuIn[index1];
          panel2.Height = checked (this.pnlSubMenu[index1].Height - this.lblSMenuTitle[index1].Height);
          panel2.Width = this.pnlSubMenu[index1].Width;
          panel2.Top = this.lblSMenuTitle[index1].Height;
          panel2.Left = 0;
          checked { ++index1; }
        }
        while (index1 <= 20);
        int index2 = 0;
        do
        {
          this.pnlSubMenu[index2].Visible = false;
          this.IsSubVisible[index2] = false;
          checked { ++index2; }
        }
        while (index2 <= 20);
      }
      if (IsColorChanging)
      {
        int index = 0;
        do
        {
          this.pnlSubMenu[index].BackColor = this.ColorMainDeep;
          this.pnlSubMenu[index].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          this.lblSMenuTitle[index].BackColor = this.ColorMainDeep;
          this.lblSMenuTitle[index].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          this.btnSMenuClose[index].BackColor = this.ColorMainDeep;
          this.btnSMenuClose[index].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          this.pnlSMenuIn[index].BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          this.pnlSMenuIn[index].ForeColor = Color.FromArgb(30, 30, 30);
          checked { ++index; }
        }
        while (index <= 20);
      }
      if (!IsTextChanging)
        return;
      int index3 = 0;
      do
      {
        this.lblSMenuTitle[index3].Font = this.fnt9;
        this.btnSMenuClose[index3].Font = this.fnt9;
        this.btnSMenuClose[index3].Text = "X";
        checked { ++index3; }
      }
      while (index3 <= 20);
    }

    public void Scene_SubMenu_Update_II(bool IsRefreshing, int intRefreshing)
    {
      if (!IsRefreshing)
      {
        int index1 = 0;
        int index2 = 0;
        do
        {
          Label label = this.lblSMenuCaption[0, index2];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index2 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[0, index2];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[0, index2].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[0, index2].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[0, index2].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index2; }
        }
        while (index2 <= 3);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[0, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index3 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[0, index3];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index1].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[0].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index3 % 2) * this.pnlSMenuIn[0].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index3; }
        }
        while (index3 <= 1);
        this.pnlSMenuIn[0].Height = checked (this.txtSMenuAnswer[0, 3].Top + this.txtSMenuAnswer[0, 3].Height + 20 + this.btnSMenuFormalBtn[0, 0].Height);
        this.pnlSubMenu[0].Height = checked (this.pnlSMenuIn[0].Height + this.lblSMenuTitle[0].Height + 1);
        int index4 = 0;
        do
        {
          this.btnSMenuFormalBtn[0, index4].Top = checked (this.pnlSMenuIn[0].Height - this.btnSMenuFormalBtn[0, index4].Height);
          checked { ++index4; }
        }
        while (index4 <= 1);
        int index5 = 1;
        int index6 = 0;
        do
        {
          Label label = this.lblSMenuCaption[1, index6];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index6 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[1, index6];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[1, index6].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[1, index6].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[1, index6].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index6; }
        }
        while (index6 <= 1);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[1, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index7 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[1, index7];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index5].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[1].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index7 % 2) * this.pnlSMenuIn[1].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index7; }
        }
        while (index7 <= 1);
        this.pnlSMenuIn[1].Height = checked (this.txtSMenuAnswer[1, 1].Top + this.txtSMenuAnswer[1, 1].Height + 20 + this.btnSMenuFormalBtn[1, 0].Height);
        this.pnlSubMenu[1].Height = checked (this.pnlSMenuIn[1].Height + this.lblSMenuTitle[1].Height + 1);
        int index8 = 0;
        do
        {
          this.btnSMenuFormalBtn[1, index8].Top = checked (this.pnlSMenuIn[1].Height - this.btnSMenuFormalBtn[1, index8].Height);
          checked { ++index8; }
        }
        while (index8 <= 1);
        int index9 = 2;
        int index10 = 0;
        do
        {
          Label label = this.lblSMenuCaption[2, index10];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index10 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[2, index10];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[2, index10].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[2, index10].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[2, index10].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index10; }
        }
        while (index10 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[2, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index11 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[2, index11];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index9].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[2].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index11 % 2) * this.pnlSMenuIn[2].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index11; }
        }
        while (index11 <= 1);
        this.pnlSMenuIn[2].Height = checked (this.txtSMenuAnswer[2, 0].Top + this.txtSMenuAnswer[2, 0].Height + 20 + this.btnSMenuFormalBtn[2, 0].Height);
        this.pnlSubMenu[2].Height = checked (this.pnlSMenuIn[2].Height + this.lblSMenuTitle[2].Height + 1);
        int index12 = 0;
        do
        {
          this.btnSMenuFormalBtn[2, index12].Top = checked (this.pnlSMenuIn[2].Height - this.btnSMenuFormalBtn[2, index12].Height);
          checked { ++index12; }
        }
        while (index12 <= 1);
        int index13 = 3;
        int index14 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index13, index14];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index14 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index13, index14];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index13, index14].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index13, index14].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index13, index14].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index14; }
        }
        while (index14 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[3, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index15 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index13, index15];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index13].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index13].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index15 % 2) * this.pnlSMenuIn[index13].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index15; }
        }
        while (index15 <= 1);
        this.pnlSMenuIn[index13].Height = checked (this.txtSMenuAnswer[index13, 0].Top + this.txtSMenuAnswer[index13, 0].Height + 20 + this.btnSMenuFormalBtn[index13, 0].Height);
        this.pnlSubMenu[index13].Height = checked (this.pnlSMenuIn[index13].Height + this.lblSMenuTitle[index13].Height + 1);
        int index16 = 0;
        do
        {
          this.btnSMenuFormalBtn[index13, index16].Top = checked (this.pnlSMenuIn[index13].Height - this.btnSMenuFormalBtn[index13, index16].Height);
          checked { ++index16; }
        }
        while (index16 <= 1);
        int index17 = 4;
        int index18 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index17, index18];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index18 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index17, index18];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index17, index18].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index17, index18].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index17, index18].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index18; }
        }
        while (index18 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[4, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index19 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index17, index19];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index17].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index17].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index19 % 2) * this.pnlSMenuIn[index17].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index19; }
        }
        while (index19 <= 1);
        this.pnlSMenuIn[index17].Height = checked (this.txtSMenuAnswer[index17, 0].Top + this.txtSMenuAnswer[index17, 0].Height + 20 + this.btnSMenuFormalBtn[index17, 0].Height);
        this.pnlSubMenu[index17].Height = checked (this.pnlSMenuIn[index17].Height + this.lblSMenuTitle[index17].Height + 1);
        int index20 = 0;
        do
        {
          this.btnSMenuFormalBtn[index17, index20].Top = checked (this.pnlSMenuIn[index17].Height - this.btnSMenuFormalBtn[index17, index20].Height);
          checked { ++index20; }
        }
        while (index20 <= 1);
        int index21 = 5;
        int index22 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index21, index22];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index22 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index21, index22];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index21, index22].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index21, index22].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index21, index22].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index22; }
        }
        while (index22 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[5, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index23 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index21, index23];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index21].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index21].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index23 % 2) * this.pnlSMenuIn[index21].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index23; }
        }
        while (index23 <= 1);
        this.pnlSMenuIn[index21].Height = checked (this.txtSMenuAnswer[index21, 0].Top + this.txtSMenuAnswer[index21, 0].Height + 20 + this.btnSMenuFormalBtn[index21, 0].Height);
        this.pnlSubMenu[index21].Height = checked (this.pnlSMenuIn[index21].Height + this.lblSMenuTitle[index21].Height + 1);
        int index24 = 0;
        do
        {
          this.btnSMenuFormalBtn[index21, index24].Top = checked (this.pnlSMenuIn[index21].Height - this.btnSMenuFormalBtn[index21, index24].Height);
          checked { ++index24; }
        }
        while (index24 <= 1);
        int index25 = 6;
        int index26 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index25, index26];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index26 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index25, index26];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index25, index26].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index25, index26].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index25, index26].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index26; }
        }
        while (index26 <= 1);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[6, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index27 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index25, index27];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index25].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index25].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index27 % 2) * this.pnlSMenuIn[index25].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index27; }
        }
        while (index27 <= 1);
        this.pnlSMenuIn[index25].Height = checked (this.txtSMenuAnswer[index25, 1].Top + this.txtSMenuAnswer[index25, 1].Height + 20 + this.btnSMenuFormalBtn[index25, 1].Height);
        this.pnlSubMenu[index25].Height = checked (this.pnlSMenuIn[index25].Height + this.lblSMenuTitle[index25].Height + 1);
        int index28 = 0;
        do
        {
          this.btnSMenuFormalBtn[index25, index28].Top = checked (this.pnlSMenuIn[index25].Height - this.btnSMenuFormalBtn[index25, index28].Height);
          checked { ++index28; }
        }
        while (index28 <= 1);
        int index29 = 7;
        int index30 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index29, index30];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index30 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index29, index30];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index29, index30].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index29, index30].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index29, index30].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index30; }
        }
        while (index30 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[7, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index31 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index29, index31];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index29].Width;
          label.Top = checked (this.pnlSMenuIn[index29].Height - label.Height);
          label.Left = 0;
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index31; }
        }
        while (index31 <= 0);
        this.pnlSMenuIn[index29].Height = checked (this.txtSMenuAnswer[index29, 0].Top + this.txtSMenuAnswer[index29, 0].Height + 20 + this.btnSMenuFormalBtn[index29, 0].Height);
        this.pnlSubMenu[index29].Height = checked (this.pnlSMenuIn[index29].Height + this.lblSMenuTitle[index29].Height + 1);
        int index32 = 0;
        do
        {
          this.btnSMenuFormalBtn[index29, index32].Top = checked (this.pnlSMenuIn[index29].Height - this.btnSMenuFormalBtn[index29, index32].Height);
          checked { ++index32; }
        }
        while (index32 <= 0);
        int index33 = 8;
        int index34 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index33, index34];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index34 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index33, index34];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index33, index34].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index33, index34].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index33, index34].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index34; }
        }
        while (index34 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[8, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index35 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index33, index35];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index33].Width;
          label.Top = checked (this.pnlSMenuIn[index33].Height - label.Height);
          label.Left = 0;
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index35; }
        }
        while (index35 <= 0);
        this.pnlSMenuIn[index33].Height = checked (this.txtSMenuAnswer[index33, 0].Top + this.txtSMenuAnswer[index33, 0].Height + 20 + this.btnSMenuFormalBtn[index33, 0].Height);
        this.pnlSubMenu[index33].Height = checked (this.pnlSMenuIn[index33].Height + this.lblSMenuTitle[index33].Height + 1);
        int index36 = 0;
        do
        {
          this.btnSMenuFormalBtn[index33, index36].Top = checked (this.pnlSMenuIn[index33].Height - this.btnSMenuFormalBtn[index33, index36].Height);
          checked { ++index36; }
        }
        while (index36 <= 0);
        int index37 = 9;
        int index38 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index37, index38];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index38 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index37, index38];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index37, index38].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index37, index38].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index37, index38].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index38; }
        }
        while (index38 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[9, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index39 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index37, index39];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index37].Width;
          label.Top = checked (this.pnlSMenuIn[index37].Height - label.Height);
          label.Left = 0;
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index39; }
        }
        while (index39 <= 0);
        this.pnlSMenuIn[index37].Height = checked (this.txtSMenuAnswer[index37, 0].Top + this.txtSMenuAnswer[index37, 0].Height + 20 + this.btnSMenuFormalBtn[index37, 0].Height);
        this.pnlSubMenu[index37].Height = checked (this.pnlSMenuIn[index37].Height + this.lblSMenuTitle[index37].Height + 1);
        int index40 = 0;
        do
        {
          this.btnSMenuFormalBtn[index37, index40].Top = checked (this.pnlSMenuIn[index37].Height - this.btnSMenuFormalBtn[index37, index40].Height);
          checked { ++index40; }
        }
        while (index40 <= 0);
        int index41 = 10;
        int index42 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index41, index42];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 230;
          label.Top = checked (20 + index42 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          checked { ++index42; }
        }
        while (index42 <= 0);
        int index43 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index41, index43];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index41].Width;
          label.Top = checked (this.pnlSMenuIn[index41].Height - label.Height);
          label.Left = 0;
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index43; }
        }
        while (index43 <= 0);
        this.pnlSMenuIn[index41].Height = checked (this.lblSMenuCaption[index41, 0].Top + this.lblSMenuCaption[index41, 0].Height + 20 + this.btnSMenuFormalBtn[index41, 0].Height);
        this.pnlSubMenu[index41].Height = checked (this.pnlSMenuIn[index41].Height + this.lblSMenuTitle[index41].Height + 1);
        int index44 = 0;
        do
        {
          this.btnSMenuFormalBtn[index41, index44].Top = checked (this.pnlSMenuIn[index41].Height - this.btnSMenuFormalBtn[index41, index44].Height);
          checked { ++index44; }
        }
        while (index44 <= 0);
        int index45 = 11;
        int index46 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index45, index46];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 230;
          label.Top = checked (20 + index46 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          checked { ++index46; }
        }
        while (index46 <= 0);
        int index47 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index45, index47];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index45].Width;
          label.Top = checked (this.pnlSMenuIn[index45].Height - label.Height);
          label.Left = 0;
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index47; }
        }
        while (index47 <= 0);
        this.pnlSMenuIn[index45].Height = checked (this.lblSMenuCaption[index45, 0].Top + this.lblSMenuCaption[index45, 0].Height + 20 + this.btnSMenuFormalBtn[index45, 0].Height);
        this.pnlSubMenu[index45].Height = checked (this.pnlSMenuIn[index45].Height + this.lblSMenuTitle[index45].Height + 1);
        int index48 = 0;
        do
        {
          this.btnSMenuFormalBtn[index45, index48].Top = checked (this.pnlSMenuIn[index45].Height - this.btnSMenuFormalBtn[index45, index48].Height);
          checked { ++index48; }
        }
        while (index48 <= 0);
        int index49 = 12;
        int index50 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index49, index50];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index50 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index49, index50];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[1, index50].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[1, index50].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[1, index50].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index50; }
        }
        while (index50 <= 1);
        int index51 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index49, index51];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index49].Width;
          label.Top = checked (this.pnlSMenuIn[index49].Height - label.Height);
          label.Left = 0;
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index51; }
        }
        while (index51 <= 0);
        this.pnlSMenuIn[index49].Height = checked (this.txtSMenuAnswer[index49, 1].Top + this.txtSMenuAnswer[index49, 1].Height + 20 + this.btnSMenuFormalBtn[index49, 0].Height);
        this.pnlSubMenu[index49].Height = checked (this.pnlSMenuIn[index49].Height + this.lblSMenuTitle[index49].Height + 1);
        int index52 = 0;
        do
        {
          this.btnSMenuFormalBtn[index49, index52].Top = checked (this.pnlSMenuIn[index49].Height - this.btnSMenuFormalBtn[index49, index52].Height);
          checked { ++index52; }
        }
        while (index52 <= 0);
        int index53 = 13;
        int index54 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index53, index54];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 230;
          label.Top = checked (20 + index54 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          checked { ++index54; }
        }
        while (index54 <= 0);
        int index55 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index53, index55];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index53].Width / 3.0)));
          label.Top = checked (this.pnlSMenuIn[index53].Height - label.Height);
          label.Left = checked (index55 * label.Width);
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index55; }
        }
        while (index55 <= 2);
        this.pnlSMenuIn[index53].Height = checked (this.lblSMenuCaption[index53, 0].Top + this.lblSMenuCaption[index53, 0].Height + 20 + this.btnSMenuFormalBtn[index53, 0].Height);
        this.pnlSubMenu[index53].Height = checked (this.pnlSMenuIn[index53].Height + this.lblSMenuTitle[index53].Height + 1);
        int index56 = 0;
        do
        {
          this.btnSMenuFormalBtn[index53, index56].Top = checked (this.pnlSMenuIn[index53].Height - this.btnSMenuFormalBtn[index53, index56].Height);
          checked { ++index56; }
        }
        while (index56 <= 2);
        int index57 = 14;
        int index58 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index57, index58];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index58 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index57, index58];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index57, index58].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index57, index58].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index57, index58].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index58; }
        }
        while (index58 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[14, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index59 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index57, index59];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index57].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index57].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index59 % 2) * this.pnlSMenuIn[index57].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index59; }
        }
        while (index59 <= 1);
        this.pnlSMenuIn[index57].Height = checked (this.txtSMenuAnswer[index57, 0].Top + this.txtSMenuAnswer[index57, 0].Height + 20 + this.btnSMenuFormalBtn[index57, 0].Height);
        this.pnlSubMenu[index57].Height = checked (this.pnlSMenuIn[index57].Height + this.lblSMenuTitle[index57].Height + 1);
        int index60 = 0;
        do
        {
          this.btnSMenuFormalBtn[index57, index60].Top = checked (this.pnlSMenuIn[index57].Height - this.btnSMenuFormalBtn[index57, index60].Height);
          checked { ++index60; }
        }
        while (index60 <= 1);
        int index61 = 15;
        int index62 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index61, index62];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index62 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index61, index62];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index61, index62].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index61, index62].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index61, index62].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index62; }
        }
        while (index62 <= 2);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[15, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index63 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index61, index63];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index61].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index61].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index63 % 2) * this.pnlSMenuIn[index61].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index63; }
        }
        while (index63 <= 1);
        this.pnlSMenuIn[index61].Height = checked (this.txtSMenuAnswer[index61, 2].Top + this.txtSMenuAnswer[index61, 2].Height + 20 + this.btnSMenuFormalBtn[index61, 0].Height);
        this.pnlSubMenu[index61].Height = checked (this.pnlSMenuIn[index61].Height + this.lblSMenuTitle[index61].Height + 1);
        int index64 = 0;
        do
        {
          this.btnSMenuFormalBtn[index61, index64].Top = checked (this.pnlSMenuIn[index61].Height - this.btnSMenuFormalBtn[index61, index64].Height);
          checked { ++index64; }
        }
        while (index64 <= 1);
        int index65 = 16;
        int index66 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index65, index66];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index66 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index65, index66];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index65, index66].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index65, index66].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index65, index66].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index66; }
        }
        while (index66 <= 1);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[16, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index67 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index65, index67];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index65].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index65].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index67 % 2) * this.pnlSMenuIn[index65].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index67; }
        }
        while (index67 <= 1);
        this.pnlSMenuIn[index65].Height = checked (this.txtSMenuAnswer[index65, 1].Top + this.txtSMenuAnswer[index65, 1].Height + 20 + this.btnSMenuFormalBtn[index65, 0].Height);
        this.pnlSubMenu[index65].Height = checked (this.pnlSMenuIn[index65].Height + this.lblSMenuTitle[index65].Height + 1);
        int index68 = 0;
        do
        {
          this.btnSMenuFormalBtn[index65, index68].Top = checked (this.pnlSMenuIn[index65].Height - this.btnSMenuFormalBtn[index65, index68].Height);
          checked { ++index68; }
        }
        while (index68 <= 1);
        int index69 = 17;
        int index70 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index69, index70];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index70 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index69, index70];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index69, index70].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index69, index70].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index69, index70].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index70; }
        }
        while (index70 <= 0);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[17, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index71 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index69, index71];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = this.pnlSMenuIn[index69].Width;
          label.Top = checked (this.pnlSMenuIn[index69].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index71 % 2) * this.pnlSMenuIn[index69].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index71; }
        }
        while (index71 <= 0);
        this.pnlSMenuIn[index69].Height = checked (this.txtSMenuAnswer[index69, 0].Top + this.txtSMenuAnswer[index69, 0].Height + 20 + this.btnSMenuFormalBtn[index69, 0].Height);
        this.pnlSubMenu[index69].Height = checked (this.pnlSMenuIn[index69].Height + this.lblSMenuTitle[index69].Height + 1);
        int index72 = 0;
        do
        {
          this.btnSMenuFormalBtn[index69, index72].Top = checked (this.pnlSMenuIn[index69].Height - this.btnSMenuFormalBtn[index69, index72].Height);
          checked { ++index72; }
        }
        while (index72 <= 0);
        int index73 = 18;
        int index74 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index73, index74];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index74 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index73, index74];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index73, index74].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index73, index74].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index73, index74].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index74; }
        }
        while (index74 <= 2);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[18, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index75 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index73, index75];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index73].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index73].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index75 % 2) * this.pnlSMenuIn[index73].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index75; }
        }
        while (index75 <= 1);
        this.pnlSMenuIn[index73].Height = checked (this.txtSMenuAnswer[index73, 2].Top + this.txtSMenuAnswer[index73, 2].Height + 20 + this.btnSMenuFormalBtn[index73, 0].Height);
        this.pnlSubMenu[index73].Height = checked (this.pnlSMenuIn[index73].Height + this.lblSMenuTitle[index73].Height + 1);
        int index76 = 0;
        do
        {
          this.btnSMenuFormalBtn[index73, index76].Top = checked (this.pnlSMenuIn[index73].Height - this.btnSMenuFormalBtn[index73, index76].Height);
          checked { ++index76; }
        }
        while (index76 <= 1);
        int index77 = 19;
        int index78 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index77, index78];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index78 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index77, index78];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index77, index78].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index77, index78].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index77, index78].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index78; }
        }
        while (index78 <= 1);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[19, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index79 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index77, index79];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index77].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index77].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index79 % 2) * this.pnlSMenuIn[index77].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index79; }
        }
        while (index79 <= 1);
        this.pnlSMenuIn[index77].Height = checked (this.txtSMenuAnswer[index77, 1].Top + this.txtSMenuAnswer[index77, 1].Height + 20 + this.btnSMenuFormalBtn[index77, 0].Height);
        this.pnlSubMenu[index77].Height = checked (this.pnlSMenuIn[index77].Height + this.lblSMenuTitle[index77].Height + 1);
        int index80 = 0;
        do
        {
          this.btnSMenuFormalBtn[index77, index80].Top = checked (this.pnlSMenuIn[index77].Height - this.btnSMenuFormalBtn[index77, index80].Height);
          checked { ++index80; }
        }
        while (index80 <= 1);
        int index81 = 20;
        int index82 = 0;
        do
        {
          Label label = this.lblSMenuCaption[index81, index82];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = 100;
          label.Top = checked (20 + index82 * 22);
          label.Left = 10;
          label.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.ForeColor = Color.FromArgb(30, 30, 30);
          TextBox textBox = this.txtSMenuAnswer[index81, index82];
          textBox.Font = this.fnt9;
          textBox.BorderStyle = BorderStyle.None;
          textBox.Height = this.lblSMenuCaption[index81, index82].Height;
          textBox.Width = 125;
          textBox.Top = this.lblSMenuCaption[index81, index82].Top;
          textBox.Left = checked (10 + this.lblSMenuCaption[index81, index82].Width + 5);
          textBox.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          textBox.ForeColor = Color.FromArgb(171, 171, 171);
          checked { ++index82; }
        }
        while (index82 <= 2);
        if (this.AutoComplete)
        {
          TextBox textBox = this.txtSMenuAnswer[20, 0];
          textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
          textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
          textBox.AutoCompleteCustomSource = this.InitCompleteCollection();
        }
        int index83 = 0;
        do
        {
          Label label = this.btnSMenuFormalBtn[index81, index83];
          label.Font = this.fnt9;
          label.Height = 22;
          label.Width = checked ((int) Math.Round(unchecked ((double) this.pnlSMenuIn[index81].Width / 2.0)));
          label.Top = checked (this.pnlSMenuIn[index81].Height - label.Height);
          label.Left = checked ((int) Math.Round(unchecked ((double) checked (unchecked (index83 % 2) * this.pnlSMenuIn[index81].Width) / 2.0)));
          label.TextAlign = ContentAlignment.MiddleCenter;
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index83; }
        }
        while (index83 <= 1);
        this.pnlSMenuIn[index81].Height = checked (this.txtSMenuAnswer[index81, 2].Top + this.txtSMenuAnswer[index81, 2].Height + 20 + this.btnSMenuFormalBtn[index81, 0].Height);
        this.pnlSubMenu[index81].Height = checked (this.pnlSMenuIn[index81].Height + this.lblSMenuTitle[index81].Height + 1);
        int index84 = 0;
        do
        {
          this.btnSMenuFormalBtn[index81, index84].Top = checked (this.pnlSMenuIn[index81].Height - this.btnSMenuFormalBtn[index81, index84].Height);
          checked { ++index84; }
        }
        while (index84 <= 1);
        int index85 = 0;
        do
        {
          this.lblSMenuTitle[index85].Text = " " + this.strSMenuTitle[index85];
          checked { ++index85; }
        }
        while (index85 <= 20);
      }
      int index86 = 0;
      do
      {
        this.lblSMenuTitle[index86].Text = " " + this.strSMenuTitle[index86];
        if (!IsRefreshing | IsRefreshing & intRefreshing == index86)
        {
          if (this.intSMenuCaptionAmount[index86] >= 0)
          {
            int num = this.intSMenuCaptionAmount[index86];
            int index1 = 0;
            while (index1 <= num)
            {
              this.lblSMenuCaption[index86, index1].Text = this.strSMenuCaption[index86, index1];
              checked { ++index1; }
            }
          }
          if (this.intSMenuAnswerAmount[index86] >= 0)
          {
            int num = this.intSMenuAnswerAmount[index86];
            int index1 = 0;
            while (index1 <= num)
            {
              this.txtSMenuAnswer[index86, index1].Text = this.strSMenuAnswer[index86, index1];
              this.txtSMenuAnswer[index86, index1].ForeColor = Color.FromArgb(171, 171, 171);
              checked { ++index1; }
            }
          }
          if (this.intSMenuFormalBtnAmount[index86] >= 0)
          {
            int num = this.intSMenuFormalBtnAmount[index86];
            int index1 = 0;
            while (index1 <= num)
            {
              this.btnSMenuFormalBtn[index86, index1].Text = this.strSMenuFormalBtn[index86, index1];
              checked { ++index1; }
            }
          }
        }
        checked { ++index86; }
      }
      while (index86 <= 20);
    }

    public void Scene_Instr_Update(bool IsSizeChanging, bool IsColorChanging, bool IsTextChanging)
    {
      if (IsSizeChanging)
      {
        Panel pnlInstr = this.pnlInstr;
        pnlInstr.Height = 25;
        pnlInstr.Width = checked (this.Width - this.pnlMainMenu.Width);
        pnlInstr.Top = checked (this.Height - pnlInstr.Height);
        pnlInstr.Left = 0;
        Label label1 = this.lblInstr[0];
        label1.Height = 25;
        label1.Width = 150;
        label1.Top = 0;
        label1.Left = 0;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        Label label2 = this.lblInstr[1];
        label2.Height = 0;
        label2.Width = 0;
        Label label3 = this.lblInstr[2];
        label3.Height = 25;
        label3.Width = checked (this.pnlInstr.Width - this.lblInstr[0].Width);
        label3.Top = 0;
        label3.Left = this.lblInstr[0].Width;
        label3.TextAlign = ContentAlignment.MiddleRight;
      }
      if (IsColorChanging)
      {
        Panel pnlInstr = this.pnlInstr;
        pnlInstr.BackColor = this.ColorMainDeep;
        pnlInstr.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        int index = 0;
        do
        {
          Label label = this.lblInstr[index];
          label.BackColor = this.ColorMainDeep;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index; }
        }
        while (index <= 2);
      }
      if (!IsTextChanging)
        return;
      Label label4 = this.lblInstr[0];
      label4.Font = this.fnt9;
      label4.Text = "MUNCS Express 2";
      this.lblInstr[2].Font = this.fnt9;
    }

    public void Scene_Main_Info_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      Color color1 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color2 = Color.FromArgb(60, 60, 60);
      if (IsSizeChanging)
      {
        if (!this.IsWideScreen)
        {
          Panel pnlMainInfo = this.pnlMainInfo;
          pnlMainInfo.Height = 706;
          pnlMainInfo.Width = 1024;
          pnlMainInfo.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainInfo.Height) / 2.0)));
          pnlMainInfo.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainInfo.Width) / 2.0)));
          Panel panel1 = this.pnlMInfo[0];
          panel1.Height = 110;
          panel1.Width = 270;
          panel1.Top = 44;
          panel1.Left = 0;
          Panel panel2 = this.pnlMInfo[1];
          panel2.Height = 446;
          panel2.Width = 250;
          panel2.Top = 169;
          panel2.Left = 20;
          Panel panel3 = this.pnlMInfo[2];
          panel3.Height = 32;
          panel3.Width = 250;
          panel3.Top = 630;
          panel3.Left = 20;
          Panel panel4 = this.pnlMInfo[3];
          panel4.Height = 90;
          panel4.Width = 720;
          panel4.Top = 44;
          panel4.Left = 285;
          Panel panel5 = this.pnlMInfo[4];
          panel5.Height = 466;
          panel5.Width = 720;
          panel5.Top = 149;
          panel5.Left = 285;
          Panel panel6 = this.pnlMInfo[5];
          panel6.Height = 32;
          panel6.Width = 720;
          panel6.Top = 630;
          panel6.Left = 285;
        }
        else
        {
          Panel pnlMainInfo = this.pnlMainInfo;
          pnlMainInfo.Height = 706;
          pnlMainInfo.Width = 1340;
          pnlMainInfo.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainInfo.Height) / 2.0)));
          pnlMainInfo.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainInfo.Width) / 2.0)));
          Panel panel1 = this.pnlMInfo[0];
          panel1.Height = 110;
          panel1.Width = 270;
          panel1.Top = 44;
          panel1.Left = 0;
          Panel panel2 = this.pnlMInfo[1];
          panel2.Height = 446;
          panel2.Width = 250;
          panel2.Top = 169;
          panel2.Left = 20;
          Panel panel3 = this.pnlMInfo[2];
          panel3.Height = 32;
          panel3.Width = 250;
          panel3.Top = 630;
          panel3.Left = 20;
          Panel panel4 = this.pnlMInfo[3];
          panel4.Height = 90;
          panel4.Width = 1036;
          panel4.Top = 44;
          panel4.Left = 285;
          Panel panel5 = this.pnlMInfo[4];
          panel5.Height = 466;
          panel5.Width = 1036;
          panel5.Top = 149;
          panel5.Left = 285;
          Panel panel6 = this.pnlMInfo[5];
          panel6.Height = 32;
          panel6.Width = 1036;
          panel6.Top = 630;
          panel6.Left = 285;
        }
        int index1 = 0;
        do
        {
          Label label = this.lblMInfoTitle[index1];
          label.Visible = false;
          label.Height = 22;
          label.Width = this.pnlMInfo[index1].Width;
          label.Top = 0;
          label.Left = 0;
          label.BackColor = this.ColorMain;
          label.ForeColor = color1;
          label.Font = this.fnt9;
          label.TextAlign = ContentAlignment.MiddleLeft;
          this.lblMInfoTitle[0].Text = "   Counter";
          this.lblMInfoTitle[1].Text = "   Speakers List";
          this.lblMInfoTitle[2].Text = "   Majority";
          this.lblMInfoTitle[3].Text = "   Title";
          this.lblMInfoTitle[4].Text = "   Main Information";
          this.lblMInfoTitle[5].Text = "   InfoNet";
          checked { ++index1; }
        }
        while (index1 <= 5);
        int index2 = 0;
        do
        {
          Panel panel = this.pnlMInfoIn[index2];
          panel.Height = this.pnlMInfo[index2].Height;
          panel.Width = this.pnlMInfo[index2].Width;
          panel.Top = 0;
          panel.Left = 0;
          checked { ++index2; }
        }
        while (index2 <= 5);
        this.pnlMInfoIn[0].Width = checked (this.pnlMInfo[0].Width - 20);
        this.pnlMInfoIn[0].Left = 20;
        int index3 = 0;
        do
        {
          Label label = this.lblMInfoPatch[index3];
          label.Visible = false;
          label.BackColor = this.ColorMain;
          label.Height = this.pnlMInfo[checked (index3 * 3 + 2)].Height;
          label.Width = 1;
          label.Top = 0;
          label.Left = 0;
          label.SendToBack();
          checked { ++index3; }
        }
        while (index3 <= 1);
        Label label1 = this.lblMInfo[0, 0];
        label1.Height = this.pnlMInfoIn[0].Height;
        label1.Width = this.pnlMInfoIn[0].Width;
        label1.Top = 0;
        label1.Left = 0;
        label1.Visible = false;
        Label label2 = this.lblMInfo[0, 1];
        label2.Height = 80;
        label2.Width = this.pnlMInfoIn[0].Width;
        label2.Top = -8;
        label2.Left = 5;
        label2.TextAlign = ContentAlignment.TopCenter;
        Label label3 = this.lblMInfo[0, 2];
        label3.Height = 35;
        label3.Width = this.pnlMInfoIn[0].Width;
        label3.Top = 70;
        label3.Left = 3;
        label3.TextAlign = ContentAlignment.MiddleCenter;
        int index4 = 0;
        do
        {
          Label label4 = this.btnMInfo[0, index4];
          label4.Height = 28;
          label4.Width = 30;
          label4.Top = checked ((int) Math.Round(unchecked (0.0 + 27.5 * (double) index4)));
          label4.Left = 0;
          label4.TextAlign = ContentAlignment.MiddleCenter;
          label4.BringToFront();
          label4.Visible = false;
          checked { ++index4; }
        }
        while (index4 <= 3);
        int index5 = 0;
        do
        {
          TextBox textBox1 = this.txtMInfo[1, index5];
          textBox1.BorderStyle = BorderStyle.None;
          textBox1.Multiline = true;
          textBox1.Height = checked (this.pnlMInfoIn[1].Height - 20 - 22);
          textBox1.Width = checked (this.pnlMInfoIn[1].Width - 36);
          textBox1.Top = 10;
          textBox1.Left = 9;
          if (this.AutoComplete)
          {
            TextBox textBox2 = this.txtMInfo[1, index5];
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteCustomSource = this.InitCompleteCollection();
          }
          checked { ++index5; }
        }
        while (index5 <= 2);
        int index6 = 0;
        do
        {
          Label label4 = this.lblMInfo[1, index6];
          label4.Height = 22;
          label4.Width = checked ((int) Math.Round(unchecked (Conversion.Int((double) this.pnlMInfo[1].Width / 4.0) + 2.0)));
          label4.Top = checked (this.pnlMInfoIn[1].Height - label4.Height);
          label4.Left = checked ((int) Math.Round(unchecked ((double) checked (index6 + 1) * Conversion.Int((double) this.pnlMInfo[1].Width / 4.0))));
          label4.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index6; }
        }
        while (index6 <= 2);
        this.btnInitiateModerator.Height = 22;
        this.btnInitiateModerator.Width = checked ((int) Math.Round(Conversion.Int(unchecked ((double) this.pnlMInfo[1].Width / 4.0))));
        this.btnInitiateModerator.Top = this.lblMInfo[1, 0].Top;
        this.btnInitiateModerator.Left = 0;
        this.btnInitiateModerator.TextAlign = ContentAlignment.MiddleCenter;
        int index7 = 5;
        do
        {
          Label label4 = this.lblMInfo[1, index7];
          label4.Height = 29;
          label4.Width = 9;
          label4.Top = checked (14 + (label4.Height + 7) * (index7 - 5));
          label4.Left = checked (this.pnlMInfo[1].Width - 18);
          checked { ++index7; }
        }
        while (index7 <= 15);
        int index8 = 0;
        do
        {
          Label label4 = this.lblMInfo[2, index8];
          label4.Height = checked (this.pnlMInfoIn[2].Height + 3);
          label4.Width = checked ((int) Math.Round(unchecked ((double) this.pnlMInfoIn[2].Width / 4.0)));
          label4.Top = -3;
          label4.Left = checked (index8 * label4.Width);
          label4.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index8; }
        }
        while (index8 <= 3);
        Label label5 = this.lblMInfo[3, 0];
        label5.Height = 60;
        label5.Width = checked (this.pnlMInfoIn[3].Width - 20);
        label5.Top = 36;
        label5.Left = 6;
        label5.TextAlign = ContentAlignment.TopLeft;
        label5.SendToBack();
        Label label6 = this.lblMInfo[3, 1];
        label6.Height = 32;
        label6.Width = checked (this.lblMInfo[3, 0].Width - 4);
        label6.Top = 10;
        label6.Left = 10;
        label6.TextAlign = ContentAlignment.BottomLeft;
        this.lblMInfo[3, 2].Visible = false;
        TextBox textBox = this.txtMInfo[4, 0];
        textBox.BorderStyle = BorderStyle.None;
        textBox.Multiline = true;
        textBox.Height = checked (this.pnlMInfoIn[4].Height - 20);
        textBox.Width = checked (this.pnlMInfoIn[4].Width - 18);
        textBox.Top = 10;
        textBox.Left = 9;
        int index9 = 0;
        do
        {
          Label label4 = this.lblMInfo[5, index9];
          label4.Height = checked (this.pnlMInfoIn[5].Height + 3);
          label4.Width = checked ((int) Math.Round(unchecked ((double) this.pnlMInfoIn[5].Width / 2.0)));
          label4.Top = -3;
          label4.Left = checked (index9 * label4.Width);
          label4.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index9; }
        }
        while (index9 <= 1);
        this.lblMInfo[5, 0].Width = 150;
        this.lblMInfo[5, 1].TextAlign = ContentAlignment.MiddleLeft;
        this.lblMInfo[5, 1].Width = checked (this.pnlMInfoIn[5].Width - this.lblMInfo[5, 0].Width);
        this.lblMInfo[5, 1].Left = this.lblMInfo[5, 0].Width;
      }
      if (IsColorChanging)
      {
        this.pnlMainInfo.BackColor = Color.Transparent;
        this.pnlMInfo[0].BackColor = Color.Transparent;
        this.pnlMInfo[1].BackColor = this.ColorMain;
        this.pnlMInfo[2].BackColor = this.ColorMain;
        this.pnlMInfo[3].BackColor = this.ColorMain;
        this.pnlMInfo[4].BackColor = this.ColorMain;
        this.pnlMInfo[5].BackColor = this.ColorMain;
        int index1 = 0;
        do
        {
          this.pnlMInfoIn[index1].BackColor = color1;
          checked { ++index1; }
        }
        while (index1 <= 5);
        Label label1 = this.lblMInfo[0, 1];
        label1.BackColor = color1;
        label1.ForeColor = this.ColorMain;
        Label label2 = this.lblMInfo[0, 2];
        label2.BackColor = color1;
        label2.ForeColor = Color.FromArgb(171, 171, 171);
        int index2 = 0;
        do
        {
          Label label3 = this.btnMInfo[0, index2];
          label3.TextAlign = ContentAlignment.MiddleCenter;
          label3.BackColor = this.ColorMain;
          label3.ForeColor = color1;
          label3.BringToFront();
          checked { ++index2; }
        }
        while (index2 <= 3);
        int index3 = 0;
        do
        {
          TextBox textBox = this.txtMInfo[1, index3];
          textBox.BackColor = color1;
          textBox.ForeColor = color2;
          checked { ++index3; }
        }
        while (index3 <= 2);
        int index4 = 0;
        do
        {
          Label label3 = this.lblMInfo[1, index4];
          label3.BackColor = this.ColorMain;
          label3.ForeColor = color1;
          checked { ++index4; }
        }
        while (index4 <= 2);
        this.lblMInfo[1, 0].BackColor = color1;
        this.lblMInfo[1, 0].ForeColor = this.ColorMain;
        int index5 = 5;
        do
        {
          this.lblMInfo[1, index5].BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index5; }
        }
        while (index5 <= 15);
        int index6 = 0;
        do
        {
          Label label3 = this.lblMInfo[2, index6];
          label3.BackColor = color1;
          label3.ForeColor = this.ColorMain;
          checked { ++index6; }
        }
        while (index6 <= 3);
        this.lblMInfo[2, 0].BackColor = this.ColorMain;
        this.lblMInfo[2, 0].ForeColor = color1;
        Label label4 = this.lblMInfo[3, 0];
        label4.BackColor = color1;
        label4.ForeColor = this.ColorMain;
        label4.SendToBack();
        Label label5 = this.lblMInfo[3, 1];
        label5.BackColor = color1;
        label5.ForeColor = Color.FromArgb(171, 171, 171);
        TextBox textBox1 = this.txtMInfo[4, 0];
        textBox1.BackColor = color1;
        textBox1.ForeColor = color2;
        int index7 = 0;
        do
        {
          Label label3 = this.lblMInfo[5, index7];
          label3.BackColor = color1;
          label3.ForeColor = this.ColorMain;
          checked { ++index7; }
        }
        while (index7 <= 1);
        this.lblMInfo[5, 0].BackColor = this.ColorMain;
        this.lblMInfo[5, 0].ForeColor = color1;
      }
      if (!IsTextChanging)
        return;
      Label label7 = this.lblMInfo[0, 1];
      label7.Text = "00 : 00";
      label7.Font = this.fntCounter57;
      Label label8 = this.lblMInfo[0, 2];
      label8.Text = "00 : 00";
      label8.Font = this.fntCounter24;
      int index10 = 0;
      do
      {
        TextBox textBox = this.txtMInfo[1, index10];
        textBox.Text = "";
        textBox.Font = this.fntDisplay;
        checked { ++index10; }
      }
      while (index10 <= 2);
      int index11 = 0;
      do
      {
        this.lblMInfo[1, index11].Text = this.strMInfo[1, 0] + Conversions.ToString(checked (index11 + 1));
        checked { ++index11; }
      }
      while (index11 <= 2);
      int index12 = 0;
      do
      {
        Label label1 = this.btnMInfo[0, index12];
        label1.Text = Conversions.ToString(checked (30 * index12 + 1));
        label1.BringToFront();
        checked { ++index12; }
      }
      while (index12 <= 3);
      int index13 = 0;
      do
      {
        Label label1 = this.lblMInfo[2, index13];
        label1.Text = Conversions.ToString(index13);
        label1.Font = this.fnt18;
        checked { ++index13; }
      }
      while (index13 <= 3);
      this.lblMInfo[2, 0].Text = "-";
      this.lblMInfo[2, 1].Text = "-";
      this.lblMInfo[2, 2].Text = "-";
      this.lblMInfo[2, 3].Text = "-";
      Label label9 = this.lblMInfo[3, 0];
      label9.Text = this.datConf[2];
      label9.Font = this.fnt24;
      label9.SendToBack();
      Label label10 = this.lblMInfo[3, 1];
      label10.Text = this.datConf[0] + " / " + this.datConf[1];
      label10.Font = this.fnt18;
      TextBox textBox3 = this.txtMInfo[4, 0];
      if (Operators.CompareString(textBox3.Text, "", false) == 0)
        textBox3.Text = "MUNCS Express 2 : Build 0130";
      textBox3.Font = this.fntDisplay;
      int index14 = 0;
      do
      {
        Label label1 = this.lblMInfo[5, index14];
        label1.Text = Conversions.ToString(index14);
        label1.Font = this.fnt18;
        checked { ++index14; }
      }
      while (index14 <= 1);
      this.lblMInfo[5, 1].Text = this.strMInfo[5, 0];
    }

    public void Scene_Main_Vote_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      Color color1 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color2 = Color.FromArgb(60, 60, 60);
      Color color3 = Color.FromArgb(67, 148, 103);
      Color color4 = Color.FromArgb(240, 98, 62);
      Color color5 = Color.FromArgb(247, 209, 48);
      Color color6 = Color.FromArgb(62, 109, 181);
      Color color7 = Color.FromArgb(200, 200, 200);
      if (IsSizeChanging)
      {
        Panel pnlMainVote = this.pnlMainVote;
        pnlMainVote.Visible = true;
        pnlMainVote.Height = 706;
        pnlMainVote.Width = 1024;
        pnlMainVote.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainVote.Height) / 2.0)));
        pnlMainVote.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainVote.Width) / 2.0)));
        Panel panel1 = this.pnlMVote[0];
        panel1.Height = 90;
        panel1.Width = 720;
        panel1.Top = 44;
        panel1.Left = 20;
        Panel panel2 = this.pnlMVote[1];
        panel2.Height = 436;
        panel2.Width = 720;
        panel2.Top = 149;
        panel2.Left = 20;
        Panel panel3 = this.pnlMVote[2];
        panel3.Height = 62;
        panel3.Width = 720;
        panel3.Top = 600;
        panel3.Left = 20;
        Panel panel4 = this.pnlMVote[3];
        panel4.Height = 156;
        panel4.Width = 250;
        panel4.Top = 44;
        panel4.Left = 755;
        Panel panel5 = this.pnlMVote[4];
        panel5.Height = 196;
        panel5.Width = 250;
        panel5.Top = 215;
        panel5.Left = 755;
        Panel panel6 = this.pnlMVote[5];
        panel6.Height = 196;
        panel6.Width = 250;
        panel6.Top = 466;
        panel6.Left = 755;
        int index1 = 0;
        do
        {
          Panel panel7 = this.pnlMVoteIn[index1];
          panel7.Height = this.pnlMVote[index1].Height;
          panel7.Width = this.pnlMVote[index1].Width;
          panel7.Top = 0;
          panel7.Left = 0;
          checked { ++index1; }
        }
        while (index1 <= 5);
        Label label1 = this.lblMVote[0, 0];
        label1.Height = 60;
        label1.Width = checked (this.pnlMInfoIn[3].Width - 20);
        label1.Top = 34;
        label1.Left = 6;
        label1.TextAlign = ContentAlignment.TopLeft;
        label1.SendToBack();
        Label label2 = this.lblMVote[0, 1];
        label2.Height = 32;
        label2.Width = checked (this.lblMInfo[3, 0].Width - 4);
        label2.Top = 10;
        label2.Left = 10;
        label2.TextAlign = ContentAlignment.BottomLeft;
        int index2 = 0;
        do
        {
          Label label3 = this.lblMVote[1, index2];
          label3.Height = 32;
          label3.Width = 270;
          label3.Top = checked (19 + unchecked (index2 % 10) * 40);
          label3.Left = checked ((int) Math.Round(unchecked (34.0 + Conversion.Int((double) index2 / 10.0) * 340.0)));
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMVoteLight[0, index2];
          label4.Height = 23;
          label4.Width = 20;
          label4.Top = checked (25 + unchecked (index2 % 10) * 40);
          label4.Left = checked ((int) Math.Round(unchecked (316.0 + Conversion.Int((double) index2 / 10.0) * 340.0)));
          label4.TextAlign = ContentAlignment.MiddleCenter;
          label4.Font = this.fnt12;
          label4.BringToFront();
          checked { ++index2; }
        }
        while (index2 <= 19);
        Label label5 = this.lblMVote[2, 0];
        label5.Height = 60;
        label5.Width = 720;
        label5.Top = 5;
        label5.Left = 0;
        label5.TextAlign = ContentAlignment.TopCenter;
        label5.SendToBack();
        int index3 = 0;
        do
        {
          Label label3 = this.lblMVote[3, index3];
          label3.Height = 32;
          label3.Width = 170;
          label3.Top = checked (19 + index3 * 40);
          label3.Left = 10;
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMVote[3, checked (4 + index3)];
          label4.Height = 32;
          label4.Width = 60;
          label4.Top = checked (19 + index3 * 40);
          label4.Left = 180;
          label4.TextAlign = ContentAlignment.MiddleRight;
          Label label6 = this.lblMVoteLight[1, index3];
          label6.Visible = false;
          label6.Height = 23;
          label6.Width = 23;
          label6.Top = checked (25 + index3 * 40);
          label6.Left = 10;
          label6.TextAlign = ContentAlignment.MiddleCenter;
          label6.Font = this.fnt12;
          checked { ++index3; }
        }
        while (index3 <= 0);
        int index4 = 1;
        do
        {
          Label label3 = this.lblMVote[3, index4];
          label3.Height = 32;
          label3.Width = 170;
          label3.Top = checked (19 + (index4 - 1) * 40);
          label3.Left = 10;
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMVote[3, checked (4 + index4)];
          label4.Height = 32;
          label4.Width = 60;
          label4.Top = checked (19 + (index4 - 1) * 40);
          label4.Left = 180;
          label4.TextAlign = ContentAlignment.MiddleRight;
          Label label6 = this.lblMVoteLight[1, index4];
          label6.Visible = false;
          label6.Height = 23;
          label6.Width = 23;
          label6.Top = checked (25 + (index4 - 1) * 40);
          label6.Left = 10;
          label6.TextAlign = ContentAlignment.MiddleCenter;
          label6.Font = this.fnt12;
          checked { ++index4; }
        }
        while (index4 <= 3);
        this.lblMVote[3, 1].Visible = false;
        this.lblMVote[3, 5].Visible = false;
        int index5 = 0;
        do
        {
          Label label3 = this.lblMVote[4, index5];
          label3.Height = 32;
          label3.Width = 125;
          label3.Top = checked (19 + index5 * 40);
          label3.Left = 46;
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMVote[4, checked (4 + index5)];
          label4.Height = 32;
          label4.Width = 60;
          label4.Top = checked (19 + index5 * 40);
          label4.Left = 180;
          label4.TextAlign = ContentAlignment.MiddleRight;
          Label label6 = this.lblMVoteLight[2, index5];
          label6.Height = 23;
          label6.Width = 20;
          label6.Top = checked (25 + index5 * 40);
          label6.Left = 10;
          label6.TextAlign = ContentAlignment.MiddleCenter;
          label6.Font = this.fnt12;
          checked { ++index5; }
        }
        while (index5 <= 3);
        int index6 = 0;
        do
        {
          Label label3 = this.lblMVote[5, index6];
          label3.Height = 60;
          label3.Width = 60;
          label3.Top = checked ((int) Math.Round(unchecked (22.0 + Conversion.Int((double) index6 / 2.0) * 70.0)));
          label3.Left = checked (60 + unchecked (index6 % 2) * 70);
          label3.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index6; }
        }
        while (index6 <= 3);
        int index7 = 4;
        do
        {
          Label label3 = this.lblMVote[5, index7];
          label3.Height = 22;
          label3.Width = 125;
          label3.Top = checked (this.pnlMVote[5].Height - label3.Height);
          label3.Left = checked (unchecked (index7 % 2) * 125);
          label3.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index7; }
        }
        while (index7 <= 5);
        Label label7 = this.lblMVote[5, 6];
        label7.Height = 22;
        label7.Width = 250;
        label7.Top = checked (this.pnlMVote[5].Height - label7.Height);
        label7.Left = 0;
        label7.TextAlign = ContentAlignment.MiddleCenter;
      }
      if (IsColorChanging)
      {
        Panel pnlMainVote = this.pnlMainVote;
        pnlMainVote.Height = checked (this.Height - this.pnlMainMenu.Height);
        pnlMainVote.Width = 1024;
        pnlMainVote.Top = 0;
        pnlMainVote.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainVote.Width) / 2.0)));
        pnlMainVote.BackColor = Color.Transparent;
        pnlMainVote.BringToFront();
        this.pnlMVote[0].BackColor = this.ColorMain;
        this.pnlMVote[1].BackColor = this.ColorMain;
        this.pnlMVote[2].BackColor = this.ColorMain;
        this.pnlMVote[3].BackColor = this.ColorMain;
        this.pnlMVote[4].BackColor = this.ColorMain;
        this.pnlMVote[5].BackColor = this.ColorMain;
        int index1 = 0;
        do
        {
          this.pnlMVote[index1].BackColor = color1;
          this.pnlMVoteIn[index1].BackColor = color1;
          checked { ++index1; }
        }
        while (index1 <= 5);
        Label label1 = this.lblMVote[0, 0];
        label1.BackColor = color1;
        label1.ForeColor = this.ColorMain;
        label1.SendToBack();
        Label label2 = this.lblMVote[0, 1];
        label2.BackColor = color1;
        label2.ForeColor = Color.FromArgb(171, 171, 171);
        int index2 = 0;
        do
        {
          Label label3 = this.lblMVote[1, index2];
          label3.BackColor = color1;
          label3.ForeColor = color7;
          Label label4 = this.lblMVoteLight[0, index2];
          label4.BackColor = color7;
          label4.BringToFront();
          if (this.Accessibility_Support)
            label4.Text = "";
          checked { ++index2; }
        }
        while (index2 <= 19);
        Label label5 = this.lblMVote[2, 0];
        label5.BackColor = color1;
        label5.ForeColor = this.ColorMain;
        label5.SendToBack();
        int index3 = 0;
        do
        {
          Label label3 = this.lblMVote[3, index3];
          label3.BackColor = color1;
          label3.ForeColor = color2;
          Label label4 = this.lblMVote[3, checked (4 + index3)];
          label4.BackColor = color1;
          label4.ForeColor = this.ColorMain;
          this.lblMVote[3, 0].ForeColor = this.ColorMain;
          this.lblMVoteLight[1, index3].BackColor = this.ColorMain;
          checked { ++index3; }
        }
        while (index3 <= 0);
        int index4 = 1;
        do
        {
          Label label3 = this.lblMVote[3, index4];
          label3.BackColor = color1;
          label3.ForeColor = color2;
          Label label4 = this.lblMVote[3, checked (4 + index4)];
          label4.BackColor = color1;
          label4.ForeColor = this.ColorMain;
          this.lblMVote[3, 0].ForeColor = this.ColorMain;
          this.lblMVoteLight[1, index4].BackColor = this.ColorMain;
          checked { ++index4; }
        }
        while (index4 <= 3);
        int index5 = 0;
        do
        {
          Label label3 = this.lblMVote[4, index5];
          label3.BackColor = color1;
          label3.ForeColor = color2;
          Label label4 = this.lblMVote[4, checked (4 + index5)];
          label4.BackColor = color1;
          label4.ForeColor = this.ColorMain;
          this.lblMVoteLight[2, 0].BackColor = color3;
          this.lblMVoteLight[2, 1].BackColor = color4;
          this.lblMVoteLight[2, 2].BackColor = color5;
          this.lblMVoteLight[2, 3].BackColor = color6;
          if (this.Accessibility_Support)
          {
            this.lblMVoteLight[2, 0].Text = "+";
            this.lblMVoteLight[2, 1].Text = "-";
            this.lblMVoteLight[2, 2].Text = "×";
            this.lblMVoteLight[2, 3].Text = "/";
          }
          checked { ++index5; }
        }
        while (index5 <= 3);
        int index6 = 0;
        do
        {
          Label label3 = this.lblMVote[5, index6];
          label3.BackColor = this.ColorMain;
          label3.ForeColor = color1;
          checked { ++index6; }
        }
        while (index6 <= 3);
        this.lblMVote[5, 0].BackColor = color3;
        this.lblMVote[5, 1].BackColor = color4;
        this.lblMVote[5, 2].BackColor = color5;
        this.lblMVote[5, 3].BackColor = color6;
        int index7 = 4;
        do
        {
          Label label3 = this.lblMVote[5, index7];
          label3.BackColor = this.ColorMainDeep;
          label3.ForeColor = color1;
          checked { ++index7; }
        }
        while (index7 <= 5);
        Label label6 = this.lblMVote[5, 6];
        label6.BackColor = this.ColorMainDeep;
        label6.ForeColor = color1;
      }
      if (!IsTextChanging)
        return;
      this.pnlMainVote.BringToFront();
      Label label8 = this.lblMVote[0, 0];
      label8.Font = this.fnt26;
      label8.SendToBack();
      this.lblMVote[0, 1].Font = this.fnt18;
      int index8 = 0;
      do
      {
        this.lblMVote[1, index8].Font = this.fnt18;
        checked { ++index8; }
      }
      while (index8 <= 19);
      Label label9 = this.lblMVote[2, 0];
      label9.Font = this.fnt26;
      label9.SendToBack();
      int index9 = 0;
      do
      {
        this.lblMVote[3, index9].Font = this.fnt18;
        this.lblMVote[3, checked (4 + index9)].Font = this.fnt18;
        this.lblMVote[3, 0].Font = this.fnt18B;
        this.lblMVote[3, 4].Font = this.fnt18B;
        checked { ++index9; }
      }
      while (index9 <= 0);
      int index10 = 1;
      do
      {
        this.lblMVote[3, index10].Font = this.fnt18;
        this.lblMVote[3, checked (4 + index10)].Font = this.fnt18;
        this.lblMVote[3, 0].Font = this.fnt18B;
        this.lblMVote[3, 0].ForeColor = this.ColorMain;
        this.lblMVote[3, 4].Font = this.fnt18B;
        checked { ++index10; }
      }
      while (index10 <= 3);
      int index11 = 0;
      do
      {
        this.lblMVote[4, index11].Font = this.fnt18;
        this.lblMVote[4, checked (4 + index11)].Font = this.fnt18;
        checked { ++index11; }
      }
      while (index11 <= 3);
      int index12 = 0;
      do
      {
        this.lblMVote[5, index12].Font = this.fnt9;
        checked { ++index12; }
      }
      while (index12 <= 3);
      int index13 = 4;
      do
      {
        this.lblMVote[5, index13].Font = this.fnt9;
        checked { ++index13; }
      }
      while (index13 <= 5);
      this.lblMVote[5, 6].Font = this.fnt9;
      this.lblMVote[0, 0].Text = this.strMVote[0, 0];
      this.lblMVote[0, 1].Text = this.strMVote[0, 1];
      int index14 = 0;
      do
      {
        this.lblMVote[3, index14].Text = this.strMVote[3, index14];
        checked { ++index14; }
      }
      while (index14 <= 7);
      int index15 = 0;
      do
      {
        this.lblMVote[4, index15].Text = this.strMVote[4, index15];
        checked { ++index15; }
      }
      while (index15 <= 7);
      int index16 = 0;
      do
      {
        this.lblMVote[5, index16].Text = this.strMVote[5, index16];
        checked { ++index16; }
      }
      while (index16 <= 6);
    }

    public void Scene_Main_RollCall_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      Color color1 = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color2 = Color.FromArgb(60, 60, 60);
      Color color3 = Color.FromArgb(67, 148, 103);
      Color color4 = Color.FromArgb(240, 98, 62);
      Color color5 = Color.FromArgb(200, 200, 200);
      if (IsSizeChanging)
      {
        Panel pnlMainRoll = this.pnlMainRoll;
        pnlMainRoll.Visible = true;
        pnlMainRoll.Height = 706;
        pnlMainRoll.Width = 1024;
        pnlMainRoll.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainRoll.Height) / 2.0)));
        pnlMainRoll.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainRoll.Width) / 2.0)));
        pnlMainRoll.BringToFront();
        Panel panel1 = this.pnlMRoll[0];
        panel1.Height = 90;
        panel1.Width = 720;
        panel1.Top = 44;
        panel1.Left = 20;
        Panel panel2 = this.pnlMRoll[1];
        panel2.Height = 436;
        panel2.Width = 720;
        panel2.Top = 149;
        panel2.Left = 20;
        Panel panel3 = this.pnlMRoll[2];
        panel3.Height = 62;
        panel3.Width = 720;
        panel3.Top = 600;
        panel3.Left = 20;
        Panel panel4 = this.pnlMRoll[3];
        panel4.Height = 156;
        panel4.Width = 250;
        panel4.Top = 44;
        panel4.Left = 755;
        Panel panel5 = this.pnlMRoll[4];
        panel5.Height = 116;
        panel5.Width = 250;
        panel5.Top = 215;
        panel5.Left = 755;
        Panel panel6 = this.pnlMRoll[5];
        panel6.Height = 126;
        panel6.Width = 250;
        panel6.Top = 536;
        panel6.Left = 755;
        int index1 = 0;
        do
        {
          Panel panel7 = this.pnlMRollIn[index1];
          panel7.Height = this.pnlMRoll[index1].Height;
          panel7.Width = this.pnlMRoll[index1].Width;
          panel7.Top = 0;
          panel7.Left = 0;
          checked { ++index1; }
        }
        while (index1 <= 5);
        Label label1 = this.lblMRoll[0, 0];
        label1.Height = 60;
        label1.Width = checked (this.pnlMInfoIn[3].Width - 20);
        label1.Top = 34;
        label1.Left = 6;
        label1.TextAlign = ContentAlignment.TopLeft;
        label1.SendToBack();
        Label label2 = this.lblMRoll[0, 1];
        label2.Height = 32;
        label2.Width = checked (this.lblMInfo[3, 0].Width - 4);
        label2.Top = 10;
        label2.Left = 10;
        label2.TextAlign = ContentAlignment.BottomLeft;
        int index2 = 0;
        do
        {
          Label label3 = this.lblMRoll[1, index2];
          label3.Height = 32;
          label3.Width = 270;
          label3.Top = checked (19 + unchecked (index2 % 10) * 40);
          label3.Left = checked ((int) Math.Round(unchecked (34.0 + Conversion.Int((double) index2 / 10.0) * 340.0)));
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMRollLight[0, index2];
          label4.Height = 23;
          label4.Width = 20;
          label4.Top = checked (25 + unchecked (index2 % 10) * 40);
          label4.Left = checked ((int) Math.Round(unchecked (316.0 + Conversion.Int((double) index2 / 10.0) * 340.0)));
          label4.TextAlign = ContentAlignment.MiddleCenter;
          label4.Font = this.fnt12;
          label4.BringToFront();
          checked { ++index2; }
        }
        while (index2 <= 19);
        Label label5 = this.lblMRoll[2, 0];
        label5.Height = 60;
        label5.Width = 720;
        label5.Top = 5;
        label5.Left = 0;
        label5.TextAlign = ContentAlignment.TopCenter;
        label5.SendToBack();
        int index3 = 0;
        do
        {
          Label label3 = this.lblMRoll[3, index3];
          label3.Height = 32;
          label3.Width = 170;
          label3.Top = checked (19 + index3 * 40);
          label3.Left = 10;
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMRoll[3, checked (4 + index3)];
          label4.Height = 32;
          label4.Width = 60;
          label4.Top = checked (19 + index3 * 40);
          label4.Left = 180;
          label4.TextAlign = ContentAlignment.MiddleRight;
          Label label6 = this.lblMRollLight[1, index3];
          label6.Visible = false;
          label6.Height = 23;
          label6.Width = 23;
          label6.Top = checked (25 + index3 * 40);
          label6.Left = 10;
          label6.TextAlign = ContentAlignment.TopCenter;
          label6.Font = this.fnt12;
          checked { ++index3; }
        }
        while (index3 <= 2);
        int index4 = 0;
        do
        {
          Label label3 = this.lblMRoll[4, index4];
          label3.Height = 32;
          label3.Width = 125;
          label3.Top = checked (19 + index4 * 40);
          label3.Left = 46;
          label3.TextAlign = ContentAlignment.MiddleLeft;
          Label label4 = this.lblMRoll[4, checked (4 + index4)];
          label4.Height = 32;
          label4.Width = 60;
          label4.Top = checked (19 + index4 * 40);
          label4.Left = 180;
          label4.TextAlign = ContentAlignment.MiddleRight;
          Label label6 = this.lblMRollLight[2, index4];
          label6.Height = 23;
          label6.Width = 20;
          label6.Top = checked (25 + index4 * 40);
          label6.Left = 10;
          label6.TextAlign = ContentAlignment.MiddleCenter;
          label6.Font = this.fnt12;
          checked { ++index4; }
        }
        while (index4 <= 1);
        this.lblMRoll[4, 0].Width = 100;
        this.lblMRoll[4, 4].Width = 85;
        this.lblMRoll[4, 4].Left = 155;
        int index5 = 0;
        do
        {
          Label label3 = this.lblMRoll[5, index5];
          label3.Height = 60;
          label3.Width = 60;
          label3.Top = checked ((int) Math.Round(unchecked (22.0 + Conversion.Int((double) index5 / 2.0) * 70.0)));
          label3.Left = checked (60 + unchecked (index5 % 2) * 70);
          label3.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index5; }
        }
        while (index5 <= 1);
        int index6 = 4;
        do
        {
          Label label3 = this.lblMRoll[5, index6];
          label3.Height = 22;
          label3.Width = 125;
          label3.Top = checked (this.pnlMRoll[5].Height - label3.Height);
          label3.Left = checked (unchecked (index6 % 2) * 125);
          label3.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index6; }
        }
        while (index6 <= 5);
        Label label7 = this.lblMRoll[5, 6];
        label7.Height = 22;
        label7.Width = 250;
        label7.Top = checked (this.pnlMRoll[5].Height - label7.Height);
        label7.Left = 0;
        label7.TextAlign = ContentAlignment.MiddleCenter;
      }
      if (IsColorChanging)
      {
        Panel pnlMainRoll = this.pnlMainRoll;
        pnlMainRoll.BackColor = Color.Transparent;
        pnlMainRoll.BringToFront();
        this.pnlMRoll[0].BackColor = this.ColorMain;
        this.pnlMRoll[1].BackColor = this.ColorMain;
        this.pnlMRoll[2].BackColor = this.ColorMain;
        this.pnlMRoll[3].BackColor = this.ColorMain;
        this.pnlMRoll[4].BackColor = this.ColorMain;
        this.pnlMRoll[5].BackColor = this.ColorMain;
        int index1 = 0;
        do
        {
          this.pnlMRoll[index1].BackColor = color1;
          this.pnlMRollIn[index1].BackColor = color1;
          checked { ++index1; }
        }
        while (index1 <= 5);
        Label label1 = this.lblMRoll[0, 0];
        label1.BackColor = color1;
        label1.ForeColor = this.ColorMain;
        label1.SendToBack();
        Label label2 = this.lblMRoll[0, 1];
        label2.BackColor = color1;
        label2.ForeColor = Color.FromArgb(171, 171, 171);
        int index2 = 0;
        do
        {
          Label label3 = this.lblMRoll[1, index2];
          label3.BackColor = color1;
          label3.ForeColor = color5;
          Label label4 = this.lblMRollLight[0, index2];
          label4.BackColor = color5;
          label4.BringToFront();
          if (this.Accessibility_Support)
            label4.Text = "";
          checked { ++index2; }
        }
        while (index2 <= 19);
        Label label5 = this.lblMRoll[2, 0];
        label5.BackColor = color1;
        label5.ForeColor = this.ColorMain;
        label5.SendToBack();
        int index3 = 0;
        do
        {
          Label label3 = this.lblMRoll[3, index3];
          label3.BackColor = color1;
          label3.ForeColor = color2;
          Label label4 = this.lblMRoll[3, checked (4 + index3)];
          label4.BackColor = color1;
          label4.ForeColor = this.ColorMain;
          this.lblMRollLight[1, index3].BackColor = this.ColorMain;
          checked { ++index3; }
        }
        while (index3 <= 2);
        int index4 = 0;
        do
        {
          Label label3 = this.lblMRoll[4, index4];
          label3.BackColor = color1;
          label3.ForeColor = color2;
          Label label4 = this.lblMRoll[4, checked (4 + index4)];
          label4.BackColor = color1;
          label4.ForeColor = this.ColorMain;
          this.lblMRollLight[2, 0].BackColor = color3;
          this.lblMRollLight[2, 1].BackColor = color4;
          if (this.Accessibility_Support)
          {
            this.lblMRollLight[2, 0].Text = "+";
            this.lblMRollLight[2, 1].Text = "-";
          }
          checked { ++index4; }
        }
        while (index4 <= 1);
        int index5 = 0;
        do
        {
          Label label3 = this.lblMRoll[5, index5];
          label3.BackColor = this.ColorMain;
          label3.ForeColor = color1;
          checked { ++index5; }
        }
        while (index5 <= 1);
        this.lblMRoll[5, 0].BackColor = color3;
        this.lblMRoll[5, 1].BackColor = color4;
        int index6 = 4;
        do
        {
          Label label3 = this.lblMRoll[5, index6];
          label3.BackColor = this.ColorMainDeep;
          label3.ForeColor = color1;
          checked { ++index6; }
        }
        while (index6 <= 5);
        Label label6 = this.lblMRoll[5, 6];
        label6.BackColor = this.ColorMainDeep;
        label6.ForeColor = color1;
      }
      if (!IsTextChanging)
        return;
      Label label8 = this.lblMRoll[0, 0];
      label8.Font = this.fnt26;
      label8.SendToBack();
      this.lblMRoll[0, 1].Font = this.fnt18;
      int index7 = 0;
      do
      {
        this.lblMRoll[1, index7].Font = this.fnt18;
        checked { ++index7; }
      }
      while (index7 <= 19);
      Label label9 = this.lblMRoll[2, 0];
      label9.Font = this.fnt26;
      label9.SendToBack();
      int index8 = 0;
      do
      {
        this.lblMRoll[3, index8].Font = this.fnt18;
        this.lblMRoll[3, checked (4 + index8)].Font = this.fnt18;
        checked { ++index8; }
      }
      while (index8 <= 2);
      int index9 = 0;
      do
      {
        this.lblMRoll[4, index9].Font = this.fnt18;
        this.lblMRoll[4, checked (4 + index9)].Font = this.fnt18;
        checked { ++index9; }
      }
      while (index9 <= 1);
      int index10 = 0;
      do
      {
        this.lblMRoll[5, index10].Font = this.fnt9;
        checked { ++index10; }
      }
      while (index10 <= 1);
      int index11 = 4;
      do
      {
        this.lblMRoll[5, index11].Font = this.fnt9;
        checked { ++index11; }
      }
      while (index11 <= 5);
      this.lblMRoll[5, 6].Font = this.fnt9;
      this.lblMRoll[0, 0].Text = this.strMRoll[0, 0];
      this.lblMRoll[0, 1].Text = this.strMRoll[0, 1];
      int index12 = 0;
      do
      {
        this.lblMRoll[3, index12].Text = this.strMRoll[3, index12];
        this.lblMRoll[3, checked (index12 + 4)].Text = this.strMRoll[3, checked (index12 + 4)];
        checked { ++index12; }
      }
      while (index12 <= 2);
      int index13 = 0;
      do
      {
        this.lblMRoll[4, index13].Text = this.strMRoll[4, index13];
        this.lblMRoll[4, checked (index13 + 4)].Text = this.strMRoll[4, checked (index13 + 4)];
        checked { ++index13; }
      }
      while (index13 <= 2);
      int index14 = 0;
      do
      {
        this.lblMRoll[5, index14].Text = this.strMRoll[5, index14];
        checked { ++index14; }
      }
      while (index14 <= 1);
      int index15 = 4;
      do
      {
        this.lblMRoll[5, index15].Text = this.strMRoll[5, index15];
        checked { ++index15; }
      }
      while (index15 <= 6);
    }

    public void Scene_Main_LanguageSelect_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      this.Event_MainMenu_Visibility_Update(false);
      if (IsSizeChanging)
      {
        Panel pnlMainLanguage = this.pnlMainLanguage;
        pnlMainLanguage.Visible = true;
        pnlMainLanguage.Height = 706;
        pnlMainLanguage.Width = 1024;
        pnlMainLanguage.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainLanguage.Height) / 2.0)));
        pnlMainLanguage.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainLanguage.Width) / 2.0)));
        pnlMainLanguage.BringToFront();
        Panel panel1 = this.pnlMLan[0];
        panel1.Height = 200;
        panel1.Width = 370;
        panel1.Top = 310;
        panel1.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMainLanguage.Width - panel1.Width) / 2.0)));
        Label lblMlanTitle = this.lblMLanTitle;
        lblMlanTitle.Height = 40;
        lblMlanTitle.Top = 5;
        lblMlanTitle.Left = 18;
        lblMlanTitle.TextAlign = ContentAlignment.MiddleLeft;
        int index = 0;
        do
        {
          Label label = this.lblMLan[index];
          label.Height = 35;
          label.Width = 100;
          label.Top = checked ((int) Math.Round(unchecked (55.0 + 45.0 * Conversion.Int((double) index / 3.0))));
          label.Left = checked (25 + 110 * unchecked (index % 3));
          label.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index; }
        }
        while (index <= 8);
        Panel panel2 = this.pnlMLan[1];
        panel2.Height = 200;
        panel2.Width = 200;
        panel2.Top = 160;
        panel2.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMainLanguage.Width - panel2.Width) / 2.0)));
        Label lblMlanLogo = this.lblMLanLogo;
        lblMlanLogo.Height = 80;
        lblMlanLogo.Width = 200;
        lblMlanLogo.Top = 60;
        lblMlanLogo.Left = 0;
      }
      if (IsColorChanging)
      {
        Panel pnlMainLanguage = this.pnlMainLanguage;
        pnlMainLanguage.BackColor = Color.Transparent;
        pnlMainLanguage.BringToFront();
        this.pnlMLan[0].BackColor = Color.Transparent;
        Label lblMlanTitle = this.lblMLanTitle;
        lblMlanTitle.BackColor = Color.Transparent;
        lblMlanTitle.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        int index = 0;
        do
        {
          Label label = this.lblMLan[index];
          label.BackColor = Color.Transparent;
          label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          label.BackgroundImage = this.imgBackTrans[0];
          label.BackgroundImageLayout = ImageLayout.Stretch;
          checked { ++index; }
        }
        while (index <= 8);
        this.pnlMLan[1].BackColor = Color.Transparent;
        Label lblMlanLogo = this.lblMLanLogo;
        lblMlanLogo.BackgroundImage = this.imgLogo[1];
        lblMlanLogo.BackgroundImageLayout = ImageLayout.Zoom;
      }
      if (!IsTextChanging)
        return;
      Label lblMlanTitle1 = this.lblMLanTitle;
      lblMlanTitle1.Text = "";
      lblMlanTitle1.Font = this.fnt21;
      int index1 = 0;
      do
      {
        this.lblMLan[index1].Font = this.fnt9;
        checked { ++index1; }
      }
      while (index1 <= 5);
      this.lblMLan[0].Text = "简体中文";
      this.lblMLan[1].Text = "繁體中文";
      this.lblMLan[2].Text = "English";
      this.lblMLan[3].Text = "日本語";
      this.lblMLan[4].Text = "Français";
      this.lblMLan[5].Text = "Русский";
      this.lblMLan[6].Text = "Español";
      this.lblMLan[7].Text = "Deutsch";
      this.lblMLan[8].Text = "Esperanto";
    }

    public void Scene_Main_BackgroundSelect_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      if (IsSizeChanging)
      {
        Panel pnlMainBackground = this.pnlMainBackground;
        pnlMainBackground.Visible = true;
        pnlMainBackground.Height = 706;
        pnlMainBackground.Width = 1024;
        pnlMainBackground.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainBackground.Height) / 2.0)));
        pnlMainBackground.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainBackground.Width) / 2.0)));
        Panel panel1 = this.pnlMBac[0];
        panel1.Height = 50;
        panel1.Width = 800;
        panel1.Top = 30;
        panel1.Left = 90;
        Panel panel2 = this.pnlMBac[1];
        panel2.Height = 600;
        panel2.Width = 800;
        panel2.Top = 125;
        panel2.Left = 112;
        Label label1 = this.lblMBac[0, 0];
        label1.Height = 50;
        label1.Width = 800;
        label1.Top = 0;
        label1.Left = 0;
        label1.TextAlign = ContentAlignment.MiddleLeft;
        int num = checked (this.SkinAmount - 1);
        int index = 0;
        while (index <= num)
        {
          Label label2 = this.lblMBac[1, index];
          label2.Height = 60;
          label2.Width = 100;
          label2.Top = checked ((int) Math.Round(unchecked (Conversion.Int((double) index / 6.0) * (double) checked (label2.Height + 10) + 20.0)));
          label2.Left = checked (unchecked (index % 6) * 110 + 90);
          label2.TextAlign = ContentAlignment.BottomRight;
          checked { ++index; }
        }
      }
      if (IsColorChanging)
      {
        this.pnlMainBackground.BackColor = Color.Transparent;
        this.pnlMBac[0].BackColor = Color.Transparent;
        Label label1 = this.lblMBac[0, 0];
        label1.BackColor = Color.Transparent;
        label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        int num = checked (this.SkinAmount - 1);
        int index = 0;
        while (index <= num)
        {
          Label label2 = this.lblMBac[1, index];
          label2.BackgroundImage = this.imgMBackSel[index];
          label2.BackgroundImageLayout = ImageLayout.Stretch;
          label2.BackColor = Color.Transparent;
          label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index; }
        }
        Label label3 = this.lblMBac[1, 6];
        Label label4 = this.lblMBac[1, 7];
      }
      if (!IsTextChanging)
        return;
      Label label5 = this.lblMBac[0, 0];
      label5.Text = this.strMBac[0, 0];
      label5.Font = this.fnt26;
      int num1 = checked (this.SkinAmount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        Label label1 = this.lblMBac[1, index1];
        label1.Font = this.fnt12;
        label1.Text = this.strMBac[1, index1];
        checked { ++index1; }
      }
    }

    public void Scene_Main_Widget_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color.FromArgb(60, 60, 60);
      this.Event_Main_Widget_Empty_Temp();
      if (IsSizeChanging)
      {
        int index1 = 0;
        do
        {
          this.lblMWid[3, index1].Visible = Conversions.ToBoolean(Interaction.IIf(this.intMWid[1, index1] == -1, (object) false, (object) true));
          checked { ++index1; }
        }
        while (index1 <= 53);
        int index2 = 0;
        do
        {
          this.lblMWid[2, index2].Visible = Conversions.ToBoolean(Interaction.IIf((double) this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index2 / 10.0)))), checked (unchecked (index2 % 10) + 1)] == Conversions.ToDouble("-1"), (object) false, (object) true));
          checked { ++index2; }
        }
        while (index2 <= 79);
        Panel pnlMainWidget = this.pnlMainWidget;
        pnlMainWidget.Visible = true;
        pnlMainWidget.Height = 706;
        pnlMainWidget.Width = 1024;
        pnlMainWidget.Top = checked ((int) Math.Round(unchecked ((double) checked (this.Height - this.pnlMainMenu.Height - pnlMainWidget.Height) / 2.0)));
        pnlMainWidget.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainWidget.Width) / 2.0)));
        Panel panel1 = this.pnlMWid[0];
        panel1.Height = 50;
        panel1.Width = 510;
        panel1.Top = 30;
        panel1.Left = 90;
        Panel panel2 = this.pnlMWid[1];
        panel2.Height = 25;
        panel2.Width = 500;
        panel2.Top = 90;
        panel2.Left = 100;
        Panel panel3 = this.pnlMWid[2];
        panel3.Height = 433;
        panel3.Width = 370;
        panel3.Top = 123;
        panel3.Left = 90;
        Panel panel4 = this.pnlMWid[3];
        panel4.Height = 420;
        panel4.Width = 400;
        panel4.Top = 115;
        panel4.Left = 610;
        Panel panel5 = this.pnlMWid[4];
        panel5.Height = 100;
        panel5.Width = 844;
        panel5.Top = 581;
        panel5.Left = 90;
        Label label1 = this.lblMWid[0, 0];
        label1.Height = 50;
        label1.Width = 610;
        label1.Top = 0;
        label1.Left = 0;
        label1.TextAlign = ContentAlignment.MiddleLeft;
        int index3 = 0;
        do
        {
          Label label2 = this.lblMWid[1, index3];
          label2.Height = 25;
          label2.Width = 35;
          label2.Top = 0;
          label2.Left = checked (45 * index3);
          checked { ++index3; }
        }
        while (index3 <= 7);
        int index4 = 0;
        do
        {
          Label label2 = this.lblMWid[2, index4];
          label2.Height = 35;
          label2.Width = 35;
          label2.Top = checked (10 + 42 * unchecked (index4 % 10));
          label2.Left = checked ((int) Math.Round(unchecked (10.0 + 45.0 * Conversion.Int((double) index4 / 10.0))));
          label2.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index4; }
        }
        while (index4 <= 79);
        int index5 = 0;
        do
        {
          Label label2 = this.lblMWid[3, index5];
          label2.Height = 40;
          label2.Width = 40;
          label2.Top = checked ((int) Math.Round(unchecked (2.0 + 48.0 * Conversion.Int((double) index5 / 6.0))));
          label2.Left = checked (2 + 48 * unchecked (index5 % 6));
          label2.TextAlign = ContentAlignment.MiddleCenter;
          checked { ++index5; }
        }
        while (index5 <= 53);
        Label label3 = this.lblMWid[4, 0];
        label3.Height = 32;
        label3.Width = 844;
        label3.Top = 0;
        label3.Left = 0;
        label3.TextAlign = ContentAlignment.MiddleLeft;
        Label label4 = this.lblMWid[4, 1];
        label4.Top = 33;
        label4.Left = 3;
        label4.TextAlign = ContentAlignment.TopLeft;
        label4.AutoSize = true;
        Label label5 = this.lblMWid[4, 2];
        label5.Top = 33;
        label5.Left = checked (3 + this.lblMWid[4, 1].Left + this.lblMWid[4, 1].Width);
        label5.TextAlign = ContentAlignment.MiddleLeft;
        label5.AutoSize = true;
        Label label6 = this.lblMWid[4, 3];
        label6.Top = checked (36 + this.lblMWid[4, 1].Height);
        label6.Left = 3;
        label6.TextAlign = ContentAlignment.MiddleLeft;
        label6.AutoSize = true;
      }
      if (IsColorChanging)
      {
        this.pnlMainWidget.BackColor = Color.Transparent;
        this.pnlMWid[0].BackColor = Color.Transparent;
        this.pnlMWid[1].BackColor = Color.Transparent;
        this.pnlMWid[2].BackColor = Color.Transparent;
        this.pnlMWid[3].BackColor = Color.Transparent;
        this.pnlMWid[4].BackColor = Color.Transparent;
        Label label1 = this.lblMWid[0, 0];
        label1.BackColor = Color.Transparent;
        label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        int index1 = 0;
        do
        {
          Label label2 = this.lblMWid[1, index1];
          label2.BackgroundImage = this.imgIcon[index1];
          label2.BackgroundImageLayout = ImageLayout.Center;
          checked { ++index1; }
        }
        while (index1 <= 7);
        int index2 = 0;
        do
        {
          Label label2 = this.lblMWid[2, index2];
          try
          {
            label2.BackgroundImage = this.imgMWid[2, index2];
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          label2.BackgroundImageLayout = ImageLayout.Stretch;
          label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index2; }
        }
        while (index2 <= 79);
        int index3 = 0;
        do
        {
          Label label2 = this.lblMWid[3, index3];
          label2.BackgroundImage = this.imgMWid[3, index3];
          label2.BackgroundImageLayout = ImageLayout.Stretch;
          label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
          checked { ++index3; }
        }
        while (index3 <= 53);
        this.lblMWid[4, 0].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        this.lblMWid[4, 1].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        this.lblMWid[4, 2].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        this.lblMWid[4, 3].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
      if (!IsTextChanging)
        return;
      Label label7 = this.lblMWid[0, 0];
      label7.Text = "< " + this.strMWid[0, 0];
      label7.Font = this.fnt26;
      Label label8 = this.lblMWid[4, 0];
      label8.Font = this.fnt18;
      label8.Text = "";
      Label label9 = this.lblMWid[4, 1];
      label9.Font = this.fnt12;
      label9.Text = "";
      Label label10 = this.lblMWid[4, 2];
      label10.Font = this.fnt12;
      label10.Text = "";
      Label label11 = this.lblMWid[4, 3];
      label11.Font = this.fnt12;
      label11.Text = "";
    }

    public void Scene_Main_KeyMenu()
    {
      Panel pnlMainKeyMenu = this.pnlMainKeyMenu;
      pnlMainKeyMenu.Visible = false;
      pnlMainKeyMenu.Height = 125;
      pnlMainKeyMenu.Width = 175;
      pnlMainKeyMenu.Top = checked (this.Height - this.pnlInstr.Height - pnlMainKeyMenu.Height);
      pnlMainKeyMenu.Left = 0;
      pnlMainKeyMenu.BackColor = Color.Transparent;
      int index = 0;
      do
      {
        Label label1 = this.lblMKeyMenu[index];
        label1.Height = 25;
        label1.Width = 150;
        label1.Top = checked (index * label1.Height);
        label1.Left = 0;
        label1.Font = this.fnt9;
        label1.TextAlign = ContentAlignment.MiddleLeft;
        label1.BackColor = this.ColorMain;
        label1.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        label1.Text = "   ·   " + this.strMKeyMenu[index];
        Label label2 = this.lblMKeyMenuDeco[index];
        label2.Height = 25;
        label2.Width = 25;
        label2.Top = checked (index * label2.Height);
        label2.Left = this.lblMKeyMenu[index].Width;
        label2.Font = this.fnt9;
        label2.TextAlign = ContentAlignment.MiddleLeft;
        label2.BackColor = this.ColorMain;
        this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        label2.Text = " ";
        checked { ++index; }
      }
      while (index <= 4);
      this.pnlMainKeyMenu.BringToFront();
    }

    public void Scene_Main_Conference_Update(
      bool IsSizeChanging,
      bool IsColorChanging,
      bool IsTextChanging)
    {
      Panel pnlMainConference = this.pnlMainConference;
      pnlMainConference.Height = checked (this.Height - this.pnlMainMenu.Height);
      pnlMainConference.Width = 1024;
      pnlMainConference.Top = 0;
      pnlMainConference.Left = checked ((int) Math.Round(unchecked ((double) checked (this.Width - pnlMainConference.Width) / 2.0)));
      pnlMainConference.BackColor = Color.Transparent;
      Panel panel = this.pnlMConf[0];
      panel.Height = 500;
      panel.Width = 320;
      panel.Top = 0;
      panel.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMainConference.Width - panel.Width) / 2.0)));
      panel.BackgroundImage = this.imgBackTrans[0];
      panel.BackgroundImageLayout = ImageLayout.Stretch;
      int index = 0;
      do
      {
        Label label = this.lblMConf[0, index];
        label.Height = 30;
        label.Width = 250;
        label.Top = checked (250 + 60 * index);
        label.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMConf[0].Width - label.Width) / 2.0 - 5.0)));
        label.TextAlign = ContentAlignment.MiddleLeft;
        label.Font = this.fnt12;
        label.Text = this.strMConf[0, index];
        label.BackColor = Color.Transparent;
        label.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        TextBox textBox = this.txtMConf[0, index];
        textBox.Height = 25;
        textBox.Width = 250;
        textBox.Top = checked (285 + 60 * index);
        textBox.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMConf[0].Width - textBox.Width) / 2.0)));
        textBox.BorderStyle = BorderStyle.None;
        textBox.TextAlign = HorizontalAlignment.Left;
        textBox.Font = this.fnt12;
        textBox.Text = "";
        textBox.BackColor = Color.White;
        textBox.ForeColor = this.ColorMain;
        checked { ++index; }
      }
      while (index <= 1);
      Label label1 = this.lblMConf[0, 4];
      label1.Height = 90;
      label1.Width = 320;
      label1.Top = 90;
      label1.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMConf[0].Width - label1.Width) / 2.0)));
      label1.BackgroundImage = this.imgLogo[0];
      label1.BackgroundImageLayout = ImageLayout.Zoom;
      Label label2 = this.lblMConf[0, 5];
      label2.Height = 50;
      label2.Width = 250;
      label2.Top = 430;
      label2.Left = checked ((int) Math.Round(unchecked ((double) checked (this.pnlMConf[0].Width - label2.Width) / 2.0)));
      label2.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      label2.BackgroundImage = this.imgMConf[0];
      label2.BackgroundImageLayout = ImageLayout.Center;
      label2.TextAlign = ContentAlignment.MiddleCenter;
    }

    public void Event_All_Update(bool IsSizeChanging, bool IsColorChanging, bool IsTextChanging)
    {
      this.Scene_Main_KeyMenu();
      this.Scene_MainMenu_Update(true, true, true);
      this.Scene_SubMenu_Update_I(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_SubMenu_Update_II(false, 0);
      this.Scene_Instr_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_Info_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_Vote_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_RollCall_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_LanguageSelect_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_BackgroundSelect_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_Conference_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.Scene_Main_Settings_Update(IsSizeChanging, IsColorChanging, IsTextChanging);
      this.BackColor = this.ColorMainDeep;
      this.BackgroundImage = (Image) this.imgBackground;
      this.BackgroundImageLayout = ImageLayout.Tile;
    }

    public void Event_All_Visibility_Erase()
    {
      this.pnlMainKeyMenu.Visible = false;
      this.pnlMainInfo.Visible = false;
      this.pnlMainVote.Visible = false;
      this.pnlMainRoll.Visible = false;
      this.pnlMainLanguage.Visible = false;
      this.pnlMainBackground.Visible = false;
      this.pnlMainWidget.Visible = false;
      this.pnlMainConference.Visible = false;
      this.pnlMainSettings.Visible = false;
      this.Event_MainMenu_Visibility_Update(false);
    }

    public void Event_All_Sub_Visibility_Update(bool Visibility)
    {
      if (!Visibility)
      {
        this.IsSubActiving = -1;
        int num = Information.UBound((Array) this.pnlSubMenu);
        int index = 0;
        while (index <= num)
        {
          this.IsSubVisible[index] = false;
          if (this.pnlSubMenu[index].Visible)
          {
            this.IsSubVisible[index] = true;
            this.pnlSubMenu[index].Visible = false;
            if (this.lblSMenuTitle[index].BackColor == this.ColorMainDeep)
              this.IsSubActiving = index;
          }
          checked { ++index; }
        }
        this.txtMInfo[4, 0].SelectionStart = Microsoft.VisualBasic.Strings.Len(this.txtMInfo[4, 0].Text);
        this.txtMInfo[4, 0].ScrollToCaret();
      }
      if (!Visibility)
        return;
      int num1 = Information.UBound((Array) this.pnlSubMenu);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (this.IsSubVisible[index1])
        {
          this.pnlSubMenu[index1].Visible = true;
          if (this.IsSubActiving == index1)
          {
            int num2 = Information.UBound((Array) this.pnlSubMenu);
            int index2 = 0;
            while (index2 <= num2)
            {
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
              checked { ++index2; }
            }
            this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
            this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
            this.pnlSubMenu[index1].BringToFront();
          }
        }
        checked { ++index1; }
      }
      this.txtMInfo[4, 0].SelectionStart = Microsoft.VisualBasic.Strings.Len(this.txtMInfo[4, 0].Text);
      this.txtMInfo[4, 0].ScrollToCaret();
    }

    public void Event_MainMenu_Visibility_Update(bool Visible)
    {
      if (Visible)
      {
        this.pnlMainMenu.Visible = true;
        this.pnlInstr.Width = checked (this.Width - this.pnlMainMenu.Width);
        this.lblInstr[2].Width = checked (this.pnlInstr.Width - this.lblInstr[0].Width);
        int index = 0;
        do
        {
          this.btnMMenu[index].BackColor = this.ColorMainDeep;
          checked { ++index; }
        }
        while (index <= 7);
      }
      else
      {
        this.pnlMainMenu.Visible = false;
        this.pnlInstr.Width = this.Width;
        this.lblInstr[2].Width = checked (this.pnlInstr.Width - this.lblInstr[0].Width);
      }
    }

    public void Event_ImgBackground_Resize(int Skin)
    {
      Graphics graphics = Graphics.FromImage((Image) this.imgBackground);
      object[] Arguments = new object[2]
      {
        MUNCS_E2.My.Resources.Resources.ResourceManager.GetObject("Background_" + Conversions.ToString(checked (Skin + 1))),
        null
      };
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      int width = workingArea.Width;
      workingArea = Screen.PrimaryScreen.WorkingArea;
      int height = workingArea.Height;
      Arguments[1] = (object) new Rectangle(0, 0, width, height);
      NewLateBinding.LateCall((object) graphics, (System.Type) null, "DrawImage", Arguments, (string[]) null, (System.Type[]) null, (bool[]) null, true);
    }

    public void Event_Main_Widget_Empty_Temp()
    {
      int index1 = 0;
      do
      {
        this.intMWid[0, index1] = -1;
        checked { ++index1; }
      }
      while (index1 <= 79);
      int index2 = 0;
      do
      {
        try
        {
          if (this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index2 / 10.0)))), checked (unchecked (index2 % 10) + 1)] != -1)
          {
            this.intMWid[0, index2] = this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index2 / 10.0)))), checked (unchecked (index2 % 10) + 1)];
            this.imgMWid[2, index2] = this.imgSMenuDesc[checked ((int) Math.Round(Conversion.Val(this.strSMenuDesc[this.intMMenuSub[(int) Math.Round(Conversion.Int(unchecked ((double) index2 / 10.0))), unchecked (index2 % 10) + 1], 6])))];
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index2; }
      }
      while (index2 <= 79);
      int index3 = 0;
      do
      {
        this.intMWid[1, index3] = -1;
        checked { ++index3; }
      }
      while (index3 <= 53);
      int index4 = 0;
      do
      {
        try
        {
          this.intMWid[1, index4] = checked ((int) Math.Round(Conversion.Val(this.strSMenuDesc[index4, 1])));
          this.imgMWid[3, index4] = this.imgSMenuDesc[checked ((int) Math.Round(Conversion.Val(this.strSMenuDesc[index4, 6])))];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index4; }
      }
      while (index4 <= 53);
    }

    public void Event_Main_RollCall_Initialize()
    {
      Color color1 = Color.FromArgb(67, 148, 103);
      Color color2 = Color.FromArgb(240, 98, 62);
      Color color3 = Color.FromArgb(200, 200, 200);
      int num1 = Information.UBound((Array) this.strMRollDelList);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.strMRollDelList[index1] = "";
        checked { ++index1; }
      }
      int num2 = Information.UBound((Array) this.datDelList);
      int index2 = 0;
      while (index2 <= num2)
      {
        this.strMRollDelList[index2] = this.datDelList[index2];
        checked { ++index2; }
      }
      int num3 = Information.UBound((Array) this.strMRollDelList);
      int index3 = 0;
      while (index3 <= num3)
      {
        if (Operators.CompareString(this.strMRollDelList[index3], "", false) == 0)
        {
          this.intMRollMax = checked (index3 - 1);
          break;
        }
        checked { ++index3; }
      }
      int index4 = 0;
      do
      {
        this.lblMRoll[1, index4].ForeColor = color3;
        Label label = this.lblMRollLight[0, index4];
        label.BackColor = color3;
        if (this.Accessibility_Support)
          label.Text = "";
        checked { ++index4; }
      }
      while (index4 <= 19);
      int num4 = 0;
      do
      {
        this.lblMRoll[3, checked (4 + num4)].Text = "-";
        checked { ++num4; }
      }
      while (num4 <= 3);
      int num5 = 0;
      do
      {
        this.lblMRoll[4, checked (4 + num5)].Text = "-";
        checked { ++num5; }
      }
      while (num5 <= 2);
      this.lblMRoll[5, 0].BackColor = color1;
      this.lblMRoll[5, 1].BackColor = color2;
      this.lblMRoll[5, 4].BackColor = color3;
      this.lblMRoll[5, 4].Visible = true;
      this.lblMRoll[5, 5].Visible = true;
      this.lblMRoll[5, 6].Visible = false;
      int index5 = 0;
      do
      {
        if (Operators.CompareString(this.strMRollDelList[index5], "", false) != 0)
        {
          this.lblMRoll[1, index5].Text = this.strMRollDelList[index5];
          this.lblMRoll[1, index5].Visible = true;
          this.lblMRollLight[0, index5].Visible = true;
          if (this.Accessibility_Support)
            this.lblMRollLight[0, index5].Text = "";
        }
        else
        {
          this.lblMRoll[1, index5].Visible = false;
          this.lblMRollLight[0, index5].Visible = false;
          if (this.Accessibility_Support)
            this.lblMRollLight[0, index5].Text = "";
        }
        checked { ++index5; }
      }
      while (index5 <= 19);
      this.intMRoll = 0;
      this.Event_MainMenu_Visibility_Update(false);
      this.Event_Main_RollCall_Refresh(true);
    }

    public void Event_Main_RollCall_Refresh(bool Initialize)
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color1 = Color.FromArgb(60, 60, 60);
      Color color2 = Color.FromArgb(67, 148, 103);
      Color color3 = Color.FromArgb(240, 98, 62);
      Color color4 = Color.FromArgb(200, 200, 200);
      if (!Initialize)
      {
        this.intMRollDelList[this.intMRoll] = Conversions.ToString(this.intMRollSelect);
        if (this.intMRoll < 19)
        {
          Label label = this.lblMRollLight[0, this.intMRoll];
          object obj = Interaction.IIf(this.intMRollSelect == 0, (object) color2, (object) color3);
          Color color5 = obj != null ? (Color) obj : new Color();
          label.BackColor = color5;
          if (this.Accessibility_Support)
            this.lblMRollLight[0, this.intMRoll].Text = Conversions.ToString(Interaction.IIf(this.intMRollSelect == 0, (object) "+", (object) "-"));
        }
        else
        {
          Label label = this.lblMRollLight[0, checked (10 + unchecked (this.intMRoll % 10))];
          object obj = Interaction.IIf(this.intMRollSelect == 0, (object) color2, (object) color3);
          Color color5 = obj != null ? (Color) obj : new Color();
          label.BackColor = color5;
          if (this.Accessibility_Support)
            this.lblMRollLight[0, checked (10 + unchecked (this.intMRoll % 10))].Text = Conversions.ToString(Interaction.IIf(this.intMRollSelect == 0, (object) "+", (object) "-"));
        }
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int intMroll = this.intMRoll;
        int index = 0;
        while (index <= intMroll)
        {
          if (this.datDelStatus[index] != 2)
          {
            string intMrollDel = this.intMRollDelList[index];
            if (Operators.CompareString(intMrollDel, Conversions.ToString(0), false) == 0)
            {
              checked { ++num1; }
              checked { ++num3; }
            }
            else if (Operators.CompareString(intMrollDel, Conversions.ToString(1), false) == 0)
              checked { ++num2; }
          }
          else
          {
            string intMrollDel = this.intMRollDelList[index];
            if (Operators.CompareString(intMrollDel, Conversions.ToString(0), false) == 0)
              checked { ++num3; }
            else if (Operators.CompareString(intMrollDel, Conversions.ToString(1), false) == 0)
              checked { ++num2; }
          }
          checked { ++index; }
        }
        if (num1 <= 0)
        {
          this.lblMRoll[3, 4].Text = "0";
          this.lblMRoll[3, 5].Text = "0";
        }
        else
        {
          this.lblMRoll[3, 4].Text = (double) num1 / 5.0 != Conversion.Int((double) num1 / 5.0) ? Conversions.ToString(Conversion.Int((double) num1 / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) num1 / 5.0));
          this.lblMRoll[3, 5].Text = Conversions.ToString(Conversion.Int((double) num1 / 2.0) + 1.0);
        }
        this.lblMRoll[3, 6].Text = (double) num1 / 3.0 * 2.0 != Conversion.Int((double) num1 / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) num1 / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) num1 / 3.0 * 2.0);
        this.lblMRoll[4, 4].Text = num1 != num3 ? Conversions.ToString(num1) + "/" + Conversions.ToString(num3) : Conversions.ToString(num1);
        this.lblMRoll[4, 5].Text = Conversions.ToString(num2);
        checked { ++this.intMRoll; }
      }
      if (this.intMRoll <= 19)
      {
        this.lblMRoll[1, this.intMRoll].ForeColor = this.ColorMain;
        if (this.intMRoll >= 1)
          this.lblMRoll[1, checked (this.intMRoll - 1)].ForeColor = color1;
      }
      else
      {
        this.lblMRoll[1, checked (10 + unchecked (this.intMRoll % 10))].ForeColor = this.ColorMain;
        if (this.intMRoll % 10 >= 1)
          this.lblMRoll[1, checked (9 + unchecked (this.intMRoll % 10))].ForeColor = color1;
        if (this.intMRoll % 10 == 0)
        {
          if (Operators.CompareString(this.strMRollDelList[this.intMRoll], "", false) != 0)
          {
            int index1 = 11;
            do
            {
              this.lblMRoll[1, index1].ForeColor = color4;
              checked { ++index1; }
            }
            while (index1 <= 19);
            int index2 = 10;
            do
            {
              this.lblMRoll[1, checked (index2 - 10)].Text = this.lblMRoll[1, index2].Text;
              this.lblMRollLight[0, checked (index2 - 10)].BackColor = this.lblMRollLight[0, index2].BackColor;
              if (this.Accessibility_Support)
                this.lblMRollLight[0, checked (index2 - 10)].Text = this.lblMRollLight[0, index2].Text;
              if (Operators.CompareString(this.strMRollDelList[checked (this.intMRoll + index2 - 10)], "", false) != 0)
              {
                this.lblMRoll[1, index2].Text = this.strMRollDelList[checked (this.intMRoll + index2 - 10)];
                this.lblMRollLight[0, index2].BackColor = color4;
                if (this.Accessibility_Support)
                  this.lblMRollLight[0, index2].Text = "";
              }
              else
              {
                this.lblMRoll[1, index2].Visible = false;
                this.lblMRollLight[0, index2].Visible = false;
                if (this.Accessibility_Support)
                  this.lblMRollLight[0, index2].Text = "";
              }
              checked { ++index2; }
            }
            while (index2 <= 19);
          }
          else
          {
            this.lblMRoll[1, 10].ForeColor = color1;
            this.lblMRoll[1, 19].ForeColor = color1;
          }
        }
      }
      this.lblMRoll[2, 0].Text = this.strMRollDelList[this.intMRoll];
      if (this.intMRoll != 0)
        this.lblMRoll[5, 4].BackColor = this.ColorMainDeep;
      if (this.intMRoll <= this.intMRollMax)
        return;
      this.lblMRoll[5, 0].BackColor = color4;
      this.lblMRoll[5, 1].BackColor = color4;
      this.lblMRoll[5, 4].Visible = false;
      this.lblMRoll[5, 5].Visible = false;
      this.lblMRoll[5, 6].Visible = true;
      int num = Information.UBound((Array) this.datDelListPresent);
      int index3 = 0;
      while (index3 <= num)
      {
        this.datDelListPresent[index3] = "";
        checked { ++index3; }
      }
      int intMrollMax = this.intMRollMax;
      int index4 = 0;
      while (index4 <= intMrollMax)
      {
        if (Conversions.ToDouble(this.intMRollDelList[index4]) == 0.0)
        {
          int index1;
          this.datDelListPresent[index1] = this.strMRollDelList[index4];
          checked { ++index1; }
        }
        checked { ++index4; }
      }
    }

    public void Event_Main_RollCall_Popback()
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color1 = Color.FromArgb(60, 60, 60);
      Color color2 = Color.FromArgb(67, 148, 103);
      Color color3 = Color.FromArgb(240, 98, 62);
      Color color4 = Color.FromArgb(200, 200, 200);
      if (this.intMRoll <= 0)
      {
        this.lblMRoll[5, 4].BackColor = color4;
        this.intMRoll = 1;
      }
      else if (this.intMRoll <= 19)
      {
        this.lblMRoll[1, this.intMRoll].ForeColor = color4;
        this.lblMRoll[1, checked (this.intMRoll - 1)].ForeColor = this.ColorMain;
        this.lblMRollLight[0, checked (this.intMRoll - 1)].BackColor = color4;
        if (this.Accessibility_Support)
          this.lblMRollLight[0, checked (this.intMRoll - 1)].Text = "";
      }
      else if (this.intMRoll % 10 == 0)
      {
        int index1 = 10;
        do
        {
          this.lblMRoll[1, index1].Text = this.lblMRoll[1, checked (index1 - 10)].Text;
          this.lblMRoll[1, index1].ForeColor = color1;
          this.lblMRollLight[0, index1].BackColor = this.lblMRollLight[0, checked (index1 - 10)].BackColor;
          if (this.Accessibility_Support)
            this.lblMRollLight[0, index1].Text = this.lblMRollLight[0, checked (index1 - 10)].Text;
          this.lblMRoll[1, index1].Visible = true;
          this.lblMRollLight[0, index1].Visible = true;
          checked { ++index1; }
        }
        while (index1 <= 19);
        int index2 = 0;
        do
        {
          this.lblMRoll[1, index2].Text = this.strMRollDelList[checked (this.intMRoll - 20 + index2)];
          Label label = this.lblMRollLight[0, index2];
          object obj = Interaction.IIf(Operators.CompareString(this.intMRollDelList[checked (this.intMRoll - 20 + index2)], "0", false) == 0, (object) color2, (object) color3);
          Color color5 = obj != null ? (Color) obj : new Color();
          label.BackColor = color5;
          if (this.Accessibility_Support)
            this.lblMRollLight[0, index2].Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(this.intMRollDelList[checked (this.intMRoll - 20 + index2)], "0", false) == 0, (object) "+", (object) "-"));
          checked { ++index2; }
        }
        while (index2 <= 9);
        this.lblMRoll[1, 19].ForeColor = this.ColorMain;
        this.lblMRollLight[0, 19].BackColor = color4;
        if (this.Accessibility_Support)
          this.lblMRollLight[0, 19].Text = "";
      }
      else
      {
        this.lblMRoll[1, checked (unchecked (this.intMRoll % 10) + 10)].ForeColor = color4;
        this.lblMRoll[1, checked (unchecked (this.intMRoll % 10) + 9)].ForeColor = this.ColorMain;
        this.lblMRollLight[0, checked (unchecked (this.intMRoll % 10) + 9)].BackColor = color4;
        if (this.Accessibility_Support)
          this.lblMRollLight[0, checked (unchecked (this.intMRoll % 10) + 9)].Text = "";
      }
      if (this.intMRoll > 0)
        checked { --this.intMRoll; }
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (this.intMRoll > 0)
      {
        int num4 = checked (this.intMRoll - 1);
        int index = 0;
        while (index <= num4)
        {
          if (this.datDelStatus[index] != 2)
          {
            string intMrollDel = this.intMRollDelList[index];
            if (Operators.CompareString(intMrollDel, Conversions.ToString(0), false) == 0)
            {
              checked { ++num1; }
              checked { ++num3; }
            }
            else if (Operators.CompareString(intMrollDel, Conversions.ToString(1), false) == 0)
              checked { ++num2; }
          }
          else
          {
            string intMrollDel = this.intMRollDelList[index];
            if (Operators.CompareString(intMrollDel, Conversions.ToString(0), false) == 0)
              checked { ++num3; }
            else if (Operators.CompareString(intMrollDel, Conversions.ToString(1), false) == 0)
              checked { ++num2; }
          }
          checked { ++index; }
        }
        if (num1 <= 0)
        {
          this.lblMRoll[3, 4].Text = "0";
          this.lblMRoll[3, 5].Text = "0";
        }
        else
        {
          this.lblMRoll[3, 4].Text = (double) num1 / 5.0 != Conversion.Int((double) num1 / 5.0) ? Conversions.ToString(Conversion.Int((double) num1 / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) num1 / 5.0));
          this.lblMRoll[3, 5].Text = Conversions.ToString(Conversion.Int((double) num1 / 2.0) + 1.0);
        }
        this.lblMRoll[3, 6].Text = (double) num1 / 3.0 * 2.0 != Conversion.Int((double) num1 / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) num1 / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) num1 / 3.0 * 2.0);
        this.lblMRoll[4, 4].Text = num1 != num3 ? Conversions.ToString(num1) + "/" + Conversions.ToString(num3) : Conversions.ToString(num1);
        this.lblMRoll[4, 5].Text = Conversions.ToString(num2);
      }
      else
      {
        int index1 = 4;
        do
        {
          this.lblMRoll[3, index1].Text = "-";
          checked { ++index1; }
        }
        while (index1 <= 6);
        int index2 = 4;
        do
        {
          this.lblMRoll[4, index2].Text = "-";
          checked { ++index2; }
        }
        while (index2 <= 5);
      }
      if (this.intMRoll == 0)
        this.lblMRoll[5, 4].BackColor = color4;
      else
        this.lblMRoll[5, 4].BackColor = this.ColorMainDeep;
    }

    public void Event_Main_Vote_Initialize()
    {
      Color color1 = Color.FromArgb(67, 148, 103);
      Color color2 = Color.FromArgb(240, 98, 62);
      Color color3 = Color.FromArgb(247, 209, 48);
      Color color4 = Color.FromArgb(62, 109, 181);
      Color color5 = Color.FromArgb(200, 200, 200);
      int num1 = Information.UBound((Array) this.strMVoteDelList);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.strMVoteDelList[index1] = "";
        checked { ++index1; }
      }
      int index2 = 0;
      int num2 = Information.UBound((Array) this.datDelListPresent);
      int index3 = 0;
      while (index3 <= num2)
      {
        int num3 = Information.UBound((Array) this.datDelList);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Operators.CompareString(this.datDelListPresent[index3], this.datDelList[index4], false) == 0 && this.datDelStatus[index4] != 2)
          {
            this.strMVoteDelList[index2] = this.datDelListPresent[index3];
            checked { ++index2; }
          }
          checked { ++index4; }
        }
        checked { ++index3; }
      }
      int num4 = Information.UBound((Array) this.strMVoteDelList);
      int index5 = 0;
      while (index5 <= num4)
      {
        if (Operators.CompareString(this.strMVoteDelList[index5], "", false) == 0)
        {
          this.intMVoteMax = checked (index5 - 1);
          break;
        }
        checked { ++index5; }
      }
      int index6 = 0;
      do
      {
        this.lblMVote[1, index6].ForeColor = color5;
        Label label = this.lblMVoteLight[0, index6];
        label.BackColor = color5;
        if (this.Accessibility_Support)
          label.Text = "";
        checked { ++index6; }
      }
      while (index6 <= 19);
      int num5 = 0;
      do
      {
        this.lblMVote[3, checked (4 + num5)].Text = "-";
        checked { ++num5; }
      }
      while (num5 <= 3);
      this.lblMVote[3, 4].Text = "-";
      this.lblMVote[3, 5].Text = Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0);
      this.lblMVote[3, 6].Text = "-";
      this.lblMVote[3, 7].Text = "-";
      int num6 = 0;
      do
      {
        this.lblMVote[4, checked (4 + num6)].Text = "-";
        checked { ++num6; }
      }
      while (num6 <= 3);
      int index7 = 0;
      do
      {
        this.lblMVote[5, index7].Text = this.strMVote[5, index7];
        checked { ++index7; }
      }
      while (index7 <= 6);
      this.lblMVote[5, 0].BackColor = color1;
      this.lblMVote[5, 1].BackColor = color2;
      this.lblMVote[5, 2].BackColor = color3;
      this.lblMVote[5, 3].BackColor = color4;
      this.lblMVote[5, 4].BackColor = color5;
      this.lblMVote[5, 4].Visible = true;
      this.lblMVote[5, 5].Visible = true;
      this.lblMVote[5, 6].Visible = false;
      this.lblMVoteLight[2, 3].Visible = true;
      this.lblMVote[4, 3].Visible = true;
      this.lblMVote[4, 7].Visible = true;
      this.pnlMVote[4].Height = 196;
      int index8 = 0;
      do
      {
        if (Operators.CompareString(this.strMVoteDelList[index8], "", false) != 0)
        {
          this.lblMVote[1, index8].Text = this.strMVoteDelList[index8];
          this.lblMVote[1, index8].Visible = true;
          this.lblMVoteLight[0, index8].Visible = true;
        }
        else
        {
          this.lblMVote[1, index8].Visible = false;
          this.lblMVoteLight[0, index8].Visible = false;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, index8].Text = "";
        }
        checked { ++index8; }
      }
      while (index8 <= 19);
      this.intMVote = 0;
      this.Event_MainMenu_Visibility_Update(false);
      this.Event_Main_Vote_Refresh(true);
    }

    public void Event_Main_Vote_Refresh(bool Initialize)
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color1 = Color.FromArgb(60, 60, 60);
      Color color2 = Color.FromArgb(67, 148, 103);
      Color color3 = Color.FromArgb(240, 98, 62);
      Color color4 = Color.FromArgb(247, 209, 48);
      Color color5 = Color.FromArgb(62, 109, 181);
      Color color6 = Color.FromArgb(200, 200, 200);
      int num1;
      if (!Initialize)
      {
        this.intMVoteDelList[this.intMVote] = Conversions.ToString(this.intMVoteSelect);
        if (this.intMVote < 19)
        {
          Label label = this.lblMVoteLight[0, this.intMVote];
          object obj = Interaction.IIf(this.intMVoteSelect == 0, (object) color2, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) color3, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) color4, (object) color5)))));
          Color color7 = obj != null ? (Color) obj : new Color();
          label.BackColor = color7;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, this.intMVote].Text = Conversions.ToString(Interaction.IIf(this.intMVoteSelect == 0, (object) "+", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) "-", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) "×", (object) "/"))))));
        }
        else
        {
          Label label = this.lblMVoteLight[0, checked (10 + unchecked (this.intMVote % 10))];
          object obj = Interaction.IIf(this.intMVoteSelect == 0, (object) color2, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) color3, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) color4, (object) color5)))));
          Color color7 = obj != null ? (Color) obj : new Color();
          label.BackColor = color7;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, checked (10 + unchecked (this.intMVote % 10))].Text = Conversions.ToString(Interaction.IIf(this.intMVoteSelect == 0, (object) "+", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) "-", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) "×", (object) "/"))))));
        }
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        num1 = 0;
        int intMvote = this.intMVote;
        int index = 0;
        while (index <= intMvote)
        {
          string intMvoteDel = this.intMVoteDelList[index];
          if (Operators.CompareString(intMvoteDel, Conversions.ToString(0), false) == 0)
            checked { ++num2; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(1), false) == 0)
            checked { ++num3; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(2), false) == 0)
            checked { ++num4; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(3), false) == 0)
            checked { ++num1; }
          checked { ++index; }
        }
        this.lblMVote[4, 4].Text = Conversions.ToString(num2);
        this.lblMVote[4, 5].Text = Conversions.ToString(num3);
        this.lblMVote[4, 6].Text = Conversions.ToString(num4);
        this.lblMVote[4, 7].Text = Conversions.ToString(num1);
        this.lblMVote[3, 4].Text = Conversions.ToString(checked (num2 + num3));
        this.lblMVote[3, 5].Text = (double) this.intMVoteMax / 5.0 != Conversion.Int((double) this.intMVoteMax / 5.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0));
        this.lblMVote[3, 6].Text = Conversions.ToString(Conversion.Int((double) checked (num2 + num3) / 2.0) + 1.0);
        this.lblMVote[3, 7].Text = (double) checked (num2 + num3) / 3.0 * 2.0 != Conversion.Int((double) checked (num2 + num3) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num2 + num3) / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) checked (num2 + num3) / 3.0 * 2.0);
        checked { ++this.intMVote; }
      }
      if (this.intMVote <= 19)
      {
        this.lblMVote[1, this.intMVote].ForeColor = this.ColorMain;
        if (this.intMVote >= 1)
          this.lblMVote[1, checked (this.intMVote - 1)].ForeColor = color1;
      }
      else
      {
        this.lblMVote[1, checked (10 + unchecked (this.intMVote % 10))].ForeColor = this.ColorMain;
        if (this.intMVote % 10 >= 1)
          this.lblMVote[1, checked (9 + unchecked (this.intMVote % 10))].ForeColor = color1;
        if (this.intMVote % 10 == 0)
        {
          if (Operators.CompareString(this.strMVoteDelList[this.intMVote], "", false) != 0)
          {
            int index1 = 11;
            do
            {
              this.lblMVote[1, index1].ForeColor = color6;
              checked { ++index1; }
            }
            while (index1 <= 19);
            int index2 = 10;
            do
            {
              this.lblMVote[1, checked (index2 - 10)].Text = this.lblMVote[1, index2].Text;
              this.lblMVoteLight[0, checked (index2 - 10)].BackColor = this.lblMVoteLight[0, index2].BackColor;
              if (this.Accessibility_Support)
                this.lblMVoteLight[0, checked (index2 - 10)].Text = this.lblMVoteLight[0, index2].Text;
              if (Operators.CompareString(this.strMVoteDelList[checked (this.intMVote + index2 - 10)], "", false) != 0)
              {
                this.lblMVote[1, index2].Text = this.strMVoteDelList[checked (this.intMVote + index2 - 10)];
                this.lblMVoteLight[0, index2].BackColor = color6;
                if (this.Accessibility_Support)
                  this.lblMVoteLight[0, index2].Text = "";
              }
              else
              {
                this.lblMVote[1, index2].Visible = false;
                this.lblMVoteLight[0, index2].Visible = false;
                if (this.Accessibility_Support)
                  this.lblMVoteLight[0, index2].Text = "";
              }
              checked { ++index2; }
            }
            while (index2 <= 19);
          }
          else
          {
            this.lblMVote[1, 10].ForeColor = color1;
            this.lblMVote[1, 19].ForeColor = color1;
          }
        }
      }
      this.lblMVote[2, 0].Text = this.strMVoteDelList[this.intMVote];
      if (this.intMVote != 0)
        this.lblMVote[5, 4].BackColor = this.ColorMainDeep;
      int num5 = Information.UBound((Array) this.datDelList);
      int index3 = 0;
      while (index3 <= num5)
      {
        if (Operators.CompareString(this.strMVoteDelList[this.intMVote], this.datDelList[index3], false) == 0)
          this.lblMVote[5, 1].Text = this.datDelStatus[index3] != 1 ? this.strMVote[5, 1] : this.strMVote[5, 7];
        checked { ++index3; }
      }
      if (this.intMVote <= this.intMVoteMax)
      {
        int num2 = Information.UBound((Array) this.datDelList);
        int index1 = 0;
        while (index1 <= num2)
        {
          if (this.intMVote > 0 && Operators.CompareString(this.strMVoteDelList[checked (this.intMVote - 1)], this.datDelList[index1], false) == 0 && (this.datDelStatus[index1] == 1 && Conversions.ToDouble(this.intMVoteDelList[checked (this.intMVote - 1)]) == 1.0))
          {
            this.lblMVote[5, 0].BackColor = color6;
            this.lblMVote[5, 1].BackColor = color6;
            this.lblMVote[5, 2].BackColor = color6;
            this.lblMVote[5, 3].BackColor = color6;
            this.lblMVote[5, 4].Visible = false;
            this.lblMVote[5, 5].Visible = false;
            this.lblMVote[5, 6].Visible = true;
          }
          checked { ++index1; }
        }
      }
      else
      {
        int num2 = Information.UBound((Array) this.datDelList);
        int index1 = 0;
        while (index1 <= num2)
        {
          if (Operators.CompareString(this.strMVoteDelList[checked (this.intMVote - 1)], this.datDelList[index1], false) == 0 && this.datDelStatus[index1] == 1 && Conversions.ToDouble(this.intMVoteDelList[checked (this.intMVote - 1)]) == 1.0)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num3 = checked (^(local = ref this.intMVoteMax) + 1);
            local = num3;
            num1 = 0;
          }
          checked { ++index1; }
        }
        if (num1 == 0)
        {
          this.lblMVote[5, 0].BackColor = color6;
          this.lblMVote[5, 1].BackColor = color6;
          this.lblMVote[5, 2].BackColor = color6;
          this.lblMVote[5, 3].BackColor = color6;
          this.lblMVote[5, 4].Visible = false;
          this.lblMVote[5, 5].Visible = false;
          this.lblMVote[5, 6].Visible = true;
        }
        else
        {
          this.Event_Main_ReVote_Initialize();
          this.Event_Main_ReVote_Refresh(true);
        }
      }
    }

    public void Event_Main_Vote_Popback()
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color1 = Color.FromArgb(60, 60, 60);
      Color color2 = Color.FromArgb(67, 148, 103);
      Color color3 = Color.FromArgb(240, 98, 62);
      Color color4 = Color.FromArgb(247, 209, 48);
      Color color5 = Color.FromArgb(62, 109, 181);
      Color color6 = Color.FromArgb(200, 200, 200);
      if (this.intMVote <= 0)
      {
        this.lblMVote[5, 4].BackColor = color6;
        this.intMVote = 1;
      }
      else if (this.intMVote <= 19)
      {
        this.lblMVote[1, this.intMVote].ForeColor = color6;
        this.lblMVote[1, checked (this.intMVote - 1)].ForeColor = this.ColorMain;
        this.lblMVoteLight[0, checked (this.intMVote - 1)].BackColor = color6;
        if (this.Accessibility_Support)
          this.lblMVoteLight[0, checked (this.intMVote - 1)].Text = "";
      }
      else if (this.intMVote % 10 == 0)
      {
        int index1 = 10;
        do
        {
          this.lblMVote[1, index1].Text = this.lblMVote[1, checked (index1 - 10)].Text;
          this.lblMVote[1, index1].ForeColor = color1;
          this.lblMVoteLight[0, index1].BackColor = this.lblMVoteLight[0, checked (index1 - 10)].BackColor;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, index1].Text = this.lblMVoteLight[0, checked (index1 - 10)].Text;
          this.lblMVote[1, index1].Visible = true;
          this.lblMVoteLight[0, index1].Visible = true;
          checked { ++index1; }
        }
        while (index1 <= 19);
        int index2 = 0;
        do
        {
          this.lblMVote[1, index2].Text = this.strMVoteDelList[checked (this.intMVote - 20 + index2)];
          string intMvoteDel = this.intMVoteDelList[checked (this.intMVote - 20 + index2)];
          Label label = this.lblMVoteLight[0, index2];
          object obj = Interaction.IIf(Operators.CompareString(intMvoteDel, "0", false) == 0, (object) color2, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMvoteDel, "1", false) == 0, (object) color3, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMvoteDel, "2", false) == 0, (object) color4, (object) color5)))));
          Color color7 = obj != null ? (Color) obj : new Color();
          label.BackColor = color7;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, index2].Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(intMvoteDel, "0", false) == 0, (object) "+", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMvoteDel, "1", false) == 0, (object) "-", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMvoteDel, "2", false) == 0, (object) "×", (object) "/"))))));
          checked { ++index2; }
        }
        while (index2 <= 9);
        this.lblMVote[1, 19].ForeColor = this.ColorMain;
        this.lblMVoteLight[0, 19].BackColor = color6;
        if (this.Accessibility_Support)
          this.lblMVoteLight[0, 19].Text = "";
      }
      else
      {
        this.lblMVote[1, checked (unchecked (this.intMVote % 10) + 10)].ForeColor = color6;
        this.lblMVote[1, checked (unchecked (this.intMVote % 10) + 9)].ForeColor = this.ColorMain;
        this.lblMVoteLight[0, checked (unchecked (this.intMVote % 10) + 9)].BackColor = color6;
        if (this.Accessibility_Support)
          this.lblMVoteLight[0, checked (unchecked (this.intMVote % 10) + 9)].Text = "";
      }
      if (this.intMVote > 0)
        checked { --this.intMVote; }
      int num1 = Information.UBound((Array) this.datDelList);
      int index3 = 0;
      while (index3 <= num1)
      {
        if (Operators.CompareString(this.strMVoteDelList[this.intMVote], this.datDelList[index3], false) == 0)
          this.lblMVote[5, 1].Text = this.datDelStatus[index3] != 1 ? this.strMVote[5, 1] : this.strMVote[5, 7];
        checked { ++index3; }
      }
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      if (this.intMVote > 0)
      {
        int num6 = checked (this.intMVote - 1);
        int index1 = 0;
        while (index1 <= num6)
        {
          string intMvoteDel = this.intMVoteDelList[index1];
          if (Operators.CompareString(intMvoteDel, Conversions.ToString(0), false) == 0)
            checked { ++num2; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(1), false) == 0)
            checked { ++num3; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(2), false) == 0)
            checked { ++num4; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(3), false) == 0)
            checked { ++num5; }
          checked { ++index1; }
        }
        this.lblMVote[4, 4].Text = Conversions.ToString(num2);
        this.lblMVote[4, 5].Text = Conversions.ToString(num3);
        this.lblMVote[4, 6].Text = Conversions.ToString(num4);
        this.lblMVote[4, 7].Text = Conversions.ToString(num5);
        this.lblMVote[3, 4].Text = Conversions.ToString(checked (num2 + num3));
        this.lblMVote[3, 5].Text = (double) this.intMVoteMax / 5.0 != Conversion.Int((double) this.intMVoteMax / 5.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0)) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0);
        this.lblMVote[3, 6].Text = Conversions.ToString(Conversion.Int((double) checked (num2 + num3) / 2.0) + 1.0);
        this.lblMVote[3, 7].Text = (double) checked (num2 + num3) / 3.0 * 2.0 != Conversion.Int((double) checked (num2 + num3) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num2 + num3) / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) checked (num2 + num3) / 3.0 * 2.0);
      }
      else
      {
        int index1 = 4;
        do
        {
          this.lblMVote[4, index1].Text = "-";
          checked { ++index1; }
        }
        while (index1 <= 7);
      }
      if (this.intMVote == 0)
        this.lblMVote[5, 4].BackColor = color6;
      else
        this.lblMVote[5, 4].BackColor = this.ColorMainDeep;
    }

    public void Event_Main_ReVote_Initialize()
    {
      string[] strArray = new string[512];
      Color color1 = Color.FromArgb(67, 148, 103);
      Color color2 = Color.FromArgb(240, 98, 62);
      Color.FromArgb(247, 209, 48);
      Color.FromArgb(62, 109, 181);
      Color color3 = Color.FromArgb(200, 200, 200);
      int num1 = Information.UBound((Array) this.strMVoteDelList);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.strMVoteDelList[index1] = "";
        checked { ++index1; }
      }
      int index2 = 0;
      int num2 = Information.UBound((Array) this.datDelListPresent);
      int index3 = 0;
      while (index3 <= num2)
      {
        int num3 = Information.UBound((Array) this.datDelList);
        int index4 = 0;
        while (index4 <= num3)
        {
          if (Operators.CompareString(this.datDelListPresent[index3], this.datDelList[index4], false) == 0 && this.datDelStatus[index4] != 2)
          {
            strArray[index2] = this.datDelListPresent[index3];
            checked { ++index2; }
          }
          checked { ++index4; }
        }
        checked { ++index3; }
      }
      int index5 = 0;
      int num4 = Information.UBound((Array) this.datDelList);
      int index6 = 0;
      while (index6 <= num4)
      {
        if (Conversions.ToDouble(this.intMVoteDelList[index6]) == 3.0)
        {
          this.strMVoteDelList[index5] = strArray[index6];
          checked { ++index5; }
        }
        checked { ++index6; }
      }
      int num5 = Information.UBound((Array) this.strMVoteDelList);
      int index7 = 0;
      while (index7 <= num5)
      {
        if (Operators.CompareString(this.strMVoteDelList[index7], "", false) == 0)
        {
          this.intMReVoteMax = checked (index7 - 1);
          break;
        }
        checked { ++index7; }
      }
      int index8 = 0;
      do
      {
        this.lblMVote[1, index8].ForeColor = color3;
        Label label = this.lblMVoteLight[0, index8];
        label.BackColor = color3;
        if (this.Accessibility_Support)
          label.Text = "";
        checked { ++index8; }
      }
      while (index8 <= 19);
      int num6 = 0;
      do
      {
        this.lblMVote[3, checked (4 + num6)].Text = "-";
        checked { ++num6; }
      }
      while (num6 <= 3);
      this.lblMVote[3, 4].Text = Conversions.ToString(checked (this.intMVoteMax + 1));
      this.lblMVote[3, 5].Text = (double) this.intMVoteMax / 5.0 != Conversion.Int((double) this.intMVoteMax / 5.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0));
      this.lblMVote[3, 6].Text = Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 2.0) + 1.0);
      this.lblMVote[3, 7].Text = (double) this.intMVoteMax / 3.0 * 2.0 != Conversion.Int((double) this.intMVoteMax / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 3.0 * 2.0) + 1.0) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 3.0 * 2.0));
      int num7 = 0;
      int num8 = 0;
      int num9 = 0;
      int intMvoteMax = this.intMVoteMax;
      int index9 = 0;
      while (index9 <= intMvoteMax)
      {
        string intMvoteDel = this.intMVoteDelList[index9];
        if (Operators.CompareString(intMvoteDel, Conversions.ToString(0), false) == 0)
          checked { ++num7; }
        else if (Operators.CompareString(intMvoteDel, Conversions.ToString(1), false) == 0)
          checked { ++num8; }
        else if (Operators.CompareString(intMvoteDel, Conversions.ToString(2), false) == 0)
          checked { ++num9; }
        checked { ++index9; }
      }
      this.lblMVote[4, 4].Text = Conversions.ToString(num7);
      this.lblMVote[4, 5].Text = Conversions.ToString(num8);
      this.lblMVote[4, 6].Text = Conversions.ToString(num9);
      this.lblMVote[3, 4].Text = Conversions.ToString(checked (num7 + num8));
      this.lblMVote[3, 5].Text = (double) this.intMVoteMax / 5.0 != Conversion.Int((double) this.intMVoteMax / 5.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0));
      this.lblMVote[3, 6].Text = Conversions.ToString(Conversion.Int((double) checked (num7 + num8) / 2.0) + 1.0);
      this.lblMVote[3, 7].Text = (double) checked (num7 + num8) / 3.0 * 2.0 != Conversion.Int((double) checked (num7 + num8) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num7 + num8) / 3.0 * 2.0) + 1.0) : Conversions.ToString(Conversion.Int((double) checked (num7 + num8) / 3.0 * 2.0));
      this.lblMVote[4, 7].Text = "-";
      int index10 = 0;
      do
      {
        this.lblMVote[5, index10].Text = this.strMVote[5, index10];
        checked { ++index10; }
      }
      while (index10 <= 6);
      this.lblMVote[5, 0].BackColor = color1;
      this.lblMVote[5, 1].BackColor = color2;
      this.lblMVote[5, 2].BackColor = color3;
      this.lblMVote[5, 3].BackColor = color3;
      this.lblMVote[5, 4].BackColor = color3;
      this.lblMVote[5, 4].Visible = true;
      this.lblMVote[5, 5].Visible = true;
      this.lblMVote[5, 6].Visible = false;
      this.lblMVoteLight[2, 3].Visible = false;
      this.lblMVote[4, 3].Visible = false;
      this.lblMVote[4, 7].Visible = false;
      this.pnlMVote[4].Height = 156;
      int index11 = 0;
      do
      {
        if (Operators.CompareString(this.strMVoteDelList[index11], "", false) != 0)
        {
          this.lblMVote[1, index11].Text = this.strMVoteDelList[index11];
          this.lblMVote[1, index11].Visible = true;
          this.lblMVoteLight[0, index11].Visible = true;
        }
        else
        {
          this.lblMVote[1, index11].Visible = false;
          this.lblMVoteLight[0, index11].Visible = false;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, index11].Text = "";
        }
        checked { ++index11; }
      }
      while (index11 <= 19);
      this.intMVote = 0;
      this.Event_MainMenu_Visibility_Update(false);
      this.Event_Main_ReVote_Refresh(true);
    }

    public void Event_Main_ReVote_Refresh(bool Initialize)
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color1 = Color.FromArgb(60, 60, 60);
      Color color2 = Color.FromArgb(67, 148, 103);
      Color color3 = Color.FromArgb(240, 98, 62);
      Color color4 = Color.FromArgb(247, 209, 48);
      Color color5 = Color.FromArgb(62, 109, 181);
      Color color6 = Color.FromArgb(200, 200, 200);
      if (!Initialize)
      {
        this.intMReVoteDelList[this.intMVote] = Conversions.ToString(this.intMVoteSelect);
        if (this.intMVote < 19)
        {
          Label label = this.lblMVoteLight[0, this.intMVote];
          object obj = Interaction.IIf(this.intMVoteSelect == 0, (object) color2, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) color3, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) color4, (object) color5)))));
          Color color7 = obj != null ? (Color) obj : new Color();
          label.BackColor = color7;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, this.intMVote].Text = Conversions.ToString(Interaction.IIf(this.intMVoteSelect == 0, (object) "+", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) "-", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) "×", (object) "/"))))));
        }
        else
        {
          Label label = this.lblMVoteLight[0, checked (10 + unchecked (this.intMVote % 10))];
          object obj = Interaction.IIf(this.intMVoteSelect == 0, (object) color2, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) color3, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) color4, (object) color5)))));
          Color color7 = obj != null ? (Color) obj : new Color();
          label.BackColor = color7;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, checked (10 + unchecked (this.intMVote % 10))].Text = Conversions.ToString(Interaction.IIf(this.intMVoteSelect == 0, (object) "+", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 1, (object) "-", RuntimeHelpers.GetObjectValue(Interaction.IIf(this.intMVoteSelect == 2, (object) "×", (object) "/"))))));
        }
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        int num7 = 0;
        int intMvote = this.intMVote;
        int index1 = 0;
        while (index1 <= intMvote)
        {
          string intMreVoteDel = this.intMReVoteDelList[index1];
          if (Operators.CompareString(intMreVoteDel, Conversions.ToString(0), false) == 0)
            checked { ++num5; }
          else if (Operators.CompareString(intMreVoteDel, Conversions.ToString(1), false) == 0)
            checked { ++num6; }
          else if (Operators.CompareString(intMreVoteDel, Conversions.ToString(2), false) == 0)
            checked { ++num7; }
          checked { ++index1; }
        }
        int intMvoteMax = this.intMVoteMax;
        int index2 = 0;
        while (index2 <= intMvoteMax)
        {
          string intMvoteDel = this.intMVoteDelList[index2];
          if (Operators.CompareString(intMvoteDel, Conversions.ToString(0), false) == 0)
            checked { ++num1; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(1), false) == 0)
            checked { ++num2; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(2), false) == 0)
            checked { ++num3; }
          else if (Operators.CompareString(intMvoteDel, Conversions.ToString(3), false) == 0)
            checked { ++num4; }
          checked { ++index2; }
        }
        this.lblMVote[3, 4].Text = Conversions.ToString(checked (num1 + num2 + num5 + num6));
        this.lblMVote[3, 5].Text = (double) this.intMVoteMax / 5.0 != Conversion.Int((double) this.intMVoteMax / 5.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0));
        this.lblMVote[3, 6].Text = Conversions.ToString(Conversion.Int((double) checked (num1 + num2 + num5 + num6) / 2.0) + 1.0);
        this.lblMVote[3, 7].Text = (double) checked (num1 + num2 + num5 + num6) / 3.0 * 2.0 != Conversion.Int((double) checked (num1 + num2 + num5 + num6) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num1 + num2 + num5 + num6) / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) checked (num1 + num2 + num5 + num6) / 3.0 * 2.0);
        this.lblMVote[4, 4].Text = Conversions.ToString(checked (num1 + num5));
        this.lblMVote[4, 5].Text = Conversions.ToString(checked (num2 + num6));
        this.lblMVote[4, 6].Text = Conversions.ToString(checked (num3 + num7));
        this.lblMVote[4, 7].Text = "-";
        checked { ++this.intMVote; }
      }
      if (this.intMVote <= 19)
      {
        this.lblMVote[1, this.intMVote].ForeColor = this.ColorMain;
        if (this.intMVote >= 1)
          this.lblMVote[1, checked (this.intMVote - 1)].ForeColor = color1;
      }
      else
      {
        this.lblMVote[1, checked (10 + unchecked (this.intMVote % 10))].ForeColor = this.ColorMain;
        if (this.intMVote % 10 >= 1)
          this.lblMVote[1, checked (9 + unchecked (this.intMVote % 10))].ForeColor = color1;
        if (this.intMVote % 10 == 0)
        {
          if (Operators.CompareString(this.strMVoteDelList[this.intMVote], "", false) != 0)
          {
            int index1 = 11;
            do
            {
              this.lblMVote[1, index1].ForeColor = color6;
              checked { ++index1; }
            }
            while (index1 <= 19);
            int index2 = 10;
            do
            {
              this.lblMVote[1, checked (index2 - 10)].Text = this.lblMVote[1, index2].Text;
              this.lblMVoteLight[0, checked (index2 - 10)].BackColor = this.lblMVoteLight[0, index2].BackColor;
              if (this.Accessibility_Support)
                this.lblMVoteLight[0, checked (index2 - 10)].Text = this.lblMVoteLight[0, index2].Text;
              if (Operators.CompareString(this.strMVoteDelList[checked (this.intMVote + index2 - 10)], "", false) != 0)
              {
                this.lblMVote[1, index2].Text = this.strMVoteDelList[checked (this.intMVote + index2 - 10)];
                this.lblMVoteLight[0, index2].BackColor = color6;
                if (this.Accessibility_Support)
                  this.lblMVoteLight[0, index2].Text = "";
              }
              else
              {
                this.lblMVote[1, index2].Visible = false;
                this.lblMVoteLight[0, index2].Visible = false;
                if (this.Accessibility_Support)
                  this.lblMVoteLight[0, index2].Text = "";
              }
              checked { ++index2; }
            }
            while (index2 <= 19);
          }
          else
          {
            this.lblMVote[1, 10].ForeColor = color1;
            this.lblMVote[1, 19].ForeColor = color1;
          }
        }
      }
      this.lblMVote[2, 0].Text = this.strMVoteDelList[this.intMVote];
      if (this.intMVote != 0)
        this.lblMVote[5, 4].BackColor = this.ColorMainDeep;
      int num8 = Information.UBound((Array) this.datDelList);
      int index3 = 0;
      while (index3 <= num8)
      {
        if (Operators.CompareString(this.strMVoteDelList[this.intMVote], this.datDelList[index3], false) == 0)
          this.lblMVote[5, 1].Text = this.datDelStatus[index3] != 1 ? this.strMVote[5, 1] : this.strMVote[5, 7];
        checked { ++index3; }
      }
      if (this.intMVote <= this.intMReVoteMax)
      {
        int num1 = Information.UBound((Array) this.datDelList);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (this.intMVote > 0 && Operators.CompareString(this.strMVoteDelList[checked (this.intMVote - 1)], this.datDelList[index1], false) == 0 && (this.datDelStatus[index1] == 1 && Conversions.ToDouble(this.intMReVoteDelList[checked (this.intMVote - 1)]) == 1.0))
          {
            this.lblMVote[5, 0].BackColor = color6;
            this.lblMVote[5, 1].BackColor = color6;
            this.lblMVote[5, 2].BackColor = color6;
            this.lblMVote[5, 3].BackColor = color6;
            this.lblMVote[5, 4].Visible = false;
            this.lblMVote[5, 5].Visible = false;
            this.lblMVote[5, 6].Visible = true;
          }
          checked { ++index1; }
        }
      }
      else
      {
        this.lblMVote[5, 0].BackColor = color6;
        this.lblMVote[5, 1].BackColor = color6;
        this.lblMVote[5, 2].BackColor = color6;
        this.lblMVote[5, 3].BackColor = color6;
        this.lblMVote[5, 4].Visible = false;
        this.lblMVote[5, 5].Visible = false;
        this.lblMVote[5, 6].Visible = true;
        int num1 = Information.UBound((Array) this.datDelList);
        int index1 = 0;
        while (index1 <= num1)
        {
          if (Operators.CompareString(this.strMVoteDelList[checked (this.intMVote - 1)], this.datDelList[index1], false) == 0 && this.datDelStatus[index1] == 1 && Conversions.ToDouble(this.intMReVoteDelList[checked (this.intMVote - 1)]) == 1.0)
          {
            // ISSUE: variable of a reference type
            int& local;
            // ISSUE: explicit reference operation
            int num2 = checked (^(local = ref this.intMReVoteMax) + 1);
            local = num2;
          }
          checked { ++index1; }
        }
      }
    }

    public void Event_Main_ReVote_Popback()
    {
      Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Color.FromArgb(16, 69, 140);
      Color color1 = Color.FromArgb(60, 60, 60);
      Color color2 = Color.FromArgb(67, 148, 103);
      Color color3 = Color.FromArgb(240, 98, 62);
      Color color4 = Color.FromArgb(247, 209, 48);
      Color color5 = Color.FromArgb(62, 109, 181);
      Color color6 = Color.FromArgb(200, 200, 200);
      if (this.intMVote <= 0)
      {
        this.lblMVote[5, 4].BackColor = color6;
        this.intMVote = 1;
      }
      else if (this.intMVote <= 19)
      {
        this.lblMVote[1, this.intMVote].ForeColor = color6;
        this.lblMVote[1, checked (this.intMVote - 1)].ForeColor = this.ColorMain;
        this.lblMVoteLight[0, checked (this.intMVote - 1)].BackColor = color6;
        if (this.Accessibility_Support)
          this.lblMVoteLight[0, checked (this.intMVote - 1)].Text = "";
      }
      else if (this.intMVote % 10 == 0)
      {
        int index1 = 10;
        do
        {
          this.lblMVote[1, index1].Text = this.lblMVote[1, checked (index1 - 10)].Text;
          this.lblMVote[1, index1].ForeColor = color1;
          this.lblMVoteLight[0, index1].BackColor = this.lblMVoteLight[0, checked (index1 - 10)].BackColor;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, 1].Text = this.lblMVoteLight[0, checked (index1 - 10)].Text;
          this.lblMVote[1, index1].Visible = true;
          this.lblMVoteLight[0, index1].Visible = true;
          checked { ++index1; }
        }
        while (index1 <= 19);
        int index2 = 0;
        do
        {
          this.lblMVote[1, index2].Text = this.strMVoteDelList[checked (this.intMVote - 20 + index2)];
          string intMreVoteDel = this.intMReVoteDelList[checked (this.intMVote - 20 + index2)];
          Label label = this.lblMVoteLight[0, index2];
          object obj = Interaction.IIf(Operators.CompareString(intMreVoteDel, "0", false) == 0, (object) color2, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMreVoteDel, "1", false) == 0, (object) color3, RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMreVoteDel, "2", false) == 0, (object) color4, (object) color5)))));
          Color color7 = obj != null ? (Color) obj : new Color();
          label.BackColor = color7;
          if (this.Accessibility_Support)
            this.lblMVoteLight[0, index2].Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(intMreVoteDel, "0", false) == 0, (object) "+", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMreVoteDel, "1", false) == 0, (object) "-", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(intMreVoteDel, "2", false) == 0, (object) "×", (object) "/"))))));
          checked { ++index2; }
        }
        while (index2 <= 9);
        this.lblMVote[1, 19].ForeColor = this.ColorMain;
        this.lblMVoteLight[0, 19].BackColor = color6;
        if (this.Accessibility_Support)
          this.lblMVoteLight[0, 19].Text = "";
      }
      else
      {
        this.lblMVote[1, checked (unchecked (this.intMVote % 10) + 10)].ForeColor = color6;
        this.lblMVote[1, checked (unchecked (this.intMVote % 10) + 9)].ForeColor = this.ColorMain;
        this.lblMVoteLight[0, checked (unchecked (this.intMVote % 10) + 9)].BackColor = color6;
        if (this.Accessibility_Support)
          this.lblMVoteLight[0, checked (unchecked (this.intMVote % 10) + 9)].Text = "";
      }
      if (this.intMVote > 0)
        checked { --this.intMVote; }
      int num1 = Information.UBound((Array) this.datDelList);
      int index3 = 0;
      while (index3 <= num1)
      {
        if (Operators.CompareString(this.strMVoteDelList[this.intMVote], this.datDelList[index3], false) == 0)
          this.lblMVote[5, 1].Text = this.datDelStatus[index3] != 1 ? this.strMVote[5, 1] : this.strMVote[5, 7];
        checked { ++index3; }
      }
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      int num8 = 0;
      int num9 = checked (this.intMVote - 1);
      int index4 = 0;
      while (index4 <= num9)
      {
        string intMreVoteDel = this.intMReVoteDelList[index4];
        if (Operators.CompareString(intMreVoteDel, Conversions.ToString(0), false) == 0)
          checked { ++num6; }
        else if (Operators.CompareString(intMreVoteDel, Conversions.ToString(1), false) == 0)
          checked { ++num7; }
        else if (Operators.CompareString(intMreVoteDel, Conversions.ToString(2), false) == 0)
          checked { ++num8; }
        checked { ++index4; }
      }
      int intMvoteMax = this.intMVoteMax;
      int index5 = 0;
      while (index5 <= intMvoteMax)
      {
        string intMvoteDel = this.intMVoteDelList[index5];
        if (Operators.CompareString(intMvoteDel, Conversions.ToString(0), false) == 0)
          checked { ++num2; }
        else if (Operators.CompareString(intMvoteDel, Conversions.ToString(1), false) == 0)
          checked { ++num3; }
        else if (Operators.CompareString(intMvoteDel, Conversions.ToString(2), false) == 0)
          checked { ++num4; }
        else if (Operators.CompareString(intMvoteDel, Conversions.ToString(3), false) == 0)
          checked { ++num5; }
        checked { ++index5; }
      }
      if (this.intMVote > 0)
      {
        this.lblMVote[3, 4].Text = Conversions.ToString(checked (num2 + num3 + num6 + num7));
        this.lblMVote[3, 5].Text = (double) this.intMVoteMax / 5.0 != Conversion.Int((double) this.intMVoteMax / 5.0) ? Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) this.intMVoteMax / 5.0));
        this.lblMVote[3, 6].Text = Conversions.ToString(Conversion.Int((double) checked (num2 + num3 + num6 + num7) / 2.0) + 1.0);
        this.lblMVote[3, 7].Text = (double) checked (num2 + num3 + num6 + num7) / 3.0 * 2.0 != Conversion.Int((double) checked (num2 + num3 + num6 + num7) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num2 + num3 + num6 + num7) / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) checked (num2 + num3 + num6 + num7) / 3.0 * 2.0);
        this.lblMVote[4, 4].Text = Conversions.ToString(checked (num2 + num6));
        this.lblMVote[4, 5].Text = Conversions.ToString(checked (num3 + num7));
        this.lblMVote[4, 6].Text = Conversions.ToString(checked (num4 + num8));
        this.lblMVote[4, 7].Text = "-";
      }
      else
      {
        this.lblMVote[4, 4].Text = Conversions.ToString(num2);
        this.lblMVote[4, 5].Text = Conversions.ToString(num3);
        this.lblMVote[4, 6].Text = Conversions.ToString(num4);
      }
      if (this.intMVote == 0)
        this.lblMVote[5, 4].BackColor = color6;
      else
        this.lblMVote[5, 4].BackColor = this.ColorMainDeep;
    }

    public void Event_Main_Initialize()
    {
      this.pnlMainInfo.Visible = false;
      this.pnlMainLanguage.Visible = true;
      this.pnlMainLanguage.BringToFront();
      this.tmrRealTime.Interval = 50;
      this.Top = checked (-this.Height);
      this.tmrRealTime.Tick += new EventHandler(this.tmrRealTime_Tick);
      this.tmrRealTime.Start();
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void Event_Authenication_Verification()
    {
      FileStream fileStream1 = new FileStream("USAA_Gen2Library.dll", FileMode.Open, FileAccess.Read);
      byte[] numArray = new byte[1001];
      fileStream1.Read(numArray, 0, 999);
      fileStream1.Close();
      if (Operators.CompareString(BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(numArray)).Replace("-", "").ToUpper(), "C5C86911C9B0EDFFB8959EB8C7F772E9", false) != 0)
        ProjectData.EndApp();
      FileStream fileStream2;
      try
      {
        fileStream2 = File.Open("System\\Authentication.license", FileMode.Open);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        fileStream2 = File.Open("System\\Authenication.license", FileMode.OpenOrCreate);
        ProjectData.ClearProjectError();
      }
      StreamReader streamReader1 = new StreamReader((Stream) fileStream2, Encoding.UTF8);
      string empty = string.Empty;
      StreamReader streamReader2 = streamReader1;
      while (!streamReader1.EndOfStream)
        empty += streamReader1.ReadLine();
      streamReader2.Close();
      Authentication authentication = new Authentication();
      AuthenticationVerifier authenticationVerifier = new AuthenticationVerifier();
      string ParsedXML = Regex.Match(empty, "(?<=<Message>).*?(?=</Message>)", RegexOptions.IgnoreCase).Value;
      ref string local = ref ParsedXML;
      if (authenticationVerifier.DecryptandVerify(ref local))
      {
        authentication.Decoding(ParsedXML);
        if (DateTime.Compare(DateTime.Parse(authentication.TimeStart).AddDays((double) authentication.TimeSustain), DateTime.Now) < 0)
        {
          Label lblGuideline;
          string str = (lblGuideline = this.lblGuideline).Text + "× 错误 - 授权超过授权有效期，有效期至 " + Conversions.ToString(DateTime.Parse(authentication.TimeStart).AddDays((double) authentication.TimeSustain)) + "\r\n";
          lblGuideline.Text = str;
          if (this.intDecisionMagicNumber < 0)
            return;
          this.intDecisionMagicNumber = -1;
        }
        else
        {
          this.datConf[0] = authentication.MainBody;
          Label lblGuideline;
          string str = (lblGuideline = this.lblGuideline).Text + string.Format("○ 提醒 - 这份软件副本授权给 [ {0} ]，有效期至 {1}\r\n", (object) authentication.Target, (object) DateTime.Parse(authentication.TimeStart).AddDays((double) authentication.TimeSustain));
          lblGuideline.Text = str;
        }
      }
      else
      {
        Label lblGuideline;
        string str = (lblGuideline = this.lblGuideline).Text + "× 错误 - 授权文档不存在或信息不正确\r\n";
        lblGuideline.Text = str;
        if (this.intDecisionMagicNumber < 0)
          return;
        this.intDecisionMagicNumber = -1;
      }
    }

    public void Event_Authorization_Confirmation()
    {
      string[] strArray = new string[4];
      StreamReader streamReader1 = new StreamReader((Stream) File.Open("System\\Authorization.txt", FileMode.OpenOrCreate), Encoding.GetEncoding("GB2312"));
      int num = 0;
      string input = "";
      StreamReader streamReader2 = streamReader1;
      while (!streamReader1.EndOfStream)
      {
        input += streamReader2.ReadLine();
        checked { ++num; }
      }
      streamReader2.Close();
      strArray[0] = Regex.Match(input, "(?<=<Sort>).*?(?=</Sort>)", RegexOptions.IgnoreCase).Value;
      strArray[1] = Regex.Match(input, "(?<=<Target>).*?(?=</Target>)", RegexOptions.IgnoreCase).Value;
      strArray[2] = Regex.Match(input, "(?<=<Period>).*?(?=</Period>)", RegexOptions.IgnoreCase).Value;
      strArray[3] = Regex.Match(input, "(?<=<Code>).*?(?=</Code>)", RegexOptions.IgnoreCase).Value;
      if (Operators.CompareString(this.MD5(strArray[0] + "Inspire2^57,885,161-1" + strArray[1] + "Your2^37,156,667-1" + strArray[2] + "Dream2^25,964,951-1", (short) 32), strArray[3], false) == 0)
      {
        if (Conversion.Val(Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yyMM")) > Conversion.Int(Conversions.ToDouble(strArray[2]) % 1000000.0 / 100.0))
        {
          Label lblGuideline;
          string str = (lblGuideline = this.lblGuideline).Text + "× 错误 - 授权超过授权有效期\r\n";
          lblGuideline.Text = str;
          if (this.intDecisionMagicNumber < 0)
            return;
          this.intDecisionMagicNumber = -1;
        }
        else
        {
          this.datConf[0] = strArray[1];
          Label lblGuideline;
          string str = (lblGuideline = this.lblGuideline).Text + "○ 提醒 - 这份软件副本授权给 [ " + strArray[1] + " ]\r\n";
          lblGuideline.Text = str;
        }
      }
      else
      {
        Label lblGuideline;
        string str = (lblGuideline = this.lblGuideline).Text + "× 错误 - 授权文档不存在或信息不正确\r\n";
        lblGuideline.Text = str;
        if (this.intDecisionMagicNumber < 0)
          return;
        this.intDecisionMagicNumber = -1;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void Event_Environment_Check()
    {
      string str1 = "Config\\Config_Initial_Launch.txt";
      FileSystem.FileOpen(1, str1, OpenMode.Output);
      FileSystem.FileClose(1);
      MyProject.Computer.FileSystem.WriteAllText(str1, "0", true);
      this.intDecisionMagicNumber = 0;
      Label lblGuideline1;
      string str2 = (lblGuideline1 = this.lblGuideline).Text + "○ 当前版本 - 0130\r\n";
      lblGuideline1.Text = str2;
      bool flag = true;
      if (!MyProject.Computer.FileSystem.DirectoryExists("System"))
        flag = false;
      MyProject.Computer.FileSystem.DirectoryExists("Customize");
      if (!MyProject.Computer.FileSystem.DirectoryExists("Config"))
        flag = false;
      MyProject.Computer.FileSystem.DirectoryExists("Image");
      if (!MyProject.Computer.FileSystem.DirectoryExists("Record"))
        flag = false;
      if (!flag)
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "× 错误 - 软件目录不完整\r\n";
        lblGuideline2.Text = str3;
        Label lblGuideline3;
        string str4 = (lblGuideline3 = this.lblGuideline).Text + "\r\n";
        lblGuideline3.Text = str4;
        Label lblGuideline4;
        string str5 = (lblGuideline4 = this.lblGuideline).Text + "由于软件目录不完整或文件丢失，您无法使用此软件副本。\r\n请确认您的软件完好无损，您也可以通过 http://muncs.org/dl 下载最新版本软件。";
        lblGuideline4.Text = str5;
        this.btnDecision.Text = " 退出 >";
        this.intDecisionMagicNumber = -2;
      }
      this.Event_Authenication_Verification();
      if (Screen.PrimaryScreen.WorkingArea.Height > 1100)
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "△ 警告 - 未处在最佳分辨率：软件运行最佳分辨率为 1024×768\r\n";
        lblGuideline2.Text = str3;
        if (this.intDecisionMagicNumber >= 0)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.intDecisionMagicNumber) + 1);
          local = num;
        }
      }
      if (Operators.ConditionalCompareObjectEqual((object) FileSystem.Dir("C:\\Windows\\Fonts\\Digiface_Regular.ttf"), (object) null, false))
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "△ 警告 - 未安装计时器字体：计时器可能显示不正确\r\n";
        lblGuideline2.Text = str3;
        if (this.intDecisionMagicNumber >= 0)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.intDecisionMagicNumber) + 1);
          local = num;
        }
      }
      if (Operators.CompareString(this.datDelList[0], "", false) == 0)
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "△ 警告 - 未设置国家名单，点名和投票功能无法使用\r\n";
        lblGuideline2.Text = str3;
        if (this.intDecisionMagicNumber >= 0)
        {
          // ISSUE: variable of a reference type
          int& local;
          // ISSUE: explicit reference operation
          int num = checked (^(local = ref this.intDecisionMagicNumber) + 1);
          local = num;
        }
      }
      else
      {
        int num1 = Information.UBound((Array) this.datDelList);
        int index1 = 0;
        if (index1 <= num1 && this.datDelStatus[index1] == 1)
        {
          Label lblGuideline2;
          string str3 = (lblGuideline2 = this.lblGuideline).Text + "○ 提醒 - 存在具有一票否决权的席位\r\n";
          lblGuideline2.Text = str3;
        }
        int num2 = Information.UBound((Array) this.datDelList);
        int index2 = 0;
        if (index2 <= num2 && this.datDelStatus[index2] == 2)
        {
          Label lblGuideline2;
          string str3 = (lblGuideline2 = this.lblGuideline).Text + "○ 提醒 - 存在不具有投票权的席位\r\n";
          lblGuideline2.Text = str3;
        }
      }
      if (this.Accessibility_Support)
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "○ 提醒 - 已经开启了无障碍支持功能\r\n";
        lblGuideline2.Text = str3;
      }
      Label lblGuideline5;
      string str6 = (lblGuideline5 = this.lblGuideline).Text + "\r\n";
      lblGuideline5.Text = str6;
      if (this.intDecisionMagicNumber < 0)
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "由于授权信息不正确，您无法使用此软件副本。\r\n请确认授权文档已正确放置且未超过有效期，您也可以通过 http://apply.muncs.org 申请新的授权。";
        lblGuideline2.Text = str3;
      }
      else if (this.intDecisionMagicNumber > 0)
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "您的软件有 " + Conversions.ToString(this.intDecisionMagicNumber) + " 项设置没有处于推荐状态。软件将会运行，但这些错误可能影响您的正常使用。\r\n建议您关闭软件，仔细阅读《快速开始手册》并完成配置。";
        lblGuideline2.Text = str3;
      }
      else
      {
        Label lblGuideline2;
        string str3 = (lblGuideline2 = this.lblGuideline).Text + "运行环境校验正确。即将开始您的会议。";
        lblGuideline2.Text = str3;
      }
      this.btnDecision.Text = this.intDecisionMagicNumber >= 0 ? " 开始会议 >" : " 退出 >";
      if (!(this.intDecisionMagicNumber != -1 & this.intDecisionMagicNumber <= 0 & this.intDecisionMagicNumber != -2 & !this.boolISInitialLaunch))
        return;
      this.pnlGuideline.Visible = false;
    }

    public void Event_Instr_Update()
    {
    }

    public void Event_Watch_Resolution()
    {
      if (this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init == null)
        Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init, new StaticLocalInitFlag(), (StaticLocalInitFlag) null);
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init, ref lockTaken);
        if (this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init.State == (short) 0)
        {
          this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init.State = (short) 2;
          this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround = 1;
        }
        else if (this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init.State == (short) 2)
          throw new IncompleteInitialization();
      }
      finally
      {
        this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init.State = (short) 1;
        if (lockTaken)
          Monitor.Exit((object) this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround\u0024Init);
      }
      if ((uint) this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround > 0U)
      {
        this.tmrResolution = new System.Windows.Forms.Timer();
        this.tmrResolution.Interval = 40;
        this.tmrResolution.Enabled = false;
        this.tmrResolution.Tick += new EventHandler(this.tmrResolution_Tick);
        this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024W = Screen.PrimaryScreen.WorkingArea.Size;
        this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024firstround = 0;
      }
      if (!(this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024W != Screen.PrimaryScreen.WorkingArea.Size))
        return;
      this.Size = Screen.PrimaryScreen.WorkingArea.Size;
      this.Location = Screen.PrimaryScreen.WorkingArea.Location;
      this.\u0024STATIC\u0024Event_Watch_Resolution\u00242001\u0024W = Screen.PrimaryScreen.WorkingArea.Size;
    }

    private void tmrResolution_Tick(object sender, EventArgs e) => this.Event_Watch_Resolution();

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void MainForm_Unload(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.datConf[1], "", false) == 0)
        return;
      string str = "Record\\Record_" + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yy") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "MM") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "dd") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "hh") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "mm") + ".txt";
      FileSystem.FileOpen(1, str, OpenMode.Append);
      FileSystem.FileClose(1);
      MyProject.Computer.FileSystem.WriteAllText(str, "----------------------------------------\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "MUNCS Express 2\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "Record of Conference\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "-- File Info. --------------------------\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, this.datConf[0] + "\r\n" + this.datConf[1] + "\r\n" + this.datConf[2] + "\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yy/MM/dd") + " " + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "hh:mm") + "\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "-- Dialogue ----------------------------\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[4, 0].Text + "\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "-- Speakers List 1 ---------------------\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[1, 0].Text + "\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "-- Speakers List 2 ---------------------\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[1, 1].Text + "\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "-- Speakers List 3 ---------------------\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[1, 2].Text + "\r\n\r\n", true);
      MyProject.Computer.FileSystem.WriteAllText(str, "----------------------------------------", true);
      StreamReader streamReader = new StreamReader((Stream) File.Open("Config\\Config_Skin.txt", FileMode.OpenOrCreate), Encoding.UTF8);
    }

    private void btnMWidEmpty_MouseEnter(object sender, EventArgs e)
    {
      if (this.IsDraging)
        return;
      int index = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)));
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        (object) 40
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "Top", new object[1]
      {
        (object) (2.0 + 48.0 * Conversion.Int((double) index / 6.0))
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "Left", new object[1]
      {
        (object) checked (2 + 48 * unchecked (index % 6))
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "top", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "left", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "visible", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null);
      if (this.intMWid[1, index] >= 0)
      {
        this.lblMWid[4, 0].Text = this.strSMenuDesc[this.intMWid[1, index], 0];
        this.lblMWid[4, 1].Text = this.strSMenuDesc[this.intMWid[1, index], 2];
        this.lblMWid[4, 2].Text = this.strSMenuDesc[this.intMWid[1, index], 3];
        this.lblMWid[4, 3].Text = this.strSMenuDesc[this.intMWid[1, index], 4];
        this.lblMWid[4, 2].Left = checked (this.lblMWid[4, 1].Left + this.lblMWid[4, 1].Width);
      }
      this.lblMWidDrag[1].Visible = true;
      this.lblMWidDrag[1].Height = Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.lblMWidDrag[1].Width = Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.lblMWidDrag[1].Top = Conversions.ToInteger(Operators.AddObject((object) this.pnlMWid[3].Top, NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      this.lblMWidDrag[1].Left = Conversions.ToInteger(Operators.AddObject((object) this.pnlMWid[3].Left, NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      this.lblMWidDrag[1].BackgroundImage = (Image) NewLateBinding.LateGet(sender, (System.Type) null, "backgroundimage", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      this.lblMWidDrag[1].BackgroundImageLayout = ImageLayout.Stretch;
      this.lblMWidDrag[1].BringToFront();
      this.intMWidChosen = new int[2]
      {
        index,
        this.intMWid[1, index]
      };
      this.lblMWidDrag[1].Capture = true;
    }

    private void btnMWidTarget_MouseEnter(object sender, EventArgs e)
    {
      int index = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)));
      if (this.IsDraging)
        return;
      object Instance = sender;
      NewLateBinding.LateSet(Instance, (System.Type) null, "Height", new object[1]
      {
        (object) 35
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(Instance, (System.Type) null, "Width", new object[1]
      {
        (object) 35
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(Instance, (System.Type) null, "Top", new object[1]
      {
        (object) checked (10 + 42 * unchecked (index % 10))
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(Instance, (System.Type) null, "Left", new object[1]
      {
        (object) (10.0 + 45.0 * Conversion.Int((double) index / 10.0))
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "top", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "left", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "visible", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null);
      if (this.intMWid[0, index] >= 0)
      {
        this.lblMWid[4, 0].Text = this.strSMenuDesc[this.intMWid[0, index], 0];
        this.lblMWid[4, 1].Text = this.strSMenuDesc[this.intMWid[0, index], 2];
        this.lblMWid[4, 2].Text = this.strSMenuDesc[this.intMWid[0, index], 3];
        this.lblMWid[4, 3].Text = this.strSMenuDesc[this.intMWid[0, index], 4];
        this.lblMWid[4, 2].Left = checked (this.lblMWid[4, 1].Left + this.lblMWid[4, 1].Width);
      }
      this.lblMWidDrag[0].Visible = true;
      this.lblMWidDrag[0].Height = Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.lblMWidDrag[0].Width = Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      this.lblMWidDrag[0].Top = Conversions.ToInteger(Operators.AddObject((object) this.pnlMWid[2].Top, NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      this.lblMWidDrag[0].Left = Conversions.ToInteger(Operators.AddObject((object) this.pnlMWid[2].Left, NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)));
      this.lblMWidDrag[0].BackgroundImage = (Image) NewLateBinding.LateGet(sender, (System.Type) null, "backgroundimage", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      this.lblMWidDrag[0].BackgroundImageLayout = ImageLayout.Stretch;
      this.lblMWidDrag[0].BringToFront();
      this.intMWidChosen = new int[2]
      {
        index,
        this.intMWid[0, index]
      };
      this.lblMWidDrag[0].Capture = true;
    }

    private void lblMWidDrag_MouseDown(object sender, MouseEventArgs e)
    {
      int num = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      if (num == 0)
      {
        Label label = this.lblMWid[2, this.intMWidChosen[0]];
        label.Visible = true;
        label.SendToBack();
        label.Height = 35;
        label.Width = 35;
        label.Top = checked (10 + 42 * unchecked (this.intMWidChosen[0] % 10));
        label.Left = checked ((int) Math.Round(unchecked (10.0 + 45.0 * Conversion.Int((double) this.intMWidChosen[0] / 10.0))));
        this.pnlMWid[2].BackgroundImage = this.imgBackTrans[0];
        this.pnlMWid[2].BackgroundImageLayout = ImageLayout.Stretch;
        NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
        {
          (object) 35
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
        {
          (object) 35
        }, (string[]) null, (System.Type[]) null);
        this.IsDraging = true;
        NewLateBinding.LateCall(sender, (System.Type) null, "focus", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
        this.senderX = e.X;
        this.senderY = e.Y;
        num = -1;
      }
      if (num != 1)
        return;
      Label label1 = this.lblMWid[3, this.intMWidChosen[0]];
      label1.Visible = true;
      label1.SendToBack();
      label1.Height = 40;
      label1.Width = 40;
      label1.Top = checked ((int) Math.Round(unchecked (2.0 + 48.0 * Conversion.Int((double) this.intMWidChosen[0] / 6.0))));
      label1.Left = checked (2 + 48 * unchecked (this.intMWidChosen[0] % 6));
      this.pnlMWid[2].BackgroundImage = this.imgBackTrans[0];
      this.pnlMWid[2].BackgroundImageLayout = ImageLayout.Stretch;
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        (object) 35
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        (object) 35
      }, (string[]) null, (System.Type[]) null);
      this.IsDraging = true;
      NewLateBinding.LateCall(sender, (System.Type) null, "focus", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      this.senderX = e.X;
      this.senderY = e.Y;
    }

    private void lblMWidDrag_MouseMove(object sender, MouseEventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      if (this.IsDraging)
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "Left", new object[1]
        {
          Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "Left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (e.X - this.senderX))
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Top", new object[1]
        {
          Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "Top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (e.Y - this.senderY))
        }, (string[]) null, (System.Type[]) null);
        int num2 = 0;
        do
        {
          if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectLessEqual(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Left + this.lblMWid[2, num2 * 10].Left + this.lblMWid[2, num2 * 10].Width), false), Operators.CompareObjectGreaterEqual(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Left + this.lblMWid[2, num2 * 10].Left), false)), Operators.CompareObjectGreaterEqual(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) this.pnlMWid[2].Top, false)), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Top + this.pnlMWid[2].Height), false))))
          {
            int num3 = 0;
            do
            {
              if (this.intMWid[0, checked (num2 * 10 + num3)] < 0)
              {
                this.lblMWid[2, checked (num2 * 10 + num3)].Visible = true;
                this.lblMWid[2, checked (num2 * 10 + num3)].BackgroundImage = this.imgBackTrans[1];
              }
              checked { ++num3; }
            }
            while (num3 <= 9);
          }
          else
          {
            int num3 = 0;
            do
            {
              if (this.intMWid[0, checked (num2 * 10 + num3)] < 0)
              {
                this.lblMWid[2, checked (num2 * 10 + num3)].Visible = false;
                this.lblMWid[2, checked (num2 * 10 + num3)].BackgroundImage = this.imgBackTrans[1];
              }
              checked { ++num3; }
            }
            while (num3 <= 9);
          }
          checked { ++num2; }
        }
        while (num2 <= 7);
      }
      else
      {
        if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject((object) (e.X < 0), Operators.CompareObjectGreater((object) e.X, NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), false)), (object) (e.Y < 0)), Operators.CompareObjectGreater((object) e.Y, NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), false))))
          return;
        NewLateBinding.LateSet(sender, (System.Type) null, "capture", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null);
      }
    }

    private void lblMWidDrag_MouseUp(object sender, MouseEventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.IsDraging = false;
      NewLateBinding.LateSet(sender, (System.Type) null, "capture", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "visible", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null);
      this.pnlMWid[2].BackgroundImage = (Image) null;
      int num2 = 0;
      do
      {
        int num3 = 0;
        do
        {
          if (this.intMWid[0, checked (num2 * 10 + num3)] < 0)
          {
            this.lblMWid[2, checked (num2 * 10 + num3)].Visible = false;
            this.lblMWid[2, checked (num2 * 10 + num3)].BackgroundImage = this.imgBackTrans[1];
          }
          checked { ++num3; }
        }
        while (num3 <= 9);
        checked { ++num2; }
      }
      while (num2 <= 7);
      bool flag = false;
      int index1 = 0;
      do
      {
        if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectLessEqual(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Left + this.lblMWid[2, index1 * 10].Left + this.lblMWid[2, index1 * 10].Width), false), Operators.CompareObjectGreaterEqual(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Left + this.lblMWid[2, index1 * 10].Left), false)), Operators.CompareObjectGreaterEqual(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) this.pnlMWid[2].Top, false)), Operators.CompareObjectLessEqual(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Top + this.pnlMWid[2].Height), false))))
        {
          int num3 = 0;
          while (this.intMWid[0, checked (index1 * 10 + num3)] >= 0)
          {
            checked { ++num3; }
            if (num3 > 9)
              goto label_12;
          }
          this.intMWid[0, checked (index1 * 10 + num3)] = this.intMWidChosen[1];
          this.intMMenuSub[index1, checked (num3 + 1)] = this.intMWidChosen[1];
          this.intMMenuSub[index1, 0] = checked (this.intMMenuSub[index1, 0] + 1);
          this.imgMWid[2, checked (index1 * 10 + num3)] = this.imgSMenuDesc[checked ((int) Math.Round(Conversion.Val(this.strSMenuDesc[this.intMMenuSub[index1, num3 + 1], 6])))];
          this.lblMWid[2, checked (index1 * 10 + num3)].BackgroundImage = this.imgMWid[2, checked (index1 * 10 + num3)];
          this.lblMWid[2, checked (index1 * 10 + num3)].Visible = true;
          flag = true;
label_12:
          if (flag)
          {
            int num4 = checked (this.intMMenuSub[index1, 0] - 2);
            int num5 = 0;
            while (num5 <= num4)
            {
              if (this.intMWid[0, checked (index1 * 10 + num5)] == this.intMWidChosen[1])
              {
                int num6 = checked (num5 + 1);
                int num7 = checked (this.intMMenuSub[index1, 0] - 1);
                int index2 = num6;
                while (index2 <= num7)
                {
                  this.intMWid[0, checked (index1 * 10 + index2 - 1)] = this.intMWid[0, checked (index1 * 10 + index2)];
                  this.intMMenuSub[index1, index2] = this.intMMenuSub[index1, checked (index2 + 1)];
                  this.imgMWid[2, checked (index1 * 10 + index2 - 1)] = this.imgMWid[2, checked (index1 * 10 + index2)];
                  this.lblMWid[2, checked (index1 * 10 + index2 - 1)].BackgroundImage = this.imgMWid[2, checked (index1 * 10 + index2)];
                  this.lblMWid[2, checked (index1 * 10 + index2 - 1)].Visible = true;
                  checked { ++index2; }
                }
                this.intMWid[0, checked (index1 * 10 + this.intMMenuSub[index1, 0] - 1)] = -1;
                this.lblMWid[2, checked (index1 * 10 + this.intMMenuSub[index1, 0] - 1)].Visible = false;
                this.intMMenuSub[index1, this.intMMenuSub[index1, 0]] = -1;
                this.intMMenuSub[index1, 0] = checked (this.intMMenuSub[index1, 0] - 1);
                break;
              }
              checked { ++num5; }
            }
          }
        }
        checked { ++index1; }
      }
      while (index1 <= 7);
      if (num1 != 0)
        return;
      int index3 = this.intMWidChosen[0];
      if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Left + this.pnlMWid[2].Width), false), Operators.CompareObjectLess(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) this.pnlMWid[2].Left, false)), Operators.CompareObjectLess(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) this.pnlMWid[2].Top, false)), Operators.CompareObjectGreater(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (this.pnlMWid[2].Top + this.pnlMWid[2].Height), false))))
        return;
      if (index3 % 10 == 9)
      {
        this.intMWid[0, index3] = -1;
        this.imgMWid[2, index3] = (Image) null;
        this.lblMWid[2, index3].BackgroundImage = (Image) null;
        this.lblMWid[2, index3].Visible = false;
        this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), checked (unchecked (index3 % 10) + 1)] = -1;
        this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] = checked (this.intMMenuSub[(int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0))), 0] - 1);
        this.intMWidChosen[0] = -1;
      }
      else
      {
        double num3 = (double) index3;
        double num4 = Conversion.Int((double) index3 / 10.0) * 10.0 + (double) this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] - 2.0;
        for (double a = num3; a <= num4; ++a)
        {
          this.intMWid[0, checked ((int) Math.Round(a))] = this.intMWid[0, checked ((int) Math.Round(unchecked (a + 1.0)))];
          this.imgMWid[2, checked ((int) Math.Round(a))] = this.imgMWid[2, checked ((int) Math.Round(unchecked (a + 1.0)))];
          this.lblMWid[2, checked ((int) Math.Round(a))].BackgroundImage = this.imgMWid[2, checked ((int) Math.Round(a))];
          this.lblMWid[2, checked ((int) Math.Round(a))].Visible = true;
          this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), checked ((int) Math.Round(unchecked (a % 10.0 + 1.0)))] = this.intMWid[0, checked ((int) Math.Round(a))];
        }
        this.intMWid[0, checked ((int) Math.Round(unchecked (Conversion.Int((double) index3 / 10.0) * 10.0 + (double) this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] - 1.0)))] = -1;
        this.imgMWid[2, checked ((int) Math.Round(unchecked (Conversion.Int((double) index3 / 10.0) * 10.0 + (double) this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] - 1.0)))] = (Image) null;
        this.lblMWid[2, checked ((int) Math.Round(unchecked (Conversion.Int((double) index3 / 10.0) * 10.0 + (double) this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] - 1.0)))].BackgroundImage = (Image) null;
        this.lblMWid[2, checked ((int) Math.Round(unchecked (Conversion.Int((double) index3 / 10.0) * 10.0 + (double) this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] - 1.0)))].Visible = false;
        this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0]] = -1;
        this.intMMenuSub[checked ((int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0)))), 0] = checked (this.intMMenuSub[(int) Math.Round(Conversion.Int(unchecked ((double) index3 / 10.0))), 0] - 1);
        this.intMWidChosen[0] = -1;
      }
    }

    private void lblMWidDrag_MouseLeave(object sender, EventArgs e)
    {
      int num = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      if (num == 0)
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "capture", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "visible", new object[1]
        {
          (object) false
        }, (string[]) null, (System.Type[]) null);
        if (this.intMWidChosen[0] >= 0)
        {
          Label label = this.lblMWid[2, this.intMWidChosen[0]];
          label.Visible = true;
          label.Height = 35;
          label.Width = 35;
          label.Top = checked (10 + 42 * unchecked (this.intMWidChosen[0] % 10));
          label.Left = checked ((int) Math.Round(unchecked (10.0 + 45.0 * Conversion.Int((double) this.intMWidChosen[0] / 10.0))));
        }
        int index = 0;
        do
        {
          this.lblMWid[4, index].Text = "";
          checked { ++index; }
        }
        while (index <= 4);
        num = -1;
      }
      if (num != 1)
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "capture", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "visible", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null);
      Label label1 = this.lblMWid[3, this.intMWidChosen[0]];
      label1.Visible = true;
      label1.Height = 40;
      label1.Width = 40;
      label1.Top = checked ((int) Math.Round(unchecked (2.0 + 48.0 * Conversion.Int((double) this.intMWidChosen[0] / 6.0))));
      label1.Left = checked (2 + 48 * unchecked (this.intMWidChosen[0] % 6));
      int index1 = 0;
      do
      {
        this.lblMWid[4, index1].Text = "";
        checked { ++index1; }
      }
      while (index1 <= 4);
    }

    private void btnMWidTitle_MouseClick(object sender, EventArgs e)
    {
      this.datToolBoxSetting = (string) null;
      int index1 = 0;
      do
      {
        int index2 = 0;
        do
        {
          // ISSUE: variable of a reference type
          string& local;
          // ISSUE: explicit reference operation
          string str = Conversions.ToString(Operators.AddObject((object) ^(local = ref this.datToolBoxSetting), Operators.ConcatenateObject((object) this.intMMenuSub[index1, index2], Interaction.IIf(index2 == 10, (object) "", (object) ","))));
          local = str;
          checked { ++index2; }
        }
        while (index2 <= 10);
        // ISSUE: variable of a reference type
        string& local1;
        // ISSUE: explicit reference operation
        string str1 = Conversions.ToString(Operators.AddObject((object) ^(local1 = ref this.datToolBoxSetting), Interaction.IIf(index1 == 7, (object) "", (object) string.Format(";{0}", (object) Environment.NewLine))));
        local1 = str1;
        checked { ++index1; }
      }
      while (index1 <= 7);
      MyProject.Computer.FileSystem.WriteAllText("Config\\Config_Toolbox.txt", this.datToolBoxSetting, false);
      this.Event_All_Update(false, false, true);
      this.pnlMainWidget.Visible = false;
      this.pnlMainInfo.Visible = true;
      this.IsKeyMenuAvailable = true;
      if (Operators.CompareString(this.datConf[2], "", false) == 0)
      {
        this.pnlMainConference.Visible = true;
        this.pnlMainConference.BringToFront();
      }
      else
      {
        if (!this.pnlMainInfo.Visible)
          return;
        this.Event_All_Sub_Visibility_Update(true);
        this.Event_MainMenu_Visibility_Update(true);
      }
    }

    private void btnMRollCall_MouseEnter(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(114, 175, 141)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(244, 137, 110)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 4:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
      }
    }

    private void btnMRollCall_MouseLeave(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(67, 148, 103)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(240, 98, 62)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 4:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          break;
      }
    }

    private void btnMRollCall_MouseDown(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(67, 148, 103)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(240, 98, 62)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 2:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(247, 209, 48)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 3:
          object obj4 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj4 != null ? (Color) obj4 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(62, 109, 181)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 4:
          object obj5 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj5 != null ? (Color) obj5 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
      }
    }

    private void btnMRollCall_MouseUp(object sender, EventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)));
      Color color = Color.FromArgb(200, 200, 200);
      switch (num1)
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) Color.FromArgb(114, 175, 141)
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) Color.FromArgb(244, 137, 110)
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 4:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) this.ColorMain
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          break;
      }
      int num2 = num1 == 0 ? 1 : 0;
      object obj4 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      int num3 = !((obj4 != null ? (Color) obj4 : new Color()) == color) ? 1 : 0;
      if ((num2 & num3) != 0)
      {
        this.intMRollSelect = 0;
        this.Event_Main_RollCall_Refresh(false);
      }
      int num4 = num1 == 1 ? 1 : 0;
      object obj5 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      int num5 = !((obj5 != null ? (Color) obj5 : new Color()) == color) ? 1 : 0;
      if ((num4 & num5) != 0)
      {
        this.intMRollSelect = 1;
        this.Event_Main_RollCall_Refresh(false);
      }
      if (num1 == 4)
        this.Event_Main_RollCall_Popback();
      if (num1 == 5)
      {
        this.Event_MainMenu_Visibility_Update(true);
        this.Event_All_Sub_Visibility_Update(true);
        this.pnlMainRoll.Visible = false;
        this.pnlMainInfo.Visible = true;
      }
      if (num1 != 6)
        return;
      int intMroll = this.intMRoll;
      int index = 0;
      int num6;
      while (index <= intMroll)
      {
        if (this.datDelStatus[index] != 2 && Conversions.ToDouble(this.intMRollDelList[index]) == 0.0)
          checked { ++num6; }
        checked { ++index; }
      }
      this.Event_MainMenu_Visibility_Update(true);
      this.pnlMainRoll.Visible = false;
      this.pnlMainInfo.Visible = true;
      this.lblMInfo[2, 0].Text = Conversions.ToString(num6);
      this.lblMInfo[2, 1].Text = this.lblMRoll[3, 4].Text;
      this.lblMInfo[2, 2].Text = this.lblMRoll[3, 5].Text;
      this.lblMInfo[2, 3].Text = this.lblMRoll[3, 6].Text;
      this.Expression_Sentences(10, -1, this.lblMRoll[4, 4].Text, Conversions.ToString(this.intMRoll), this.lblMRoll[3, 4].Text, this.lblMRoll[3, 5].Text, this.lblMRoll[3, 6].Text);
      this.Event_All_Sub_Visibility_Update(true);
    }

    private void btnMVote_MouseEnter(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(114, 175, 141)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(244, 137, 110)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 2:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(249, 220, 100)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 3:
          object obj4 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj4 != null ? (Color) obj4 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(110, 146, 200)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 4:
          object obj5 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj5 != null ? (Color) obj5 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
      }
    }

    private void btnMVote_MouseLeave(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(67, 148, 103)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(240, 98, 62)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 2:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(247, 209, 48)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 3:
          object obj4 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj4 != null ? (Color) obj4 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb(62, 109, 181)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 4:
          object obj5 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj5 != null ? (Color) obj5 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          break;
      }
    }

    private void btnMVote_MouseDown(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(67, 148, 103)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(240, 98, 62)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 2:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(247, 209, 48)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 3:
          object obj4 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj4 != null ? (Color) obj4 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb(62, 109, 181)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 4:
          object obj5 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if ((obj5 != null ? (Color) obj5 : new Color()) == Color.FromArgb(200, 200, 200))
            break;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          break;
      }
    }

    private void btnMVote_MouseUp(object sender, EventArgs e)
    {
      int num1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)));
      Color color = Color.FromArgb(200, 200, 200);
      switch (num1)
      {
        case 0:
          object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) Color.FromArgb(114, 175, 141)
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 1:
          object obj2 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj2 != null ? (Color) obj2 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) Color.FromArgb(244, 137, 110)
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 2:
          object obj3 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj3 != null ? (Color) obj3 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) Color.FromArgb(249, 220, 100)
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 3:
          object obj4 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj4 != null ? (Color) obj4 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) Color.FromArgb(110, 146, 200)
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 4:
          object obj5 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
          if (!((obj5 != null ? (Color) obj5 : new Color()) == Color.FromArgb(200, 200, 200)))
          {
            NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
            {
              (object) this.ColorMain
            }, (string[]) null, (System.Type[]) null);
            NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
            {
              (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
            }, (string[]) null, (System.Type[]) null);
            break;
          }
          break;
        case 5:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          break;
        case 6:
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
          NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
          {
            (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
          }, (string[]) null, (System.Type[]) null);
          break;
      }
      int num2 = num1 == 0 ? 1 : 0;
      object obj6 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      int num3 = !((obj6 != null ? (Color) obj6 : new Color()) == color) ? 1 : 0;
      if ((num2 & num3) != 0)
      {
        this.intMVoteSelect = 0;
        if (this.lblMVote[5, 3].BackColor == Color.FromArgb(200, 200, 200))
          this.Event_Main_ReVote_Refresh(false);
        else
          this.Event_Main_Vote_Refresh(false);
      }
      int num4 = num1 == 1 ? 1 : 0;
      object obj7 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      int num5 = !((obj7 != null ? (Color) obj7 : new Color()) == color) ? 1 : 0;
      if ((num4 & num5) != 0)
      {
        this.intMVoteSelect = 1;
        if (this.lblMVote[5, 3].BackColor == Color.FromArgb(200, 200, 200))
          this.Event_Main_ReVote_Refresh(false);
        else
          this.Event_Main_Vote_Refresh(false);
      }
      int num6 = num1 == 2 ? 1 : 0;
      object obj8 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      int num7 = !((obj8 != null ? (Color) obj8 : new Color()) == color) ? 1 : 0;
      if ((num6 & num7) != 0)
      {
        this.intMVoteSelect = 2;
        if (this.lblMVote[5, 3].BackColor == Color.FromArgb(200, 200, 200))
          this.Event_Main_ReVote_Refresh(false);
        else
          this.Event_Main_Vote_Refresh(false);
      }
      int num8 = num1 == 3 ? 1 : 0;
      object obj9 = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      int num9 = !((obj9 != null ? (Color) obj9 : new Color()) == color) ? 1 : 0;
      if ((num8 & num9) != 0)
      {
        this.intMVoteSelect = 3;
        if (this.lblMVote[5, 3].BackColor == Color.FromArgb(200, 200, 200))
          this.Event_Main_ReVote_Refresh(false);
        else
          this.Event_Main_Vote_Refresh(false);
      }
      if (num1 == 4)
      {
        if (this.lblMVote[5, 3].BackColor == Color.FromArgb(200, 200, 200))
          this.Event_Main_ReVote_Popback();
        else
          this.Event_Main_Vote_Popback();
      }
      if (num1 == 5)
      {
        this.Event_MainMenu_Visibility_Update(true);
        this.Event_All_Sub_Visibility_Update(true);
        this.pnlMainVote.Visible = false;
        this.pnlMainInfo.Visible = true;
      }
      if (num1 != 6)
        return;
      if (this.lblMVoteLight[2, 3].Visible)
      {
        if (this.intMVote <= this.intMVoteMax)
        {
          this.Expression_Sentences(11, -1, this.lblMVote[4, 4].Text, this.lblMVote[4, 5].Text, this.lblMVote[4, 6].Text, "", "");
          this.Expression_Sentences(11, 2, this.strMVoteDelList[checked (this.intMVote - 1)], "", "", "", "");
          this.Event_All_Sub_Visibility_Update(true);
        }
        else
        {
          this.Expression_Sentences(11, -1, this.lblMVote[4, 4].Text, this.lblMVote[4, 5].Text, this.lblMVote[4, 6].Text, "", "");
          if (Conversion.Val(this.lblMVote[4, 4].Text) >= Conversion.Val(this.lblMVote[3, 7].Text))
            this.Expression_Sentences(11, 0, this.lblMVote[0, 0].Text, "", "", "", "");
          else
            this.Expression_Sentences(11, 1, this.lblMVote[0, 0].Text, "", "", "", "");
          this.Event_All_Sub_Visibility_Update(true);
        }
      }
      else if (!this.lblMVoteLight[2, 3].Visible)
      {
        if (this.intMVote <= this.intMReVoteMax)
        {
          this.Expression_Sentences(11, -1, this.lblMVote[4, 4].Text, this.lblMVote[4, 5].Text, this.lblMVote[4, 6].Text, "", "");
          this.Expression_Sentences(11, 2, this.strMVoteDelList[checked (this.intMVote - 1)], "", "", "", "");
          this.Event_All_Sub_Visibility_Update(true);
        }
        else
        {
          this.Expression_Sentences(11, -1, this.lblMVote[4, 4].Text, this.lblMVote[4, 5].Text, this.lblMVote[4, 6].Text, "", "");
          if (Conversion.Val(this.lblMVote[4, 4].Text) >= Conversion.Val(this.lblMVote[3, 7].Text))
            this.Expression_Sentences(11, 0, this.lblMVote[0, 0].Text, "", "", "", "");
          else
            this.Expression_Sentences(11, 1, this.lblMVote[0, 0].Text, "", "", "", "");
          this.Event_All_Sub_Visibility_Update(true);
        }
      }
      this.Event_MainMenu_Visibility_Update(true);
      this.pnlMainVote.Visible = false;
      this.pnlMainInfo.Visible = true;
      this.Event_All_Sub_Visibility_Update(true);
    }

    private void btnMBac_MouseEnter(object sender, EventArgs e)
    {
      int num = checked (this.SkinAmount - 1);
      int index = 0;
      while (index <= num)
      {
        Label label = this.lblMBac[1, index];
        label.Height = 60;
        label.Width = 100;
        label.Top = checked ((int) Math.Round(unchecked (Conversion.Int((double) index / 6.0) * (double) checked (label.Height + 10) + 20.0)));
        label.Left = checked (unchecked (index % 6) * 110 + 90);
        checked { ++index; }
      }
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "top", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "left", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnMBac_MouseLeave(object sender, EventArgs e)
    {
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "top", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "left", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 2)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnMBac_MouseDown(object sender, EventArgs e)
    {
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 8)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 8)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "top", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "left", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnMBac_MouseUp(object sender, EventArgs e)
    {
      int Skin = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)));
      NewLateBinding.LateSet(sender, (System.Type) null, "height", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 8)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "width", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(sender, (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 8)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "top", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "left", new object[1]
      {
        Operators.SubtractObject(NewLateBinding.LateGet(sender, (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 4)
      }, (string[]) null, (System.Type[]) null);
      this.Parameter_Skin(Skin);
      MyProject.Computer.FileSystem.WriteAllText("Config\\Config_Skin.txt", "1\r\n" + Conversions.ToString(Skin), false);
      this.Event_All_Update(false, true, false);
      if (this.pnlMainInfo.Visible & (uint) Operators.CompareString(this.datConf[2], "", false) > 0U)
      {
        this.Event_All_Sub_Visibility_Update(true);
        this.Event_MainMenu_Visibility_Update(true);
      }
      this.pnlMainBackground.Visible = false;
      this.pnlMainInfo.Visible = true;
      this.Event_All_Sub_Visibility_Update(true);
      this.Event_MainMenu_Visibility_Update(true);
    }

    private void btnMMenu_MouseEnter(object sender, EventArgs e)
    {
      string[] strArray = new string[10];
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      int index1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.intMMenuActive = index1;
      Panel pnlMmenuSub = this.pnlMMenuSub;
      pnlMmenuSub.Visible = true;
      pnlMmenuSub.BringToFront();
      pnlMmenuSub.Height = checked (25 * this.intMMenuSub[index1, 0]);
      pnlMmenuSub.Top = checked (this.Height - this.pnlMainMenu.Height - pnlMmenuSub.Height);
      int num = checked (this.intMMenuSub[index1, 0] - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        this.btnMMenuSub[index2].Visible = true;
        this.btnMMenuSubDeco[index2].Visible = true;
        this.btnMMenuSub[index2].BackColor = this.ColorMain;
        this.btnMMenuSubDeco[index2].BackColor = this.ColorMain;
        try
        {
          strArray[index2] = " " + this.strSMenuTitle[this.intMMenuSub[index1, checked (index2 + 1)]];
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.btnMMenuSub[index2].Text = strArray[index2];
        this.btnMMenuSub[index2].Top = checked (25 * index2);
        this.btnMMenuSubDeco[index2].Top = checked (25 * index2);
        checked { ++index2; }
      }
      int index3 = this.intMMenuSub[index1, 0];
      while (index3 <= 9)
      {
        this.btnMMenuSub[index3].Visible = false;
        this.btnMMenuSubDeco[index3].Visible = false;
        checked { ++index3; }
      }
    }

    private void btnMMenu_MouseLeave(object sender, EventArgs e)
    {
      this.Capture = true;
      Control TopControl = (Control) this;
      Control youngestChildUnderMouse = MainForm.GetYoungestChildUnderMouse(ref TopControl);
      this.Capture = false;
      if (youngestChildUnderMouse != null)
      {
        try
        {
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.StrReverse(youngestChildUnderMouse.Name.ToString()).Substring(checked (youngestChildUnderMouse.Name.ToString().Length - 11)), Microsoft.VisualBasic.Strings.StrReverse("btnMMenuSub"), false) == 0)
            return;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          this.pnlMMenuSub.Visible = false;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
        {
          (object) this.ColorMainDeep
        }, (string[]) null, (System.Type[]) null);
        this.pnlMMenuSub.Visible = false;
      }
    }

    private void btnMMenuSub_MouseEnter(object sender, EventArgs e)
    {
      int index = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.btnMMenuSub[index].BackColor = this.ColorMainDeep;
      this.btnMMenuSubDeco[index].BackColor = this.ColorMainDeep;
    }

    private void btnMMenuSub_MouseLeave(object sender, EventArgs e)
    {
      int index = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.btnMMenuSub[index].BackColor = this.ColorMain;
      this.btnMMenuSubDeco[index].BackColor = this.ColorMain;
      this.Capture = true;
      Control TopControl = (Control) this;
      Control youngestChildUnderMouse = MainForm.GetYoungestChildUnderMouse(ref TopControl);
      this.Capture = false;
      try
      {
        if (youngestChildUnderMouse != null)
        {
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.StrReverse(youngestChildUnderMouse.Name.ToString()).Substring(checked (youngestChildUnderMouse.Name.ToString().Length - 11)), Microsoft.VisualBasic.Strings.StrReverse("btnMMenuSub"), false) == 0)
            return;
          NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "visible", new object[1]
          {
            (object) false
          }, (string[]) null, (System.Type[]) null, false, true);
          this.btnMMenu[this.intMMenuActive].BackColor = this.ColorMainDeep;
          this.intMMenuActive = -1;
        }
        else
        {
          NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "visible", new object[1]
          {
            (object) false
          }, (string[]) null, (System.Type[]) null, false, true);
          this.btnMMenu[this.intMMenuActive].BackColor = this.ColorMainDeep;
          this.intMMenuActive = -1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void btnMMenuSub_MouseClick(object sender, EventArgs e)
    {
      int intRefreshing = this.intMMenuSub[this.intMMenuActive, checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)) + 1)];
      this.pnlSubMenu[intRefreshing].Visible = true;
      this.pnlSubMenu[intRefreshing].BringToFront();
      this.IsSubVisible[intRefreshing] = true;
      this.Scene_SubMenu_Update_II(true, intRefreshing);
      int num1 = Information.UBound((Array) this.pnlSubMenu);
      int index = 0;
      while (index <= num1)
      {
        this.Func_PaintBackColor((Control) this.pnlSubMenu[index], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
        this.Func_PaintForeColor((Control) this.pnlSubMenu[index], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
        checked { ++index; }
      }
      int num2 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.Func_PaintBackColor((Control) this.pnlSubMenu[intRefreshing], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
      this.Func_PaintForeColor((Control) this.pnlSubMenu[intRefreshing], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
      this.pnlMMenuSub.Visible = false;
      this.btnMMenu[this.intMMenuActive].BackColor = this.ColorMainDeep;
      this.intMMenuActive = -1;
    }

    private void btnKeyMenu_MouseEnter(object sender, EventArgs e)
    {
      string[] strArray = new string[10];
      if (!this.IsKeyMenuAvailable)
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      this.intMMenuActive = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      Panel pnlMainKeyMenu = this.pnlMainKeyMenu;
      pnlMainKeyMenu.Visible = true;
      pnlMainKeyMenu.BringToFront();
    }

    private void btnKeyMenu_MouseLeave(object sender, EventArgs e)
    {
      this.Capture = true;
      Control TopControl = (Control) this;
      Control youngestChildUnderMouse = MainForm.GetYoungestChildUnderMouse(ref TopControl);
      this.Capture = false;
      if (youngestChildUnderMouse != null)
      {
        try
        {
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.StrReverse(youngestChildUnderMouse.Name.ToString()).Substring(checked (youngestChildUnderMouse.Name.ToString().Length - 11)), Microsoft.VisualBasic.Strings.StrReverse("lblMKeyMenu"), false) == 0)
            return;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMainDeep
          }, (string[]) null, (System.Type[]) null);
          this.pnlMainKeyMenu.Visible = false;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
        {
          (object) this.ColorMainDeep
        }, (string[]) null, (System.Type[]) null);
        this.pnlMainKeyMenu.Visible = false;
      }
    }

    private void btnKeyMenuSub_MouseEnter(object sender, EventArgs e)
    {
      int index = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.lblMKeyMenu[index].BackColor = this.ColorMainDeep;
      this.lblMKeyMenuDeco[index].BackColor = this.ColorMainDeep;
    }

    private void btnKeyMenuSub_MouseLeave(object sender, EventArgs e)
    {
      int index = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.lblMKeyMenu[index].BackColor = this.ColorMain;
      this.lblMKeyMenuDeco[index].BackColor = this.ColorMain;
      this.Capture = true;
      Control TopControl = (Control) this;
      Control youngestChildUnderMouse = MainForm.GetYoungestChildUnderMouse(ref TopControl);
      this.Capture = false;
      try
      {
        if (youngestChildUnderMouse != null)
        {
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.StrReverse(youngestChildUnderMouse.Name.ToString()).Substring(checked (youngestChildUnderMouse.Name.ToString().Length - 11)), Microsoft.VisualBasic.Strings.StrReverse("lblMKeyMenu"), false) == 0)
            return;
          NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "visible", new object[1]
          {
            (object) false
          }, (string[]) null, (System.Type[]) null, false, true);
          this.lblInstr[0].BackColor = this.ColorMainDeep;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
        }
        else
        {
          NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "visible", new object[1]
          {
            (object) false
          }, (string[]) null, (System.Type[]) null, false, true);
          this.lblInstr[0].BackColor = this.ColorMainDeep;
          NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
          {
            (object) this.ColorMain
          }, (string[]) null, (System.Type[]) null);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void btnKeyMenuSub_MouseClick(object sender, EventArgs e)
    {
      int num = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.pnlMainKeyMenu.Visible = false;
      NewLateBinding.LateSet(sender, (System.Type) null, "BackColor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      this.lblInstr[0].BackColor = this.ColorMainDeep;
      this.intMMenuActive = -1;
      switch (num)
      {
        case 0:
          this.Cursor = Cursors.WaitCursor;
          this.pnlMainLanguage.Visible = false;
          this.pnlMainBackground.Visible = false;
          this.pnlMainWidget.Visible = false;
          this.pnlMainInfo.Visible = false;
          this.Event_MainMenu_Visibility_Update(false);
          this.Event_All_Sub_Visibility_Update(false);
          this.pnlMainBackground.Visible = true;
          this.pnlMainBackground.BringToFront();
          this.Cursor = Cursors.Arrow;
          break;
        case 1:
          this.Cursor = Cursors.WaitCursor;
          this.pnlMainLanguage.Visible = false;
          this.pnlMainBackground.Visible = false;
          this.pnlMainWidget.Visible = false;
          this.pnlMainInfo.Visible = false;
          this.Event_MainMenu_Visibility_Update(false);
          this.Event_All_Sub_Visibility_Update(false);
          this.pnlMainLanguage.Visible = true;
          this.pnlMainLanguage.BringToFront();
          this.Cursor = Cursors.Arrow;
          break;
        case 2:
          this.Cursor = Cursors.WaitCursor;
          this.pnlMainLanguage.Visible = false;
          this.pnlMainBackground.Visible = false;
          this.pnlMainWidget.Visible = false;
          this.pnlMainInfo.Visible = false;
          this.Event_MainMenu_Visibility_Update(false);
          this.Event_All_Sub_Visibility_Update(false);
          this.Event_Main_Widget_Empty_Temp();
          this.Scene_Main_Widget_Update(true, true, true);
          this.pnlMainWidget.Visible = true;
          this.pnlMainWidget.BringToFront();
          this.Cursor = Cursors.Arrow;
          break;
        case 4:
          if (Operators.CompareString(this.datConf[1], "", false) != 0)
          {
            string str = "Record\\Record_" + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yy") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "MM") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "dd") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "hh") + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "mm") + ".txt";
            FileSystem.FileOpen(1, str, OpenMode.Append);
            FileSystem.FileClose(1);
            MyProject.Computer.FileSystem.WriteAllText(str, "----------------------------------------\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "MUNCS Express 2\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "Record of Conference\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "-- File Info. --------------------------\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, this.datConf[0] + "\r\n" + this.datConf[1] + "\r\n" + this.datConf[2] + "\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "yy/MM/dd") + " " + Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "hh:mm") + "\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "-- Dialogue ----------------------------\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[4, 0].Text + "\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "-- Speakers List 1 ---------------------\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[1, 0].Text + "\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "-- Speakers List 2 ---------------------\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[1, 1].Text + "\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "-- Speakers List 3 ---------------------\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, this.txtMInfo[1, 2].Text + "\r\n\r\n", true);
            MyProject.Computer.FileSystem.WriteAllText(str, "----------------------------------------", true);
          }
          ProjectData.EndApp();
          break;
      }
    }

    private void lblMInfoMark_MouseEnter(object sender, EventArgs e)
    {
      int index = 5;
      do
      {
        if (!(this.lblMInfo[1, index].BackColor == this.ColorMainDeep))
          this.lblMInfo[1, index].BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        checked { ++index; }
      }
      while (index <= 15);
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!((obj != null ? (Color) obj : new Color()) == Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
    }

    private void lblMInfoMark_MouseLeave(object sender, EventArgs e)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if ((obj != null ? (Color) obj : new Color()) == this.ColorMainDeep)
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
    }

    private void lblMInfoMark_MouseClick(object sender, EventArgs e)
    {
      int index = 5;
      do
      {
        object obj = NewLateBinding.LateGet(sender, (System.Type) null, "BackColor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
        if (!((obj != null ? (Color) obj : new Color()) == this.ColorMainDeep))
          this.lblMInfo[1, index].BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        checked { ++index; }
      }
      while (index <= 15);
      object obj1 = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if ((obj1 != null ? (Color) obj1 : new Color()) == Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue))
        NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
        {
          (object) this.ColorMainDeep
        }, (string[]) null, (System.Type[]) null);
      else
        NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
        {
          (object) this.ColorMain
        }, (string[]) null, (System.Type[]) null);
    }

    private void btnInitiateModerator_Click(object sender, EventArgs e)
    {
      NewLateBinding.LateSet(sender, (System.Type) null, "Backcolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "Forecolor", new object[1]
      {
        (object) Color.White
      }, (string[]) null, (System.Type[]) null);
      SpeakersListSource speakersListSource = new SpeakersListSource();
      int index1 = 0;
      while (!this.txtMInfo[1, index1].Visible)
      {
        checked { ++index1; }
        if (index1 > 2)
          return;
      }
      if (string.IsNullOrEmpty(this.txtMInfo[1, index1].Text))
        return;
      speakersListSource.Topic = this.CurrentTopic;
      speakersListSource.SubTopic = string.Empty;
      speakersListSource.TotalTime = Conversions.ToInteger(this.intMInfoCounter[2].ToString());
      speakersListSource.Time = Conversions.ToInteger(this.intMInfoCounter[3].ToString());
      string[] lines = this.txtMInfo[1, index1].Lines;
      ArrayList arrayList = new ArrayList();
      string[] strArray = lines;
      int index2 = 0;
      while (index2 < strArray.Length)
      {
        string str = strArray[index2];
        if (!string.IsNullOrEmpty(str))
          arrayList.Add((object) str);
        checked { ++index2; }
      }
      speakersListSource.Speakers = arrayList;
      string str1 = JsonConvert.SerializeObject((object) speakersListSource);
      using (StreamWriter streamWriter = new StreamWriter("Config\\Moderator_Tube.txt", false, Encoding.UTF8))
        streamWriter.Write(str1);
      try
      {
        new Process()
        {
          StartInfo = {
            FileName = "Express Moderator.exe"
          },
          EnableRaisingEvents = true
        }.Start();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Console.WriteLine("An error occurred!!!: " + ex.Message);
        ProjectData.ClearProjectError();
      }
    }

    private void Panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void btnMInfoCounter_MouseEnter(object sender, EventArgs e)
    {
      int index = 0;
      do
      {
        this.btnMInfo[0, index].BackColor = this.ColorMain;
        this.btnMInfo[0, index].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        this.btnMInfo[0, index].Visible = true;
        this.btnMInfo[0, index].BringToFront();
        checked { ++index; }
      }
      while (index <= 3);
    }

    private void btnMInfoCounter_MouseLeave(object sender, EventArgs e)
    {
      this.Capture = true;
      Control TopControl = (Control) this;
      Control youngestChildUnderMouse = MainForm.GetYoungestChildUnderMouse(ref TopControl);
      this.Capture = false;
      if (youngestChildUnderMouse != null)
      {
        try
        {
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.StrReverse(youngestChildUnderMouse.Name.ToString()).Substring(checked (youngestChildUnderMouse.Name.ToString().Length - 8)), Microsoft.VisualBasic.Strings.StrReverse("btnMInfo"), false) == 0)
            return;
          int index = 0;
          do
          {
            this.btnMInfo[0, index].Visible = false;
            checked { ++index; }
          }
          while (index <= 3);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else
      {
        int index = 0;
        do
        {
          this.btnMInfo[0, index].Visible = false;
          checked { ++index; }
        }
        while (index <= 3);
      }
    }

    private void btnMInfoCounterSub_MouseEnter(object sender, EventArgs e) => this.btnMInfo[0, checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)))].BackColor = this.ColorMainDeep;

    private void btnMInfoCounterSub_MouseLeave(object sender, EventArgs e)
    {
      this.btnMInfo[0, checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)))].BackColor = this.ColorMain;
      this.Capture = true;
      Control TopControl = (Control) this;
      Control youngestChildUnderMouse = MainForm.GetYoungestChildUnderMouse(ref TopControl);
      this.Capture = false;
      try
      {
        if (youngestChildUnderMouse != null)
        {
          if (Operators.CompareString(Microsoft.VisualBasic.Strings.StrReverse(youngestChildUnderMouse.Name.ToString()).Substring(checked (youngestChildUnderMouse.Name.ToString().Length - 8)), Microsoft.VisualBasic.Strings.StrReverse("btnMInfo"), false) == 0)
            return;
          int index = 0;
          do
          {
            this.btnMInfo[0, index].Visible = false;
            checked { ++index; }
          }
          while (index <= 3);
        }
        else
        {
          int index = 0;
          do
          {
            this.btnMInfo[0, index].Visible = false;
            checked { ++index; }
          }
          while (index <= 3);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void btnMInfoCounterSub_MouseClick(object sender, EventArgs e)
    {
      int num = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.pnlMainKeyMenu.Visible = false;
      NewLateBinding.LateSet(sender, (System.Type) null, "BackColor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      this.lblInstr[0].BackColor = this.ColorMainDeep;
      this.intMMenuActive = -1;
      switch (num)
      {
        case 0:
          this.Cursor = Cursors.WaitCursor;
          this.pnlMainLanguage.Visible = false;
          this.pnlMainBackground.Visible = false;
          this.pnlMainWidget.Visible = false;
          this.Event_MainMenu_Visibility_Update(false);
          this.Event_All_Sub_Visibility_Update(false);
          this.pnlMainBackground.Visible = true;
          this.pnlMainBackground.BringToFront();
          this.Cursor = Cursors.Arrow;
          break;
        case 1:
          this.Cursor = Cursors.WaitCursor;
          this.pnlMainLanguage.Visible = false;
          this.pnlMainBackground.Visible = false;
          this.pnlMainWidget.Visible = false;
          this.Event_MainMenu_Visibility_Update(false);
          this.Event_All_Sub_Visibility_Update(false);
          this.pnlMainLanguage.Visible = true;
          this.pnlMainLanguage.BringToFront();
          this.Cursor = Cursors.Arrow;
          break;
        case 2:
          this.Cursor = Cursors.WaitCursor;
          this.pnlMainLanguage.Visible = false;
          this.pnlMainBackground.Visible = false;
          this.pnlMainWidget.Visible = false;
          this.Event_MainMenu_Visibility_Update(false);
          this.Event_All_Sub_Visibility_Update(false);
          this.Event_Main_Widget_Empty_Temp();
          this.Scene_Main_Widget_Update(true, true, true);
          this.pnlMainWidget.Visible = true;
          this.pnlMainWidget.BringToFront();
          this.Cursor = Cursors.Arrow;
          break;
        case 4:
          ProjectData.EndApp();
          break;
      }
    }

    private void SubMenu_MouseDown(object sender, EventArgs e)
    {
      string[] strArray = new string[2];
      try
      {
        NewLateBinding.LateCall(sender, (System.Type) null, "focus", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      Control control = (Control) sender;
      while (Operators.CompareString(Microsoft.VisualBasic.Strings.Split(control.Name.ToString(), "(")[0], "pnlSubMenu", false) != 0)
        control = control.Parent;
      control.BringToFront();
      int num = Information.UBound((Array) this.pnlSubMenu);
      int index1 = 0;
      while (index1 <= num)
      {
        this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
        this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
        checked { ++index1; }
      }
      int index2 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
      this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
    }

    private void SubMenuTitle_MouseDown(object sender, MouseEventArgs e)
    {
      NewLateBinding.LateCall(sender, (System.Type) null, "Focus", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
      this.IsDraging = true;
      this.senderX = e.X;
      this.senderY = e.Y;
    }

    private void SubMenuTitle_MouseMove(object sender, MouseEventArgs e)
    {
      if (!this.IsDraging)
        return;
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Left", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (e.X - this.senderX))
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Top", new object[1]
      {
        Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) checked (e.Y - this.senderY))
      }, (string[]) null, (System.Type[]) null, false, true);
    }

    private void SubMenuTitle_MouseUp(object sender, MouseEventArgs e)
    {
      this.IsDraging = false;
      if (Operators.ConditionalCompareObjectGreater(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (object) checked (this.Height - this.pnlMainMenu.Height), false))
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "top", new object[1]
        {
          Operators.SubtractObject((object) checked (this.Height - this.pnlMainMenu.Height), NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))
        }, (string[]) null, (System.Type[]) null, false, true);
      if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 0, false))
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "top", new object[1]
        {
          (object) 0
        }, (string[]) null, (System.Type[]) null, false, true);
      if (Operators.ConditionalCompareObjectGreater(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), (object) this.Width, false))
        NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "left", new object[1]
        {
          Operators.SubtractObject((object) this.Width, NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))
        }, (string[]) null, (System.Type[]) null, false, true);
      if (!Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) 0, false))
        return;
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "left", new object[1]
      {
        (object) 0
      }, (string[]) null, (System.Type[]) null, false, true);
    }

    private void txtSMenuAnswer_GotFocus(object sender, EventArgs e)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "forecolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!((obj != null ? (Color) obj : new Color()) == Color.FromArgb(171, 171, 171)))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "text", new object[1]
      {
        (object) ""
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
      {
        (object) Color.FromArgb(90, 90, 90)
      }, (string[]) null, (System.Type[]) null);
    }

    private void txtSMenuAnswer_LostFocus(object sender, EventArgs e)
    {
      string[] strArray1 = new string[2];
      string[] strArray2 = Microsoft.VisualBasic.Strings.Split(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString(), ",");
      strArray2[0] = strArray2[0] + ")";
      strArray2[1] = "(" + strArray2[1];
      int index1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(strArray2[0], "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      int index2 = checked ((int) Math.Round(Conversion.Val(Regex.Match(strArray2[1], "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) this.lblSMenuCaption[index1, index2].Text, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(sender, (System.Type) null, "text", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) "", false))))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "text", new object[1]
      {
        (object) this.lblSMenuCaption[index1, index2].Text
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
      {
        (object) Color.FromArgb(171, 171, 171)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnSMenuFormalBtn_MouseEnter(object sender, EventArgs e)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "Backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if ((obj != null ? (Color) obj : new Color()) == Color.FromArgb(171, 171, 171))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "Backcolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "Forecolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnSMenuFormalBtn_MouseLeave(object sender, EventArgs e)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "Backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if ((obj != null ? (Color) obj : new Color()) == Color.FromArgb(171, 171, 171))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "Backcolor", new object[1]
      {
        (object) this.ColorMainDeep
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "Forecolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnSMenuFormalBtn_MouseDown(object sender, EventArgs e)
    {
      int num = Information.UBound((Array) this.pnlSubMenu);
      int index1 = 0;
      while (index1 <= num)
      {
        this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
        this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
        checked { ++index1; }
      }
      int index2 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
      this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
      NewLateBinding.LateSet(sender, (System.Type) null, "Backcolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "Forecolor", new object[1]
      {
        (object) this.ColorMainDeep
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnSMenuFormalBtn_MouseUp(object sender, EventArgs e)
    {
      string[] strArray1 = new string[2];
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "Backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!((obj != null ? (Color) obj : new Color()) == Color.FromArgb(171, 171, 171)))
      {
        NewLateBinding.LateSet(sender, (System.Type) null, "Backcolor", new object[1]
        {
          (object) this.ColorMain
        }, (string[]) null, (System.Type[]) null);
        NewLateBinding.LateSet(sender, (System.Type) null, "Forecolor", new object[1]
        {
          (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
        }, (string[]) null, (System.Type[]) null);
      }
      string[] strArray2 = Microsoft.VisualBasic.Strings.Split(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null).ToString().Replace(",", "("), "(", 3);
      if (Operators.CompareString(strArray2[0], "btnSMenuClose", false) == 0)
      {
        this.Event_SubMenu_Close(RuntimeHelpers.GetObjectValue(sender));
      }
      else
      {
        if (Operators.CompareString(strArray2[0], "btnSMenuFormalBtn", false) != 0)
          return;
        if (Conversion.Val(strArray2[1]) == 0.0 & this.txtSMenuAnswer[0, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[0, 1].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[0, 2].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[0, 3].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[0, 2].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[0, 3].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[0, 2].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[0, 3].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            this.Expression_Sentences(0, -1, this.txtSMenuAnswer[0, 0].Text, this.txtSMenuAnswer[0, 1].Text, this.txtSMenuAnswer[0, 2].Text, this.txtSMenuAnswer[0, 3].Text, "");
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            {
              this.tmrMainCounter.Stop();
              this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
              this.Expression_Sentences(0, 0, "", "", "", "", "");
              this.pnlSubMenu[0].Visible = false;
              this.Scene_SubMenu_Update_II(true, 13);
              this.pnlSubMenu[13].Visible = true;
              this.IsSubVisible[13] = true;
              this.pnlSubMenu[13].BringToFront();
              this.pnlSubMenu[13].Focus();
              int num2 = Information.UBound((Array) this.pnlSubMenu);
              int index1 = 0;
              while (index1 <= num2)
              {
                this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
                this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
                checked { ++index1; }
              }
              int index2 = 13;
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
              this.IsSubVisible[0] = false;
            }
          }
          else if (num1 == 1.0 && this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.Expression_Sentences(0, 1, "", "", "", "", "");
            this.pnlSubMenu[0].Visible = false;
            this.IsSubVisible[0] = false;
          }
        }
        if (Conversion.Val(strArray2[1]) == 1.0 & this.txtSMenuAnswer[1, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[1, 1].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[1, 1].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[1, 1].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[1, 1].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[1, 1].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            this.Expression_Sentences(1, -1, this.txtSMenuAnswer[1, 0].Text, this.txtSMenuAnswer[1, 1].Text, "", "", "");
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            {
              this.tmrMainCounter.Stop();
              this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
              this.Expression_Sentences(1, 0, "", "", "", "", "");
              this.pnlSubMenu[1].Visible = false;
              this.Scene_SubMenu_Update_II(true, 13);
              this.pnlSubMenu[13].Visible = true;
              this.IsSubVisible[13] = true;
              this.pnlSubMenu[13].BringToFront();
              this.pnlSubMenu[13].Focus();
              int num2 = Information.UBound((Array) this.pnlSubMenu);
              int index1 = 0;
              while (index1 <= num2)
              {
                this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
                this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
                checked { ++index1; }
              }
              int index2 = 13;
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
              this.IsSubVisible[1] = false;
            }
          }
          else if (num1 == 1.0 && this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.Expression_Sentences(1, 1, "", "", "", "", "");
            this.pnlSubMenu[1].Visible = false;
            this.IsSubVisible[1] = false;
          }
        }
        if (Conversion.Val(strArray2[1]) == 2.0 & this.txtSMenuAnswer[2, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(2, -1, this.txtSMenuAnswer[2, 0].Text, "", "", "", "");
          double num = Conversion.Val(strArray2[2]);
          if (num == 0.0)
          {
            this.Expression_Sentences(2, 0, "", "", "", "", "");
            this.pnlSubMenu[2].Visible = false;
          }
          else if (num == 1.0)
          {
            this.Expression_Sentences(2, 1, "", "", "", "", "");
            this.pnlSubMenu[2].Visible = false;
          }
          this.IsSubVisible[2] = false;
        }
        if (Conversion.Val(strArray2[1]) == 3.0 & this.txtSMenuAnswer[3, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(3, -1, this.txtSMenuAnswer[3, 0].Text, "", "", "", "");
          double num = Conversion.Val(strArray2[2]);
          if (num == 0.0)
          {
            this.Expression_Sentences(3, 0, "", "", "", "", "");
            this.pnlSubMenu[3].Visible = false;
          }
          else if (num == 1.0)
          {
            this.Expression_Sentences(3, 1, "", "", "", "", "");
            this.pnlSubMenu[3].Visible = false;
          }
          this.IsSubVisible[3] = false;
        }
        if (Conversion.Val(strArray2[1]) == 4.0 & this.txtSMenuAnswer[4, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(4, -1, this.txtSMenuAnswer[4, 0].Text, "", "", "", "");
          double num = Conversion.Val(strArray2[2]);
          if (num == 0.0)
          {
            this.Expression_Sentences(4, 0, "", "", "", "", "");
            this.pnlSubMenu[4].Visible = false;
          }
          else if (num == 1.0)
          {
            this.Expression_Sentences(4, 1, "", "", "", "", "");
            this.pnlSubMenu[4].Visible = false;
          }
          this.IsSubVisible[4] = false;
        }
        if (Conversion.Val(strArray2[1]) == 5.0 & this.txtSMenuAnswer[5, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(5, -1, this.txtSMenuAnswer[5, 0].Text, "", "", "", "");
          double num = Conversion.Val(strArray2[2]);
          if (num == 0.0)
          {
            this.Expression_Sentences(5, 0, "", "", "", "", "");
            this.pnlSubMenu[5].Visible = false;
          }
          else if (num == 1.0)
          {
            this.Expression_Sentences(5, 1, "", "", "", "", "");
            this.pnlSubMenu[5].Visible = false;
          }
          this.IsSubVisible[5] = false;
        }
        if (Conversion.Val(strArray2[1]) == 6.0 & this.txtSMenuAnswer[6, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[6, 1].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[6, 1].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[6, 1].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[6, 1].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[6, 1].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            this.Expression_Sentences(6, -1, this.txtSMenuAnswer[6, 0].Text, this.txtSMenuAnswer[6, 1].Text, "", "", "");
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            {
              this.tmrMainCounter.Stop();
              this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
              this.Expression_Sentences(6, 0, "", "", "", "", "");
              this.pnlSubMenu[6].Visible = false;
              this.Scene_SubMenu_Update_II(true, 13);
              this.pnlSubMenu[13].Visible = true;
              this.IsSubVisible[13] = true;
              this.pnlSubMenu[13].BringToFront();
              this.pnlSubMenu[13].Focus();
              int num2 = Information.UBound((Array) this.pnlSubMenu);
              int index1 = 0;
              while (index1 <= num2)
              {
                this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
                this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
                checked { ++index1; }
              }
              int index2 = 13;
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
              this.IsSubVisible[6] = false;
            }
          }
          else if (num1 == 1.0 && this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.Expression_Sentences(6, 1, "", "", "", "", "");
            this.pnlSubMenu[6].Visible = false;
            this.IsSubVisible[6] = false;
          }
        }
        if (Conversion.Val(strArray2[1]) == 7.0 & this.txtSMenuAnswer[7, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(7, -1, this.txtSMenuAnswer[7, 0].Text, "", "", "", "");
          this.pnlSubMenu[7].Visible = false;
          this.IsSubVisible[7] = false;
        }
        if (Conversion.Val(strArray2[1]) == 8.0 & this.txtSMenuAnswer[8, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(8, -1, this.txtSMenuAnswer[8, 0].Text, "", "", "", "");
          this.pnlSubMenu[8].Visible = false;
          this.IsSubVisible[8] = false;
        }
        if (Conversion.Val(strArray2[1]) == 9.0 & this.txtSMenuAnswer[9, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(9, -1, this.txtSMenuAnswer[9, 0].Text, "", "", "", "");
          this.pnlSubMenu[9].Visible = false;
          this.IsSubVisible[9] = false;
        }
        if (Conversion.Val(strArray2[1]) == 10.0)
        {
          this.Event_All_Visibility_Erase();
          this.pnlMainRoll.Visible = true;
          this.Scene_Main_RollCall_Update(true, true, true);
          this.Event_Main_RollCall_Initialize();
          this.pnlSubMenu[10].Visible = false;
          this.Event_All_Sub_Visibility_Update(false);
          this.IsSubVisible[10] = false;
        }
        if (Conversion.Val(strArray2[1]) == 11.0)
        {
          this.Event_All_Visibility_Erase();
          this.pnlMainVote.Visible = true;
          this.Scene_Main_Vote_Update(true, true, true);
          this.Event_Main_Vote_Initialize();
          this.pnlSubMenu[11].Visible = false;
          this.Event_All_Sub_Visibility_Update(false);
          this.IsSubVisible[11] = false;
        }
        if (Conversion.Val(strArray2[1]) == 12.0 & this.txtSMenuAnswer[12, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[12, 1].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[12, 0].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[12, 1].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[12, 0].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[12, 1].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
            this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
            this.pnlSubMenu[12].Visible = false;
            this.IsSubVisible[12] = false;
            this.Scene_SubMenu_Update_II(true, 13);
            this.pnlSubMenu[13].Visible = true;
            this.IsSubVisible[13] = true;
            this.pnlSubMenu[13].BringToFront();
            this.pnlSubMenu[13].Focus();
            int num = Information.UBound((Array) this.pnlSubMenu);
            int index1 = 0;
            while (index1 <= num)
            {
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
              checked { ++index1; }
            }
            int index2 = 13;
            this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
            this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
          }
        }
        if (Conversion.Val(strArray2[1]) == 13.0)
        {
          double num = Conversion.Val(strArray2[2]);
          if (num == 0.0)
            this.tmrMainCounter.Start();
          else if (num == 1.0)
            this.tmrMainCounter.Stop();
          else if (num == 2.0)
          {
            this.tmrMainCounter.Stop();
            if (this.intMInfoCounter[0] < this.intMInfoCounter[3])
            {
              int index = 0;
              do
              {
                this.intMInfoCounter[index] = 0;
                checked { ++index; }
              }
              while (index <= 3);
              this.lblMInfo[0, 1].Text = "00 : 00";
              this.lblMInfo[0, 2].Text = "00 : 00";
              this.pnlSubMenu[13].Visible = false;
              this.IsSubVisible[13] = false;
            }
            else
            {
              this.intMInfoCounter[1] = this.intMInfoCounter[3];
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
            }
          }
        }
        if (Conversion.Val(strArray2[1]) == 14.0)
        {
          bool[] flagArray = new bool[2];
          int index1 = 0;
          do
          {
            flagArray[index1] = false;
            checked { ++index1; }
          }
          while (index1 <= 1);
          string text = this.txtSMenuAnswer[14, 0].Text;
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            int num2 = Information.UBound((Array) this.datDelList);
            int index2 = 0;
            while (index2 <= num2)
            {
              if (Operators.CompareString(text, this.datDelList[index2], false) == 0)
              {
                flagArray[0] = true;
                int num3 = Information.UBound((Array) this.datDelListPresent);
                int index3 = 0;
                while (index3 <= num3)
                {
                  if (Operators.CompareString(text, this.datDelListPresent[index3], false) == 0)
                    flagArray[1] = true;
                  checked { ++index3; }
                }
              }
              checked { ++index2; }
            }
            if (flagArray[0] && !flagArray[1])
            {
              string[] strArray3 = new string[512];
              int index3 = 0;
              int num3 = Information.UBound((Array) this.datDelList);
              int index4 = 0;
              while (index4 <= num3)
              {
                int num4 = Information.UBound((Array) this.datDelListPresent);
                int index5 = 0;
                while (index5 <= num4)
                {
                  if (Operators.CompareString(this.datDelList[index4], this.datDelListPresent[index5], false) == 0 & (uint) Operators.CompareString(this.datDelList[index4], "", false) > 0U)
                  {
                    try
                    {
                      strArray3[index3] = this.datDelList[index4];
                      checked { ++index3; }
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                    }
                  }
                  checked { ++index5; }
                }
                if (Operators.CompareString(this.datDelList[index4], text, false) == 0 & (uint) Operators.CompareString(this.datDelList[index4], "", false) > 0U)
                {
                  strArray3[index3] = this.datDelList[index4];
                  checked { ++index3; }
                  strArray3[index3] = "";
                }
                checked { ++index4; }
              }
              int num5 = Information.UBound((Array) this.datDelListPresent);
              int index6 = 0;
              while (index6 <= num5)
              {
                this.datDelListPresent[index6] = strArray3[index6];
                checked { ++index6; }
              }
              int num6 = 0;
              int num7 = 0;
              int num8 = Information.UBound((Array) this.datDelListPresent);
              int index7 = 0;
              while (index7 <= num8)
              {
                if (Operators.CompareString(this.datDelListPresent[index7], "", false) != 0)
                {
                  checked { ++num6; }
                  int num4 = Information.UBound((Array) this.datDelList);
                  int index5 = 0;
                  while (index5 <= num4)
                  {
                    if (Operators.CompareString(this.datDelList[index5], this.datDelListPresent[index7], false) == 0 && this.datDelStatus[index5] == 2)
                      checked { ++num7; }
                    checked { ++index5; }
                  }
                }
                checked { ++index7; }
              }
              this.lblMInfo[2, 0].Text = Conversions.ToString(num6);
              if (num6 <= 0)
              {
                this.lblMInfo[2, 1].Text = "0";
                this.lblMInfo[2, 2].Text = "0";
              }
              else
              {
                this.lblMInfo[2, 1].Text = (double) checked (num6 - num7) / 5.0 != Conversion.Int((double) checked (num6 - num7) / 5.0) ? Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 5.0));
                this.lblMInfo[2, 2].Text = Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 2.0) + 1.0);
              }
              this.lblMInfo[2, 3].Text = (double) checked (num6 - num7) / 3.0 * 2.0 != Conversion.Int((double) checked (num6 - num7) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) checked (num6 - num7) / 3.0 * 2.0);
              this.Expression_Sentences(14, -1, "", "", "", "", "");
              this.Expression_Sentences(14, 0, text, "", "", "", "");
              if (num7 == 0)
                this.Expression_Sentences(14, 2, Conversions.ToString(num6), this.lblMInfo[2, 1].Text, this.lblMInfo[2, 2].Text, this.lblMInfo[2, 3].Text, "");
              else
                this.Expression_Sentences(14, 2, Conversions.ToString(checked (num6 - num7)) + "/" + Conversions.ToString(num6), this.lblMInfo[2, 1].Text, this.lblMInfo[2, 2].Text, this.lblMInfo[2, 3].Text, "");
              this.pnlSubMenu[14].Visible = false;
              this.IsSubVisible[14] = false;
            }
          }
          else if (num1 == 1.0)
          {
            int num2 = Information.UBound((Array) this.datDelList);
            int index2 = 0;
            while (index2 <= num2)
            {
              if (Operators.CompareString(text, this.datDelList[index2], false) == 0)
              {
                flagArray[0] = true;
                int num3 = Information.UBound((Array) this.datDelListPresent);
                int index3 = 0;
                while (index3 <= num3)
                {
                  if (Operators.CompareString(text, this.datDelListPresent[index3], false) == 0)
                    flagArray[1] = true;
                  checked { ++index3; }
                }
              }
              checked { ++index2; }
            }
            if (flagArray[0] && flagArray[1])
            {
              string[] strArray3 = new string[512];
              int index3 = 0;
              int num3 = Information.UBound((Array) this.datDelList);
              int index4 = 0;
              while (index4 <= num3)
              {
                int num4 = Information.UBound((Array) this.datDelListPresent);
                int index5 = 0;
                while (index5 <= num4)
                {
                  if (Operators.CompareString(this.datDelList[index4], this.datDelListPresent[index5], false) == 0 & (uint) Operators.CompareString(this.datDelList[index4], "", false) > 0U)
                  {
                    try
                    {
                      strArray3[index3] = this.datDelList[index4];
                      checked { ++index3; }
                    }
                    catch (Exception ex)
                    {
                      ProjectData.SetProjectError(ex);
                      ProjectData.ClearProjectError();
                    }
                  }
                  checked { ++index5; }
                }
                if (Operators.CompareString(this.datDelList[index4], text, false) == 0 & (uint) Operators.CompareString(this.datDelList[index4], "", false) > 0U)
                {
                  checked { --index3; }
                  strArray3[index3] = "";
                }
                checked { ++index4; }
              }
              int num5 = Information.UBound((Array) this.datDelListPresent);
              int index6 = 0;
              while (index6 <= num5)
              {
                this.datDelListPresent[index6] = strArray3[index6];
                checked { ++index6; }
              }
              int num6 = 0;
              int num7 = 0;
              int num8 = Information.UBound((Array) this.datDelListPresent);
              int index7 = 0;
              while (index7 <= num8)
              {
                if (Operators.CompareString(this.datDelListPresent[index7], "", false) != 0)
                {
                  checked { ++num6; }
                  int num4 = Information.UBound((Array) this.datDelList);
                  int index5 = 0;
                  while (index5 <= num4)
                  {
                    if (Operators.CompareString(this.datDelList[index5], this.datDelListPresent[index7], false) == 0 && this.datDelStatus[index5] == 2)
                      checked { ++num7; }
                    checked { ++index5; }
                  }
                }
                checked { ++index7; }
              }
              this.lblMInfo[2, 0].Text = Conversions.ToString(num6);
              if (num6 <= 0)
              {
                this.lblMInfo[2, 1].Text = "0";
                this.lblMInfo[2, 2].Text = "0";
              }
              else
              {
                this.lblMInfo[2, 1].Text = (double) checked (num6 - num7) / 5.0 != Conversion.Int((double) checked (num6 - num7) / 5.0) ? Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 5.0) + 1.0) : Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 5.0));
                this.lblMInfo[2, 2].Text = Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 2.0) + 1.0);
              }
              this.lblMInfo[2, 3].Text = (double) checked (num6 - num7) / 3.0 * 2.0 != Conversion.Int((double) checked (num6 - num7) / 3.0 * 2.0) ? Conversions.ToString(Conversion.Int((double) checked (num6 - num7) / 3.0 * 2.0) + 1.0) : Conversions.ToString((double) checked (num6 - num7) / 3.0 * 2.0);
              this.Expression_Sentences(14, -1, "", "", "", "", "");
              this.Expression_Sentences(14, 1, text, "", "", "", "");
              if (num7 == 0)
                this.Expression_Sentences(14, 2, Conversions.ToString(num6), this.lblMInfo[2, 1].Text, this.lblMInfo[2, 2].Text, this.lblMInfo[2, 3].Text, "");
              else
                this.Expression_Sentences(14, 2, Conversions.ToString(checked (num6 - num7)) + "/" + Conversions.ToString(num6), this.lblMInfo[2, 1].Text, this.lblMInfo[2, 2].Text, this.lblMInfo[2, 3].Text, "");
              this.pnlSubMenu[14].Visible = false;
              this.IsSubVisible[14] = false;
            }
          }
        }
        if (Conversion.Val(strArray2[1]) == 15.0 & this.txtSMenuAnswer[15, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[15, 1].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[15, 2].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[15, 2].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[15, 2].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[15, 2].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[15, 2].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            this.Expression_Sentences(15, -1, this.txtSMenuAnswer[15, 0].Text, this.txtSMenuAnswer[15, 1].Text, this.txtSMenuAnswer[15, 2].Text, "", "");
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            {
              this.tmrMainCounter.Stop();
              this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
              this.Expression_Sentences(15, 0, "", "", "", "", "");
              this.pnlSubMenu[15].Visible = false;
              this.Scene_SubMenu_Update_II(true, 13);
              this.pnlSubMenu[13].Visible = true;
              this.IsSubVisible[13] = true;
              this.pnlSubMenu[13].BringToFront();
              this.pnlSubMenu[13].Focus();
              int num2 = Information.UBound((Array) this.pnlSubMenu);
              int index1 = 0;
              while (index1 <= num2)
              {
                this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
                this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
                checked { ++index1; }
              }
              int index2 = 13;
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
              this.IsSubVisible[1] = false;
            }
          }
          else if (num1 == 1.0 && this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.Expression_Sentences(15, 1, "", "", "", "", "");
            this.pnlSubMenu[15].Visible = false;
            this.IsSubVisible[15] = false;
          }
        }
        if (Conversion.Val(strArray2[1]) == 16.0 & this.txtSMenuAnswer[16, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[16, 1].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[16, 1].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[16, 1].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[16, 1].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[16, 1].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            this.Expression_Sentences(16, -1, this.txtSMenuAnswer[16, 0].Text, this.txtSMenuAnswer[16, 1].Text, "", "", "");
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            {
              this.tmrMainCounter.Stop();
              this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
              this.Expression_Sentences(16, 0, "", "", "", "", "");
              this.pnlSubMenu[16].Visible = false;
              this.Scene_SubMenu_Update_II(true, 13);
              this.pnlSubMenu[13].Visible = true;
              this.IsSubVisible[13] = true;
              this.pnlSubMenu[13].BringToFront();
              this.pnlSubMenu[13].Focus();
              int num2 = Information.UBound((Array) this.pnlSubMenu);
              int index1 = 0;
              while (index1 <= num2)
              {
                this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
                this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
                checked { ++index1; }
              }
              int index2 = 13;
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
              this.IsSubVisible[1] = false;
            }
          }
          else if (num1 == 1.0 && this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.Expression_Sentences(16, 1, "", "", "", "", "");
            this.pnlSubMenu[16].Visible = false;
            this.IsSubVisible[16] = false;
          }
        }
        if (Conversion.Val(strArray2[1]) == 17.0 & this.txtSMenuAnswer[17, 0].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(17, -1, this.txtSMenuAnswer[17, 0].Text, "", "", "", "");
          this.pnlSubMenu[17].Visible = false;
          this.IsSubVisible[17] = false;
        }
        if (Conversion.Val(strArray2[1]) == 18.0 & this.txtSMenuAnswer[18, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[18, 1].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[18, 2].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[18, 2].Text)));
          this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[18, 2].Text)));
          this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[18, 2].Text)));
          this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[18, 2].Text)));
          if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            this.Expression_Sentences(18, -1, this.txtSMenuAnswer[18, 0].Text, this.txtSMenuAnswer[18, 1].Text, this.txtSMenuAnswer[18, 2].Text, "", "");
          double num1 = Conversion.Val(strArray2[2]);
          if (num1 == 0.0)
          {
            if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
            {
              this.tmrMainCounter.Stop();
              this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
              this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
              this.Expression_Sentences(18, 0, "", "", "", "", "");
              this.pnlSubMenu[18].Visible = false;
              this.Scene_SubMenu_Update_II(true, 13);
              this.pnlSubMenu[13].Visible = true;
              this.IsSubVisible[13] = true;
              this.pnlSubMenu[13].BringToFront();
              this.pnlSubMenu[13].Focus();
              int num2 = Information.UBound((Array) this.pnlSubMenu);
              int index1 = 0;
              while (index1 <= num2)
              {
                this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
                this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
                checked { ++index1; }
              }
              int index2 = 13;
              this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
              this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
              this.IsSubVisible[1] = false;
            }
          }
          else if (num1 == 1.0 && this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          {
            this.Expression_Sentences(18, 1, "", "", "", "", "");
            this.pnlSubMenu[18].Visible = false;
            this.IsSubVisible[18] = false;
          }
        }
        if (Conversion.Val(strArray2[1]) == 19.0 & this.txtSMenuAnswer[19, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[19, 1].ForeColor == Color.FromArgb(90, 90, 90))
        {
          this.Expression_Sentences(19, -1, this.txtSMenuAnswer[19, 0].Text, this.txtSMenuAnswer[19, 1].Text, "", "", "");
          double num = Conversion.Val(strArray2[2]);
          if (num == 0.0)
          {
            this.Expression_Sentences(19, 0, "", "", "", "", "");
            this.pnlSubMenu[19].Visible = false;
            this.Scene_SubMenu_Update_II(true, 11);
            this.pnlSubMenu[11].Visible = true;
            this.IsSubVisible[11] = true;
            this.pnlSubMenu[11].BringToFront();
            this.pnlSubMenu[11].Focus();
          }
          else if (num == 1.0)
          {
            this.Expression_Sentences(19, 1, "", "", "", "", "");
            this.pnlSubMenu[19].Visible = false;
          }
          this.pnlSubMenu[19].Visible = false;
          this.IsSubVisible[19] = false;
        }
        if (!(Conversion.Val(strArray2[1]) == 20.0 & this.txtSMenuAnswer[20, 0].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[20, 1].ForeColor == Color.FromArgb(90, 90, 90) & this.txtSMenuAnswer[20, 2].ForeColor == Color.FromArgb(90, 90, 90)))
          return;
        this.intMInfoCounter[0] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[20, 2].Text)));
        this.intMInfoCounter[1] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[20, 2].Text)));
        this.intMInfoCounter[2] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[20, 2].Text)));
        this.intMInfoCounter[3] = checked ((int) Math.Round(Conversion.Val(this.txtSMenuAnswer[20, 2].Text)));
        if (this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599)
          this.Expression_Sentences(20, -1, this.txtSMenuAnswer[20, 0].Text, this.txtSMenuAnswer[20, 1].Text, this.txtSMenuAnswer[20, 2].Text, "", "");
        double num9 = Conversion.Val(strArray2[2]);
        if (num9 == 0.0)
        {
          if (!(this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599))
            return;
          this.tmrMainCounter.Stop();
          this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
          this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
          this.Expression_Sentences(20, 0, "", "", "", "", "");
          this.pnlSubMenu[20].Visible = false;
          this.Scene_SubMenu_Update_II(true, 13);
          this.pnlSubMenu[13].Visible = true;
          this.IsSubVisible[13] = true;
          this.pnlSubMenu[13].BringToFront();
          this.pnlSubMenu[13].Focus();
          int num1 = Information.UBound((Array) this.pnlSubMenu);
          int index1 = 0;
          while (index1 <= num1)
          {
            this.Func_PaintBackColor((Control) this.pnlSubMenu[index1], this.ColorMainDeep, Color.FromArgb(171, 171, 171));
            this.Func_PaintForeColor((Control) this.pnlSubMenu[index1], Color.FromArgb(30, 30, 30), Color.FromArgb(172, 172, 172));
            checked { ++index1; }
          }
          int index2 = 13;
          this.Func_PaintBackColor((Control) this.pnlSubMenu[index2], Color.FromArgb(171, 171, 171), this.ColorMainDeep);
          this.Func_PaintForeColor((Control) this.pnlSubMenu[index2], Color.FromArgb(172, 172, 172), Color.FromArgb(30, 30, 30));
          this.IsSubVisible[1] = false;
        }
        else
        {
          if (num9 != 1.0 || !(this.intMInfoCounter[0] >= this.intMInfoCounter[1] & this.intMInfoCounter[0] <= 3599))
            return;
          this.Expression_Sentences(20, 1, "", "", "", "", "");
          this.pnlSubMenu[20].Visible = false;
          this.IsSubVisible[20] = false;
        }
      }
    }

    public void Event_SubMenu_Close(object sender)
    {
      int index1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value)));
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "visible", new object[1]
      {
        (object) false
      }, (string[]) null, (System.Type[]) null, false, true);
      this.IsSubVisible[index1] = false;
      if (index1 != 13)
        return;
      this.tmrMainCounter.Stop();
      int index2 = 0;
      do
      {
        this.intMInfoCounter[index2] = 0;
        checked { ++index2; }
      }
      while (index2 <= 3);
      this.lblMInfo[0, 1].Text = "00 : 00";
      this.lblMInfo[0, 2].Text = "00 : 00";
    }

    private void btnLanSel_MouseEnter(object sender, EventArgs e) => NewLateBinding.LateSet(sender, (System.Type) null, "backgroundimage", new object[1]
    {
      (object) this.imgBackTrans[1]
    }, (string[]) null, (System.Type[]) null);

    private void btnLanSel_MouseLeave(object sender, EventArgs e) => NewLateBinding.LateSet(sender, (System.Type) null, "backgroundimage", new object[1]
    {
      (object) this.imgBackTrans[0]
    }, (string[]) null, (System.Type[]) null);

    private void btnLanSel_MouseClick(object sender, EventArgs e)
    {
      switch (checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\((?<id>[0-9]+)\\)").Groups["id"].Value))))
      {
        case 0:
          this.Language = "CHS";
          this.fnt9 = new Font(this.ChineseFont, 9f);
          this.fnt12 = new Font(this.ChineseFont, 12f);
          this.fnt18 = new Font(this.ChineseFont, 18f);
          this.fnt18B = new Font(this.ChineseFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.ChineseFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.ChineseFont, 21f);
          this.fnt24 = new Font(this.ChineseFont, 24f);
          this.fnt26 = new Font(this.ChineseFont, 26f);
          this.fnt57 = new Font(this.ChineseFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 1:
          this.Language = "CHT";
          this.fnt9 = new Font(this.ChineseFont, 9f);
          this.fnt12 = new Font(this.ChineseFont, 12f);
          this.fnt18 = new Font(this.ChineseFont, 18f);
          this.fnt18B = new Font(this.ChineseFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.ChineseFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.ChineseFont, 21f);
          this.fnt24 = new Font(this.ChineseFont, 24f);
          this.fnt26 = new Font(this.ChineseFont, 26f);
          this.fnt57 = new Font(this.ChineseFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 2:
          this.Language = "ENG";
          this.fnt9 = new Font(this.WesternFont, 9f);
          this.fnt12 = new Font(this.WesternFont, 12f);
          this.fnt18 = new Font(this.WesternFont, 18f);
          this.fnt18B = new Font(this.WesternFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.WesternFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.WesternFont, 21f);
          this.fnt24 = new Font(this.WesternFont, 24f);
          this.fnt26 = new Font(this.WesternFont, 26f);
          this.fnt57 = new Font(this.WesternFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 3:
          this.Language = "JPN";
          this.fnt9 = new Font(this.ChineseFont, 9f);
          this.fnt12 = new Font(this.ChineseFont, 12f);
          this.fnt18 = new Font(this.ChineseFont, 18f);
          this.fnt18B = new Font(this.ChineseFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.ChineseFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.ChineseFont, 21f);
          this.fnt24 = new Font(this.ChineseFont, 24f);
          this.fnt26 = new Font(this.ChineseFont, 26f);
          this.fnt57 = new Font(this.ChineseFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 4:
          this.Language = "FRA";
          this.fnt9 = new Font(this.WesternFont, 9f);
          this.fnt12 = new Font(this.WesternFont, 12f);
          this.fnt18 = new Font(this.WesternFont, 18f);
          this.fnt18B = new Font(this.WesternFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.WesternFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.WesternFont, 21f);
          this.fnt24 = new Font(this.WesternFont, 24f);
          this.fnt26 = new Font(this.WesternFont, 26f);
          this.fnt57 = new Font(this.WesternFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 5:
          this.Language = "RUS";
          this.fnt9 = new Font(this.WesternFont, 9f);
          this.fnt12 = new Font(this.WesternFont, 12f);
          this.fnt18 = new Font(this.WesternFont, 18f);
          this.fnt18B = new Font(this.WesternFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.WesternFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.WesternFont, 21f);
          this.fnt24 = new Font(this.WesternFont, 24f);
          this.fnt26 = new Font(this.WesternFont, 26f);
          this.fnt57 = new Font(this.WesternFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 6:
          this.Language = "ESP";
          this.fnt9 = new Font(this.WesternFont, 9f);
          this.fnt12 = new Font(this.WesternFont, 12f);
          this.fnt18 = new Font(this.WesternFont, 18f);
          this.fnt18B = new Font(this.WesternFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.WesternFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.WesternFont, 21f);
          this.fnt24 = new Font(this.WesternFont, 24f);
          this.fnt26 = new Font(this.WesternFont, 26f);
          this.fnt57 = new Font(this.WesternFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 7:
          this.Language = "GER";
          this.fnt9 = new Font(this.WesternFont, 9f);
          this.fnt12 = new Font(this.WesternFont, 12f);
          this.fnt18 = new Font(this.WesternFont, 18f);
          this.fnt18B = new Font(this.WesternFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.WesternFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.WesternFont, 21f);
          this.fnt24 = new Font(this.WesternFont, 24f);
          this.fnt26 = new Font(this.WesternFont, 26f);
          this.fnt57 = new Font(this.WesternFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        case 8:
          this.Language = "EOL";
          this.fnt9 = new Font(this.WesternFont, 9f);
          this.fnt12 = new Font(this.WesternFont, 12f);
          this.fnt18 = new Font(this.WesternFont, 18f);
          this.fnt18B = new Font(this.WesternFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.WesternFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.WesternFont, 21f);
          this.fnt24 = new Font(this.WesternFont, 24f);
          this.fnt26 = new Font(this.WesternFont, 26f);
          this.fnt57 = new Font(this.WesternFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
        default:
          this.Language = "CHS";
          this.fnt9 = new Font(this.ChineseFont, 9f);
          this.fnt12 = new Font(this.ChineseFont, 12f);
          this.fnt18 = new Font(this.ChineseFont, 18f);
          this.fnt18B = new Font(this.ChineseFont, 18f, FontStyle.Bold);
          this.fntDisplay = new Font(this.ChineseFont, (float) this.DisplayedFontSize);
          this.fnt21 = new Font(this.ChineseFont, 21f);
          this.fnt24 = new Font(this.ChineseFont, 24f);
          this.fnt26 = new Font(this.ChineseFont, 26f);
          this.fnt57 = new Font(this.ChineseFont, 57f);
          this.fntCounter24 = new Font(this.FontTimer.Families[0], 24f);
          this.fntCounter57 = new Font(this.FontTimer.Families[0], 57f);
          break;
      }
      this.Load_Language_Packs();
      this.Expression_Phrases(true);
      this.Event_All_Update(false, false, true);
      this.pnlMainLanguage.Visible = false;
      this.IsKeyMenuAvailable = true;
      if (Operators.CompareString(this.datConf[2], "", false) == 0)
      {
        this.pnlMainConference.Visible = true;
        this.pnlMainConference.BringToFront();
      }
      else
      {
        this.pnlMainInfo.Visible = true;
        if (!this.pnlMainInfo.Visible)
          return;
        this.Event_All_Sub_Visibility_Update(true);
        this.Event_MainMenu_Visibility_Update(true);
      }
    }

    private void btnMConf_MouseEnter(object sender, EventArgs e) => NewLateBinding.LateSet(sender, (System.Type) null, "backgroundimage", new object[1]
    {
      (object) this.imgMConf[1]
    }, (string[]) null, (System.Type[]) null);

    private void btnMConf_MouseLeave(object sender, EventArgs e) => NewLateBinding.LateSet(sender, (System.Type) null, "backgroundimage", new object[1]
    {
      (object) this.imgMConf[0]
    }, (string[]) null, (System.Type[]) null);

    private void btnMConf_MouseClick(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtMConf[0, 0].Text, "", false) == 0 | Operators.CompareString(this.txtMConf[0, 1].Text, "", false) == 0)
        return;
      this.datConf[1] = this.txtMConf[0, 0].Text;
      this.datConf[2] = this.txtMConf[0, 1].Text;
      this.Event_All_Update(false, false, true);
      this.Event_All_Visibility_Erase();
      this.pnlMainInfo.Visible = true;
      this.Event_All_Sub_Visibility_Update(true);
      this.Event_MainMenu_Visibility_Update(true);
    }

    private void btnMInfoDelSelect_MouseEnter(object sender, EventArgs ea)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!((obj != null ? (Color) obj : new Color()) == this.ColorMain))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) this.ColorMainDeep
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnMInfoDelSelect_MouseLeave(object sender, EventArgs ea)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!((obj != null ? (Color) obj : new Color()) == this.ColorMainDeep))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnMInfoDelSelect_MouseDown(object sender, EventArgs ea)
    {
      object obj = NewLateBinding.LateGet(sender, (System.Type) null, "backcolor", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null);
      if (!((obj != null ? (Color) obj : new Color()) == this.ColorMainDeep))
        return;
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
    }

    private void btnMInfoDelSelect_MouseUp(object sender, EventArgs ea)
    {
      int index1 = checked ((int) Math.Round(Conversion.Val(Regex.Match(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)), "\\,(?<id>[0-9]+)\\)").Groups["id"].Value)));
      int index2 = 0;
      do
      {
        this.lblMInfo[1, index2].BackColor = this.ColorMain;
        this.lblMInfo[1, index2].ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
        this.txtMInfo[1, index2].Visible = false;
        checked { ++index2; }
      }
      while (index2 <= 2);
      NewLateBinding.LateSet(sender, (System.Type) null, "backcolor", new object[1]
      {
        (object) Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue)
      }, (string[]) null, (System.Type[]) null);
      NewLateBinding.LateSet(sender, (System.Type) null, "forecolor", new object[1]
      {
        (object) this.ColorMain
      }, (string[]) null, (System.Type[]) null);
      this.txtMInfo[1, index1].Visible = true;
    }

    private void btnDecision_MouseEnter(object sender, EventArgs e) => NewLateBinding.LateSet(sender, (System.Type) null, "backgroundimage", new object[1]
    {
      (object) this.imgBackTrans[1]
    }, (string[]) null, (System.Type[]) null);

    private void btnDecision_MouseLeave(object sender, EventArgs e) => NewLateBinding.LateSet(sender, (System.Type) null, "backgroundimage", new object[1]
    {
      (object) this.imgBackTrans[0]
    }, (string[]) null, (System.Type[]) null);

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void btnDecision_MouseClick(object sender, EventArgs e)
    {
      if (this.intDecisionMagicNumber == -1 | this.intDecisionMagicNumber == -2)
        ProjectData.EndApp();
      else
        this.pnlGuideline.Visible = false;
    }

    private void tmrInstr_Tick(object sender, EventArgs e)
    {
      if (this.intInstr[0] == 1)
      {
        this.pnlInstr.Visible = true;
        if (this.intInstr[1] == 9999)
          return;
        this.intInstr[1] = checked (this.intInstr[1] - 1);
        if (this.intInstr[1] > 0)
          return;
        this.intInstr[0] = 0;
        this.intInstr[1] = 0;
      }
      else
      {
        this.pnlInstr.Visible = false;
        if (this.intInstr[1] > 0)
          this.intInstr[0] = 1;
        else
          this.intInstr[1] = 0;
      }
    }

    private void tmrRealTime_Tick(object sender, EventArgs e) => this.lblMInfo[5, 0].Text = Microsoft.VisualBasic.Strings.Format((object) DateAndTime.Now, "HH:mm:ss");

    private void tmrMainCounter_Tick(object sender, EventArgs e)
    {
      if (!(this.intMInfoCounter[0] == 0 | this.intMInfoCounter[1] == 0))
      {
        this.intMInfoCounter[0] = checked (this.intMInfoCounter[0] - 1);
        this.intMInfoCounter[1] = checked (this.intMInfoCounter[1] - 1);
        this.lblMInfo[0, 2].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[0] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[0] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[0] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[0] % 60)));
        this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
      }
      else
      {
        this.tmrMainCounter.Stop();
        if (this.intMInfoCounter[0] < this.intMInfoCounter[3])
        {
          int index = 0;
          do
          {
            this.intMInfoCounter[index] = 0;
            checked { ++index; }
          }
          while (index <= 3);
          this.lblMInfo[0, 1].Text = "00 : 00";
          this.lblMInfo[0, 2].Text = "00 : 00";
          this.pnlSubMenu[13].Visible = false;
          this.IsSubVisible[13] = false;
        }
        else
        {
          this.intMInfoCounter[1] = this.intMInfoCounter[3];
          this.lblMInfo[0, 1].Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Interaction.IIf(Conversion.Int((double) this.intMInfoCounter[1] / 60.0) < 10.0, (object) "0", (object) ""), (object) Conversion.Int((double) this.intMInfoCounter[1] / 60.0)), (object) " : "), Interaction.IIf(this.intMInfoCounter[1] % 60 < 10, (object) "0", (object) "")), (object) (this.intMInfoCounter[1] % 60)));
        }
      }
    }

    private AutoCompleteStringCollection InitCompleteCollection()
    {
      AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
      StreamReader streamReader = new StreamReader("Config\\Delegation_List.txt", Encoding.UTF8);
      while (!streamReader.EndOfStream)
      {
        string str = streamReader.ReadLine();
        stringCollection.Add(str);
      }
      streamReader.Close();
      return stringCollection;
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

    public void Func_PaintBackColor(Control objRaw, Color colRaw, Color colNew)
    {
      object[] objArray = new object[1024];
      int index1 = 0;
      do
      {
        objArray[index1] = (object) null;
        checked { ++index1; }
      }
      while (index1 <= 1023);
      objArray[0] = (object) objRaw;
      Control control1 = (Control) null;
      objRaw.BackColor = colNew;
      int num1;
      do
      {
        int num2 = Information.UBound((Array) objArray);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (objArray[index2] != null)
          {
            control1 = (Control) objArray[index2];
            objArray[index2] = (object) null;
            break;
          }
          checked { ++index2; }
        }
        if (control1 != null)
        {
          if (control1.HasChildren)
          {
            try
            {
              foreach (Control control2 in control1.Controls)
              {
                try
                {
                  if (control2.BackColor == colRaw)
                    control2.BackColor = colNew;
                  int num3 = Information.UBound((Array) objArray);
                  int index3 = 0;
                  while (index3 <= num3)
                  {
                    if (objArray[index3] == null)
                    {
                      objArray[index3] = (object) control2;
                      break;
                    }
                    checked { ++index3; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
        }
        num1 = 0;
        int num4 = Information.UBound((Array) objArray);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (objArray[index4] != null)
            checked { ++num1; }
          checked { ++index4; }
        }
      }
      while (num1 != 0);
    }

    public void Func_PaintForeColor(Control objRaw, Color colRaw, Color colNew)
    {
      object[] objArray = new object[1024];
      int index1 = 0;
      do
      {
        objArray[index1] = (object) null;
        checked { ++index1; }
      }
      while (index1 <= 1023);
      objArray[0] = (object) objRaw;
      Control control1 = (Control) null;
      objRaw.ForeColor = colNew;
      int num1;
      do
      {
        int num2 = Information.UBound((Array) objArray);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (objArray[index2] != null)
          {
            control1 = (Control) objArray[index2];
            objArray[index2] = (object) null;
            break;
          }
          checked { ++index2; }
        }
        if (control1 != null)
        {
          if (control1.HasChildren)
          {
            try
            {
              foreach (Control control2 in control1.Controls)
              {
                try
                {
                  if (control2.ForeColor == colRaw)
                    control2.ForeColor = colNew;
                  int num3 = Information.UBound((Array) objArray);
                  int index3 = 0;
                  while (index3 <= num3)
                  {
                    if (objArray[index3] == null)
                    {
                      objArray[index3] = (object) control2;
                      break;
                    }
                    checked { ++index3; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
        }
        num1 = 0;
        int num4 = Information.UBound((Array) objArray);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (objArray[index4] != null)
            checked { ++num1; }
          checked { ++index4; }
        }
      }
      while (num1 != 0);
    }

    public void Func_AddControl(Control objRaw)
    {
      object[] objArray = new object[1024];
      int index1 = 0;
      do
      {
        objArray[index1] = (object) null;
        checked { ++index1; }
      }
      while (index1 <= 1023);
      objArray[0] = (object) objRaw;
      Control control1 = (Control) null;
      int num1;
      do
      {
        int num2 = Information.UBound((Array) objArray);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (objArray[index2] != null)
          {
            control1 = (Control) objArray[index2];
            objArray[index2] = (object) null;
            break;
          }
          checked { ++index2; }
        }
        if (control1 != null)
        {
          if (control1.HasChildren)
          {
            try
            {
              foreach (Control control2 in control1.Controls)
              {
                try
                {
                  control2.MouseDown += new MouseEventHandler(this.SubMenu_MouseDown);
                  int num3 = Information.UBound((Array) objArray);
                  int index3 = 0;
                  while (index3 <= num3)
                  {
                    if (objArray[index3] == null)
                    {
                      objArray[index3] = (object) control2;
                      break;
                    }
                    checked { ++index3; }
                  }
                }
                catch (Exception ex)
                {
                  ProjectData.SetProjectError(ex);
                  ProjectData.ClearProjectError();
                }
              }
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
          }
        }
        num1 = 0;
        int num4 = Information.UBound((Array) objArray);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (objArray[index4] != null)
            checked { ++num1; }
          checked { ++index4; }
        }
      }
      while (num1 != 0);
    }

    public static Control GetYoungestChildUnderMouse(ref Control TopControl) => MainForm.GetYoungestChildAtDesktopPoint(ref TopControl, Cursor.Position);

    public static Control GetYoungestChildAtDesktopPoint(
      ref Control TopControl,
      Point DesktopPoint)
    {
      Control childAtPoint = TopControl.GetChildAtPoint(TopControl.PointToClient(DesktopPoint));
      return childAtPoint != null ? (childAtPoint.HasChildren ? MainForm.GetYoungestChildAtDesktopPoint(ref childAtPoint, DesktopPoint) : childAtPoint) : childAtPoint;
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

    public string MD5(string strSource, short Code)
    {
      byte[] bytes = new ASCIIEncoding().GetBytes(strSource);
      byte[] hash = ((HashAlgorithm) CryptoConfig.CreateFromName(nameof (MD5))).ComputeHash(bytes);
      string str = "";
      switch (Code)
      {
        case 16:
          int index1 = 4;
          do
          {
            str += Conversion.Hex(hash[index1]).PadLeft(2, '0').ToLower();
            checked { ++index1; }
          }
          while (index1 <= 11);
          break;
        case 32:
          int index2 = 0;
          do
          {
            str += Conversion.Hex(hash[index2]).PadLeft(2, '0').ToLower();
            checked { ++index2; }
          }
          while (index2 <= 15);
          break;
        default:
          int index3 = 0;
          do
          {
            str += Conversion.Hex(hash[index3]).PadLeft(2, '0').ToLower();
            checked { ++index3; }
          }
          while (index3 <= 15);
          break;
      }
      return str;
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
      this.AutoScaleDimensions = new SizeF(9f, 20f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.ClientSize = new Size(335, 251);
      this.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (MainForm);
      this.Text = "MUNCS Express 2";
      this.ResumeLayout(false);
    }
  }
}
