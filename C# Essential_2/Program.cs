using C__Essential_2;

Converter converter = new Converter(41, 39, 0.5);


double euro = converter.ConvertGrnToCurrency(100, "eur");
Console.WriteLine($"100 грн в доларах: {euro}");


double grn = converter.ConvertCurrencyToGrn(100, "eur");
Console.WriteLine($"100 євро в гривнях: {grn}");