using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW4
{
    public abstract class Animal : IComparable<Animal>
    {
        public Animal(string kind, float weight, GenderAnimal gender)
        {
            Kind = kind;
            Weight = weight;
            Gender = gender;
        }

        public string Kind { get; }
        public GenderAnimal Gender { get; }
        public float Weight { get; protected set; }

        public virtual string GetDesription()
        {
            return $"Вид - {Kind} : Пол - {Gender} : Вес - {Weight}";
        }

        public int CompareTo(Animal? other)
        {
            return Gender.CompareTo(other.Gender);
        }
    }
}
