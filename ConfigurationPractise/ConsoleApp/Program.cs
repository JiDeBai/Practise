using System;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var source = new Dictionary<string, string> 
            {
                ["format:dateTime:longDatePattern"] = "dddd, MMMM d, yyyy",
                ["format:dateTime:longTimePattern"] = "h:mm:ss tt",
                ["format:dateTime:shortDatePattern"] = "M/d/yyyy",
                ["format:dateTime:shortTimePattern"] = "h:mm tt",

                ["format:currencyDecimal:digits"] = "2",
                ["format:currencyDecimal:symbol"] = "$",

            };

            var config = new ConfigurationBuilder()
                .Add(new MemoryConfigurationSource { InitialData = source })
                .Build();

            var options = new FormatOptions(config.GetSection("Format"));
            var datetime = options.DateTime;
            var currencyDecimal = options.CurrencyDecimal;
            Console.WriteLine($"Datetime:");
            Console.WriteLine($"\tShortTimePattern:{ datetime.ShortTimePattern}");
            Console.ReadLine();

        }
    }
}
