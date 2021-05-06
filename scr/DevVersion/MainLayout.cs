using System;
//Use Dash library new Vector2(Camera.Coordinates.X - DCoordinates.X, Camera.Coordinates.Y - DCoordinates.Y); 
using Dash;

namespace Main{
  class MainClass {
  //Create DrawBatch
  public static DrawBatch DB = new DrawBatch();
  public static void Main (string[] args) {
    //Set Textures here
    var YourTexture = new Texture2D(new Vector2(YourtextureSizeX, YourtextureSizeY), "YourTexturePathWithFileExtention");
    //Start the Game Loop 
    while(true){
      //Draw Textures
      Drawing.DrawSprite(YourTexture, new Vector2(YourTextureCoordsX, YourTextureCoordsY));
      //Draw the DrawBatch
      DB.Draw();
    }
  }
}
}
