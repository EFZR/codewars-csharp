namespace Solution;

public class Class1
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> result = [];

        T? previous = default;

        foreach (T item in iterable)
        {
            if (!item!.Equals(previous) || result.Count == 0)
            {
                result.Add(item);
                previous = item;
            }
        }

        return result;
    }
}
