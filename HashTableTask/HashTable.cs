using System.Collections;

namespace HashTableTask
{
    class HashTable<T> : ICollection<T>
    {
        public int Count { get ; }

        public bool IsReadOnly { get => true; }

        public List<T>[] Items { get; }

        public HashTable()
        {
            Count = 10;

            Items = new List<T>[Count];
        }

        public HashTable(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("Длинна таблицы должна быть больше нуля.");
            }

            Count = count;

            Items = new List<T>[Count];
        }

        public HashTable(int count, T item)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("Длинна таблицы должна быть больше нуля.");
            }

            Count = count;

            Items = new List<T>[Count];

            if (item == null)
            {
                throw new ArgumentNullException("Значение не может быть null");
            }

            int hash = this.GetHash(item);

            Items[hash] = new List<T> { item };
        }

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Значение не может быть null");
            }

            int hash = this.GetHash(item);

            if (Items[hash] == null)
            {
                Items[hash] = new List<T> { item };
            }
            else
            {
                Items[hash].Add(item);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Items[i].Clear();
            }
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                return false;
            }

            int hash = this.GetHash(item);

            if (Items[hash] == null)
            {
                return false;
            }

            return Items[hash].Contains(item);
        }

        public bool Remove(T item)
        {
            if (item == null)
            {
                return false;
            }

            int hash = this.GetHash(item);

            if (Items[hash] == null)
            {
                return false;
            }

            return Items[hash].Remove(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Массив не может быть null.");
            }

            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Значение параметра item не может быть меньше нуля.");
            }

            if (array.Length - arrayIndex < this.Count)
            {
                throw new ArgumentException("Размер необходимого места в массиве недостаточно.");
            }

            Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        private int GetHash(T item)
        {
            return Math.Abs(item.GetHashCode() % Items.Length);
        }
    }
}