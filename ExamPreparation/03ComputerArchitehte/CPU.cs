using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }

        public string Brand { get; set; }
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public override string ToString()
        {
            //            return "{brand} CPU:
            //Cores: { cores}
            //        Frequency: { frequency}

            //            GHz"
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Brand} CPU:");
            sb.AppendLine($"Cores: {this.Cores}");
            sb.AppendLine($"Frequency: {this.Frequency:f1} GHz");
            string word = sb.ToString().TrimEnd();
            return word;



        }
    }
}
