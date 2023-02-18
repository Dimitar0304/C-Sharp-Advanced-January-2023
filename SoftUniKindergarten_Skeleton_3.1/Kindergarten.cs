using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity  { get; set; }
        public List<Child> Registry  { get; set; }
        public int ChildrenCount { get { return Registry.Count; } }

        public bool AddChild(Child child)
        {
            if (Capacity<=Registry.Count)
            {
                return false;
            }
            Registry.Add(child);
            return true;
        }

        public bool RemoveChild(string childFullName)
        {
            for (int i = 0; i < Registry.Count; i++)
            {
                if ($"{Registry[i].FirstName} {Registry[i].LastName}"==childFullName)
                {
                    Registry.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public Child GetChild(string childFullName)
        {
            return Registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFullName);
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in { Name}:");
            foreach (var item in Registry.OrderByDescending(c=>c.Age).ThenBy(c=>c.LastName).ThenBy(c=>c.FirstName))
            {
                sb.AppendLine($"{item}");
            }
            return sb.ToString().Trim();
        }
    }
}
