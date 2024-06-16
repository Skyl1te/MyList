using System;
using System.Collections;
using System.Collections.Generic;

namespace MyList;

public class ReList<T> : IList<T>, IEquatable<ReList<T>>, ICloneable, IEnumerable<T>
{
    private T[] _data;

    public ReList()
    {
        _data = new T[0];
    }

    public T this[int index]
    {
        get { return _data[index]; }
        set { _data[index] = value; }
    }

    public int Count { get { return _data.Length; } }

    public bool IsReadOnly { get { return false; } }

    public void Add(T item)
    {
        Array.Resize(ref _data, _data.Length + 1);
        _data[_data.Length - 1] = item;
    }

    public void Clear()
    {
        _data = new T[0];
    }

    public bool Contains(T item)
    {
        foreach (T element in _data)
        {
            if (element.Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        int copyCount = array.Length - arrayIndex;
        if (copyCount > _data.Length)
        {
            copyCount = _data.Length;
        }

        for (int i = 0; i < copyCount; i++)
        {
            array[i + arrayIndex] = _data[i];
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < _data.Length; i++)
        {
            if (_data[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public void Insert(int index, T item)
    {
        Array.Resize(ref _data, _data.Length + 1);
        for (int i = _data.Length - 1; i > index; i--)
        {
            _data[i] = _data[i - 1];
        }
        _data[index] = item;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index < 0)
            return false;

        RemoveAt(index);
        return true;
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < _data.Length - 1; i++)
        {
            _data[i] = _data[i + 1];
        }
        Array.Resize(ref _data, _data.Length - 1);
    }

    public bool Equals(ReList<T>? other)
    {
        if (other == null || _data.Length != other._data.Length)
        {
            return false;
        }

        for (int i = 0; i < _data.Length; i++)
        {
            if (_data[i].Equals(other._data[i]))
            {
                return true;
            }
        }
        return false;
    }

    public object Clone()
    {
        ReList<T> newList = new ReList<T>();
        newList._data = new T[_data.Length];
        Array.Copy(_data, newList._data, _data.Length);
        return newList;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _data.Length; i++)
        {
            yield return _data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void PrintReList()
    {
        foreach (var item in _data)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
