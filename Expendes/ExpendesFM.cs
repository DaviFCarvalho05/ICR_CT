using System;
using System.Windows.Forms;
using Icr_Treasury_Control.Classes;

namespace Icr_Treasury_Control.Expendes
{
    public partial class ExpendesFM : Form
    {
        public ExpendesFM()
        {
            InitializeComponent();
        }

        DataRec dr = new DataRec();

        private void Register_Expendes_Click(object sender, EventArgs e)
        {
            // Passa a instância atual do ExpendesFM para Register_ExpendesFM
            Register_ExpendesFM Re = new Register_ExpendesFM(this);
            Re.Show();
        }

        private void ExpendesFM_Load(object sender, EventArgs e)
        {
            dr.FirstLaunch();
            DataFilter df = new DataFilter();
            df.ComboBoxPopulator(dr.FolderPath, CB_Periods);
            CB_Periods_SelectedIndexChanged(sender, e);
        }

        private void CB_Periods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Periods.SelectedItem == null) return;

            string selectedPeriod = CB_Periods.SelectedItem.ToString();
            string baseFolder = dr.FolderPath; // Caminho base da pasta
            string dataCategory = "Expendes";

            DataLoad dl = new DataLoad(baseFolder)
            {
                Filter = selectedPeriod,
                DataCategory = dataCategory,
                DataTypeTitle = "Tipo de Despesa",
                DataNameTitle = "Descrição da Despesa"
            };

            try
            {
                var data = dl.LoadData();
                dl.DisplayData(GV_Data, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        public void ReloadData()
        {
            CB_Periods_SelectedIndexChanged(null, null);
        }

        private void Btn_EraseData_Click(object sender, EventArgs e)
        {
            var dataDeletion = new DataDeletion("DataFPath");
            dataDeletion.DeleteSelectedRow(GV_Data);

            ReloadData();
        }

        private void GV_Data_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GV_Data.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
