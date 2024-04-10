using S2Lab4n2;
int x, y, yesno;
double Number;
var USD = new USD(39.21, "dollar", 1000);
var EUR = new EUR(42.12, "euro", 1000);
var RMB = new RMB(5.41, "yuan", 1000);
var JPY = new JPY(0.26, "yen", 1000);
var GBP = new GBP(49.46, "pounds", 1000);
var PLN = new PLN(9.87, "zlotiy", 1000);
var CHF = new CHF(43.35, "Swiss franc", 1000);
CurrencyExchanger currencyExchanger = new CurrencyExchanger();


Currency[] Array = {USD, EUR, RMB, JPY, GBP, PLN, CHF };
Console.WriteLine("USD = 0, EUR = 1, RMB = 2, JPY3 = 3, GBP = 4, PLN = 5, CHF = 6");


Console.WriteLine("бажаєте змінити курс? yes=1 no=0");
yesno = int.Parse(Console.ReadLine());

if(yesno == 1)
{
    int valut;
    double newcours;
    Console.WriteLine("що бажаєте змінити?");
    valut = int.Parse(Console.ReadLine());
    Console.WriteLine("який новий курс");
    newcours = int.Parse(Console.ReadLine());
    Array[valut].SetCours(newcours) ;
}

Console.WriteLine("яку валюту бажаєте обміняти?");
x = int.Parse(Console.ReadLine());

Console.WriteLine("в яку валюту обміняти?");
y = int.Parse(Console.ReadLine());

Console.WriteLine("скільки бажаєте обміняти");
Number = int.Parse(Console.ReadLine());
currencyExchanger.Exchange(Array[x], Array[y], Number);


Dictionary<string, Currency> Valuta = new Dictionary<string, Currency>();
Valuta.Add("dollar", Array[0]);
Valuta.Add("euro", Array[1]);
Valuta.Add("yuan", Array[2]);
Valuta.Add("yen", Array[3]);
Valuta.Add("pounds", Array[4]);
Valuta.Add("zlotiy", Array[5]);
Valuta.Add("Swiss franc", Array[6]);

currencyExchanger.Write(Valuta);





