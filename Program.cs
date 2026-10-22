Console.Clear();

double nota1, nota2, nota3, nota4, media;
string resultado;

Console.WriteLine("-= Calculadora de média =-\n");

Console.WriteLine("Digite as notas:");

Console.Write("Nota 1: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
nota4 = Convert.ToDouble(Console.ReadLine());

if (
    0 <= nota1 && nota1 <= 10 &&
    0 <= nota2 && nota2 <= 10 &&
    0 <= nota3 && nota3 <= 10 &&
    0 <= nota4 && nota4 <= 10 
) {
    Console.WriteLine("\n-= Resultado =-\n");

    media = (nota1 + nota2 + nota3 + nota4) / 4;

    Console.Write($"Você ficou com média {media:N1}. Resultado: ");

    if (media > 6) {
        Console.ForegroundColor = ConsoleColor.Green;
        resultado = "Aprovado!";
    } else if (media >= 5) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        resultado = "Em recuperação.";
    } else {
        Console.ForegroundColor = ConsoleColor.Red;
        resultado = "Reprovado.";
    }

    Console.WriteLine(resultado);
} else {
    Console.WriteLine("\nDigite somente notas entre 0 e 10.");
}

Console.ResetColor();
