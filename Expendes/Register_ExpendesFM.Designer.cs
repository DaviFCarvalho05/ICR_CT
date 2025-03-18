namespace Icr_Treasury_Control.Expendes
{
    partial class Register_ExpendesFM
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
            txt_ExValue = new NumericUpDown();
            Expense_Type = new GroupBox();
            rd_Maintenance_Improvements = new RadioButton();
            rd_Several = new RadioButton();
            rd_Help = new RadioButton();
            rd_Fixed_Expenses = new RadioButton();
            btn_add = new Button();
            txt_expense_desc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_ExValue).BeginInit();
            Expense_Type.SuspendLayout();
            SuspendLayout();
            // 
            // CB_Periods
            // 
            CB_Periods.Dock = DockStyle.Top;
            CB_Periods.Font = new Font("Segoe UI", 10F);
            CB_Periods.FormattingEnabled = true;
            CB_Periods.Location = new Point(20, 10);
            CB_Periods.Name = "CB_Periods";
            CB_Periods.Size = new Size(749, 31);
            CB_Periods.TabIndex = 6;
            CB_Periods.SelectedIndexChanged += CB_Periods_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_ExValue);
            groupBox1.Controls.Add(Expense_Type);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(txt_expense_desc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(20, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 315);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // txt_ExValue
            // 
            txt_ExValue.DecimalPlaces = 2;
            txt_ExValue.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            txt_ExValue.Location = new Point(74, 58);
            txt_ExValue.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txt_ExValue.Name = "txt_ExValue";
            txt_ExValue.Size = new Size(656, 27);
            txt_ExValue.TabIndex = 10;
            // 
            // Expense_Type
            // 
            Expense_Type.Controls.Add(rd_Maintenance_Improvements);
            Expense_Type.Controls.Add(rd_Several);
            Expense_Type.Controls.Add(rd_Help);
            Expense_Type.Controls.Add(rd_Fixed_Expenses);
            Expense_Type.Font = new Font("Segoe UI", 14F);
            Expense_Type.Location = new Point(16, 93);
            Expense_Type.Name = "Expense_Type";
            Expense_Type.Size = new Size(714, 76);
            Expense_Type.TabIndex = 9;
            Expense_Type.TabStop = false;
            Expense_Type.Text = "Tipo de Saída";
            // 
            // rd_Maintenance_Improvements
            // 
            rd_Maintenance_Improvements.AutoSize = true;
            rd_Maintenance_Improvements.Location = new Point(416, 35);
            rd_Maintenance_Improvements.Name = "rd_Maintenance_Improvements";
            rd_Maintenance_Improvements.Size = new Size(301, 36);
            rd_Maintenance_Improvements.TabIndex = 9;
            rd_Maintenance_Improvements.TabStop = true;
            rd_Maintenance_Improvements.Text = "Manutenção e Melhorias";
            rd_Maintenance_Improvements.UseVisualStyleBackColor = true;
            // 
            // rd_Several
            // 
            rd_Several.AutoSize = true;
            rd_Several.Dock = DockStyle.Left;
            rd_Several.Font = new Font("Segoe UI", 14F);
            rd_Several.Location = new Point(285, 35);
            rd_Several.Name = "rd_Several";
            rd_Several.Size = new Size(125, 38);
            rd_Several.TabIndex = 8;
            rd_Several.TabStop = true;
            rd_Several.Text = "Diversos";
            rd_Several.UseVisualStyleBackColor = true;
            // 
            // rd_Help
            // 
            rd_Help.AutoSize = true;
            rd_Help.Dock = DockStyle.Left;
            rd_Help.Font = new Font("Segoe UI", 14F);
            rd_Help.Location = new Point(168, 35);
            rd_Help.Name = "rd_Help";
            rd_Help.Size = new Size(117, 38);
            rd_Help.TabIndex = 6;
            rd_Help.TabStop = true;
            rd_Help.Text = "Socorro";
            rd_Help.UseVisualStyleBackColor = true;
            // 
            // rd_Fixed_Expenses
            // 
            rd_Fixed_Expenses.AutoSize = true;
            rd_Fixed_Expenses.Dock = DockStyle.Left;
            rd_Fixed_Expenses.Font = new Font("Segoe UI", 14F);
            rd_Fixed_Expenses.Location = new Point(3, 35);
            rd_Fixed_Expenses.Name = "rd_Fixed_Expenses";
            rd_Fixed_Expenses.Size = new Size(165, 38);
            rd_Fixed_Expenses.TabIndex = 7;
            rd_Fixed_Expenses.TabStop = true;
            rd_Fixed_Expenses.Text = "Gastos Fixos";
            rd_Fixed_Expenses.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(142, 270);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(481, 34);
            btn_add.TabIndex = 5;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_expense_desc
            // 
            txt_expense_desc.Font = new Font("Segoe UI", 14F);
            txt_expense_desc.Location = new Point(12, 208);
            txt_expense_desc.Name = "txt_expense_desc";
            txt_expense_desc.Size = new Size(721, 39);
            txt_expense_desc.TabIndex = 4;
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
            label3.Size = new Size(164, 32);
            label3.TabIndex = 2;
            label3.Text = "Valor da Saída";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 172);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 0;
            label1.Text = "Descrição de Saída";
            // 
            // Register_ExpendesFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 376);
            Controls.Add(groupBox1);
            Controls.Add(CB_Periods);
            Name = "Register_ExpendesFM";
            Padding = new Padding(20, 10, 20, 20);
            Text = "Register_ExpendesFM";
            Load += Register_ExpendesFM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_ExValue).EndInit();
            Expense_Type.ResumeLayout(false);
            Expense_Type.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CB_Periods;
        private GroupBox groupBox1;
        private NumericUpDown txt_ExValue;
        private GroupBox Expense_Type;
        private RadioButton rd_Maintenance_Improvements;
        private RadioButton rd_Several;
        private RadioButton rd_Help;
        private RadioButton rd_Fixed_Expenses;
        private Button btn_add;
        private TextBox txt_expense_desc;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}