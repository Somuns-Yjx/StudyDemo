using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{

    #region 接口隔离1
    interface IGreenLeaves
    {
        void Photosynthesize();
    }
    interface IFlowers
    {
        void AbsorbOxygen();
    }

    public class GreenPlants : IGreenLeaves, IFlowers
    {
        public void Photosynthesize()
        {
            Console.WriteLine("GreenTree is photosynthesizing ");
        }
        public void AbsorbOxygen()
        {
            Console.WriteLine("GreenTree is absorbing oxygen ");
        }
    }

    public class Rose : IFlowers
    {
        public void AbsorbOxygen()
        {
            Console.WriteLine("Rose is absorbing oxygen ");
        }
    }
    #endregion

    #region 接口隔离2
    public class ReadOnlyCollection : IEnumerable
    {
        private int[] _array;
        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public class Enumerator : IEnumerator
        {
            public ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }
            public bool MoveNext()
            {
                if (++_head < _collection._array.Length)
                    return true;
                else
                    return false;
            }
            public void Reset()
            {
                _head = -1;
            }
        }
    }
    #endregion

    #region 接口隔离3
    interface IGentleman
    {
        void Warm();
    }

    public interface IRogue
    {
        void Bully();
    }

    public class People : IGentleman,IRogue
    {
        public void Warm()
        {
            Console.WriteLine("I am a warmheart person ");
        }
        void IRogue.Bully()
        {
            Console.WriteLine("I bullied some people before ");
        }
    }


    #endregion


}
