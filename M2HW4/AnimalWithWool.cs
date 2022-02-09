using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4
{
    public class AnimalWithWool : HerbivoreAnimal
    {
        public AnimalWithWool(string kind, float weight, GenderAnimal gender, string typeGrassToEat, string colorOfWool)
            : base(kind, weight, gender, typeGrassToEat)
        {
            ColorOfWool = colorOfWool;
        }

        public string ColorOfWool { get; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} : Цвет шерсти - {ColorOfWool}";
        }
    }
}
