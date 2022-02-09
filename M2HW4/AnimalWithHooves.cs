namespace M2HW4
{
    public class AnimalWithHooves : AnimalWithHorns
    {
        public AnimalWithHooves(string kind, float weight, GenderAnimal gender, string typeGrassToEat, string colorOfWool, float weightOfHorns, float longOfHorns, string typeOfHooves)
            : base(kind, weight, gender, typeGrassToEat, colorOfWool, weightOfHorns, longOfHorns)
        {
            TypeOfHooves = typeOfHooves;
        }

        public string TypeOfHooves { get; }

        public override string GetDesription()
        {
            return $"{base.GetDesription()} : Тип копыт - {TypeOfHooves}";
        }
    }
}
