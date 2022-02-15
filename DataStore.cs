using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class StringDataStore<T>
    {
        private T[] Store;
        public StringDataStore()
        {
            Store = new T[10];
        }
        public StringDataStore(int Length)
        {
            Store = new T[Length];
        }
        public T this[int Index]
        {
            get
            {
                if(Index < 0 || Index >= Store.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                return Store[Index];
            }
            set
            {
                if (Index < 0 || Index >= Store.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                Store[Index] = value;
            }
        }
        public int Length
        {
            get
            {return Store.Length;

            }
        }

    }
}
