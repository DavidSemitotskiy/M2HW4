namespace M2HW4
{
    public interface ISection
    {
        public Animal[] Animals { get; }
        public void AddAnimal(Animal animal);
        public string GetDescriptionSection();
    }
}
