using System.Collections;
using System.Collections.Generic;
using Parsevoir.Compatibility;

namespace Parsevoir.Collections;

internal class LinkedCollection<T> : IEnumerable<T>
    where T : notnull
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
        _last = null;
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
            
            current = current.Next;
            i++;
        }

        return array;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator() => new Enumerator(this);

    internal class Node
    {
        public Node? Next { get; set; } = null;
        public T Value { get; }
        
        public Node(T item)
        {
            Value = item;
        }
    }

    public struct Enumerator : IEnumerator<T>, IEnumerator
    {
        private readonly LinkedCollection<T> _collection;
        private Node? _node;
        private T _current;

        object IEnumerator.Current => Current;
        public T Current => _current;

        public Enumerator(LinkedCollection<T> collection)
        {
            _collection = collection;
            _node = _collection._first;
            _current = default!;
        }

        public bool MoveNext()
        {
            if (_node is null)
                return false;
            
            _current = _node.Value;
            _node = _node != _collection._last
                ? _node.Next
                : null;

            return true;
        }

        public void Reset()
        {
            _node = _collection._first;
            _current = default!;
        }

        public void Dispose()
        {
        }
    }
}