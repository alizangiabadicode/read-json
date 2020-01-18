using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"D:\readexcel\ConsoleApp1\first.json");
            List<firstExcel> ls = JsonConvert.DeserializeObject<List<firstExcel>>(text);
            foreach (firstExcel i in ls)
            {
                Console.WriteLine($"Address = {i.Address}, Telephone = {i.Telephone}, provice= {i.Provice}");
            }
        }
    }

    class firstExcel
    {
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Provice { get; set; }
        public string TypeMarkaz { get; set; }
        public string NameMarkaz { get; set; }
    }
}

