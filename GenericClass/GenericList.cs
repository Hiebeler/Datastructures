namespace GenericClass;

internal class GenericList<T>
{
    private readonly List<T> list = new();

    public void Add(T input)
    {
        list.Add(input);
    }

    public List<T> getList()
    {
        return list;
    }

    public T getItem(int index)
    {
        return list.ElementAtOrDefault(index);
    }
}