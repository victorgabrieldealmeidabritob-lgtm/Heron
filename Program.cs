double lado1, lado2, lado3;
double p; // Semiperímetro
double area;

Console.WriteLine("Digite os lados do triângulo desejado.\n");

Console.Write("Lado 1..: ");
lado1 = Convert.ToDouble(Console.ReadLine());

// Pelo o que eu acho que diz acima, será necessário escrever (Console.Write) algo para converter para o dobro (Convert.ToDouble). Isso para o lado 1.

Console.Write("Lado 2..: ");
lado2 = Convert.ToDouble(Console.ReadLine());

// assim como eu disse no primeiro comentário, será necessário escrever (Console.Write) algo para converter para o dobro (Convert.ToDouble). Isso para o lado 2.

Console.Write("Lado 3..: ");
lado3 = Convert.ToDouble(Console.ReadLine());

// assim como eu disse no segundo comentário, será necessário escrever (Console.Write) algo para converter para o dobro (Convert.ToDouble). Isso para o lado 3.

p = (lado1 + lado2 + lado3) / 2;

// logo acima esta dizendo que p (que é seu Semiperímetro) é igual a soma dos três lados dividido por dois.

area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));

Console.WriteLine($"Semiperímetro..: {p}");
Console.WriteLine($"Área...........: {area}");

// o que diz "area = Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));" eu não entendi muito, mas acho que entendi um pouco mais os outros dois ultimos.