using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Api
{
    public class Client
    {
        public string grant_type { get; set; } 
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string username { get; set; } 
        public string password { get; set; } 
        public Client ()
        {
            grant_type = "password";
            client_id = "6779ef20e75817b79601";
            client_secret = "3e0f85f44b9ffbc87e90acf40d482601";
            username = "hiring";
            password = "cosmicdev";
        }
        public override string ToString ()
        {
            return JsonConvert.SerializeObject(this);
        }
        
    }

}
