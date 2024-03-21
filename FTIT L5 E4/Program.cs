/*Ex 4
Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit
de la tastatura, ignorand caseing-ul literelor.
Exemplu:
Input: Elena are mere
Output: e apare de 5 ori*/

Console.WriteLine("Introduceti un sir de caractere: ");
string str = Console.ReadLine().ToLower();
int[] count = new int[256];
int lenght = str.Length;
for (int i = 0; i < lenght; i++)
{
    count[str[i]]++;
}
int max = -1;
char chr = ' ';
for (int i  = 0; i < lenght; i++)
{
    if (max < count[str[i]])
    {
        max = count[str[i]];
        chr = str[i];
    }
}
if (max == 1)
{
    Console.WriteLine("Toate caracterele apar odata.");
}
else
{ Console.WriteLine($"Caracterul \"{chr}\" apare de {max} ori."); }

//Metoda de rezolvare este obtinuta cu ajutorul internetului, daca exista o metoda mai simpla de rezolvare va rog sa imi spuneti.