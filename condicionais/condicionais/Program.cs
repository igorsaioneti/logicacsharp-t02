//Condicional IF

string nome = "Joca"; //Alterar para "Ana"

if (nome == "Joca") // Alterar para "Ana"

{

    Console.WriteLine("Olá, Joca!"); //if else sempre se usa { }

}

//Se tiver outro nome na string, o programa vai rodar, mas não vai aparecer nada!

string texto = "";


if (string.IsNullOrEmpty(texto))

{

    Console.WriteLine("A String Está vazia.");

}

/* Aqui se não tiver nada escrito na string texto ele vai reconhecer e vai falar que está vazia,

  o comando IsNullOrEmpty é para reconhecer se é nula ou vazia o local onde deveria ter texto */

//Condicional IF/ELSE

int idade = 16;

if (idade >= 18) // IF = Sim

{

    Console.WriteLine("Você já pode ser preso bro"); // Alterar para "Você é maior de idade"

}

else // Else = SeNão

{

    Console.WriteLine("Você ainda é só um garotinho."); // Alterar para "Você é menor de idade"

}

int numero = 2;

if (numero % 2 == 0)

{

    Console.WriteLine("O numero é Par");

}


else

{

    Console.WriteLine("O Numero é Impar");

}

//Teste

double nota = 6.5;

if (nota >= 9.0)

{

    Console.WriteLine("Você é foda cara!"); // Alterar para "Excelente nota!, Aprovado com distinção"

}

else if (nota >= 7.0)

{

    Console.WriteLine("Você é fodinha, passou raspando!"); // Alterar para "Você está aprovado"

}

else if (nota >= 5.0)

{

    Console.WriteLine("Meu amigo, na proxima tu se arrasa!"); // Alterar para "Você está com risco de recuperação"

}

else if (nota >= 3.0)

{

    Console.WriteLine("Tu é Burro hein, vai estudar!"); // Alterar para "Você está em recuperação"

}

else

{

    Console.WriteLine("KKKKKKKKKKKKKKK Reprovado"); // Alterar para "Você foi reprovado"

}

//Condicional switch

double pontuacao = 8.5;

// Arredondando a nota para o inteiro mais proximo (match.floor arredonda para baixo)

int faixaNota = (int)Math.Floor(pontuacao);

/*Case é tipo "caso" e break é pra parar caso tenha encontrado oq precisa no "caso"

 Exemplo, caso tenha tirado 9 ou 8 na pontuação vai reconhecer oq tem que ser imprimido e parar em seguida.

Nota-se que iniciou com double por não ser numero inteiro mas logo em seguida, transformamos em numero inteiro

pra funcionar e facilitar usando a variavel (int faixaNota, Match.Floor e Pontuação) onde guardamos o numero*/

switch (faixaNota)

{

    case 10:

        Console.WriteLine("Você obteve uma excelente nota! Aprovado com distinção.");

        break;

    case 9:

    case 8:

        Console.WriteLine("Você está aprovado.");

        break;

    case 7:

    case 6:

        Console.WriteLine("Você está em Recuperação.");

        break;

    case 5:

    case 4:

    case 3:

        Console.WriteLine("Você está com risco de reprovação");

        break;

    default:

        Console.WriteLine("Você foi Reprovado.");

        break;

}
