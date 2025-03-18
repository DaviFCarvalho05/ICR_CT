using System;
using System.Globalization;
using System.IO;
using System.Text.Json;


namespace Icr_Treasury_Control.Classes;



internal class DataRec
{
    
    // Public path to the main folder
    public string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Controle de Tesouraria para Igrejas");
    

    // Properties to hold the data information
    public string DataClass { get; set; }
    public string DataType { get; set; }
    public double DataValue { get; set; }
    public string DataName { get; set; }

    public string DataFPath { get; set; }

    // First launch method to initialize the directories
    public void FirstLaunch()
    {
        // Ensure the main folder exists
        Directory.CreateDirectory(FolderPath);

        // Get all the subdirectories and group them by year and month
        var existingDirs = Directory.GetDirectories(FolderPath);
        var monthDirs = new Dictionary<string, int>();

        foreach (var dir in existingDirs)
        {
            string folderName = new DirectoryInfo(dir).Name;
            string[] parts = folderName.Split('-');
            if (parts.Length == 2 && DateTime.TryParseExact(parts[1], "MMMM 'de' yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out _))
            {
                string monthYear = parts[1];  // Example: "janeiro de 2025"
                if (!monthDirs.ContainsKey(monthYear))
                {
                    monthDirs[monthYear] = 0;
                }
                monthDirs[monthYear]++;
            }
        }

        // Get the current month and year in the specified format (yyyyMM)
        DateTime now = DateTime.Now;
        string currentMonthYear = now.ToString("yyyyMM", new CultureInfo("pt-BR"));

        // Generate the folder name based on the date format (yyyyMM)
        string newFolderName = $"{currentMonthYear}-{now.ToString("MMMM 'de' yyyy", new CultureInfo("pt-BR"))}";

        string ConfigFolder = Path.Combine(FolderPath, "-Configurações");
        Directory.CreateDirectory(ConfigFolder);
        // Create the folder for this month
        string monthFolder = Path.Combine(FolderPath, newFolderName);
        Directory.CreateDirectory(monthFolder);

        // Create subfolders for "Incomes" and "Expendes"
        string incomesFolder = Path.Combine(monthFolder, "Incomes");
        string expensesFolder = Path.Combine(monthFolder, "Expendes");
        Directory.CreateDirectory(incomesFolder);
        Directory.CreateDirectory(expensesFolder);
    }

    // Method to save data into a JSON file in the respective folder
    public void SaveDataFile(string dtClass, double dtValue, string dtType, string dtName, string selectedFolder)
    {
        // Atualizar as propriedades com os dados
        DataClass = dtClass;
        DataValue = dtValue;
        DataType = dtType;
        DataName = dtName;

        // Certificar-se de que a pasta principal existe
        Directory.CreateDirectory(FolderPath);

        // Criar o caminho completo para a pasta selecionada
        string targetFolder = Path.Combine(FolderPath, selectedFolder, DataClass);

        // Verificar se a pasta selecionada existe
        if (!Directory.Exists(targetFolder))
        {
            Console.WriteLine($"A pasta {targetFolder} não existe!");
            return;
        }

        // Gerar o nome do arquivo baseado na data e hora atual
        DateTime now = DateTime.Now;
        string fileName = $"{now:dd.MM_HH-mm-ss}.json";
        string filePath = Path.Combine(targetFolder, fileName);

        DataFPath = filePath;

        // Serializar o objeto para JSON e salvar o arquivo
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);

        Console.WriteLine($"Arquivo salvo em: {filePath}");
    }
}
