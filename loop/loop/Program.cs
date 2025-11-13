for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);

}

int soma  = 0;
for  (int i = 0; i <= 100; i++)
{
    soma += i;
}

Console.WriteLine("\nA soma dos números de 1 a 100 é: " + soma);

int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;
}

int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++;

} while (novocontador <= 5);

List<string> nomes = new List<string> { "Ana", "Carlos", "João" };

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

int[] numeros = { 1, 2, 3, 4, 5 };

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}


