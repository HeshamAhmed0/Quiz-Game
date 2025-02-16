namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.Write("Enter Your Name : ");
            player.SetName(Console.ReadLine()?? "No Name");
            Console.Write("Enter Your Id : ");
            player.SetId(int.Parse(Console.ReadLine()?? "0"));
            Console.Clear();
            Questions questions = new Questions();
            questions.Start();
            player.SetScore( questions.GetScore());
            Console.WriteLine(player);
        }
    }
}
