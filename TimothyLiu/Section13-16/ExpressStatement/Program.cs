using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Section13
            Console.WriteLine("=============13===========" + "\n");
            Console.WriteLine("==========================" + "\n");
            #endregion

            #region Section14
            Console.WriteLine("=============14===========" + "\n");

            #region Reflection
            Console.WriteLine("==========================" + "\n");
            Test.Reflection.GetCylinderVolume(10, 20);
            #endregion
            #endregion

            #region Section15
            Console.WriteLine("=============15===========" + "\n");
            #region Try-Catch-Finally
            Test.TryStatement.Show();
            Console.WriteLine("==========================" + "\n");
            #endregion

            #endregion

            #region Section16
            
            #region DoWhile
            Console.WriteLine("=============16===========" + "\n");
            //Test.DoWhile.Show();
            
            #endregion

            #region Iterator
            Test.IteratorExample.ShowIterator();
            Test.IteratorExample.ShowForeach();
            Console.WriteLine("\n"+"==========================" + "\n");

            #endregion

            #endregion

            Console.ReadKey();


        }
    }
}
