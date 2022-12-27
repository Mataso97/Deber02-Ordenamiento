namespace _02_AlgoritmoPorSeleccion;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ALGORITMO POR SELECCION");
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

        // Ordenar el arreglo con el algoritmo de seleccion
        Seleccion(A);

        // Mostrar el arreglo ordenado
        Console.Write("\nArreglo ordenado por seleccion: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
    }

    static void Seleccion(int[] A)
    {
        int i, j, indiceMenor;
        int aux;
        for (i = 0; i < A.Length - 1; i++)
        {
            indiceMenor = i;
            for (j = i + 1; j < A.Length; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j;
                }
            }
            aux = A[indiceMenor];
            A[indiceMenor] = A[i];
            A[i] = aux;
        }
    }
}
