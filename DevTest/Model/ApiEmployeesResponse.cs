using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DevTest.Model
{
    class ApiEmployeesResponse: ApiResponse
    {
        [JsonProperty("data ")]
        public Employee[] Data { get; set; }
    }
}
