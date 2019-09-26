using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace Aula7Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Document ex1 = new Document();

            Section s1 = ex1.AddSection();

            Paragraph title = s1.AddParagraph();

            title.AppendText("Exercício resolvido!\n\n");

            title.Format.HorizontalAlignment =  HorizontalAlignment.Center;

            ParagraphStyle testilo = new ParagraphStyle(ex1);

            testilo.Name = "\tCor do tiulo";

            testilo.CharacterFormat.TextColor = Color.AliceBlue;
            testilo.CharacterFormat.Bold = true;
            testilo.CharacterFormat.Italic = true;
            testilo.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            testilo.CharacterFormat.FontSize = 18;
            testilo.CharacterFormat.FontName ="Arial";

            Table tabela = s1.AddTable(true);

            String[] header = {"Nome","Descrição","Nome vendedor(a)","Preço"};
            String[][] data = {
                new string[]{"Marmita 1","Picadinho","Persona 1","R$ 10,00"},
                new string[]{"Marmita 2","Bife acebolado","Persona 2","R$ 10,00"},
                new string[]{"Marmita 3","Legumes refogados","Persona 3","R$ 12,00"}
            };

            tabela.ResetCells(data.Length +1, header.Length);

            TableRow linha1 = tabela.Rows[0];
            linha1.IsHeader = true;
            linha1.Height = 23;
            linha1.RowFormat.BackColor = Color.AliceBlue;

            for (int i = 0; i < header.Length; i++)
            {
                Paragraph p = linha1.Cells[i].AddParagraph();
                linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                TextRange TR = p.AppendText(header[i]);
                TR.CharacterFormat.FontName = "Arial";
                TR.CharacterFormat.FontSize = 14;
                TR.CharacterFormat.Bold = true;

                
            }
            for (int r = 0; r < data.Length; r++)
                {
                    TableRow linhaDados = tabela.Rows[r + 1];

                    linhaDados.Height = 20;

                    for (int c = 0; c < data.Length; c++)
                    {
                        linhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                        Paragraph p2 = linhaDados.Cells[c].AddParagraph();
                        TextRange TR2 = p2.AppendText(data[r][c]);

                        p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                        TR2.CharacterFormat.FontName = "Arial";
                        TR2.CharacterFormat.FontSize = 12;
                        TR2.CharacterFormat.TextColor = Color.Red;
                    }
                }

                Section secaoImagem = ex1.AddSection();
                Paragraph paragrafoImagem = secaoImagem.AddParagraph();
                paragrafoImagem.Format.HorizontalAlignment = HorizontalAlignment.Right;

                DocPicture imagemExemplo = paragrafoImagem.AppendPicture(Image.FromFile(@"saida\pinguins.jpeg"));
                
                imagemExemplo.Width = 400;
                imagemExemplo.Height = 400;

                paragrafoImagem.AppendText("\t Pinguins dançantes!");

                ex1.SaveToFile(@"saida\Exercicio1.pdf", FileFormat.PDF);

        }
    }
}
