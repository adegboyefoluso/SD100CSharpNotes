// using _12_IntroToAPI.Models;
using _12_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            // var response = client.GetAsync("https://swapi.dev/api/people/1");
            HttpResponseMessage response = client.GetAsync("https://swapi.dev/api/people/1").Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content;
                string contentString = content.ReadAsStringAsync().Result;
                // Console.WriteLine(contentString);

                Person person = content.ReadAsAsync<Person>().Result;
                Console.WriteLine($"{person.Name,25}: {person.Height,3} cm, {person.Mass,3} kg");

                foreach (string vehicleUrl in person.Vehicles)
                {
                    HttpResponseMessage vehicleResponse = client.GetAsync(vehicleUrl).Result;

                    // Challenge: Create a Vehicle class, and use ReadAsAsync<>() to get the Name and Model of each vehicle and print them to the console (in this loop)

                    Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                    Console.WriteLine($"{vehicle.Name,30}: {vehicle.Model,15}, {vehicle.Cost_In_Credits}");

                }
            }
            Console.ReadKey();
            Console.Clear();

            SWAPIService service = new SWAPIService("https://swapi.dev/api/");

            while (true)
            {

                Console.Write("Enter an ID: ");
                string id = Console.ReadLine();

                if (id == "no")
                {
                    break;
                }

                Person person2 = service.GetPersonByIdAsync(id).Result;

                Console.WriteLine(person2.Name);

                foreach (string vehicleUrl in person2.Vehicles)
                {
                    var vehicle = service.GetAsync<Vehicle>(vehicleUrl).Result;
                    Console.WriteLine($"   { vehicle.Name,30}");
                }

                Console.ReadKey();
            }

            Console.Write("Search for a vehicle? ");
            string query = Console.ReadLine();
            var results = service.GetVehicleSearchAsync(query).Result.Results;

            Console.WriteLine($"{results.Count} vehicles found:");

            foreach (Vehicle vehicle in results)
            {
                Console.WriteLine($"{vehicle.Name}, {vehicle.Model}");
            }

            Console.ReadKey();
        }
    }
}
