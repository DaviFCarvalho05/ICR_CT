namespace Icr_Treasury_Control.Incomes
{
    partial class IncomesFM
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            CB_Periods = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_EraseData = new Button();
            Register_Incomes = new Button();
            GV_Data = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GV_Data).BeginInit();
            SuspendLayout();
            // 
            // CB_Periods
            // 
            CB_Periods.Dock = DockStyle.Top;
            CB_Periods.Font = new Font("Segoe UI", 16F);
            CB_Periods.FormattingEnabled = true;
            CB_Periods.Location = new Point(60, 128);
            CB_Periods.Name = "CB_Periods";
            CB_Periods.Size = new Size(865, 45);
            CB_Periods.TabIndex = 7;
            CB_Periods.SelectedIndexChanged += CB_Periods_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(Btn_EraseData);
            flowLayoutPanel1.Controls.Add(Register_Incomes);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(60, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(865, 128);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // Btn_EraseData
            // 
            Btn_EraseData.AutoSize = true;
            Btn_EraseData.Dock = DockStyle.Left;
            Btn_EraseData.Font = new Font("Segoe UI", 20F);
            Btn_EraseData.Location = new Point(23, 3);
            Btn_EraseData.Name = "Btn_EraseData";
            Btn_EraseData.Size = new Size(810, 58);
            Btn_EraseData.TabIndex = 0;
            Btn_EraseData.Text = "Apagar Registro Selecionado";
            Btn_EraseData.UseVisualStyleBackColor = true;
            Btn_EraseData.Click += Btn_EraseData_Click;
            // 
            // Register_Incomes
            // 
            Register_Incomes.AutoSize = true;
            Register_Incomes.Dock = DockStyle.Right;
            Register_Incomes.Font = new Font("Segoe UI", 20F);
            Register_Incomes.Location = new Point(23, 67);
            Register_Incomes.Name = "Register_Incomes";
            Register_Incomes.Size = new Size(809, 58);
            Register_Incomes.TabIndex = 1;
            Register_Incomes.Text = "Registrar Entrada de Receita";
            Register_Incomes.UseVisualStyleBackColor = true;
            Register_Incomes.Click += Register_Incomes_Click;
            // 
            // GV_Data
            // 
            GV_Data.AllowUserToAddRows = false;
            GV_Data.AllowUserToDeleteRows = false;
            GV_Data.AllowUserToResizeColumns = false;
            GV_Data.AllowUserToResizeRows = false;
            GV_Data.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SeaGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 83, 52);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            GV_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            GV_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.SeaGreen;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle6.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            GV_Data.DefaultCellStyle = dataGridViewCellStyle6;
            GV_Data.Dock = DockStyle.Top;
            GV_Data.EditMode = DataGridViewEditMode.EditProgrammatically;
            GV_Data.Location = new Point(60, 173);
            GV_Data.Name = "GV_Data";
            GV_Data.RowHeadersWidth = 51;
            GV_Data.RowTemplate.Height = 41;
            GV_Data.Size = new Size(865, 682);
            GV_Data.TabIndex = 11;
            // 
            // IncomesFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1006, 721);
            Controls.Add(GV_Data);
            Controls.Add(CB_Periods);
            Controls.Add(flowLayoutPanel1);
            Name = "IncomesFM";
            Padding = new Padding(60, 0, 60, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entradas";
            WindowState = FormWindowState.Maximized;
            Load += IncomesFM_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GV_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CB_Periods;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_EraseData;
        private Button Register_Incomes;
        private DataGridView GV_Data;
    }
}