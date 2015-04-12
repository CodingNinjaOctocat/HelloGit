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

            MakeBug();

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

        /// <summary>
        /// 清除指定行的内容。
        /// </summary>
        /// <param name="lineNumber">要清楚内容行的行号。</param>
        static void ClearLine(int lineNumber)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;

            Console.SetCursorPosition(0, lineNumber);
            Console.ForegroundColor = Console.BackgroundColor;

            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(left, top);
        }

        static void MakeBug()
        {
            throw new Exception();
        }
    }
}
