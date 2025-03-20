using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string defaultImagePath = "tux.jpg";
            string imagePath;
            int width;

            if (args.Length == 2)
            {
                imagePath = args[0];  
                width = int.Parse(args[1]);  
            }
            else
            {
                imagePath = defaultImagePath;
                width = 24;
            }

            CanvasImage image = new CanvasImage(imagePath);
            image.MaxWidth(width); 
            AnsiConsole.Write(image);
        }
    }
}
