using System;

public class CustomList<T>
{
    private T[] arr;
    private int capacity;
    private int count;

    public CustomList()
    {
        capacity = 4; // ù ũ�� ����
        arr = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == capacity)
        {
            // �迭 ũ�⸦ �ø��� ���� ��ҵ��� ����
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(arr, newArray, count);
            arr = newArray;
        }

        arr[count] = item;
        count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException();
        }

        return arr[index];
    }

    public int Count
    {
        get { return count; }
    }
}
