using System;
using System.IO;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Icr_Treasury_Control.Classes;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using System.Diagnostics.SymbolStore;

namespace Icr_Treasury_Control.Dashboard
{
    class FReport
    {

        public static void GenerateReport(string DenoFedChu, string Church, string Person_ID, List<DataRec> Incomes, List<DataRec> Expendes)
        {
            WordFuncs wc = new WordFuncs();
            DataRec dr = new DataRec();
            // Open SaveFileDialog for user to choose the path
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Documento WORD|*.docx",
                FileName = "RelatorioFinanceiro.docx",
                Title = "Salvar Relatório Financeiro"
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
                    Body body = mainPart.Document.AppendChild(new Body());

                    wc.AddLogoFromConfig(mainPart);
                    // Adding the title
                    wc.AddTitle(body);




                    // Adding church information
                    wc.AddChurchInfo(body, DenoFedChu, Church);
                    wc.AddLine(body, $"CNPJ: {Person_ID}");

                    // Creating tables for incomes and expenses
                    wc.CreateTable(body, "Nome do Contribuinte:", "Valor:", Incomes, "92d050");
                    wc.AddLine(body, "\n");
                    wc.CreateTable(body, "Detalhamento de Despesas:", "Valor:", Expendes, "ff2d2d");
                    wc.AddLine(body, "\n");

                    // Adding totals
                    double totalIncomes = wc.SumValues(Incomes);
                    double totalExpendes = wc.SumValues(Expendes);
                    double balance = totalIncomes - totalExpendes;

                    wc.AddLine(body, $"Arrecadação Total : {totalIncomes:C}");
                    wc.AddLine(body, $"Despesa Total: {totalExpendes:C}");
                    string balanceColor = balance < 0 ? "FF0000" : "000000";
                    wc.AddLine(body, $"Saldo: {balance:C}", balanceColor);

                    // Signatures
                    wc.AddLine(body, "\n");
                    wc.AddLine(body, "\n_________________________");
                    wc.AddLine(body, "\nAssinatura do Tesoureiro");
                    wc.AddLine(body, "\n");
                    wc.AddLine(body, "\n_________________________");
                    wc.AddLine(body, "\nAssinatura do Pastor Presidente");
                }
            }
        }
    }
}








