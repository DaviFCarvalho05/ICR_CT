namespace Icr_Treasury_Control
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            btnConfig = new Button();
            btnExpenses = new Button();
            btnIncomes = new Button();
            btnDashboard = new Button();
            btnMenu = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(29, 88, 55);
            panelMenu.BorderStyle = BorderStyle.Fixed3D;
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Controls.Add(btnExpenses);
            panelMenu.Controls.Add(btnIncomes);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(21, 69, 21, 0);
            panelMenu.Size = new Size(0, 1033);
            panelMenu.TabIndex = 2;
            panelMenu.MouseLeave += panelMenu_MouseLeave;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(29, 88, 55);
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnConfig.Font = new Font("Segoe UI", 16F);
            btnConfig.ForeColor = Color.WhiteSmoke;
            btnConfig.Location = new Point(21, 204);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(0, 45);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.FromArgb(29, 88, 55);
            btnExpenses.Dock = DockStyle.Top;
            btnExpenses.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnExpenses.Font = new Font("Segoe UI", 16F);
            btnExpenses.ForeColor = Color.WhiteSmoke;
            btnExpenses.Location = new Point(21, 159);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(0, 45);
            btnExpenses.TabIndex = 2;
            btnExpenses.Text = "Saidas";
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpendes_Click;
            // 
            // btnIncomes
            // 
            btnIncomes.BackColor = Color.FromArgb(29, 88, 55);
            btnIncomes.Dock = DockStyle.Top;
            btnIncomes.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnIncomes.Font = new Font("Segoe UI", 16F);
            btnIncomes.ForeColor = Color.WhiteSmoke;
            btnIncomes.Location = new Point(21, 114);
            btnIncomes.Margin = new Padding(3, 100, 101, 3);
            btnIncomes.Name = "btnIncomes";
            btnIncomes.Size = new Size(0, 45);
            btnIncomes.TabIndex = 1;
            btnIncomes.Text = "Entradas";
            btnIncomes.UseVisualStyleBackColor = false;
            btnIncomes.Click += btnIncomes_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(29, 88, 55);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnDashboard.Font = new Font("Segoe UI", 16F);
            btnDashboard.ForeColor = Color.WhiteSmoke;
            btnDashboard.Location = new Point(21, 69);
            btnDashboard.Margin = new Padding(3, 100, 101, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(0, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Enter += btnMenu_MouseEnter;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.BackgroundImageLayout = ImageLayout.None;
            btnMenu.Location = new Point(9, 9);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(50, 51);
            btnMenu.TabIndex = 6;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            btnMenu.MouseEnter += btnMenu_MouseEnter;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(btnMenu);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Tesouraria";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load;
            Resize += FormMenu_Resize;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private PictureBox btnMenu;
        private Button btnDashboard;
        private Button btnIncomes;
        private Button btnExpenses;
        private Button btnConfig;
    }
}