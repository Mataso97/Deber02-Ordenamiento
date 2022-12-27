namespace _01_AlgoritmoBurbuja;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ALGORITMO DE LA BURBUJA");

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

        // Ordenar el arreglo con el algoritmo de la Burbuja
        Burbuja(A);

        // Imprimir el arreglo ordenado
        Console.Write("\nArreglo Ordenado por Burbuja: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
    }

    static void Burbuja(int[] A)
    {
        int aux;
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A.Length - 1; j++)
            {
                if (A[j] > A[j + 1])
                {
                    aux = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = aux;
                }
            }
        }
    }
}