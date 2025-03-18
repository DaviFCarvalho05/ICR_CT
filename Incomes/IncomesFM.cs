using System;
using System.Windows.Forms;
using Icr_Treasury_Control.Classes;

namespace Icr_Treasury_Control.Incomes
{
    
    public partial class IncomesFM : Form
    {
        public IncomesFM()
        {
            InitializeComponent();
        }

        DataRec dr = new DataRec();


        private void IncomesFM_Load(object sender, EventArgs e)
        {
            DataFilter df = new DataFilter();
            dr.FirstLaunch();
            df.ComboBoxPopulator(dr.FolderPath, CB_Periods);
            CB_Periods_SelectedIndexChanged(sender, e); // Carrega dados ao inicializar
          
            
        }

        private void CB_Periods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Periods.SelectedItem == null) return;


            DataLoad dataLoad = new DataLoad(dr.FolderPath)
            {
                Filter = CB_Periods.SelectedItem.ToString(),
                DataCategory = "Incomes",
                DataTypeTitle = "Tipo de Receita", // Título personalizado para a coluna DataType
                DataNameTitle = "Descrição da Receita" // Título personalizado para a coluna DataName
            };

            try
            {
                var data = dataLoad.LoadData();
                dataLoad.DisplayData(GV_Data, data); // Use o DataGridView para exibir os dados
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        public void ReloadData()
        {
            // Reutiliza a lógica existente para recarregar os dados
            CB_Periods_SelectedIndexChanged(null, null);
        }
        private void Register_Incomes_Click(object sender, EventArgs e)
        {
            // Passa a instância atual do IncomesFM para Register_IncomesFM
            Register_IncomesFM Ri = new Register_IncomesFM(this);
            Ri.Show();
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
