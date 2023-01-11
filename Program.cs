using HasSetConsole;

var listPr = new List<string>() { "1", "2", "3", "1" };
var cleanList = Helpers.RemoveElementsDuplicated<string>(listPr);
cleanList
    .ToList()
    .ForEach(x => Console.WriteLine(x));

Console.ReadLine();

var listPr2 = new List<Phone>()
{
    new Phone
    {
        Id=1,
        Name="Iphone",
        Price = 1000000
    },
    new Phone
    {
        Id=2,
        Name="Huawei",
        Price = 2000000
    },
    new Phone
    {
        Id=1,
        Name="Iphone",
        Price = 1000000
    },
};

var EqualityComparePhone = new PhoneQualityCompare();
var cleanList2 = Helpers.RemoveElementsDuplicated<Phone>(listPr2, EqualityComparePhone);
cleanList2
    .ToList()
    .ForEach(x => Console.WriteLine(x));

Console.ReadLine();
