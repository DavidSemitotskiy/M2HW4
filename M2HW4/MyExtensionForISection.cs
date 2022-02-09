namespace M2HW4
{
    public static class MyExtensionForISection
    {
        public static (int, int, int, int) CountAnimalsOfType(this ISection section)
        {
            if (section == null)
            {
                return (0, 0, 0, 0);
            }

            (int HerbivoreAnimal, int AnimalWithWool, int AnimalWithHorns, int AnimalWithHooves) countEveryoneTypes = (0, 0, 0, 0);
            for (int i = 0; i < section.Animals.Length; i++)
            {
                if (section.Animals[i].GetType().Name == TypesOfAnimal.HerbivoreAnimal.ToString())
                {
                    countEveryoneTypes.HerbivoreAnimal++;
                }
                else if (section.Animals[i].GetType().Name == TypesOfAnimal.AnimalWithHooves.ToString())
                {
                    countEveryoneTypes.AnimalWithHooves++;
                }
                else if (section.Animals[i].GetType().Name == TypesOfAnimal.AnimalWithHorns.ToString())
                {
                    countEveryoneTypes.AnimalWithHorns++;
                }
                else
                {
                    countEveryoneTypes.AnimalWithWool++;
                }
            }

            return countEveryoneTypes;
        }
    }
}
