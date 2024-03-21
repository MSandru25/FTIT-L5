/*Ex 3
Scrieti un program care va numara toate aparitiile unui caracter intr-un sir
de caractere. Atat caracterul cautat cat si sirul de caractere vor fi citite de la
tastatura*/

Console.WriteLine("Introduceti un sir de caractere: ");
string str = Console.ReadLine();
Console.WriteLine("Introduceti caracterul cautat: ");
char chr = Convert.ToChar(Console.ReadLine());
int count  = 0;
foreach (var i in str)
{
    if (i == chr)
    { count++; }
}
Console.WriteLine($"Numarul de aparitii al caracterului: {count}");