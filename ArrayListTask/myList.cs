using System.Collections;

namespace ArrayListTask
{
    internal class MyList<T> : IList<T>
    {
        private T[] Collection { get; set; }

        public T this[int index] { get => Collection[index]; set => Collection[index] = value; }

        public int Count { get; set; }

        public int Capacity { get; set; }

        public bool IsReadOnly { get => true; }

        public MyList()
        {
            Capacity = 0;

            Collection = new T[Capacity];
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Значение" + nameof(capacity) + " не может быть меньше нуля.");
            }

            Capacity = capacity;

            Collection = new T[Capacity];
        }

        public MyList(T[] collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Collection = new T[collection.Length];

            for (int i = 0; i < Collection.Length; i++)
            {
                Collection[i] = collection[i];

                Count++;
            }

            Capacity = Collection.Length;
        }

        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                T[] bigCollection = new T[Capacity + Count];

                for (int i = 0; i < Collection.Length; i++)
                {
                    bigCollection[i] = Collection[i];
                }

                Capacity = bigCollection.Length;

                Collection = bigCollection;
            }

            Collection[Count] = item;

            Count++;
        }

        public void Clear()
        {
            Array.Clear(Collection);

            Count = 0;
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            for (int i = 0; i < Count; i++)
            {
                if (Collection[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Collection.CopyTo(array, arrayIndex);
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Collection[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (Capacity <= Count)
            {
                T[] bigCollection = new T[Capacity + Count];

                for (int i = 0; i < Collection.Length; i++)
                {
                    bigCollection[i] = Collection[i];
                }

                Capacity = bigCollection.Length;

                Collection = bigCollection;
            }

            for (int i = Count; i >= index; i--)
            {
                Collection[i + 1] = Collection[i];

                if (i == index)
                {
                    Collection[i] = item;

                    Count++;
                }
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Collection[i].Equals(item))
                {
                    for (int j = i; j < Count; j++)
                    {
                        if (j + 1 == Count)
                        {
                            Collection[j] = default;

                            Count--;

                            return true;
                        }

                        Collection[j] = Collection[j + 1];
                    }
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            for (int i = index; i < Count; i++)
            {
                if (i + 1 == Count)
                {
                    Collection[i] = default;

                    Count--;

                    break;
                }

                Collection[i] = Collection[i + 1];
            }
        }

        public void TrimExcess()
        {
            T[] newCollection = new T[Count];

            for (int i = 0; i < newCollection.Length; i++)
            {
                newCollection[i] = Collection[i];
            }

            Capacity = newCollection.Length;

            Collection = newCollection;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}