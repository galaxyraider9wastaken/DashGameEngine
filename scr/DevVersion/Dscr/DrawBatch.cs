namespace Dash
{
    public class DrawBatch : Config
    {
        public Vector2 Postition;
        public DrawBatch()
        {

        }
        public void Draw()
        {
            Empty();
        }
        public void Empty()
        {
            System.IO.File.WriteAllText(TDPath + "TD.js", string.Empty);
        }
    }
}
