
using Server;
using System.Net;



namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // continue; f
            HttpServer httpServer = new HttpServer(IPAddress.Any, 10001);
            Console.WriteLine("Running new Server.");
            // httpServer.RegisterEndpoint("users", new User());
            httpServer.Run();
        }
    }
}