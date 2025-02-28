namespace ConsoleApp1
{
    internal class Class
    {
        static void Main(string[] args)
        {
            int n = 4; // Number of rows

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
