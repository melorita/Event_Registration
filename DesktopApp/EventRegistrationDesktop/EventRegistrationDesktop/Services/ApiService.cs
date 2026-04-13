using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization; // For JavaScriptSerializer in .NET 4.7.2

namespace EventRegistrationDesktop.Services
{
    public class ApiService
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://localhost:7054/api/"; // Adjusted to match launchSettings.json

        private static readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            try
            {
                var response = await client.GetAsync(BaseUrl + endpoint);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return serializer.Deserialize<T>(json);
                }
                return default;
            }
            catch (Exception ex)
            {
                Console.WriteLine("API Get Error: " + ex.Message);
                return default;
            }
        }

        public static async Task<bool> PostAsync<T>(string endpoint, T data)
        {
            try
            {
                var json = serializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(BaseUrl + endpoint, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("API Post Error: " + ex.Message);
                return false;
            }
        }

        public static async Task<bool> PutAsync<T>(string endpoint, T data)
        {
            try
            {
                var json = serializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(BaseUrl + endpoint, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("API Put Error: " + ex.Message);
                return false;
            }
        }

        public static async Task<bool> DeleteAsync(string endpoint)
        {
            try
            {
                var response = await client.DeleteAsync(BaseUrl + endpoint);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("API Delete Error: " + ex.Message);
                return false;
            }
        }
    }
}
