/*Ex 2
Scrieti un program care sa verifice daca un sir de caractere citit de la
tastatura este sau nu palindrom.*/

Console.Write("Introduceti un sir de caractere: ");
string str = Console.ReadLine();
if (str.SequenceEqual(str.Reverse()))
{
    Console.WriteLine("Sirul de caractere este palindrom.");
}
else
{
    Console.WriteLine("Sirul de caractere nu este palindrom.");
}