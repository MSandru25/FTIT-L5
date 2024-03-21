/* Ex 5
Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
Exemplu:
Input: Ana ARE mErE
Rezultat: Ana Are Mere */

Console.WriteLine("Introduceti un sir de caractere: ");
string str = Console.ReadLine();
string lowStr = str.ToLower();
var splitStr = lowStr.Split(" ");
var res = "";
foreach (var i in splitStr)
{
    res += char.ToUpper(i[0]) + i.Substring(1) + ' ';
}
Console.WriteLine(res.Trim());