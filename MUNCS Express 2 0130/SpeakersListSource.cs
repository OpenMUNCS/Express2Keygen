// Decompiled with JetBrains decompiler
// Type: MUNCS_E2.SpeakersListSource
// Assembly: MUNCS Express 2 Rebuild, Version=2.0.1.25, Culture=neutral, PublicKeyToken=null
// MVID: 0D772052-686C-4562-BE2C-3873CFDD4BAE
// Assembly location: C:\Users\Kevin\Downloads\MUNCS Express 2 0130\MUNCS Express 2 0130.exe

using System.Collections;

namespace MUNCS_E2
{
  public class SpeakersListSource
  {
    private string _topic;
    private string _subtopic;
    private int _totaltime;
    private int _time;
    private ArrayList _speakers;

    public string Topic
    {
      get => this._topic;
      set => this._topic = value;
    }

    public string SubTopic
    {
      get => this._subtopic;
      set => this._subtopic = value;
    }

    public int TotalTime
    {
      get => this._totaltime;
      set => this._totaltime = value;
    }

    public int Time
    {
      get => this._time;
      set => this._time = value;
    }

    public ArrayList Speakers
    {
      get => this._speakers;
      set => this._speakers = value;
    }
  }
}
