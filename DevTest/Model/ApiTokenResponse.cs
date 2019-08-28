using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Model
{
   public  class ApiTokenResponse: ApiResponse
    {
        [JsonProperty("data ")]
        public Token Data { get; set; }
    }
}
