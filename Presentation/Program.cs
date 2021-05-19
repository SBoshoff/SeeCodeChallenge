using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace SeeCodeChallenge
{
    /// <summary>The startup class of the program.</summary>
    class Program
    {
        /// <summary>
        /// Initialises a new EventService instance
        /// </summary>
        static IEventService eventService = new EventService();

        /// <summary>
        /// The main function of the program
        /// </summary>
        /// <param name="args">Optional arguments to pass to the application</param>
        static void Main(string[] args)
        {
            string output = JsonConvert.SerializeObject(eventService.getEvents(), Formatting.Indented);

            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = Path.Combine(path, "output.json");
            File.WriteAllText(fileName, output);
            Console.WriteLine($"Output file saved to {fileName}");
            Console.WriteLine("Output:");
            Console.WriteLine(output);
        }
    }
}
