using System;
using System.Globalization;
using System.Windows.Forms;
using Icr_Treasury_Control.Classes;

namespace Icr_Treasury_Control.Expendes
{
    public partial class Register_ExpendesFM : Form
    {
        string selectedPeriod;

        private ExpendesFM _parentForm;

        public Register_ExpendesFM(ExpendesFM parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        Radio r = new Radio();


        private void Register_ExpendesFM_Load(object sender, EventArgs e)
        {
            DataRec dr = new DataRec();

            DataFilter df = new DataFilter();
            df.ComboBoxPopulator(dr.FolderPath, CB_Periods);

        }

        private void CB_Periods_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRec dr = new DataRec();


            try
            {
                if (CB_Periods.SelectedItem == null) return;
                selectedPeriod = CB_Periods.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValueValid, isTypeSelected, isDescFilled, isAllTrue;
                isValueValid = !string.IsNullOrEmpty(txt_ExValue.Text) && decimal.TryParse(txt_ExValue.Text, out decimal value) && value > 0;
                isTypeSelected = rd_Fixed_Expenses.Checked || rd_Help.Checked || rd_Several.Checked || rd_Maintenance_Improvements.Checked;
                isDescFilled = !string.IsNullOrEmpty(txt_expense_desc.Text);
                isAllTrue = isValueValid && isTypeSelected && isDescFilled;

                switch (isAllTrue)
                {
                    case true:
                        string expenseDesc = txt_expense_desc.Text;
                        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                        string expenseType = r.GetSelectedRadioButton(Expense_Type);

                        DataRec data = new DataRec
                        {
                            DataClass = "Expendes",
                            DataType = expenseType,
                            DataValue = (double)txt_ExValue.Value,
                            DataName = ti.ToTitleCase(expenseDesc.ToLower())
                        };

                        data.SaveDataFile(data.DataClass, data.DataValue, data.DataType, data.DataName, selectedPeriod);

                        MessageBox.Show("Saída Registrada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recarrega os dados no formulário principal
                        _parentForm?.ReloadData();

                        this.Close();
                        break;

                    case false:
                        MessageBox.Show("Entrada com informações faltando", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar saída: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
