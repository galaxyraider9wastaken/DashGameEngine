using System;

namespace Dash {
  public class Animation {
    public Texture2D Frames;
    public int FrameAmount;
    public int TotalTime;
    public Animation(Texture2D[] frames, int frameamount, int totaltime //in millaseconds){
      Frames = frames;
      FrameAmount = frameamount;
      TotalTime = totaltime;
    }
  }
}
