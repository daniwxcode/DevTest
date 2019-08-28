using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Model
{
    [JsonObject("data")]
    public  class Employee
    {
        /// <summary>
        /// Examples: "8c8c13b6-35ed-3ffb-92d5-c438825df67f", "8c2313b6-35ed-3ffb-92d5-c438825df67f", "1c2313b6-35ed-3ffb-92d5-c438825df67f", "2c2313b6-35ed-3ffb-92d5-c438825df67f", "3c2313b6-35ed-3ffb-92d5-c438825df67f"
        /// </summary>
        [JsonProperty("id")]

        public string Id { get; set; }

        /// <summary>
        /// Examples: "1990-06-29", "1980-06-29", "1955-06-29", "1986-06-29", "1982-06-29"
        /// </summary>
        [JsonProperty("date_of_birth")]
        public DateTimeOffset DateOfBirth { get; set; }

        /// <summary>
        /// Examples: "https://lorempixel.com/640/480/people/?96612", "https://lorempixel.com/640/480/people/?96613", "https://lorempixel.com/640/480/people/?96614", "https://lorempixel.com/640/480/people/?96616", "https://lorempixel.com/640/480/people/?96618"
        /// </summary>
        [JsonProperty("image")]
        public Uri Image { get; set; }
        /// <summary>
        /// Examples: "andres34@gmail.com", "milesz774@gmail.com", "andre55@gmail.com", "stein23@gmail.com", "tompkins23@gmail.com"
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// Examples: "Dayni", "Alisa", "Andre", "James", "John"
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Examples: "Mayez", "Milesz", "Barbuda", "Stein", "Tompkins"
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Examples: "Mr.", "Mrs."
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Examples: "18342 Alisa Square Suite 259", "774 Snider Street", "4593 Michigan Avenue", "Colorado Springs, CO 80903", "4451 Deans Lane"
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        /// <summary>
        /// Examples: "USA"
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
        /// <summary>
        /// Examples: "Maxime ratione optio ratione voluptatem sed rem rerum.\n\t\t\t\t  Eaque voluptatem veniam voluptatum porro. Animi sequi nisi ut\n\t\t\t\t  quia minima aspernatur. At enim consequuntur sunt blanditiis."
        /// </summary>
        [JsonProperty("bio")]
        public string Bio { get; set; }
        /// <summary>
        /// Examples: "3.0600000000000001", "3.0600000000000002", "1.0600000000000001", "5.0600000000000001", "2.0600000000000001"
        /// </summary>
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
