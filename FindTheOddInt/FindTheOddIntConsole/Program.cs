namespace FindTheOddInt;

public static class FindTheOddIntSolution
{
    public static int findOddSolution(int[] seq)
    {
        // Usamos un diccionario para contar las ocurrencias de cada número
        var counts = new Dictionary<int, int>();

        foreach (var num in seq)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }

        // Buscamos el número con un conteo impar
        foreach (var pair in counts)
        {
            if (pair.Value % 2 != 0)
            {
                return pair.Key;
            }
        }

        return -1; // Retornar -1 si no se encuentra (aunque no debería ocurrir)
    }
}


class Program
{
    static void Main()
    {
        // This should return 4
        Console.WriteLine(FindTheOddIntSolution.findOddSolution([1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1]));
    }
}
