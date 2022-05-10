// Dado um array de X números, ache o pico.

int[] valores = { 10, 20, 30, 100, 4 };

for(int i = 0; i < valores.Length; i++)
{
    int numeroAnterior = 0, numeroProximo = 0;

    if(i == 0)
    {
        numeroAnterior = -1;
    }
    else
    {
        numeroAnterior = valores[i - 1];
    }

    if(i == valores.Length - 1)
    {
        numeroProximo = -1;
    }
    else
    {
        numeroProximo = valores[i + 1];
    }

    if(numeroAnterior <= valores[i] && numeroProximo < valores[i])
    {
        Console.WriteLine("Pico(s): " + valores[i]); 
    }
}

return -1;
