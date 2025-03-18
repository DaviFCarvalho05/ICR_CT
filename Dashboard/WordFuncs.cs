using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Icr_Treasury_Control.Classes;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using DocumentFormat.OpenXml.Packaging;

namespace Icr_Treasury_Control.Dashboard
{
    internal class WordFuncs
    {
        DataRec dr = new DataRec();

        // Método para adicionar imagem no cabeçalho da primeira página
        public void AddLogoFromConfig(MainDocumentPart mainPart)
        {
            try
            {
                // Caminho completo para a imagem
                string imagePath = Path.Combine(dr.FolderPath, "-Configurações", "logo.png");

                // Carregar a imagem do arquivo
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                // Determinar o tipo de imagem pela extensão do arquivo
                PartTypeInfo imageType = Path.GetExtension(imagePath).ToLower() switch
                {
                    ".png" => ImagePartType.Png,
                    ".jpg" or ".jpeg" => ImagePartType.Jpeg,
                    ".gif" => ImagePartType.Gif,
                    ".bmp" => ImagePartType.Bmp,
                    _ => throw new ArgumentException("Formato de imagem não suportado")
                };

                // Adicionar a imagem ao documento
                ImagePart imagePart = mainPart.AddImagePart(imageType);
                using (var stream = new MemoryStream(imageBytes))
                {
                    imagePart.FeedData(stream);
                }

                // Calcular dimensões em EMUs (150px a 96 DPI)
                const long emuPerPixel = 914400L / 96L;
                long emuWidth = 150L * emuPerPixel;
                long emuHeight = 150L * emuPerPixel;

                // Criar elemento gráfico
                var drawing = new Drawing(
                    new DW.Inline(
                        new DW.Extent { Cx = emuWidth, Cy = emuHeight },
                        new DW.EffectExtent
                        {
                            LeftEdge = 0L,
                            TopEdge = 0L,
                            RightEdge = 0L,
                            BottomEdge = 0L
                        },
                        new DW.DocProperties { Id = 1U, Name = "CompanyLogo" },
                        new DW.NonVisualGraphicFrameDrawingProperties(
                            new A.GraphicFrameLocks { NoChangeAspect = true }),
                        new A.Graphic(
                            new A.GraphicData(
                                new PIC.Picture(
                                    new PIC.NonVisualPictureProperties(
                                        new PIC.NonVisualDrawingProperties
                                        {
                                            Id = 0U,
                                            Name = "Logo"
                                        },
                                        new PIC.NonVisualPictureDrawingProperties()),
                                    new PIC.BlipFill(
                                        new A.Blip
                                        {
                                            Embed = mainPart.GetIdOfPart(imagePart)
                                        },
                                        new A.Stretch(new A.FillRectangle())),
                                    new PIC.ShapeProperties(
                                        new A.Transform2D(
                                            new A.Offset { X = 0L, Y = 0L },
                                            new A.Extents
                                            {
                                                Cx = emuWidth,
                                                Cy = emuHeight
                                            }),
                                        new A.PresetGeometry(
                                            new A.AdjustValueList())
                                        {
                                            Preset = A.ShapeTypeValues.Rectangle
                                        }))
                            )
                            {
                                Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture"
                            }))
                    {
                        DistanceFromTop = 0U,
                        DistanceFromBottom = 0U,
                        DistanceFromLeft = 0U,
                        DistanceFromRight = 0U
                    });

                // Criar parágrafo centralizado
                Paragraph paragraph = new Paragraph(
                    new Run(drawing)
                );
                paragraph.ParagraphProperties = new ParagraphProperties(
                    new Justification { Val = JustificationValues.Center }
                );

                // Inserir a imagem no início do documento
                mainPart.Document.Body.InsertAt(paragraph, 0);
            }
            catch (Exception ex)
            {
                // Tratar erros (registrar em log, etc.)
                throw new InvalidOperationException("Falha ao adicionar o logo: " + ex.Message, ex);
            }
        }
        public void AddTitle(Body body)
        {
            // Adding the title with RunProperties
            Paragraph title = new Paragraph(new Run(new Text("Relatório Financeiro"))
            {
                RunProperties = new RunProperties(new Bold(), new FontSize() { Val = "32" })
            });

            title.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
            body.AppendChild(title);
        }


        public void AddChurchInfo(Body body, string denominacao, string igreja)
        {
            AddLine(body, "\n");
            AddLine(body, $"{denominacao}");
            AddLine(body, $"{igreja}");
            
        }

        public void CreateTable(Body body, string col1, string col2, List<DataRec> data, string headerColor)
        {
            // Create the table
            Table table = new Table();

            // Set table properties (including width)
            TableProperties tableProperties = new TableProperties(
                new TableBorders(
                    new TopBorder() { Val = BorderValues.Single, Size = 6 },
                    new BottomBorder() { Val = BorderValues.Single, Size = 6 },
                    new LeftBorder() { Val = BorderValues.Single, Size = 6 },
                    new RightBorder() { Val = BorderValues.Single, Size = 6 },
                    new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 6 },
                    new InsideVerticalBorder() { Val = BorderValues.Single, Size = 6 }
                ),
                new TableWidth() { Width = "5000", Type = TableWidthUnitValues.Pct } // 50% of page width
            );
            table.AppendChild(tableProperties);

            // Add table header with background color and fixed width
            TableRow headerRow = new TableRow();
            headerRow.Append(
                CreateCell(col1, headerColor, "2500"), // 50% of table width
                CreateCell(col2, headerColor, "2500")  // 50% of table width
            );
            table.AppendChild(headerRow);

            // Add data rows
            foreach (var item in data)
            {
                TableRow row = new TableRow();
                row.Append(
                    CreateCell(item.DataName, "FFFFFF", "2500"), // White background
                    CreateCell(item.DataValue.ToString("C"), "FFFFFF", "2500")
                );
                table.AppendChild(row);
            }

            // Center table
            TableJustification justification = new TableJustification() { Val = TableRowAlignmentValues.Center };
            table.AppendChild(justification);

            // Append table to the document body
            body.AppendChild(table);
        }

        // Method to create table cells with width and background color
        public  TableCell CreateCell(string text, string bgColor, string width)
        {
            TableCell cell = new TableCell(new Paragraph(new Run(new Text(text))));

            // Set cell properties
            cell.Append(new TableCellProperties(
                new TableCellWidth() { Width = width, Type = TableWidthUnitValues.Pct },
                new Shading() { Fill = bgColor }
            ));

            return cell;
        }

        public void AddLine(Body body, string text, string color = "000000") // Default color: Black
        {
            Run run = new Run(new Text(text));

            // Set color
            RunProperties runProperties = new RunProperties(new DocumentFormat.OpenXml.Wordprocessing.Color() { Val = color });
            run.PrependChild(runProperties);

            Paragraph paragraph = new Paragraph(run);
            paragraph.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });

            body.AppendChild(paragraph);
        }

        public double SumValues(List<DataRec> data)
        {
            double total = 0;
            foreach (var item in data)
            {
                total += item.DataValue;
            }
            return total;
        }
    }

}

