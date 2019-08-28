using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Model
{
    [JsonObject("data")]
    public  class Employee
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date_of_birth")]
        public DateTimeOffset DateOfBirth { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        public override string ToString ()
        {
            return $@"
======================================================================
{Title} {FirstName} {LastName}
Dob:    {DateOfBirth}
Email : {Email}
Contry: {Country}
Rating : {Rating}
Bio:
{Bio}
======================================================================
";
        }
    }
}
