using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessAnimalsShelter.Core.OutputModels
{
    public class AnimalOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> TagList { get; set; } = new List<string>();
    }
}

