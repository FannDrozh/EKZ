﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace EKZ
{
    
    /// <summary>
    /// Основной класс программы для реализации программы
    /// </summary>
    public class Program
    {
        public class Entrecsv
        {
            public string s;
            /// <summary>
            /// метод для создания ввода в файл
            /// </summary>
            public void entre()
            {
                StreamReader entre = new StreamReader("Entre.txt");
                while (!entre.EndOfStream)
                {
                    s = entre.ReadLine();
                    Console.WriteLine(s);
                }
                entre.Close();
            }

            //Вывод введенных данных в csv
            public void vivod()
            {
                string[] lines = new string[] { s };
                File.WriteAllLines("entre.csv", lines);
            }
        }
        /// <summary>
        /// Это основной класс программы для расчёта
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Entrecsv entrecsv = new Entrecsv();
            entrecsv.vivod();
            entrecsv.entre();
            //переменные для суммы элементов
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine(sum);
            Sum();
            Debug.WriteLine("Ответ: " + sum);
            matmodel mat = new matmodel();
            mat.minus(4, 2);
            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
            new TextWriterTraceListener("Model.txt"),// путь на созданный txt файл
            new TextWriterTraceListener(Console.Out)};
            Debug.Listeners.AddRange(listeners);            
            Debug.WriteLine("Программа завершена"); //Сообщение  пользователю и вывод результата в файл
            Debug.Flush();
            Console.ReadKey();
            void Sum()
            {                
                sum = a + b;
            }
        }

        
        
    }
    /// <summary>
    /// Это класс для хранения метода вычитания 
    /// </summary>
    public class matmodel
    {
        public void minus(int a, int b)
        {
            int minusi = a - b;
        }
    }
}
