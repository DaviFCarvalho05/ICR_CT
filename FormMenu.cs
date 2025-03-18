using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Icr_Treasury_Control.Dashboard;
using Icr_Treasury_Control.Incomes;
using Icr_Treasury_Control.Expendes;
using Icr_Treasury_Control.Classes;
using System.Globalization;
using Newtonsoft.Json;
using Microsoft.VisualBasic.Logging;
using System.Runtime.ConstrainedExecution;


namespace Icr_Treasury_Control
{
    public partial class FormMenu : Form
    {
        DataRec dt = new DataRec();
        private ConfigManager configManager;



        private void OpenForm(Form form)
        {
            // Fechar formulários abertos
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Configurar o formulário como filho MDI
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized; // Abrir maximizado (opcional)
            form.Show();
        }
        private void Hide()
        {
            panelMenu.Width = 0;
            btnMenu.BackColor = Color.Transparent;

        }





        public FormMenu()
        {
            InitializeComponent();
            configManager = new ConfigManager();


        }

        private bool isMenuPinned = false;



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new Dashboard.Dashboard());
        }

        private void btnIncomes_Click(object sender, EventArgs e)
        {
            OpenForm(new Incomes.IncomesFM());
        }

        private void btnExpendes_Click(object sender, EventArgs e)
        {
            OpenForm(new Expendes.ExpendesFM());
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            string cf = Path.Combine(dt.FolderPath, "-Configurações", "Config.Json");
            panelMenu.Width = (int)(this.Width * 0.3); // 30% of the form's width


            if (!isMenuPinned)
            {
                if (File.Exists(cf))
                {
                    var configuracoes = configManager.LoadConfigurations();
                    Color cor = Color.FromArgb((int)configuracoes.Color);
                    btnMenu.BackColor = cor;

                }
                else
                {
                    btnMenu.BackColor = Color.SeaGreen;

                }



            }
        }

        private void FormMenu_Resize(object sender, EventArgs e)
        {

            panelMenu.Height = this.Height;
        }

        private void panelMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!panelMenu.Bounds.Contains(PointToClient(MousePosition)))
            {
                Hide();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {




            string cf = Path.Combine(dt.FolderPath, "-Configurações", "Config.Json");
            string logo = Path.Combine(dt.FolderPath, "-Configurações", "logo.png");

            if (File.Exists(cf) && File.Exists(logo))
            {
                var configuracoes = configManager.LoadConfigurations();

                OpenForm(new Dashboard.Dashboard());
                Color cor = Color.FromArgb((int)configuracoes.Color);
                panelMenu.BackColor = cor;
                btnConfig.BackColor = cor;
                btnDashboard.BackColor = cor;
                btnExpenses.BackColor = cor;
                btnIncomes.BackColor = cor;
            }
            else
            {
                OpenForm(new Config.Config());
                panelMenu.BackColor = Color.SeaGreen;
                btnConfig.BackColor = Color.SeaGreen;
                btnDashboard.BackColor = Color.SeaGreen;
                btnExpenses.BackColor = Color.SeaGreen;
                btnIncomes.BackColor = Color.SeaGreen;

            }

            dt.FirstLaunch();
            Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenForm(new Config.Config());
        }



    }
}