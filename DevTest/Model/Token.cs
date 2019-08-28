using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Model
{
   public  class Token
    {
        [JsonProperty("access_token ")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type ")]
        public string TokenType { get; set; }

        [JsonProperty("expires_at ")]
        public DateTime ExpiresAt { get; set; }
    }
}
