using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        private int capacity;
        private string model;
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            this.Multiprocessor = new List<CPU>();
        }
        public List<CPU> Multiprocessor 
        {
            get 
            {
                return multiprocessor;
            } 
            set 
            { 
                multiprocessor = value;
            } 
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        

        public int Count { get { return Multiprocessor.Count; } }

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU cpuToRemove = Multiprocessor.FirstOrDefault(x => x.Brand == brand);
            if (cpuToRemove != null) 
            { 
                return Multiprocessor.Remove(cpuToRemove);
            }
            return false;
        }

        //Method MostPowerful() - returns the most powerful CPU
        //(the CPU with the highest frequency)

        public CPU MostPowerful()
        {
            if (Multiprocessor.Count == 0)
            {
                return null;
            }

            CPU mostPowerful = Multiprocessor[0];            

            foreach(var cpu in Multiprocessor)
            {
                if (cpu.Frequency > mostPowerful.Frequency)
                {
                    mostPowerful = cpu;
                }
            }
            return mostPowerful;
        }

        //Method GetCPU(string brand) – returns the CPU with the given brand.
        //If there is no CPU, meeting the requirements, return null

        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(c => c.Brand == brand);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"CPUs in the Computer {Model}:");
            foreach(var cpu in Multiprocessor) 
            { 
                result.AppendLine(cpu.ToString());
            }

            return result.ToString().Trim();
        }
    }


}
