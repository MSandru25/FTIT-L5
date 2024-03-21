/*Ex 1
Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
siruri de caractere fiind citite de la tastatura*/


Console.Write("String: ");
string str = Console.ReadLine();
Console.Write("Substring: ");
string substr = Console.ReadLine();
var index = str.IndexOf(substr);
if (index == -1)
{
    Console.WriteLine("Substring-ul nu apare in string.");
}
else
{
    Console.WriteLine($"Pozitia de inceput a substringului este {index + 1}.");
}