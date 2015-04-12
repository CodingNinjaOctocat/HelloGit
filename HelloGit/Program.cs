using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //向屏幕打印一行问候语。
            Console.WriteLine("Hello Git");

            //暂停程序。
            Console.ReadLine();
        }

        /// <summary>
        /// 打印集合。
        /// </summary>
        /// <typeparam name="T">集合的类型。</typeparam>
        /// <param name="collection">一个集合。</param>
        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
