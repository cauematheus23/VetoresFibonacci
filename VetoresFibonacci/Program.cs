﻿int n1 = -1, n2 = 1, aux,quant=0;
do
{
    Console.WriteLine("Digite a quantidade de vezes que deseja executar o programa: ");
    quant = int.Parse(Console.ReadLine());
} while (quant <= 0);
for  (int i = 0; i < quant; i++)
{
    aux = n1 + n2;
    Console.Write(aux + " ");
    n1 = n2;
    n2 = aux;
    
}

    