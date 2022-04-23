using System.Collections;

namespace ListTask
{
    internal class MyList<T> : IEnumerable<T>
    {
        public Node<T>? Head { get; private set; }

        public Node<T>? Tail { get; private set; }

        public int Capacity { get; set; }

        public int Count { get; private set; }

        public MyList()
        {
            Capacity = 10;

            Count = 0;
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException($"Значение {nameof(capacity)} должно быть больше 0.");
            }

            Capacity = capacity;
        }

        public MyList(int capacity, T data)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException($"Значение {nameof(capacity)} должно быть больше 0.");
            }

            Node<T> node = new Node<T>(data);

            Head = node;

            Tail = node;

            Capacity = capacity;

            Count++;
        }

        public T GetFirst()
        {
            if (Head == null)
            {
                throw new Exception("Список пуст!");
            }

            return Head.Data;
        }

        public void Add(T data)
        {
            Node<T> current = new Node<T>(data);

            if (Head == null)
            {
                Head = current;
            }
            else
            {
                Tail.Next = current;
            }

            Tail = current;

            if (Count == Capacity)
            {
                Capacity *= 2;
            }

            Count++;
        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            int count = 0;

            Node<T>? current = Head;

            while (current != null)
            {
                if (count == index)
                {
                    break;
                }

                current = current.Next;

                count++;
            }

            return current.Data;
        }

        public T Change(int index, T data)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            int count = 0;

            Node<T> node = new Node<T>(data);

            Node<T>? previous = null;

            Node<T>? current = Head;

            while (current != null)
            {
                if (index == count)
                {
                    if (previous != null)
                    {
                        previous.Next = node;

                        node.Next = current.Next;

                        if (node.Next == null)
                        {
                            Tail = node;
                        }
                    }
                    else
                    {
                        node.Next = Head.Next;

                        Head = node;

                        if (Head == null)
                        {
                            Tail = null;
                        }

                        if (Head.Next == null)
                        {
                            Tail = node;
                        }
                    }

                    return current.Data;
                }

                previous = current;

                current = current.Next;

                count++;
            }

            return current.Data;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            int count = 0;

            Node<T>? previous = null;

            Node<T>? current = Head;

            while (current != null)
            {
                if (index == count)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        Head = Head.Next;

                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }

                    Count--;

                    return current.Data;
                }

                previous = current;

                current = current.Next;

                count++;
            }

            return current.Data;
        }

        public void AppendFirst(T data)
        {
            Node<T> current = new Node<T>(data);

            current.Next = Head;

            Head = current;

            if (Count == 0)
            {
                Tail = Head;
            }

            if (Count == Capacity)
            {
                Capacity *= 2;
            }

            Count++;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            int count = 0;

            Node<T> node = new Node<T>(data);

            Node<T>? previous = null;

            Node<T>? current = Head;

            while (current != null)
            {
                if (index == count)
                {
                    if (previous != null)
                    {
                        previous.Next = node;

                        if (current != null)
                        {
                            node.Next = current;
                        }
                        else
                        {
                            Tail = node;
                        }

                        if (Count == Capacity)
                        {
                            Capacity *= 2;
                        }

                        Count++;
                    }
                    else
                    {
                        node.Next = Head;

                        Head = node;

                        if (Head == null)
                        {
                            Tail = node;
                        }
                        else
                        {
                            Tail = node.Next;
                        }

                        if (Count == Capacity)
                        {
                            Capacity *= 2;
                        }

                        Count++;
                    }
                }

                previous = current;

                current = current.Next;

                count++;
            }
        }

        public bool Remove(T data)
        {
            Node<T>? previous = null;

            Node<T>? current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                    }
                    else
                    {
                        Head = Head.Next;

                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }

                    Count--;

                    return true;
                }

                previous = current;

                current = current.Next;
            }

            return false;
        }

        public T RemoveFirst()
        {
            if (Head == null)
            {
                throw new ArgumentNullException("Список пуст!");
            }

            Node<T> current = Head;

            Head = Head.Next;

            Count--;

            return current.Data;
        }

        public void Reverse()
        {
            Node<T>? previous = null;

            Node<T>? current = Head;

            Node<T>? next = null;

            Tail = current;

            while (current != null)
            {
                next = current.Next;

                current.Next = previous;

                previous = current;

                current = next;
            }

            Head = previous;
        }

        public void CopyTo(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Не может быть null " + nameof(array));
            }

            Node<T>? current = Head;

            try
            {
                int i = 0;

                {
                    while (current != null)
                    {
                        array[i] = current.Data;

                        current = current.Next;

                        i++;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Исходный список содержит большее число элементов чем массив " + nameof(array));
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? current = Head;

            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}