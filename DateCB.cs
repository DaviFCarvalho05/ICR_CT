using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icr_Treasury_Control.Classes;

internal class DateCB
{
    public  DateTime ParseCustomDate(string input)
    {
        // Dividir a string em partes numéricas e textuais
        string[] parts = input.Split('-');
        if (parts.Length != 2)
            throw new FormatException("Formato inválido. Use 'yyyyMM-mês de yyyy'");

        // Parte numérica (202501)
        string numericPart = parts[0].Trim();
        DateTime numericDate;
        if (!DateTime.TryParseExact(numericPart, "yyyyMM", null, DateTimeStyles.None, out numericDate))
            throw new FormatException("Parte numérica inválida");

        // Parte textual (janeiro de 2025)
        string textualPart = parts[1].Trim();
        DateTime textualDate;
        CultureInfo culture = new CultureInfo("pt-BR");
        if (!DateTime.TryParseExact(textualPart, "MMMM 'de' yyyy", culture, DateTimeStyles.None, out textualDate))
            throw new FormatException("Parte textual inválida");

        // Verificar consistência
        if (numericDate.Year != textualDate.Year || numericDate.Month != textualDate.Month)
            throw new InvalidOperationException("Datas não coincidem");

        return new DateTime(textualDate.Year, textualDate.Month, 1);
    }
}


