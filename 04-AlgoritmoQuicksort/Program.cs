namespace _04_AlgoritmoQuicksort;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ALGORITMO QUICKSORT");
        // Inicializar el arreglo con valores aleatorios
        Random random = new Random();
        int[] A = new int[10];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = random.Next(1, 101);
        }

        // Imprimir el arreglo desordenado
        Console.Write("Arreglo Desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }

        // Ordenar el arreglo con el algoritmo Quicksort
        Quicksort(A, 0, A.Length - 1);

        // Imprimir el arreglo ordenado
        Console.Write("\nArreglo Ordenado por Quicksort: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
    }

    static void Quicksort(int[] A, int primero, int ultimo)
    {
        int i, j, central, pivote;
        central = (primero + ultimo) / 2;
        pivote = A[central];
        i = primero;
        j = ultimo;
        do
        {
            while (A[i] < pivote)
            {
                i++;
            }
            while (A[j] > pivote)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
        {
            Quicksort(A, primero, j);
        }
        if (i < ultimo)
        {
            Quicksort(A, i, ultimo);
        }
    }
}
