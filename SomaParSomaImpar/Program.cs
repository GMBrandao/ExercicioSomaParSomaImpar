internal class Program
{
    private static void Main(string[] args)
    {
        
        int sumPar = 0, sumImp = 0, aux;

        do
        {
            Console.WriteLine("Digite um número inteiro:");
            aux = int.Parse(Console.ReadLine());

            if (aux < 0)
            {
                Console.WriteLine("Número inválido\n");
            }
            else
            {
                if (aux > 999)
                {
                    Console.WriteLine("Processo de leitura encerrado");
                }
                else
                {
                    if (aux % 2 == 0)
                        sumPar += aux;
                    else
                        sumImp += aux;
                }
            }
        } while (aux < 1000);

        Console.WriteLine("O valor da soma dos números pares é: " + sumPar);
        Console.WriteLine("O valor da soma dos números impares é: "  + sumImp);

    }
}