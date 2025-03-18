using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Icr_Treasury_Control.Classes
{
    public class DataFilter
    {
        private DataRec dr =new DataRec();
        public void ComboBoxPopulator(string directoryPath, ComboBox comboBox)
        {
            if (Directory.Exists(directoryPath))
            {
                string[] directories = Directory.GetDirectories(directoryPath);
                comboBox.Items.Clear();

                foreach (string directory in directories)
                {
                    if (Path.GetFileName(directory) != "-Configurações")
                    {
                        comboBox.Items.Add(Path.GetFileName(directory));
                    }
                    DateTime now = DateTime.Now;
                    string currentMonthYear = now.ToString("yyyyMM", new CultureInfo("pt-BR"));

                    // Generate the folder name based on the date format (yyyyMM)
                    string newFolderName = $"{currentMonthYear}-{now.ToString("MMMM 'de' yyyy", new CultureInfo("pt-BR"))}";

                    // Create the folder for this month
                    string monthFolder = Path.Combine(dr.FolderPath, newFolderName);

                    if (comboBox.Items.Contains(newFolderName))
                    {
                        comboBox.SelectedItem = newFolderName;
                    }
                }
            }
        }
        public void PopulateTypeComboBox(ComboBox comboBox, string transactionType)
        {
            comboBox.Items.Clear();

            // Adiciona a opção padrão "Todos"
            comboBox.Items.Add("Todos");

            // Adiciona os itens específicos com base no tipo de transação
            switch (transactionType.ToLower())
            {
                case "incomes":
                    comboBox.Items.AddRange(new[] { "Dízimo", "Oferta", "Doação" });
                    break;
                case "expendes":
                    comboBox.Items.AddRange(new[] { "Gastos Fixos", "Socorro", "Diversos", "Manutenção e Melhorias" });
                    break;
                default:
                    // Opcional: tratar casos não esperados
                    break;
            }

            // Define "Todos" como seleção padrão
            comboBox.SelectedIndex = 0;
        }

    }
}