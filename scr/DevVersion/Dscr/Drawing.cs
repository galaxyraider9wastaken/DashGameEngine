namespace Dash
{
    public class Drawing : Config
    {
        public static void DrawSprite(Texture2D Texture, Vector2 Coords)
        {
            using (StreamWriter writer = new StreamWriter(TDPath + "TD.js", true))
            {
                writer.WriteLine("Draw(" + (int)Coords.X + ", " + (int)Coords.Y + ", " + (int)Texture.Size.X + ", " + (int)Texture.Size.Y + ", " + "\"" + Texture.File + "\"" + ");");
            }
        }
    }
}
