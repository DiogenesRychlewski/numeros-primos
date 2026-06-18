namespace numeros_primos
{
    internal class Calculo
    {
        internal static int[] calcularNumerosPrimos(int numInicial, int numFinal)
        {
            var numerosPrimos = new List<int>();

            //for para iterar do número inicial ao número final
            for (var i = numInicial; i <= numFinal; i++)
            {
                //verificar se o número é primo
                if (isPrimo(i))
                {
                    numerosPrimos.Add(i);
                }
            }

            return numerosPrimos.ToArray();
        }

        static bool isPrimo(int num)
        {
            if (num < 2) return false;

            //verificar se o número é divisível por algum número entre 2 e a raiz quadrada do número
            for (var i = 2; i * i <= num; i++)
            {
                //se o número for divisível por algum número, ele não é primo
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
