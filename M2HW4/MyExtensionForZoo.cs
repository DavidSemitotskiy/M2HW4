namespace M2HW4
{
    public static class MyExtensionForZoo
    {
        public static Animal[] SearchGenderAnimal(this Zoo zoo, GenderAnimal gender)
        {
            if (zoo == null)
            {
                return null;
            }

            Animal[] newArray = Array.Empty<Animal>();
            for (int i = 0; i < zoo.Section.Animals.Length; i++)
            {
                if (zoo.Section.Animals[i].Gender == gender)
                {
                    newArray = newArray.Add(zoo.Section.Animals[i]);
                }
            }

            return newArray;
        }
    }
}
