using ListaCursos.Interfaces;
using ListaCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ListaCursos.Providers
{
    public class VideosProvider : IVideosProvider
    {

        private readonly Video repo = new Video();
        private readonly IHttpClientFactory httpClientFactory;

        public VideosProvider(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<Video> GetAllAsync(string search)
        {

            // Create httpClient instance
            var client = httpClientFactory.CreateClient("searchVideosService");

            var key = "AIzaSyANvx7vV8kEIWgBIkzo7El9dhA87XBmHX8";
            var part = "snippet";
            var type = "video";
            var q = search;
            var maxResults = 20;

            // Getting response of request GET at httpClient created as service on ConfigureServices
            var response = await client.GetAsync($"?key={key}&part={part}&type={type}&q={q}&maxResults={maxResults}");
 
            if (response.IsSuccessStatusCode)
            {
                // Getting content as string
                var content = await response.Content.ReadAsStringAsync();
                // Console.WriteLine(content);
                    
                // Deserialize content with fastest seserializer included in .NET 3.0
                // Looks for more info https://www.newtonsoft.com/json
                var result = JsonConvert.DeserializeObject<Video>(content);
               
                // Finally return result
                return result;        
            }
            
            return null;
        }
      
    
       
    }


}
