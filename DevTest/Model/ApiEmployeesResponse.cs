using System;
using System.Collections.Generic;
using System.Text;
using DevTest.Settings;
using Newtonsoft.Json;

namespace DevTest.Model
{
    class ApiEmployeesResponse: ApiResponse
    {
        [JsonProperty("data ")]
        public IList<Employee> Employees { get; set; }

        private IList<Employee>GetEmployees(string json ) =>JsonConvert.DeserializeObject<IList<Employee>>($"[{ json.Split("[")[1].Split("]")[0]}]", Converter.Settings);
        
        public static ApiEmployeesResponse FromJson ( string json ) => JsonConvert.DeserializeObject<ApiEmployeesResponse>(json, Converter.Settings);

        public void Display (string json )
        {
            foreach(Employee employee in GetEmployees(json))
            {
                Console.WriteLine(employee.ToString());
            }
        }

    }


}
