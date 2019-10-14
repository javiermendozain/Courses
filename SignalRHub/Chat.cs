using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRHub
{
    public class Chat : Hub
    {
        public Task Send(string message) {
            // Show messages on console
            System.Console.WriteLine(message);
            
            // Clients is a property in the base Hub class
            // with Others the message is received but not from the client's origin
            return Clients.Others.SendCoreAsync("Send", new [] { message});
        }
    }
}