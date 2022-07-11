//Даны следующие страны – Беларусь, Польша, Китай, Великобритания, Голландия, Италия, Франция, Канада, США.
//Используя класс CultureInfo, сделайте вывод следующей форматированной строки для каждой из стран -  
//Date and time format for Belarus is “время и дата”. The national currency is ‘1BYN’. Не забудьте про кавычки.
//Используйте эскейп символ для разделения строк. 
//Вывод оформите двумя способами 
//1. Используя string.Format() 
//2.Используя интерполированные строки

using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

DisplayDataFormatAndCurrencyForCountry("by-BY", "Belarus");
DisplayDataFormatAndCurrencyForCountry("pl-PL", "Poland");
DisplayDataFormatAndCurrencyForCountry("zh-CN", "China");
DisplayDataFormatAndCurrencyForCountry("en-GB", "Great Britain");
DisplayDataFormatAndCurrencyForCountry("nl-NL", "Netherlands");
DisplayDataFormatAndCurrencyForCountry("it-IT", "Italy");
DisplayDataFormatAndCurrencyForCountry("fr-FR", "France");
DisplayDataFormatAndCurrencyForCountry("fr-CA", "Canada (french)");
DisplayDataFormatAndCurrencyForCountry("en-CA", "Canada (english)");
DisplayDataFormatAndCurrencyForCountry("en-US", "USA");

void DisplayDataFormatAndCurrencyForCountry(string countryCode, string countryName)
{
    CultureInfo countryInfo = new CultureInfo(countryCode);
    Console.WriteLine(String.Format("Date and time format for {0} is \"{1}\". The national currency is '{2}'.\n",
    countryName, countryInfo.DateTimeFormat.LongDatePattern, countryInfo.NumberFormat.CurrencySymbol));
}