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
    public class WebApiCoursesProvider : ICoursesProvider
    {
        private readonly IHttpClientFactory httpClientFactory;

        public WebApiCoursesProvider(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<(bool IsSuccess, int? Id)> AddAsync(Course course)
        {
            // Create httpClient instance
            var client = httpClientFactory.CreateClient("coursesService");

            var body = new StringContent(JsonConvert.SerializeObject(course), System.Text.Encoding.UTF8, "application/json");

            // Getting response of request POST at httpClient created as service on ConfigureServices
            var response = await client.PostAsync("api/courses", body);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Deserialize content with fastest seserializer included in .NET 3.0
                // Looks for more info https://www.newtonsoft.com/json
                var result = JsonConvert.DeserializeObject<int?>(content);

                // If correct is added, returns true and result
                return (true, result);
            }

            return (false, null);
        }

        public async Task<ICollection<Course>> GetAllAsync()
        {
            // Create httpClient instance
            var client = httpClientFactory.CreateClient("coursesService");

            // Getting response of request GET at httpClient created as service on ConfigureServices
            var response = await client.GetAsync("api/courses");

            if (response.IsSuccessStatusCode)
            {
                // Getting content as string
                var content = await response.Content.ReadAsStringAsync();

                // Deserialize content with fastest seserializer included in .NET 3.0
                // Looks for more info https://www.newtonsoft.com/json
                var result = JsonConvert.DeserializeObject<ICollection<Course>>(content);

                // Finally return the course collection
                return result;
            }

            return null;
        }

        public async Task<Course> GetAsync(int id)
        {
            // Create httpClient instance
            var client = httpClientFactory.CreateClient("coursesService");

            // Getting response of request GET at httpClient created as service on ConfigureServices
            var response = await client.GetAsync($"api/courses/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Deserialize content with fastest seserializer included in .NET 3.0
                // Looks for more info https://www.newtonsoft.com/json
                var result = JsonConvert.DeserializeObject<Course>(content);

                // Finally return the course
                return result;
            }

            return null;
        }

        public async Task<ICollection<Course>> SearchAsync(string search)
        {
            // Create httpClient instance
            var client = httpClientFactory.CreateClient("coursesService");

            // Getting response of request GET at httpClient created as service on ConfigureServices
            var response = await client.GetAsync($"api/courses/search/{search}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                
                // Deserialize content with fastest seserializer included in .NET 3.0
                // Looks for more info https://www.newtonsoft.com/json
                var result = JsonConvert.DeserializeObject<ICollection<Course>>(content);

                // Finally return the course collection 
                return result;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(int id, Course course)
        {
            // Create httpClient instance
            var client = httpClientFactory.CreateClient("coursesService");

            var body = new StringContent(JsonConvert.SerializeObject(course), System.Text.Encoding.UTF8, "application/json");

            // Getting response of request PUT at httpClient created as service on ConfigureServices
            var response = await client.PutAsync($"api/courses/{id}", body);

            if (response.IsSuccessStatusCode)
            {
                // If the update was correct, return true
                return true;
            }

            return false;
        }
    }
}
