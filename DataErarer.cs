using System;
using System.IO;
using System.Windows.Forms;

namespace Icr_Treasury_Control.Classes
{
    public class DataDeletion
    {
        /// <summary>
        /// Nome da coluna no DataGridView que contém o caminho do arquivo JSON a ser excluído.
        /// </summary>
        public string FilePathColumnName { get; set; }

        public DataDeletion(string filePathColumnName)
        {
            if (string.IsNullOrEmpty(filePathColumnName))
                throw new ArgumentException("O nome da coluna do caminho do arquivo não pode ser nulo ou vazio.");

            FilePathColumnName = filePathColumnName;
        }

        /// <summary>
        /// Exclui o arquivo correspondente à linha selecionada no DataGridView.
        /// </summary>
        /// <param name="dataGridView">O DataGridView contendo os dados.</param>
        public void DeleteSelectedRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma linha para excluir.");
                return;
            }

            var selectedRow = dataGridView.SelectedRows[0];

            // Verificar se a coluna existe no DataGridView
            if (!dataGridView.Columns.Contains(FilePathColumnName))
            {
                MessageBox.Show($"A coluna '{FilePathColumnName}' não foi encontrada no DataGridView.");
                return;
            }

            // Obter o caminho do arquivo a partir da célula
            var filePath = selectedRow.Cells[FilePathColumnName].Value?.ToString();
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("O caminho do arquivo não está definido ou está vazio.");
                return;
            }

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("O registro foi excluído com sucesso.");
                }
                else
                {
                    MessageBox.Show("O arquivo correspondente não foi encontrado.");
                }

                // Remover a linha do DataGridView
                dataGridView.Rows.Remove(selectedRow);
            }
            catch (Exception ex)
            {
                ex = null;
            }
        }
    }
}
