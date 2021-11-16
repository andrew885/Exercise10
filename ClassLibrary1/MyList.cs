using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class MyList<MyItem> : IList<MyItem>
    {      
        IList<MyItem> myList;
        public MyList()
        {
            myList = new List<MyItem>();
        }
        public MyItem this[int index]
        {
            get
            {
                if (index <= myList.Count && index >= 0)
                    return myList[index];
                else
                    return default(MyItem);
            }
            set
            {
                myList[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return myList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return myList.IsReadOnly;
            }            
        }

        public void Add(MyItem item)
        {
            myList.Add(item);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public bool Contains(MyItem item)
        {
            if (item == null)
                return false;
            else
                return myList.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            myList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            if (item == null)
                return -1;
            else
            {
                return myList.IndexOf(item);
            }                          
        }

        public void Insert(int index, MyItem item)
        {
            myList.Insert(index,item);
        }

        public bool Remove(MyItem item)
        {
            if (item == null)
                return false;
            else
                return myList.Remove(item);           
        }

        public void RemoveAt(int index)
        {
            myList.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
