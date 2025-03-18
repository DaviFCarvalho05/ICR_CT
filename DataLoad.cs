using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Icr_Treasury_Control.Classes
{
    public class DataLoad
    {
        public string BaseFolder { get; set; } // Base folder for data
        public string Filter { get; set; } // Selected folder filter
        public string DataCategory { get; set; } // "Incomes" or "Expendes"
        public string DataTypeTitle { get; set; } // Custom title for DataType column
        public string DataNameTitle { get; set; } // Custom title for DataName column
        public string DataValueTitle { get; set; } // Custom title for DataValue column

        public DataLoad(string baseFolder)
        {
            BaseFolder = baseFolder;
        }

        public List<DataRecord> LoadData()
        {
            if (string.IsNullOrEmpty(Filter) || string.IsNullOrEmpty(DataCategory))
                throw new InvalidOperationException("Filtro e categoria não foram selecionados");

            string folderPath = Path.Combine(BaseFolder, Filter, DataCategory);

            if (!Directory.Exists(folderPath))
                throw new DirectoryNotFoundException($"The folder {folderPath} was not found.");

            List<DataRecord> dataList = new List<DataRecord>();

            foreach (string filePath in Directory.GetFiles(folderPath, "*.json"))
            {
                string jsonContent = File.ReadAllText(filePath);
                DataRecord data = JsonSerializer.Deserialize<DataRecord>(jsonContent);
                dataList.Add(data);
            }

            return dataList;
        }

        public void DisplayData(DataGridView dataGridView, List<DataRecord> data)
        {
            dataGridView.DataSource = data;

            if (dataGridView.Columns["DataType"] != null)
                dataGridView.Columns["DataType"].HeaderText = DataTypeTitle ?? "Tipo";

            if (dataGridView.Columns["DataValue"] != null)
                dataGridView.Columns["DataValue"].HeaderText = DataValueTitle ?? "Valor";

            if (dataGridView.Columns["DataName"] != null)
                dataGridView.Columns["DataName"].HeaderText = DataNameTitle ?? "Nome do contribuinte";

            if (dataGridView.Columns["DataFPath"] != null)
                dataGridView.Columns["DataFPath"].Visible = false;

            dataGridView.Columns["DataValue"].DefaultCellStyle.Format = "C2";
            dataGridView.Columns["DataValue"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdjustDataGridViewHeight(dataGridView);
        }

        public void DisplayDataFiltered(DataGridView dataGridView, List<DataRecord> data, string filterType)
        {
            if (filterType == "")
            {
                dataGridView.DataSource = data;
            }
            else
            {
                var filteredData = data.Where(d => d.DataType == filterType).ToList();
                dataGridView.DataSource = filteredData;
            }

            if (dataGridView.Columns["DataName"] != null)
                dataGridView.Columns["DataName"].HeaderText = DataNameTitle;

            if (dataGridView.Columns["DataValue"] != null)
                dataGridView.Columns["DataValue"].HeaderText = "Valor Gasto";

            if (dataGridView.Columns["DataType"] != null)
                dataGridView.Columns["DataType"].Visible = false;

            if (dataGridView.Columns["DataFPath"] != null)
                dataGridView.Columns["DataFPath"].Visible = false;

            dataGridView.Columns["DataValue"].DefaultCellStyle.Format = "C2";
            dataGridView.Columns["DataValue"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("pt-BR");

            dataGridView.Columns["DataName"].DisplayIndex = 0;
            dataGridView.Columns["DataValue"].DisplayIndex = 1;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdjustDataGridViewHeight(dataGridView);
        }

        private void AdjustDataGridViewHeight(DataGridView dataGridView)
        {
            int rowHeight = dataGridView.RowTemplate.Height;
            int headerHeight = dataGridView.ColumnHeadersHeight;
            int rowCount = dataGridView.Rows.Count;
            int padding = 10;
            dataGridView.Height = (rowCount * rowHeight) + headerHeight + padding;
        }
    }

    public class DataRecord
    {
        public string DataType { get; set; }
        public double DataValue { get; set; }
        public string DataName { get; set; }
        public string DataFPath { get; set; }
    }
}
