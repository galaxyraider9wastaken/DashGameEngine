using System;

namespace Dash {
  public class Texture2D {
    public Vector2 Size;
    public string File;
    public string Name;
    public Texture2D(Vector2 size, string file){
      Size = size;
      File = file;
    }
  }
}
