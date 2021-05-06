using System;
using System.Timers;

namespace Dash {
  public class Animation {
    public Texture2D[] Frames;
    public int FrameAmount;
    public int TotalTime;
    public Timer TimeToFrame;
    public int CurrentFrame;
    public Animation(Texture2D[] frames, int frameamount, int totaltime //in millaseconds){
      frames = new int[frameamount];
      Frames = frames;
      FrameAmount = frameamount;
      TotalTime = totaltime;
    }
    public void Start(){
      TimeToFrame = new Timer(TotalTime);
      Timer.Elapsed += OnNextFrame;
      Timer.AutoReset = true;
      Timer.Enabled = true;
    }
    private static void OnNextFrame(Object source, ElapsedEventArgs e)
    {
      if(CurrentFrame < FrameAmount){
        CurrentFrame+=1;
      } else {
        Timer.AutoReset = false;
        Timer.Enabled = false;
        CurrentFrame = 0;
      }
    }
    public Texture2D GetCurrentTexture(){
      return Frames[CurrentFrame];
    }
  }
}
