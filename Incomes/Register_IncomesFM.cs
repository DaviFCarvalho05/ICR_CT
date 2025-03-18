using System;
using System.Globalization;
using System.Windows.Forms;
using Icr_Treasury_Control.Classes;

namespace Icr_Treasury_Control.Incomes
{
    public partial class Register_IncomesFM : Form
    {
        
        private IncomesFM _parentForm;

        public Register_IncomesFM(IncomesFM parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        Radio r = new Radio();
        string selectedPeriod;
        private void Register_IcomesFM_Load(object sender, EventArgs e)
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
                bool isValueValid, isTypeSelected, isDonorNameFilled, isAllTrue;
                isValueValid = !string.IsNullOrEmpty(txt_INValue.Text) && decimal.TryParse(txt_INValue.Text, out decimal value) && value > 0;
                isTypeSelected = rd_Offer.Checked || rd_Tithe.Checked || rd_Donation.Checked;
                isDonorNameFilled = !string.IsNullOrEmpty(txt_donor_name.Text);
                isAllTrue = isValueValid && isTypeSelected && isDonorNameFilled;

                switch (isAllTrue)
                {
                    case true:
                        string incomeType = r.GetSelectedRadioButton(Income_Type);
                        string donor_name = txt_donor_name.Text;
                        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

                        DataRec data = new DataRec
                        {
                            DataClass = "Incomes",
                            DataType = incomeType,
                            DataValue = (double)txt_INValue.Value,
                            DataName = ti.ToTitleCase(donor_name.ToLower()),
                        };

                        data.SaveDataFile(data.DataClass, data.DataValue, data.DataType, data.DataName, selectedPeriod);

                        MessageBox.Show("Entrada Registrada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show($"Erro ao registrar entrada: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
