using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество шагов арифметической прогрессии - ");
            int length = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression(2,2);
            Console.WriteLine("Шаг прогрессии - {0}", arithProgression.x);
            arithProgression.setStart();
            for (int i = 0; i < length; i++)
            {
                Console.Write(arithProgression.GetNext()+" ");
            }
            Console.WriteLine();
            arithProgression.Reset();
            Console.WriteLine();
            Console.Write("Введите количество шагов геометрической прогрессии - ");
            length = Convert.ToInt32(Console.ReadLine());
            GeomProgression geomProgression = new GeomProgression(2, 3);
            Console.WriteLine("Шаг прогрессии - {0}", geomProgression.x);
            geomProgression.setStart();
            for (int i = 0; i < length; i++)
            {
                Console.Write(geomProgression.GetNext() + " ");
            }
            Console.WriteLine();
            geomProgression.Reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart();
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        public int x { get; set; }
        public int a { get; set; }
        public int a0 { get; set; }
        public int GetNext()
        {
            return a = a + x;
        }

        public void Reset()
        {
            Console.WriteLine("Выполнен сброс до первоначального значения - {0}",a0);
            a = a0;
        }

        public void setStart()
        {
            a0 = a;
            Console.Write("Начальное значение - {0}\nАрифметическая прогрессия - ", a0);
        }
        public ArithProgression(int a, int x)
        {
            this.a = a;
            this.x = x;
        }
    }
    class GeomProgression : ISeries
    {
        public int x { get; set; }
        public int a { get; set; }
        public int a0 { get; set; }
        public int GetNext()
        {
            return a = a * x;
        }

        public void Reset()
        {
            Console.WriteLine("Выполнен сброс до первоначального значения - {0}", a0);
            a = a0;
        }

        public void setStart()
        {
            a0 = a;
            Console.Write("Начальное значение - {0}\nГеометрическая прогрессия - ", a0);
        }
        public GeomProgression(int a, int x)
        {
            this.a = a;
            this.x = x;
        }
    }
}
