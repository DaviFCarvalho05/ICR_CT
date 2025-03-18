namespace Icr_Treasury_Control.Config
{
    partial class Config
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
            groupBox1 = new GroupBox();
            BtnSave = new Button();
            BtnChooseImage = new Button();
            pbLogo = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ColorPre = new Button();
            btnColorSelect = new Button();
            txt_CNPJ = new TextBox();
            label3 = new Label();
            Txt_Church_Name = new TextBox();
            label2 = new Label();
            TxT_ChuDenoFed = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(BtnChooseImage);
            groupBox1.Controls.Add(pbLogo);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(txt_CNPJ);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Txt_Church_Name);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxT_ChuDenoFed);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(935, 1000);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // BtnSave
            // 
            BtnSave.Dock = DockStyle.Top;
            BtnSave.Location = new Point(3, 717);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(929, 51);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Salvar";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnChooseImage
            // 
            BtnChooseImage.Dock = DockStyle.Top;
            BtnChooseImage.Location = new Point(3, 666);
            BtnChooseImage.Name = "BtnChooseImage";
            BtnChooseImage.Size = new Size(929, 51);
            BtnChooseImage.TabIndex = 9;
            BtnChooseImage.Text = "Escolher Logo";
            BtnChooseImage.UseVisualStyleBackColor = true;
            BtnChooseImage.Click += BtnChooseImage_Click;
            // 
            // pbLogo
            // 
            pbLogo.Dock = DockStyle.Top;
            pbLogo.Location = new Point(3, 466);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(929, 200);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(ColorPre);
            flowLayoutPanel1.Controls.Add(btnColorSelect);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 338);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15, 0, 10, 0);
            flowLayoutPanel1.Size = new Size(929, 128);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // ColorPre
            // 
            ColorPre.AutoSize = true;
            ColorPre.BackColor = Color.FromArgb(37, 116, 74);
            ColorPre.Dock = DockStyle.Left;
            ColorPre.Font = new Font("Segoe UI", 20F);
            ColorPre.Location = new Point(18, 3);
            ColorPre.Name = "ColorPre";
            ColorPre.Size = new Size(890, 58);
            ColorPre.TabIndex = 0;
            ColorPre.UseVisualStyleBackColor = false;
            // 
            // btnColorSelect
            // 
            btnColorSelect.AutoSize = true;
            btnColorSelect.Dock = DockStyle.Right;
            btnColorSelect.Font = new Font("Segoe UI", 20F);
            btnColorSelect.Location = new Point(18, 67);
            btnColorSelect.Name = "btnColorSelect";
            btnColorSelect.Size = new Size(888, 58);
            btnColorSelect.TabIndex = 1;
            btnColorSelect.Text = "Escolher a Cor";
            btnColorSelect.UseVisualStyleBackColor = true;
            btnColorSelect.Click += btnColorSelect_Click;
            // 
            // txt_CNPJ
            // 
            txt_CNPJ.Dock = DockStyle.Top;
            txt_CNPJ.Location = new Point(3, 287);
            txt_CNPJ.MaxLength = 14;
            txt_CNPJ.Name = "txt_CNPJ";
            txt_CNPJ.PlaceholderText = "Somente números";
            txt_CNPJ.Size = new Size(929, 51);
            txt_CNPJ.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(3, 241);
            label3.Name = "label3";
            label3.Size = new Size(95, 46);
            label3.TabIndex = 4;
            label3.Text = "CNPJ";
            // 
            // Txt_Church_Name
            // 
            Txt_Church_Name.Dock = DockStyle.Top;
            Txt_Church_Name.Location = new Point(3, 190);
            Txt_Church_Name.Name = "Txt_Church_Name";
            Txt_Church_Name.Size = new Size(929, 51);
            Txt_Church_Name.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 144);
            label2.Name = "label2";
            label2.Size = new Size(251, 46);
            label2.TabIndex = 2;
            label2.Text = "Nome da Igreja";
            // 
            // TxT_ChuDenoFed
            // 
            TxT_ChuDenoFed.Dock = DockStyle.Top;
            TxT_ChuDenoFed.Location = new Point(3, 93);
            TxT_ChuDenoFed.Name = "TxT_ChuDenoFed";
            TxT_ChuDenoFed.Size = new Size(929, 51);
            TxT_ChuDenoFed.TabIndex = 1;
            TxT_ChuDenoFed.Text = "Federação ICR Avivalista do Brasil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(586, 46);
            label1.TabIndex = 0;
            label1.Text = "Nome da Denominação ou Federação";
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1006, 721);
            Controls.Add(groupBox1);
            Name = "Config";
            Padding = new Padding(25);
            Text = "Config";
            Load += Config_Load;
            Resize += Config_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_CNPJ;
        private Label label3;
        private TextBox Txt_Church_Name;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ColorPre;
        private Button btnColorSelect;
        private PictureBox pbLogo;
        private Button BtnChooseImage;
        private Label label2;
        private Button BtnSave;
    }
}