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

        public void RemoveValue(int k)
        {
            throw new NotImplementedException();            
        }

        public void RemoveElemK(int k)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
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
