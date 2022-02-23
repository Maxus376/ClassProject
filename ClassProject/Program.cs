using static System.Console;

namespace ClassProject
{
    class Program
    {
        public static void Main()
        {
            Apteka apt1 = (new Apteka { name = "Губернская"});
            ShowName(apt1.name);
            apt1.Add(new Medicines { name = "Амбробене", price = 390f });
            apt1.Add(new Medicines { name = "Гексорал", price = 500f });
            apt1.Add(new Medicines { name = "Гевискон", price = 900f });
            apt1.Add(new Medicines { name = "Парацетамол", price = 150f });
            apt1.DetectExpensiveMedicines();
            apt1.GetSumPriceMedicines();
            ReadKey();
        }

        static void ShowName(string name)
        {
            WriteLine($"Название аптеки: {name}");
        }
    }
}
