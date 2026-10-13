// Média das notas e maior número 




List<double> nota = new List<double>();
double notas, mediaAritmetica;
double soma = 0;


for (int i = 0; i < 4; i++)
{
    Console.Write("Digite um número: ");
    notas = double.Parse(Console.ReadLine());

    nota.Add(notas);
    soma += notas;

}

    mediaAritmetica = soma / 4;
Console.WriteLine($"Média aritmética: {mediaAritmetica}\n Maior número: {nota.Max()}");
