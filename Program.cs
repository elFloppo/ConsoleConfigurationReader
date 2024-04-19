using ConfigurationReader.Models;
using ConfigurationReader.Services;

namespace ConsoleConfigurationReader
{
    public class Program
    {
        private static readonly string _fileDirectory = $@"{Environment.CurrentDirectory}\TestFiles";
        private static List<Configuration> _configurations = new();

        public static void Main()
        {
            try
            {
                AddConfigurationFromFile($@"{_fileDirectory}\CorrectConfiguration.xml");
                AddConfigurationFromFile($@"{_fileDirectory}\CorrectConfiguration.csv");
            }
            catch
            {
                Console.WriteLine("Ошибка десериализации");
            }

            Console.ReadKey(true);
        }

        private static void AddConfigurationFromFile(string filePath)
        {
            var configuration = Deserializer.DeserializeFile<Configuration>(filePath);
            _configurations.Add(configuration);

            Console.WriteLine("Список конфигураций:");
            foreach (var config in _configurations)
                Console.WriteLine($"Name: {config.Name}, Description: {config.Description}");

            Console.WriteLine();
        }
    }
}
