namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var gameWindow = new Window(new Game()))
            {
                gameWindow.Run(60);
            }
        }
    }
}
