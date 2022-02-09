namespace M2HW4
{
    public class HerbivoreAnimal : Animal
    {
        public HerbivoreAnimal(string kind, float weight, GenderAnimal gender, string typeGrassToEat)
            : base(kind, weight, gender)
        {
            TypeGrassToEat = typeGrassToEat;
        }

        public string TypeGrassToEat { get; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} : Пища - {TypeGrassToEat}";
        }
    }
}
