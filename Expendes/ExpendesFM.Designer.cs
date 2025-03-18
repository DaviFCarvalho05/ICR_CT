namespace Icr_Treasury_Control.Expendes
{
    partial class ExpendesFM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Btn_EraseData = new Button();
            Register_Expendes = new Button();
            CB_Periods = new ComboBox();
            GV_Data = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GV_Data).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(Btn_EraseData);
            flowLayoutPanel1.Controls.Add(Register_Expendes);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(60, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 0, 0, 0);
            flowLayoutPanel1.Size = new Size(886, 128);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // Btn_EraseData
            // 
            Btn_EraseData.AutoSize = true;
            Btn_EraseData.Dock = DockStyle.Left;
            Btn_EraseData.Font = new Font("Segoe UI", 20F);
            Btn_EraseData.Location = new Point(23, 3);
            Btn_EraseData.Name = "Btn_EraseData";
            Btn_EraseData.Size = new Size(835, 58);
            Btn_EraseData.TabIndex = 0;
            Btn_EraseData.Text = "Apagar Registro Selecionado";
            Btn_EraseData.UseVisualStyleBackColor = true;
            Btn_EraseData.Click += Btn_EraseData_Click;
            // 
            // Register_Expendes
            // 
            Register_Expendes.AutoSize = true;
            Register_Expendes.Dock = DockStyle.Right;
            Register_Expendes.Font = new Font("Segoe UI", 20F);
            Register_Expendes.Location = new Point(23, 67);
            Register_Expendes.Name = "Register_Expendes";
            Register_Expendes.Size = new Size(835, 58);
            Register_Expendes.TabIndex = 1;
            Register_Expendes.Text = "Registrar Saída de Recurso";
            Register_Expendes.UseVisualStyleBackColor = true;
            Register_Expendes.Click += Register_Expendes_Click;
            // 
            // CB_Periods
            // 
            CB_Periods.Dock = DockStyle.Top;
            CB_Periods.Font = new Font("Segoe UI", 20F);
            CB_Periods.FormattingEnabled = true;
            CB_Periods.Location = new Point(60, 128);
            CB_Periods.Name = "CB_Periods";
            CB_Periods.Size = new Size(886, 53);
            CB_Periods.TabIndex = 4;
            CB_Periods.SelectedIndexChanged += CB_Periods_SelectedIndexChanged;
            // 
            // GV_Data
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GV_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GV_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkRed;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GV_Data.DefaultCellStyle = dataGridViewCellStyle2;
            GV_Data.Dock = DockStyle.Top;
            GV_Data.Location = new Point(60, 181);
            GV_Data.Name = "GV_Data";
            GV_Data.RowHeadersWidth = 51;
            GV_Data.RowTemplate.Height = 41;
            GV_Data.Size = new Size(886, 941);
            GV_Data.TabIndex = 9;
            GV_Data.CellMouseClick += GV_Data_CellMouseClick;
            // 
            // ExpendesFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(GV_Data);
            Controls.Add(CB_Periods);
            Controls.Add(flowLayoutPanel1);
            Name = "ExpendesFM";
            Padding = new Padding(60, 0, 60, 0);
            Text = "Saídas";
            Load += ExpendesFM_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GV_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Btn_EraseData;
        private Button Register_Expendes;
        private ComboBox CB_Periods;
        private DataGridView GV_Data;
    }
}