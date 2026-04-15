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
        private static readonly HttpClient client;
        private const string BaseUrl = "http://localhost:5090/api/"; // Adjusted to match launchSettings.json http profile

        static ApiService()
        {
            // Bypass SSL certificate validation for development
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            client = new HttpClient(handler);
        }

        public static string LastErrorMessage { get; private set; }

        private static readonly JavaScriptSerializer serializer = new JavaScriptSerializer();

        private static void AddAuthHeader()
        {
            if (!string.IsNullOrEmpty(SessionService.Token))
            {
                if (client.DefaultRequestHeaders.Contains("Authorization"))
                    client.DefaultRequestHeaders.Remove("Authorization");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + SessionService.Token);
            }
        }

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            try
            {
                AddAuthHeader();
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
                AddAuthHeader();
                var response = await client.PostAsync(BaseUrl + endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    LastErrorMessage = string.Empty;
                    return true;
                }
                LastErrorMessage = await response.Content.ReadAsStringAsync();
                return false;
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                Console.WriteLine("API Post Error: " + ex.Message);
                return false;
            }
        }

        public static async Task<TResponse> PostWithResultAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            LastErrorMessage = "Unknown error occurred";
            try
            {
                var json = serializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                AddAuthHeader();
                var response = await client.PostAsync(BaseUrl + endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    LastErrorMessage = string.Empty;
                    var resultJson = await response.Content.ReadAsStringAsync();
                    return serializer.Deserialize<TResponse>(resultJson);
                }
                LastErrorMessage = await response.Content.ReadAsStringAsync();
                return default;
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                Console.WriteLine("API PostWithResult Error: " + ex.Message);
                return default;
            }
        }

        public static async Task<bool> PutAsync<T>(string endpoint, T data)
        {
            try
            {
                var json = serializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                AddAuthHeader();
                var response = await client.PutAsync(BaseUrl + endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    LastErrorMessage = string.Empty;
                    return true;
                }
                LastErrorMessage = await response.Content.ReadAsStringAsync();
                return false;
            }
            catch (Exception ex)
            {
                LastErrorMessage = ex.Message;
                Console.WriteLine("API Put Error: " + ex.Message);
                return false;
            }
        }

        public static async Task<bool> DeleteAsync(string endpoint)
        {
            try
            {
                AddAuthHeader();
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
