using System;
using DevTest.Api;

namespace DevTest
{
    class Program
    {
        static void Main ( string[] args )
        {
            Server.RunAsync().GetAwaiter().GetResult();
        }
    }
}
