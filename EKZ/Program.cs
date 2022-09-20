using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EKZ
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;
            Sum();
            matmodel mat = new matmodel();
            mat.minus(4, 2);
            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
            new TextWriterTraceListener(@"Z:\Model.txt"),  // путь на созданный txt файл
            new TextWriterTraceListener(Console.Out)};
            Debug.Listeners.AddRange(listeners);
            Debug.WriteLine("Программа завершена"); //Сообщение  пользователю и вывод результата в файл
            Debug.Flush();
            Console.ReadKey();
            void Sum()
            {
                int sum;
                sum = a + b;
            }
        }
        
        
    }
    public class matmodel
    {
        public void minus(int a, int b)
        {
            int minusi = a - b;
        }
    }
}
