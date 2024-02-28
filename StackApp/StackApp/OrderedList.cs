using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    public class OrderedList<T> where T : IComparable
    {
        public Elem<T> First { get; set; }


        public void Add(T item) 
        { 
            if(First == null) // пустой список
                First = new Elem<T>() { Info = item };
            else
            {
                if (First.Info.CompareTo(item) == 0) // элемент равен первому
                    return;
                if (First.Info.CompareTo(item) > 0) // элемент меньше первого
                {
                    var newElem = new Elem<T> { Info = item, Next = First };
                    First = newElem;
                    return;
                }
                var cur  = First;
                while(cur.Next != null)
                {
                    if (cur.Next.Info.CompareTo(item) == 0) // элемент равен следующему
                        return;
                    if (cur.Next.Info.CompareTo(item) > 0) // элемент меньше следующего
                    {
                        cur.Next = new Elem<T> { Info = item, Next = cur.Next };
                        return;
                    }
                    else
                        cur = cur.Next;
                }
                cur.Next = new Elem<T> { Info = item};// элемент больше последнего
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = First;
            while (el != null)
            {
                sb.Append($"{el.Info} -> ");
                el = el.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }



        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Merge(OrderedList<T> list)
        {
            // вставить все элементы второго упорядеченного списка в текущий список
            // за один проход не создавая новых элементов только меняя
            // ссылочки - поля Next
            throw new NotImplementedException();
        }

    }


    


}
