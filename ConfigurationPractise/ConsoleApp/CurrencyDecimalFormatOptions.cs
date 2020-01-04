﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    public class CurrencyDecimalFormatOptions
    {
        public int Digits { get; set; }
        public string Symbol { get; set; }

        public CurrencyDecimalFormatOptions(IConfiguration config)
        {
            Digits = int.Parse(config["Digits"]);
            Symbol = config["Symbol"];
        }
    }
}
