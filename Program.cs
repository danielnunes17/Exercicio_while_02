/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
Entrada:           
2 2     
3 -2
-8 -1
-7 1
0 2*/

Console.WriteLine("Digite a coordenada de X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a coordenada de Y: ");
int y = int.Parse(Console.ReadLine());

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro Quadrante");
        break;
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo Quadrante");
        break;
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro Quadrante");
        break;
    }
    else
    {
        Console.WriteLine("Quarto Quadrante");
        break;
    }
}

