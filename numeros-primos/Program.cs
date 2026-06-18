using numeros_primos;

const int numInicial = 0;
var numFinal = 1000;

var numerosPrimos = Calculo.calcularNumerosPrimos(numInicial, numFinal);
Console.WriteLine("Números primos entre " + numInicial + " e " + numFinal + ": " + string.Join(", ", numerosPrimos));
Console.WriteLine("Total de números primos encontrados: " + numerosPrimos.Length);
