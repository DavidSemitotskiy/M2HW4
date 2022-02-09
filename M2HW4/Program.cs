using M2HW4;
public class Program
{
    public static void Main(string[] args)
    {
        DataFile file = new DataFile();
        Zoo zoo = new Zoo(new Section(file));
        zoo.AddAnimal(new AnimalWithHooves("dawdawds", 32f, GenderAnimal.Masculine, "kkk", "jjad", 2f, 12f, "kakk"));
        Console.WriteLine("Массив животных до сортировки по полу: ");
        zoo.ShowDescriptionOfSection();
        Array.Sort(zoo.Section.Animals);
        Console.WriteLine("Массив животных после сортировки по полу: ");
        zoo.ShowDescriptionOfSection();
        Console.WriteLine("Подсчет количества животных в иерархии: ");
        var result = zoo.Section.CountAnimalsOfType();
        Console.WriteLine($"Количество животных типа - {TypesOfAnimal.HerbivoreAnimal} = {result.Item1}");
        Console.WriteLine($"Количество животных типа - {TypesOfAnimal.AnimalWithWool} = {result.Item2}");
        Console.WriteLine($"Количество животных типа - {TypesOfAnimal.AnimalWithHorns} = {result.Item3}");
        Console.WriteLine($"Количество животных типа - {TypesOfAnimal.AnimalWithHooves} = {result.Item4}");
        Random rand = new Random();
        GenderAnimal gender = (GenderAnimal)rand.Next(2);
        Console.WriteLine($"Поиск по полу животного: {gender}");
        var result1 = zoo.SearchGenderAnimal(gender);
        if (result1 == null || result1.Length == 0)
        {
            Console.WriteLine("По запросу не было найдено животных!!");
        }
        else
        {
            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine($"{i + 1}) Имя вида - {result1[i].Kind} : Пол - {result1[i].Gender} : Вес - {result1[i].Weight}");
            }
        }
    }
}