namespace _03_AlgoritmoPorInsercion;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ALGORITMO POR INSERCION LINEAL");
        // Inicializar el arreglo con valores aleatorios
        Random random = new Random();
        int[] A = new int[10];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 101);
        }

        // Mostrar el arreglo desordenado
        Console.Write("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }

        // Ordenar el arreglo con el algoritmo de insercion lineal
        InsercionLineal(A);

        // Mostrar el arreglo ordenado
        Console.Write("\nArreglo ordenado por insercion lineal: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
    }

    static void InsercionLineal(int[] A)
    {
        int i, j, aux;
        Boolean encontrado;

        for (i = 1; i < A.Length; i++)
        {
            aux = A[i];
            j = i - 1;
            encontrado = false;
            while (j >= 0 && !encontrado)
            {
                if (A[j] > aux)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            A[j + 1] = aux;
        }
    }
}
