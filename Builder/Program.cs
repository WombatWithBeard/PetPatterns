namespace Builder
{
    internal class Program
    {
        private static void Main()
        {
            var maze = new MazeFromBuilder().CreateMaze();
        }
    }
}