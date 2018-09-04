using System;
using System.Threading.Tasks;

namespace ConsoleWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAcessando WebAI, aguarde....\n");

            var repository = new Repository();

            var user = repository.GetUserAsync();

            user.ContinueWith(task =>
            {
                var _user = task.Result;

                foreach (var item in _user)
                {
                    Console.WriteLine(item.ToString());
                }

            },TaskContinuationOptions.OnlyOnRanToCompletion
            );

            Console.ReadLine();
        }
    }
}
