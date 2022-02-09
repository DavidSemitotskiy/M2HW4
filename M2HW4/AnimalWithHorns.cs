namespace M2HW4
{
    public class AnimalWithHorns : AnimalWithWool
    {
        public AnimalWithHorns(string kind, float weight, GenderAnimal gender, string typeGrassToEat, string colorOfWool, float weightOfHorns, float longOfHorns)
            : base(kind, weight, gender, typeGrassToEat, colorOfWool)
        {
            WeightOfHorns = weightOfHorns;
            LongOfHorns = longOfHorns;
        }

        public float WeightOfHorns { get; protected set; }
        public float LongOfHorns { get; protected set; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} : Вес рогов - {WeightOfHorns} : Длина рогов - {LongOfHorns}";
        }
    }
}
