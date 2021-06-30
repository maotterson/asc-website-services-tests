using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using razordemo.Models;

namespace razordemo.Services
{
    public class CheckInValidationService
    {
        public static async Task<HttpResponseMessage> validateCredentials(Credentials credentials)
        {
            string destinationURI = "http://localhost:3000/api/credentials";

            var formData = new Dictionary<string, string>
            {
                { "studentid", credentials.studentid },
                { "lastName", credentials.lastName},
            };

            var requestBody = new FormUrlEncodedContent(formData);

            try
            {
                Uri baseURL = new Uri(destinationURI);
                HttpClient client = new HttpClient();


                return await client.PostAsync(baseURL.ToString(), requestBody);
            }
            catch
            {
                throw new Exception("Error: Could not complete request");
            }
        }
    }
}
