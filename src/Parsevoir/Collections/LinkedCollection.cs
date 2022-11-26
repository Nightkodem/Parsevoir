using System;
using Parsevoir.Compatibility;

namespace Parsevoir.Collections;

internal class LinkedCollection<T>
{
    public int Count { get; private set; }

    private Node? _first;
    private Node? _last;

    internal LinkedCollection()
    {
        Clear();
    }

    public void Add(T item)
    {
        var newNode = new Node(item);

        if (_first is null || _last is null)
        {
            _first = newNode;
            _last = _first;
        }
        else
        {
            _last.Next = newNode;
            _last = _last.Next;
        }
        
        Count++;
    }

    public void Clear()
    {
        Count = 0;
        _first = null;
        _last = _first;
    }

    public T[] ToArray()
    {
        if (_first is null) return EmptyArray.Value<T>();
        
        T[] array = new T[Count];
        
        Node? current = _first;
        int i = 0;
        while (current is not null)
        {
            array[i] = current.Value;
            i++;
            current = current.Next;
        }

        return array;
    }

    internal class Node
    {
        public Node? Next { get; set; } = null;
        public T Value { get; }
        
        public Node(T item)
        {
            Value = item;
        }
    }
}