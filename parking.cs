XDocument xdoc = XDocument.Load("parking.xml");
foreach (XElement phoneElement in xdoc.Element("spot_info").Elements("spot"))
{
    XAttribute idAttribute = spotElement.Attribute("id");
    XElement typeElement = spotElement.Element("type");
    XElement costElement = spotElement.Element("cost");
     
    if (nameAttribute != null && companyElement!=null && priceElement!=null)
    {
        Console.WriteLine($"Номер места автостоянки: {idAttribute.Value}");
        Console.WriteLine($"Тип места: {typeElement.Value}");
        Console.WriteLine($"Стоимость аренды места в сутки: {cost.Value}");
    }
    Console.WriteLine();
}
