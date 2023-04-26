void loop()
{
void frase(string txt)
{
    for (int i = 0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);        
    }Thread.Sleep(75);
}
double total, min, max;
min = 0;
max = 10;
bool naRules = true;
List<double> notas = new List<double>();
Console.Clear();
Console.ForegroundColor = ConsoleColor.Gray;
frase("Digite quantas notas possue essa média: ");
int qtd = int.Parse(Console.ReadLine()!);
Console.Clear();
for (int i = 0; i < qtd; i++)
{
Console.ForegroundColor = ConsoleColor.Yellow;
frase($"Digite a {i+1}° nota: ");
Console.ForegroundColor = ConsoleColor.White;
double nota = double.Parse(Console.ReadLine()!);
notas.Add(nota);
if (nota <= min || nota > max)
{
    naRules = false;
}
}
double todas_nota = 0;
foreach (var c in notas)
{
    todas_nota += c;
}
total = todas_nota/Convert.ToDouble(qtd);

if (naRules == true && qtd != 0)
{
Console.ForegroundColor = ConsoleColor.DarkCyan;
frase($"\nA média é {total:n1}.\n");
if (total > 6)
{
Console.ForegroundColor = ConsoleColor.Green;
frase("O aluno está Aprovado.\n");
}
else if (total < 5)
{
Console.ForegroundColor = ConsoleColor.Red;
frase("O aluno está Reprovado.\n");
}
else if (total >= 5 && total <= 6)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
frase("O aluno está em Recuperação.\n");
}
}
else if (naRules == false)
{
Console.ForegroundColor = ConsoleColor.Red;
frase("Digite as notas somente entre 0 e 10.\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Pressione qualquer tecla para recomeçar.");
Console.ReadKey();
loop();
}
else
{
Console.ForegroundColor = ConsoleColor.Red;
frase("Tem somente 0 notas, então não tem como fazer a média.\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Pressione qualquer tecla para finalizar.");
Console.ReadKey();
Console.Clear();
}
}
loop();
Console.ResetColor();