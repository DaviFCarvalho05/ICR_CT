namespace Icr_Treasury_Control.Incomes
{
    partial class Register_IncomesFM
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
            groupBox1 = new GroupBox();
            txt_INValue = new NumericUpDown();
            Income_Type = new GroupBox();
            rd_Donation = new RadioButton();
            rd_Tithe = new RadioButton();
            rd_Offer = new RadioButton();
            btn_add = new Button();
            txt_donor_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_INValue).BeginInit();
            Income_Type.SuspendLayout();
            SuspendLayout();
            // 
            // CB_Periods
            // 
            CB_Periods.Dock = DockStyle.Top;
            CB_Periods.Font = new Font("Segoe UI", 10F);
            CB_Periods.FormattingEnabled = true;
            CB_Periods.Location = new Point(0, 0);
            CB_Periods.Name = "CB_Periods";
            CB_Periods.Size = new Size(516, 31);
            CB_Periods.TabIndex = 5;
            CB_Periods.SelectedIndexChanged += CB_Periods_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_INValue);
            groupBox1.Controls.Add(Income_Type);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(txt_donor_name);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 327);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // txt_INValue
            // 
            txt_INValue.DecimalPlaces = 2;
            txt_INValue.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txt_INValue.Location = new Point(74, 58);
            txt_INValue.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txt_INValue.Name = "txt_INValue";
            txt_INValue.Size = new Size(377, 27);
            txt_INValue.TabIndex = 10;
            // 
            // Income_Type
            // 
            Income_Type.Controls.Add(rd_Donation);
            Income_Type.Controls.Add(rd_Tithe);
            Income_Type.Controls.Add(rd_Offer);
            Income_Type.Font = new Font("Segoe UI", 14F);
            Income_Type.Location = new Point(16, 93);
            Income_Type.Name = "Income_Type";
            Income_Type.Size = new Size(335, 76);
            Income_Type.TabIndex = 9;
            Income_Type.TabStop = false;
            Income_Type.Text = "Tipo de Contribuição";
            // 
            // rd_Donation
            // 
            rd_Donation.AutoSize = true;
            rd_Donation.Dock = DockStyle.Left;
            rd_Donation.Font = new Font("Segoe UI", 14F);
            rd_Donation.Location = new Point(215, 35);
            rd_Donation.Name = "rd_Donation";
            rd_Donation.Size = new Size(115, 38);
            rd_Donation.TabIndex = 8;
            rd_Donation.TabStop = true;
            rd_Donation.Text = "Doação";
            rd_Donation.UseVisualStyleBackColor = true;
            // 
            // rd_Tithe
            // 
            rd_Tithe.AutoSize = true;
            rd_Tithe.Dock = DockStyle.Left;
            rd_Tithe.Font = new Font("Segoe UI", 14F);
            rd_Tithe.Location = new Point(105, 35);
            rd_Tithe.Name = "rd_Tithe";
            rd_Tithe.Size = new Size(110, 38);
            rd_Tithe.TabIndex = 6;
            rd_Tithe.TabStop = true;
            rd_Tithe.Text = "Dizimo";
            rd_Tithe.UseVisualStyleBackColor = true;
            // 
            // rd_Offer
            // 
            rd_Offer.AutoSize = true;
            rd_Offer.Dock = DockStyle.Left;
            rd_Offer.Font = new Font("Segoe UI", 14F);
            rd_Offer.Location = new Point(3, 35);
            rd_Offer.Name = "rd_Offer";
            rd_Offer.Size = new Size(102, 38);
            rd_Offer.TabIndex = 7;
            rd_Offer.TabStop = true;
            rd_Offer.Text = "Oferta";
            rd_Offer.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(16, 262);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(481, 34);
            btn_add.TabIndex = 5;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_donor_name
            // 
            txt_donor_name.Font = new Font("Segoe UI", 14F);
            txt_donor_name.Location = new Point(12, 208);
            txt_donor_name.Name = "txt_donor_name";
            txt_donor_name.Size = new Size(481, 39);
            txt_donor_name.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(46, 32);
            label4.TabIndex = 2;
            label4.Text = "R$:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(243, 32);
            label3.TabIndex = 2;
            label3.Text = "Valor da Contribuição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 172);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome do Contribuinte";
            // 
            // Register_IncomesFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 358);
            Controls.Add(groupBox1);
            Controls.Add(CB_Periods);
            Name = "Register_IncomesFM";
            Text = "Registrar_Entrada";
            Load += Register_IcomesFM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_INValue).EndInit();
            Income_Type.ResumeLayout(false);
            Income_Type.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox CB_Periods;
        private GroupBox groupBox1;
        private NumericUpDown txt_INValue;
        private GroupBox Income_Type;
        private RadioButton rd_Donation;
        private RadioButton rd_Tithe;
        private RadioButton rd_Offer;
        private Button btn_add;
        private TextBox txt_donor_name;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}