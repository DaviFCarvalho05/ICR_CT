using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Icr_Treasury_Control.Classes;


namespace Icr_Treasury_Control.Dashboard
{
    class PublicAccount
    {

        public static void GeneratePA(string DateCB,string DenoFedChu, string Church, List<DataRec> Ex_Fixed, List<DataRec> Ex_Help, List<DataRec> Ex_Main, List<DataRec> Ex_Misc, int InNum)
        {
            Dashboard_Funcs dsf = new  Dashboard_Funcs();
            WordFuncs wc = new WordFuncs();
            List<DataRec> Lvoid = new List<DataRec>();
            

            // Open SaveFileDialog for user to choose the path
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Documento WORD|*.docx",
                FileName = "Prestação de Contas.docx",
                Title = "Salvar Prestação de Contas"
            };
            
            // If the user selects a path
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName; // Get the full file path

                // Create the document and save it to the selected path
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    // Create the main document part
                    MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    DocumentFormat.OpenXml.Wordprocessing.Body body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());
                    wc.AddLogoFromConfig(mainPart);
                    wc.AddTitle(body);
                    wc.AddChurchInfo(body, DenoFedChu, Church);
                    wc.AddLine(body, $"Mês de {DateCB}");
                    wc.AddLine(body, "Detalhamento de Entradas");
                    wc.CreateTable(body, "Numero de Dizimistas", $"{InNum} Entradas", Lvoid, "FFFFFF");

                    wc.AddLine(body, "Gastos Fixos");
                    wc.CreateTable(body, "Detalhamento de Gasto", "Valor:", Ex_Fixed, "92d050");
                    wc.AddLine(body, "\nSocorro");
                    
                    wc.CreateTable(body, "Detalhamento de Gasto", "Valor:", Ex_Help, "92d050");
                    wc.AddLine(body, "\nManutenção e Melhorias");
                    wc.CreateTable(body, "Detalhamento de Gasto", "Valor:", Ex_Main, "92d050");
                    wc.AddLine(body, "\nDiversos");
                    wc.CreateTable(body, "Detalhamento de Gasto", "Valor:", Ex_Misc, "92d050");
                    wc.AddLine(body, "\n");

                }






            }
        }
    }
} 
