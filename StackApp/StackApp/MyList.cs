using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
 
    // класс для реализации прохода по коллекции
    public class ListEnumerator<T> : IEnumerator<T>
    {
        private MyLinkedList<T> _list;
        private Elem<T> curElem;

        // в конструктор передаём нашу коллекцию
        public ListEnumerator(MyLinkedList<T> list)
        {
            _list = list;
            curElem = new Elem<T>() { Info = default, Next = list.First };
        }

        // получить текущий элемент коллекции
        public T Current
        {
            get
            {
                return curElem.Info;
            }

        }

        object IEnumerator.Current => curElem.Info;

        public void Dispose()
        {
            return;
        }

        // переход на следующий элемент, если коллекция закончилась false
        public bool MoveNext()
        {
            curElem = curElem.Next;
            return curElem != null;
        }

        // сброс указателя на нулевой элемент  
        public void Reset()
        {
            curElem = new Elem<T>() { Info = default, Next = _list.First };
        }
    }

    public class MyLinkedList<T>:IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            // вызов класса нумератора
            //return new ListEnumerator<T>(this);


            //реализация нумератора через Lazy yield return
            yield return default;
            yield return default;
            yield return default;


            var el = First;
            while(el != null)
            {
                yield return el.Info;
                el = el.Next;
            }
            yield break;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        

    }

    public class Elem<T>
    {
        public T Info { get; set; }
        public Elem<T> Next { get; set; }
    }
}
