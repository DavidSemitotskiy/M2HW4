using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4
{
    public interface ISection
    {
        public Animal[] Animals { get; }
        public void AddAnimal(Animal animal);
        public string GetDescriptionSection();
    }
}
