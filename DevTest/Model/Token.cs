using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Model
{
   public  class Token
    {
        /// <summary>
        /// token that will be used in subsequent requests
        /// </summary>
        [JsonProperty("access_token ")]
        public string AccessToken { get; set; }
        /// <summary>
        /// Examples: "bearer"
        /// </summary>
        [JsonProperty("token_type ")]
        public string TokenType { get; set; }
        /// <summary>
        /// date of expiration
        /// </summary>
        [JsonProperty("expires_at ")]
        public DateTime ExpiresAt { get; set; }
    }
}
