namespace Uri1759;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i == n){
                Console.Write("Ho!\n");
            }
            else{
                Console.Write("Ho ");
            }
        }
    }
}

