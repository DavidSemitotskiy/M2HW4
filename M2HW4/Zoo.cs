namespace M2HW4
{
    public class Zoo
    {
        public Zoo(ISection section) => Section = section;

        public ISection Section { get; private set; }

        public void ShowDescriptionOfSection()
        {
            Console.WriteLine(Section.GetDescriptionSection());
        }

        public void AddAnimal(Animal animal)
        {
            Section.AddAnimal(animal);
        }
    }
}
