using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    public class MyLinkedList<T>
    {
        public Elem<T> First { get; set; }


        public void AddFirst(T item)
        {
            Elem<T> newElem = new Elem<T>();
            newElem.Info = item;
            newElem.Next = First;

            First = newElem;    
        }

        public void AddLast(T item)
        {
            if (First == null)
            {
                AddFirst(item);
                return;
            }
            var el = First;
            while (el.Next != null)
                el = el.Next;
            
            el.Next = new Elem<T> { Info = item };
        }

        public void RemoveValue(T x)
        {
            while(First != null && First.Info.Equals(x) ) 
            {
                First = First.Next;
            }
            if(First == null)
            {
                return;
            }

            var elem = First;
            while(elem.Next != null)
            {
                if (elem.Next.Info.Equals(x))
                    elem.Next = elem.Next.Next;
                else 
                    elem = elem.Next;
            }            
        }

        public void RemoveAtIndex(int k)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }


        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
        public bool CountOfValue(T item)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = First;
            while(el != null )
            {
                sb.Append($"{el.Info} -> ");
                el = el.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }



    }

    public class Elem<T>
    {
        public T Info { get; set; }
        public Elem<T> Next { get; set; }
    }
}
