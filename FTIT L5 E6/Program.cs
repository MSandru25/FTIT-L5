/*Ex 6
Screiti un program care va numara vocalele dintr-un sir de caractere citit de
la tastatura.*/

Console.WriteLine("Introduceti un sir de caractere: ");
string s = Console.ReadLine();
string sl = s.ToLower();
int vowels = 0;
foreach (char i in sl)
{
    if (i == 'a' || i == 'e' || i == 'o' || i == 'u' || i == 'i')
    { vowels++; }
}
Console.WriteLine($"Sirul contine {vowels} vocale.");