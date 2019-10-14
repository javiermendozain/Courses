using ListaCursos.Interfaces;
using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.SignalR.Client;

namespace ListaCursos.Providers
{
    public class MessageProvider : IMessageProvider
    {

        private readonly List<Message> repo = new List<Message>();
    
        public MessageProvider()
        {
 

        }

        public Message GetMessage()
        {
            string message = "";  
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5020/ChatHub")
                .Build();
            // Subscribe to the event send to listen to the messages sent
            connection.On<string>("Send", (ms)=>{
                message = ms;
            });
          
            // Start conecction
            connection.StartAsync().Wait();

            if (!string.IsNullOrWhiteSpace(message))
            {
                var result = JsonConvert.DeserializeObject<Message>(message);
                return result;
            }

            return null;
        }

        public Task<bool> SendMessage(string message)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5020/chathub")
                .Build();
     
            // Subscribe to the event send to listen to the messages sent
            connection.On<string>("Send", (message)=>{
                // var result = JsonConvert.DeserializeObject<Message>(message);
                // System.Console.WriteLine(result);
            });

            // Start conecction
            connection.StartAsync().Wait();
          
            // Send messaje to SignalR
            connection.SendAsync("Send", message);
         
            
            return Task.FromResult(true);
        }    
       
    }


}
