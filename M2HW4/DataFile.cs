namespace M2HW4
{
    public class DataFile : IDataProvider
    {
        public Animal[] GetData()
        {
            return new Animal[]
            {
            new HerbivoreAnimal("aaaa", 23.3f, GenderAnimal.Female, "dawd"),
            new AnimalWithHooves("bbb", 53.4f, GenderAnimal.Masculine, "dawd", "hdh", 4.3f, 10f, "hha"),
            new AnimalWithHorns("hahd", 123f, GenderAnimal.Masculine, "kkk", "kkadj", 12f, 34f),
            new AnimalWithWool("jjj", 75f, GenderAnimal.Female, "lll", "oooad"),
            new AnimalWithHooves("asaa", 23.4f, GenderAnimal.Masculine, "ada", "aaad", 4.3f, 10f, "hha")
            };
        }
    }
}
