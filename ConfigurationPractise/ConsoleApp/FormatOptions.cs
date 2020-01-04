using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    public class FormatOptions
    {
        public DateTimeFormatOptions DateTime { get; set; }

        public CurrencyDecimalFormatOptions CurrencyDecimal { get; set; }

        public FormatOptions(IConfiguration config)
        {
            DateTime = new DateTimeFormatOptions(config.GetSection("DateTime"));
            CurrencyDecimal = new CurrencyDecimalFormatOptions(config.GetSection("CurrencyDecimal"));
        }
    }
}
