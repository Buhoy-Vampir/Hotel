using System.Windows.Forms;
using Xceed.Words.NET;

public class Docx
{
    [System.Obsolete]
    public void DocxPrint(string[] param)
    {
        // Открытие шаблонного файла
        DocX document = DocX.Load("template.docx");

        // Замена участков текста на значения из TextBox
        document.ReplaceText("[дата]", param[0]);
        document.ReplaceText("[фио]", param[1]);
        document.ReplaceText("[год рождения]", param[2]);
        document.ReplaceText("[адрес]", param[3]);
        document.ReplaceText("[паспорт]", param[4]);
        document.ReplaceText("[телефон]", param[5]);
        document.ReplaceText("[стоимость]", param[6]);

        // Сохранение результирующего файла
        document.SaveAs("result.docx");

        MessageBox.Show("Файл успешно сгенерирован.");
    }
}

