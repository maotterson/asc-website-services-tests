using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using razordemo.Services;
using razordemo.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace razordemo.Controllers
{
    public class CheckInValidationController
    {
        public static async Task<String> post(String studentid, String name)
        {
            // pass credentials to validation service
            Credentials credentials = new Credentials(studentid, name);
            HttpResponseMessage response = await CheckInValidationService.validateCredentials(credentials);
            string json = await response.Content.ReadAsStringAsync();

            //pass response to deserialize JSON string into C# object
            var schema = new {
                student = new { 
                    _id = ""
                }
            };
            try
            {
                dynamic result = JSONSerializerService.deserialize(json, schema); 
                return result.student._id;
            }
            catch
            {
                return "error";
            }
        }
    }
}
