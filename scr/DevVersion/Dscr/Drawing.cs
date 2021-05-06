using System;
using System.IO;
using Dash;

namespace Dash : Config {
  public class Drawing {
    public static void DrawSprite(Texture2D Texture, Vector2 Coords){
      using (StreamWriter writer = new StreamWriter(TDPath + "TD.js", true))
      {  
        writer.WriteLine("Draw("+ (int)Coords.X + ", " + (int)Coords.Y + ", " + (int)Texture.Size.X + ", " + (int)Texture.Size.Y + ", " + "\"" + Texture.File + "\"" + ");");
      }  
    }
  }
}
