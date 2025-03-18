using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Icr_Treasury_Control.Classes;
using System.Runtime.Intrinsics.Arm;
using DocumentFormat.OpenXml.Drawing;

namespace Icr_Treasury_Control.Dashboard
{
    public partial class Dashboard : Form
    {

        ConfigManager cfs = new ConfigManager();
        DateCB dtcb = new DateCB();

        public Dashboard()
        {
            InitializeComponent();
            ConfigManager cfs = new ConfigManager();
        }
        Dashboard_Funcs DsF = new Dashboard_Funcs();
        DataRec dr = new DataRec();




        private void Dashboard_Load(object sender, EventArgs e)
        {

            string PdP = CB_Periods.Text;

            DataFilter df = new DataFilter();
            dr.FirstLaunch();
            df.ComboBoxPopulator(dr.FolderPath, CB_Periods);
            CB_Periods_SelectedIndexChanged(sender, e);

            DynamicIn();
            DynamicEx();
        }
        public string Db => CB_Periods.Text;

        private void CB_Periods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Periods.SelectedIndex == null) return;

            string selectedPeriod = CB_Periods.SelectedItem.ToString();
            string baseFolder = dr.FolderPath;

            DynamicIn();
            DynamicEx();
        }
        public void DynamicIn()
        {
            string pr = System.IO.Path.Combine(dr.FolderPath, Db, "Incomes");

            if (!Directory.Exists(pr) || !Directory.EnumerateFiles(pr, "*.json").Any())
            {
                LB_Total_In.Text = "R$ 0,00";
                PB_Donation.Value = 0;
                PB_Offer.Value = 0;
                PB_Tilte.Value = 0;
                PB_Donation.DisplayText = "0%";
                PB_Offer.DisplayText = "0%";
                PB_Tilte.DisplayText = "0%";
                LB_Donation.Text = "0";
                LB_Offer.Text = "0";
                LB_Tilte.Text = "0";
                return;
            }

            double In_Total = DsF.Total("Incomes", Db);
            LB_Total_In.Text = In_Total.ToString("C");

            int Total_In_N = DsF.File_Total(Db, "Incomes");
            int Offer_N = DsF.CtDtT(Db, "Incomes", "Oferta");
            int Tilte_N = DsF.CtDtT(Db, "Incomes", "Dizimo");
            int Donation_N = DsF.CtDtT(Db, "Incomes", "Doação");


            double Offer_Per = DsF.Percentual(Db, "Oferta", In_Total, "Incomes");
            double Tilte_Per = DsF.Percentual(Db, "Dizimo", In_Total, "Incomes");
            double Donation_Per = DsF.Percentual(Db, "Doação", In_Total, "Incomes");

            PB_Donation.Value = Math.Round(Donation_Per);
            PB_Offer.Value = Math.Round(Offer_Per);
            PB_Tilte.Value = Math.Round(Tilte_Per);

            PB_Donation.DisplayText = Math.Round(Donation_Per).ToString() + "%";
            PB_Offer.DisplayText = Math.Round(Offer_Per).ToString() + "%";
            PB_Tilte.DisplayText = Math.Round(Tilte_Per).ToString() + "%";

            LB_Donation.Text = Donation_N.ToString();
            LB_Offer.Text = Offer_N.ToString();
            LB_Tilte.Text = Tilte_N.ToString();
        }


        public void DynamicEx()
        {



            string pr = System.IO.Path.Combine(dr.FolderPath, Db, "Expendes");

            if (!Directory.Exists(pr) || !Directory.EnumerateFiles(pr, "*.json").Any())
            {
                LB_Total_Ex.Text = "R$ 0,00";
                LB_Balance.Text = "R$ 0,00";
                PB_Help.Value = 0;
                PB_Fixed.Value = 0;
                PB_Several.Value = 0;
                PB_M_I.Value = 0;
                PB_Help.DisplayText = "0%";
                PB_Fixed.DisplayText = "0%";
                PB_Several.DisplayText = "0%";
                PB_M_I.DisplayText = "0%";
                return;
            }

            double In_Total = DsF.Total("Incomes", Db);
            double Ex_Total = DsF.Total("Expendes", Db);
            int Ex_Help = DsF.Percentual(Db, "Socorro", Ex_Total, "Expendes");
            int Ex_Fixed = DsF.Percentual(Db, "Gastos Fixos", Ex_Total, "Expendes");
            int Ex_Several = DsF.Percentual(Db, "Diversos", Ex_Total, "Expendes");
            int Ex_MnIm = DsF.Percentual(Db, "Manutenção e Melhorias", Ex_Total, "Expendes");

            PB_Help.DisplayText = Ex_Help.ToString() + "%";
            PB_Help.Value = Ex_Help;

            PB_Fixed.DisplayText = Ex_Fixed.ToString() + "%";
            PB_Fixed.Value = Ex_Fixed;

            PB_Several.DisplayText = Ex_Several.ToString() + "%";
            PB_Several.Value = Ex_Several;

            PB_M_I.DisplayText = Ex_MnIm.ToString() + "%";
            PB_M_I.Value = Ex_MnIm;

            LB_Total_Ex.Text = Ex_Total.ToString("C");
            LB_Balance.Text = (In_Total - Ex_Total).ToString("C");

        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
            var cf = cfs.LoadConfigurations();

            // Caminho da logo
            string logoPath = System.IO.Path.Combine(dr.FolderPath, "-Configurações", "logo.png");

            // Informações da igreja
            string ChuDenoFed = cf.ChuDenoFed.ToString();
            string Church = cf.ChurchName.ToString();
            string ID = CnpjFormat(cf.PersoID.ToString());

            // Carregando os dados de receitas
            var dataLoadIn = new DataLoad(dr.FolderPath);
            dataLoadIn.Filter = CB_Periods.SelectedItem.ToString();  // A pasta ou categoria de receitas
            dataLoadIn.DataCategory = "Incomes";  // Categoria de receitas
            List<DataRecord> Incomes = dataLoadIn.LoadData();

            // Carregando os dados de despesas
            var dataLoadEx = new DataLoad(dr.FolderPath);
            dataLoadEx.Filter = CB_Periods.SelectedItem.ToString();  // A pasta ou categoria de despesas
            dataLoadEx.DataCategory = "Expendes";  // Categoria de despesas
            List<DataRecord> Expendes = dataLoadEx.LoadData();

            // Convertendo as listas de DataRecord para a estrutura que o método de relatório precisa
            var incomesList = ConvertToDataRecList(Incomes);
            var expendesList = ConvertToDataRecList(Expendes);

            // Chamada do método para gerar o relatório
            FReport.GenerateReport(ChuDenoFed, Church, ID, incomesList, expendesList);


            // Informar ao usuário que o relatório foi gerado
            MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_PublicAccount_Click(object sender, EventArgs e)
        {
            var cf = cfs.LoadConfigurations();

            // Caminho da logo
            string logoPath = System.IO.Path.Combine(dr.FolderPath, "-Configurações", "logo.png");

            // Informações da igreja
            string ChuDenoFed = cf.ChuDenoFed.ToString();
            string Church = cf.ChurchName.ToString();
            string ID = CnpjFormat(cf.PersoID.ToString());



            // Carregando os dados de despesas
            var dataLoadEx = new DataLoad(dr.FolderPath);
            dataLoadEx.Filter = CB_Periods.SelectedItem.ToString();  // A pasta ou categoria de despesas
            dataLoadEx.DataCategory = "Expendes";  // Categoria de despesas
            List<DataRecord> Expendes = dataLoadEx.LoadData();

            // Convertendo as listas de DataRecord para a estrutura que o método de relatório precisa

            var ex_FixedList = ConvertAndFilterData(Expendes, "Gastos Fixos");
            var ex_HelpList = ConvertAndFilterData(Expendes, "Socorro");
            var ex_MainList = ConvertAndFilterData(Expendes, "Manutenção e Melhorias");
            var ex_MiscList = ConvertAndFilterData(Expendes, "Diversos");
            int InNum = DsF.File_Total(CB_Periods.SelectedItem.ToString(), "Incomes");
            DateTime datecb = dtcb.ParseCustomDate(CB_Periods.SelectedItem.ToString());

            // Chamada do método para gerar o relatório
            PublicAccount.GeneratePA(datecb.ToString("MMMM/yyyy", new CultureInfo("pt-BR")), ChuDenoFed, Church, ex_FixedList, ex_HelpList, ex_MainList, ex_MiscList, InNum);


            // Informar ao usuário que o relatório foi gerado
            MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private List<DataRec> ConvertToDataRecList(List<DataRecord> dataList)
        {
            var result = new List<DataRec>();
            foreach (var item in dataList)
            {
                result.Add(new DataRec
                {
                    DataName = item.DataName,
                    DataValue = item.DataValue
                });
            }
            return result;
        }
        public string CnpjFormat(string doc)
        {
            if (string.IsNullOrEmpty(doc))
                return "Documento inválido"; // Ou retorne string.Empty
            switch (doc.Length)
            {
                case 14:
                    return Convert.ToUInt64(doc).ToString(@"00\.000\.000\/0000\-00");


                default:
                    return "Documento inválido";


            }
        }

        private static List<DataRec> ConvertAndFilterData(List<DataRecord> dataList, string dataType)
        {
            return dataList
                .Where(item => item.DataType.Trim().Equals(dataType.Trim(), StringComparison.OrdinalIgnoreCase)) // 🔹 Filtra antes de converter
                .Select(item => new DataRec
                {
                    DataName = item.DataName,
                    DataValue = item.DataValue,
                    DataType = item.DataType // Mantendo o DataType se for necessário
                })
                .ToList();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {

            if (gp_Content.Width >= 1366)
            {
    
                Pn_Expendes.Dock = DockStyle.Right;
                Pn_Incomes.Dock = DockStyle.Left;
                gp_Content.Height = 1200;
                gp_Cont.Height = gp_Content.Height-200;
            }else
            {
                Pn_Expendes.Dock = DockStyle.Bottom;
                Pn_Incomes.Dock = DockStyle.Top;
                gp_Content.Height = 2000;
                gp_Cont.Height  = gp_Content.Height -200;
            }
        }

        private void LB_Balance_Click(object sender, EventArgs e)
        {

        }
    }
}