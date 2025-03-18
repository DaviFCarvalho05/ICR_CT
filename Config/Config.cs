using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Icr_Treasury_Control.Classes;

namespace Icr_Treasury_Control.Config
{

    public partial class Config : Form
    {
        private ConfigManager configManager;

        public Config()
        {
            InitializeComponent();
            configManager = new ConfigManager();
        }

        private void btnColorSelect_Click(object sender, EventArgs e)
        {
            // Configura a cor escolhida pelo usuário usando o ColorDialog
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Altere a cor de fundo de um componente, como o botão
                    ColorPre.BackColor = colorDialog.Color;
                    // Salve a cor em algum lugar para usá-la posteriormente
                }
            }
        }

        private void BtnChooseImage_Click(object sender, EventArgs e)
        {
            // Abre o diálogo para o usuário escolher a imagem
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Carrega a imagem no PictureBox
                    pbLogo.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Salva a imagem e as configurações usando o ConfigManager
            if (pbLogo.Image != null)
            {
                Radio r = new Radio();
                string caminhoImagem = configManager.SaveImage(pbLogo.Image);


                // Salva as outras configurações (cor e texto)
                Color corEscolhida = ColorPre.BackColor;
                string textoChurch = Txt_Church_Name.Text;
                string textoChuDeno = TxT_ChuDenoFed.Text;

                long CNPJ;
                long.TryParse(txt_CNPJ.Text, out CNPJ);
                switch (txt_CNPJ.Text.Length)
                {
                    case 14:

                        configManager.SaveConfigurations(caminhoImagem, corEscolhida, textoChurch, textoChuDeno, CNPJ.ToString("00000000000000"));
                        MessageBox.Show("Configurações salvas com sucesso.");

                        break;
                    default:
                        MessageBox.Show("Número inválido! Deve ser um CNPJ (14 caracteres).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }




            }
            else
            {
                MessageBox.Show("Por favor, selecione uma imagem antes de salvar.");
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            LoadConfigs();
        }
        private void LoadConfigs()
        {
            // Carrega as configurações ao iniciar o formulário
            var configuracoes = configManager.LoadConfigurations();
            if (configuracoes != null)
            {
                DataRec dr = new();
                string cs = Path.Combine(dr.FolderPath, "-Configurações", "logo.png");
                if (File.Exists(cs))
                    pbLogo.Image = Image.FromFile(cs);

                // Carrega a cor
                ColorPre.BackColor = Color.FromArgb((int)configuracoes.Color);

                // Carrega os textos
                Txt_Church_Name.Text = configuracoes.ChurchName.ToString();
                TxT_ChuDenoFed.Text = configuracoes.ChuDenoFed.ToString();
                txt_CNPJ.Text = configuracoes.PersoID.ToString();
            }
        }



        private void txt_PersoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Impede a inserção de caracteres não numéricos
                e.Handled = true;
            }

        }

        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxT_ChuDenoFed;

        private void Config_Resize(object sender, EventArgs e)
        {
           int padSize = this.Width - 1400;

            this.Padding = new Padding(padSize, 20, padSize, 20);
          
        }
    }
}
