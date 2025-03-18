namespace Icr_Treasury_Control.Dashboard
{
    partial class Dashboard
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
            CB_Periods = new ComboBox();
            gp_Content = new GroupBox();
            Lt_Buttons = new FlowLayoutPanel();
            btn_Report = new Button();
            btn_PublicAccount = new Button();
            gp_Cont = new GroupBox();
            Pn_Expendes = new Panel();
            groupBox7 = new GroupBox();
            PB_M_I = new CustomProgressBar();
            label11 = new Label();
            groupBox8 = new GroupBox();
            PB_Several = new CustomProgressBar();
            label12 = new Label();
            groupBox6 = new GroupBox();
            PB_Help = new CustomProgressBar();
            label10 = new Label();
            label16 = new Label();
            label14 = new Label();
            LB_Total_Ex = new Label();
            LB_Balance = new Label();
            groupBox5 = new GroupBox();
            PB_Fixed = new CustomProgressBar();
            label8 = new Label();
            label9 = new Label();
            Pn_Incomes = new Panel();
            groupBox4 = new GroupBox();
            PB_Donation = new CustomProgressBar();
            label6 = new Label();
            LB_Donation = new Label();
            groupBox3 = new GroupBox();
            PB_Offer = new CustomProgressBar();
            label4 = new Label();
            LB_Offer = new Label();
            groupBox2 = new GroupBox();
            PB_Tilte = new CustomProgressBar();
            label3 = new Label();
            LB_Tilte = new Label();
            LB_Total_In = new Label();
            label1 = new Label();
            gp_Content.SuspendLayout();
            Lt_Buttons.SuspendLayout();
            gp_Cont.SuspendLayout();
            Pn_Expendes.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            Pn_Incomes.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CB_Periods
            // 
            CB_Periods.Dock = DockStyle.Top;
            CB_Periods.Font = new Font("Segoe UI", 20F);
            CB_Periods.FormattingEnabled = true;
            CB_Periods.Location = new Point(60, 20);
            CB_Periods.Name = "CB_Periods";
            CB_Periods.Size = new Size(865, 53);
            CB_Periods.TabIndex = 0;
            CB_Periods.SelectedIndexChanged += CB_Periods_SelectedIndexChanged;
            CB_Periods.SelectionChangeCommitted += CB_Periods_SelectedIndexChanged;
            // 
            // gp_Content
            // 
            gp_Content.Controls.Add(Lt_Buttons);
            gp_Content.Controls.Add(gp_Cont);
            gp_Content.Dock = DockStyle.Top;
            gp_Content.Location = new Point(60, 73);
            gp_Content.Name = "gp_Content";
            gp_Content.Size = new Size(865, 1806);
            gp_Content.TabIndex = 1;
            gp_Content.TabStop = false;
            // 
            // Lt_Buttons
            // 
            Lt_Buttons.AutoSize = true;
            Lt_Buttons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Lt_Buttons.Controls.Add(btn_Report);
            Lt_Buttons.Controls.Add(btn_PublicAccount);
            Lt_Buttons.Dock = DockStyle.Top;
            Lt_Buttons.Location = new Point(3, 1773);
            Lt_Buttons.Name = "Lt_Buttons";
            Lt_Buttons.Padding = new Padding(20, 0, 10, 0);
            Lt_Buttons.Size = new Size(859, 128);
            Lt_Buttons.TabIndex = 7;
            // 
            // btn_Report
            // 
            btn_Report.AutoSize = true;
            btn_Report.Dock = DockStyle.Left;
            btn_Report.Font = new Font("Segoe UI", 20F);
            btn_Report.Location = new Point(23, 3);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(810, 58);
            btn_Report.TabIndex = 0;
            btn_Report.Text = "Imprimir Relatório";
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // btn_PublicAccount
            // 
            btn_PublicAccount.AutoSize = true;
            btn_PublicAccount.Dock = DockStyle.Right;
            btn_PublicAccount.Font = new Font("Segoe UI", 20F);
            btn_PublicAccount.Location = new Point(23, 67);
            btn_PublicAccount.Name = "btn_PublicAccount";
            btn_PublicAccount.Size = new Size(809, 58);
            btn_PublicAccount.TabIndex = 1;
            btn_PublicAccount.Text = "Imprimir Prestação de Contas";
            btn_PublicAccount.UseVisualStyleBackColor = true;
            btn_PublicAccount.Click += btn_PublicAccount_Click;
            // 
            // gp_Cont
            // 
            gp_Cont.Controls.Add(Pn_Expendes);
            gp_Cont.Controls.Add(Pn_Incomes);
            gp_Cont.Dock = DockStyle.Top;
            gp_Cont.Location = new Point(3, 23);
            gp_Cont.Name = "gp_Cont";
            gp_Cont.Padding = new Padding(100, 20, 100, 75);
            gp_Cont.Size = new Size(859, 1750);
            gp_Cont.TabIndex = 2;
            gp_Cont.TabStop = false;
            // 
            // Pn_Expendes
            // 
            Pn_Expendes.BackColor = Color.DarkRed;
            Pn_Expendes.Controls.Add(groupBox7);
            Pn_Expendes.Controls.Add(groupBox8);
            Pn_Expendes.Controls.Add(groupBox6);
            Pn_Expendes.Controls.Add(label16);
            Pn_Expendes.Controls.Add(label14);
            Pn_Expendes.Controls.Add(LB_Total_Ex);
            Pn_Expendes.Controls.Add(LB_Balance);
            Pn_Expendes.Controls.Add(groupBox5);
            Pn_Expendes.Controls.Add(label9);
            Pn_Expendes.Dock = DockStyle.Bottom;
            Pn_Expendes.Location = new Point(100, 880);
            Pn_Expendes.Name = "Pn_Expendes";
            Pn_Expendes.Size = new Size(659, 795);
            Pn_Expendes.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(PB_M_I);
            groupBox7.Controls.Add(label11);
            groupBox7.Location = new Point(16, 539);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(630, 126);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            // 
            // PB_M_I
            // 
            PB_M_I.BackColor = Color.Transparent;
            PB_M_I.BackgroundColor = Color.FromArgb(64, 0, 0);
            PB_M_I.BorderColor = Color.WhiteSmoke;
            PB_M_I.BorderRadius = 23;
            PB_M_I.DisplayText = "30%";
            PB_M_I.Location = new Point(274, 45);
            PB_M_I.Name = "PB_M_I";
            PB_M_I.ProgressBorderColor = Color.WhiteSmoke;
            PB_M_I.ProgressColor = Color.DarkGoldenrod;
            PB_M_I.Size = new Size(350, 50);
            PB_M_I.TabIndex = 2;
            PB_M_I.TextColor = Color.WhiteSmoke;
            PB_M_I.TextFont = new Font("Arial", 10F);
            PB_M_I.Value = 30D;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(19, 23);
            label11.Name = "label11";
            label11.Size = new Size(229, 92);
            label11.TabIndex = 0;
            label11.Text = "Manutenção \r\ne Melhorias";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(PB_Several);
            groupBox8.Controls.Add(label12);
            groupBox8.Location = new Point(16, 671);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(630, 100);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            // 
            // PB_Several
            // 
            PB_Several.BackColor = Color.Transparent;
            PB_Several.BackgroundColor = Color.FromArgb(64, 0, 0);
            PB_Several.BorderColor = Color.WhiteSmoke;
            PB_Several.BorderRadius = 23;
            PB_Several.DisplayText = "30%";
            PB_Several.Location = new Point(274, 26);
            PB_Several.Name = "PB_Several";
            PB_Several.ProgressBorderColor = Color.WhiteSmoke;
            PB_Several.ProgressColor = Color.DarkGoldenrod;
            PB_Several.Size = new Size(350, 50);
            PB_Several.TabIndex = 2;
            PB_Several.TextColor = Color.WhiteSmoke;
            PB_Several.TextFont = new Font("Arial", 10F);
            PB_Several.Value = 30D;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(28, 32);
            label12.Name = "label12";
            label12.Size = new Size(156, 46);
            label12.TabIndex = 0;
            label12.Text = "Diversos";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(PB_Help);
            groupBox6.Controls.Add(label10);
            groupBox6.Location = new Point(16, 433);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(630, 100);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            // 
            // PB_Help
            // 
            PB_Help.BackColor = Color.Transparent;
            PB_Help.BackgroundColor = Color.FromArgb(64, 0, 0);
            PB_Help.BorderColor = Color.WhiteSmoke;
            PB_Help.BorderRadius = 23;
            PB_Help.DisplayText = "30%";
            PB_Help.Location = new Point(274, 32);
            PB_Help.Name = "PB_Help";
            PB_Help.ProgressBorderColor = Color.WhiteSmoke;
            PB_Help.ProgressColor = Color.DarkGoldenrod;
            PB_Help.Size = new Size(350, 50);
            PB_Help.TabIndex = 2;
            PB_Help.TextColor = Color.WhiteSmoke;
            PB_Help.TextFont = new Font("Arial", 10F);
            PB_Help.Value = 30D;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(28, 32);
            label10.Name = "label10";
            label10.Size = new Size(146, 46);
            label10.TabIndex = 0;
            label10.Text = "Socorro";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(0, 149);
            label16.Name = "label16";
            label16.Size = new Size(217, 60);
            label16.TabIndex = 1;
            label16.Text = "Despesas:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(35, 244);
            label14.Name = "label14";
            label14.Size = new Size(155, 60);
            label14.TabIndex = 1;
            label14.Text = "Saldo :";
            // 
            // LB_Total_Ex
            // 
            LB_Total_Ex.AutoSize = true;
            LB_Total_Ex.Font = new Font("Segoe UI", 36F);
            LB_Total_Ex.ForeColor = Color.WhiteSmoke;
            LB_Total_Ex.Location = new Point(209, 131);
            LB_Total_Ex.Name = "LB_Total_Ex";
            LB_Total_Ex.Size = new Size(366, 81);
            LB_Total_Ex.TabIndex = 1;
            LB_Total_Ex.Text = "R$:12.000,00";
            // 
            // LB_Balance
            // 
            LB_Balance.AutoSize = true;
            LB_Balance.Font = new Font("Segoe UI", 36F);
            LB_Balance.ForeColor = Color.WhiteSmoke;
            LB_Balance.Location = new Point(209, 226);
            LB_Balance.Name = "LB_Balance";
            LB_Balance.Size = new Size(366, 81);
            LB_Balance.TabIndex = 1;
            LB_Balance.Text = "R$:12.000,00";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(PB_Fixed);
            groupBox5.Controls.Add(label8);
            groupBox5.Location = new Point(16, 327);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(630, 100);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            // 
            // PB_Fixed
            // 
            PB_Fixed.BackColor = Color.Transparent;
            PB_Fixed.BackgroundColor = Color.FromArgb(64, 0, 0);
            PB_Fixed.BorderColor = Color.WhiteSmoke;
            PB_Fixed.BorderRadius = 23;
            PB_Fixed.DisplayText = "30%";
            PB_Fixed.Location = new Point(274, 32);
            PB_Fixed.Name = "PB_Fixed";
            PB_Fixed.ProgressBorderColor = Color.WhiteSmoke;
            PB_Fixed.ProgressColor = Color.DarkGoldenrod;
            PB_Fixed.Size = new Size(350, 50);
            PB_Fixed.TabIndex = 1;
            PB_Fixed.TextColor = Color.WhiteSmoke;
            PB_Fixed.TextFont = new Font("Arial", 10F);
            PB_Fixed.Value = 30D;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(28, 32);
            label8.Name = "label8";
            label8.Size = new Size(217, 46);
            label8.TabIndex = 0;
            label8.Text = "Gastos Fixos";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Champagne & Limousines", 56F, FontStyle.Bold);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(200, 20);
            label9.Name = "label9";
            label9.Size = new Size(306, 99);
            label9.TabIndex = 0;
            label9.Text = "Saídas";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // Pn_Incomes
            // 
            Pn_Incomes.BackColor = Color.SeaGreen;
            Pn_Incomes.BorderStyle = BorderStyle.FixedSingle;
            Pn_Incomes.Controls.Add(groupBox4);
            Pn_Incomes.Controls.Add(groupBox3);
            Pn_Incomes.Controls.Add(groupBox2);
            Pn_Incomes.Controls.Add(LB_Total_In);
            Pn_Incomes.Controls.Add(label1);
            Pn_Incomes.Dock = DockStyle.Top;
            Pn_Incomes.Location = new Point(100, 40);
            Pn_Incomes.Margin = new Padding(3, 3, 3, 20);
            Pn_Incomes.Name = "Pn_Incomes";
            Pn_Incomes.Padding = new Padding(15, 5, 15, 5);
            Pn_Incomes.Size = new Size(659, 795);
            Pn_Incomes.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PB_Donation);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(LB_Donation);
            groupBox4.Location = new Point(41, 570);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(604, 165);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // PB_Donation
            // 
            PB_Donation.BackColor = Color.Transparent;
            PB_Donation.BackgroundColor = Color.FromArgb(23, 72, 46);
            PB_Donation.BorderColor = Color.WhiteSmoke;
            PB_Donation.BorderRadius = 45;
            PB_Donation.DisplayText = "30%";
            PB_Donation.Location = new Point(181, 32);
            PB_Donation.Name = "PB_Donation";
            PB_Donation.ProgressBorderColor = Color.WhiteSmoke;
            PB_Donation.ProgressColor = Color.MediumSeaGreen;
            PB_Donation.Size = new Size(400, 100);
            PB_Donation.TabIndex = 2;
            PB_Donation.TextColor = Color.WhiteSmoke;
            PB_Donation.TextFont = new Font("Arial", 10F);
            PB_Donation.Value = 30D;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(21, 23);
            label6.Name = "label6";
            label6.Size = new Size(154, 46);
            label6.TabIndex = 0;
            label6.Text = "Doações";
            // 
            // LB_Donation
            // 
            LB_Donation.AutoSize = true;
            LB_Donation.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Donation.ForeColor = Color.WhiteSmoke;
            LB_Donation.Location = new Point(48, 86);
            LB_Donation.Name = "LB_Donation";
            LB_Donation.Size = new Size(58, 46);
            LB_Donation.TabIndex = 0;
            LB_Donation.Text = "30";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PB_Offer);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(LB_Offer);
            groupBox3.Location = new Point(41, 380);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 165);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // PB_Offer
            // 
            PB_Offer.BackColor = Color.Transparent;
            PB_Offer.BackgroundColor = Color.FromArgb(23, 72, 46);
            PB_Offer.BorderColor = Color.WhiteSmoke;
            PB_Offer.BorderRadius = 45;
            PB_Offer.DisplayText = "30%";
            PB_Offer.Location = new Point(181, 32);
            PB_Offer.Name = "PB_Offer";
            PB_Offer.ProgressBorderColor = Color.WhiteSmoke;
            PB_Offer.ProgressColor = Color.MediumSeaGreen;
            PB_Offer.Size = new Size(400, 100);
            PB_Offer.TabIndex = 2;
            PB_Offer.TextColor = Color.WhiteSmoke;
            PB_Offer.TextFont = new Font("Arial", 10F);
            PB_Offer.Value = 30D;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(21, 23);
            label4.Name = "label4";
            label4.Size = new Size(138, 46);
            label4.TabIndex = 0;
            label4.Text = "Ofertas";
            // 
            // LB_Offer
            // 
            LB_Offer.AutoSize = true;
            LB_Offer.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Offer.ForeColor = Color.WhiteSmoke;
            LB_Offer.Location = new Point(48, 86);
            LB_Offer.Name = "LB_Offer";
            LB_Offer.Size = new Size(57, 46);
            LB_Offer.TabIndex = 0;
            LB_Offer.Text = "27";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PB_Tilte);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(LB_Tilte);
            groupBox2.Location = new Point(41, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 165);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // PB_Tilte
            // 
            PB_Tilte.BackColor = Color.Transparent;
            PB_Tilte.BackgroundColor = Color.FromArgb(23, 72, 46);
            PB_Tilte.BorderColor = Color.WhiteSmoke;
            PB_Tilte.BorderRadius = 45;
            PB_Tilte.DisplayText = "30%";
            PB_Tilte.Location = new Point(181, 32);
            PB_Tilte.Name = "PB_Tilte";
            PB_Tilte.ProgressBorderColor = Color.WhiteSmoke;
            PB_Tilte.ProgressColor = Color.MediumSeaGreen;
            PB_Tilte.Size = new Size(400, 100);
            PB_Tilte.TabIndex = 1;
            PB_Tilte.TextColor = Color.WhiteSmoke;
            PB_Tilte.TextFont = new Font("Arial", 10F);
            PB_Tilte.Value = 30D;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(21, 23);
            label3.Name = "label3";
            label3.Size = new Size(148, 46);
            label3.TabIndex = 0;
            label3.Text = "Dizimos";
            // 
            // LB_Tilte
            // 
            LB_Tilte.AutoSize = true;
            LB_Tilte.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Tilte.ForeColor = Color.WhiteSmoke;
            LB_Tilte.Location = new Point(48, 86);
            LB_Tilte.Name = "LB_Tilte";
            LB_Tilte.Size = new Size(58, 46);
            LB_Tilte.TabIndex = 0;
            LB_Tilte.Text = "30";
            // 
            // LB_Total_In
            // 
            LB_Total_In.AutoSize = true;
            LB_Total_In.Font = new Font("Segoe UI", 36F);
            LB_Total_In.ForeColor = Color.WhiteSmoke;
            LB_Total_In.Location = new Point(139, 103);
            LB_Total_In.Name = "LB_Total_In";
            LB_Total_In.Size = new Size(366, 81);
            LB_Total_In.TabIndex = 1;
            LB_Total_In.Text = "R$:12.000,00";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Champagne & Limousines", 56F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(162, 16);
            label1.Name = "label1";
            label1.Size = new Size(383, 99);
            label1.TabIndex = 0;
            label1.Text = "Entradas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1006, 721);
            Controls.Add(gp_Content);
            Controls.Add(CB_Periods);
            Name = "Dashboard";
            Padding = new Padding(60, 20, 60, 20);
            Text = "Dashboard";
            Load += Dashboard_Load;
            Resize += Dashboard_Resize;
            gp_Content.ResumeLayout(false);
            gp_Content.PerformLayout();
            Lt_Buttons.ResumeLayout(false);
            Lt_Buttons.PerformLayout();
            gp_Cont.ResumeLayout(false);
            Pn_Expendes.ResumeLayout(false);
            Pn_Expendes.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            Pn_Incomes.ResumeLayout(false);
            Pn_Incomes.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CB_Periods;
        private GroupBox gp_Content;
        private GroupBox gp_Cont;
        private Panel Pn_Expendes;
        private GroupBox groupBox7;
        private CustomProgressBar PB_M_I;
        private Label label11;
        private GroupBox groupBox8;
        private CustomProgressBar PB_Several;
        private Label label12;
        private GroupBox groupBox6;
        private CustomProgressBar PB_Help;
        private Label label10;
        private Label label16;
        private Label label14;
        private Label LB_Total_Ex;
        private Label LB_Balance;
        private GroupBox groupBox5;
        private CustomProgressBar PB_Fixed;
        private Label label8;
        private Label label9;
        private Panel Pn_Incomes;
        private GroupBox groupBox4;
        private CustomProgressBar PB_Donation;
        private Label label6;
        private Label LB_Donation;
        private GroupBox groupBox3;
        private CustomProgressBar PB_Offer;
        private Label label4;
        private Label LB_Offer;
        private GroupBox groupBox2;
        private CustomProgressBar PB_Tilte;
        private Label label3;
        private Label LB_Tilte;
        private Label LB_Total_In;
        private Label label1;
        private FlowLayoutPanel Lt_Buttons;
        private Button btn_Report;
        private Button btn_PublicAccount;
    }
}