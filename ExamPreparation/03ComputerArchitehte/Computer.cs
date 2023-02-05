using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
        }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor = new List<CPU>();

       public int Count()
        {
          return Multiprocessor.Count;
        }
        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count<this.Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Brand==brand)
                {
                    Multiprocessor.Remove(cpu);
                    return true;
                }
            }
            return false;
           
        }
        public CPU MostPowerful()
        {
            CPU hightesCupfuency = new CPU(" ", 0, 0.0);
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Frequency>hightesCupfuency.Frequency)
                {
                    hightesCupfuency = cpu;
                }
            }
            return hightesCupfuency;
        }
        public CPU GetCPU(string brand)
        {
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Brand == brand)
                {
                    return cpu;
                }
            }
            return null;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {this.Model}:");
            foreach (var cpu in Multiprocessor)
            {
                sb.AppendLine(cpu.ToString());
            }
            string report = sb.ToString().TrimEnd();
            return report;
        }
    }
}
