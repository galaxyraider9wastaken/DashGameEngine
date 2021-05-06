using System;

namespace Dash {
  public class DrawBatch {
    public DrawBatch(){

    }
    public void Draw(){
      Empty();
    }
    public void Empty(){
      System.IO.File.WriteAllText("TD" + ".js", string.Empty);
    }
  }
}
