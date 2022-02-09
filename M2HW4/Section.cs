using System.Text;

namespace M2HW4
{
    public class Section : ISection
    {
        private Animal[] _animals;
        public Section(IDataProvider data)
        {
            if (data == null)
            {
                _animals = Array.Empty<Animal>();
                return;
            }

            _animals = data.GetData();
        }

        public Animal[] Animals
        {
            get => _animals;
        }

        public string GetDescriptionSection()
        {
            if (_animals.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder str = new StringBuilder(_animals[0].GetDesription());
            for (int i = 1; i < _animals.Length; i++)
            {
                str.Append($"\n{_animals[i].GetDesription()}");
            }

            return Convert.ToString(str);
        }

        public void AddAnimal(Animal animal)
        {
            _animals = _animals.Add(animal);
        }
    }
}
