// Decompiled with JetBrains decompiler
// Type: MUNCS_E2.My.MySettings
// Assembly: MUNCS Express 2 Rebuild, Version=2.0.1.25, Culture=neutral, PublicKeyToken=null
// MVID: 0D772052-686C-4562-BE2C-3873CFDD4BAE
// Assembly location: C:\Users\Kevin\Downloads\MUNCS Express 2 0130\MUNCS Express 2 0130.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MUNCS_E2.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(handlerLockObject, ref lockTaken);
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(handlerLockObject);
          }
        }
        return MySettings.defaultInstance;
      }
    }
  }
}
