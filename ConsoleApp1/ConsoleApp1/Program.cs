namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.Write("Enter Your Name : ");
            player.SetName(Console.ReadLine());
            Console.Write("Enter Your Id : ");
            player.SetId(int.Parse(Console.ReadLine()));
            Console.Clear();
            Questions questions = new Questions();
            questions.Start();
            player.SetScore( questions.GetScore());


        }
    }
}
