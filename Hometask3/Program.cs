using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    /// <summary>
    /// Комплексное число
    /// </summary>
    struct Complex
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = re - x.im;
            return y;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }

    internal class Sample02
    {
        public static void Main(string[] args)
        {
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            double inputRe = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            double inputIm = double.Parse(Console.ReadLine());

            Complex complex01;
            complex01.re = inputRe;
            complex01.im = inputIm;

            Console.Write("(2) Введите действительную часть комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine());

            Complex complex02;
            complex02.re = inputRe02;
            complex02.im = inputIm02;


            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            //Complex complex3 = complex01.Plus(complex02);

            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
            Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");

            Console.ReadLine();
        }
    }



    class ComplexClass
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        public double Re
        {
            get
            {
                return re;

            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("На ноль делить нелья!");
                }
                re = value;
            }
        }


        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
        {
            if (re == 0)
            {
                throw new Exception("На ноль делить нелья!");
            }

            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Plus(ComplexClass x)
        {
            return new ComplexClass(re + x.re, im + x.im);
        }

        public ComplexClass Minus(ComplexClass x)
        {
            return new ComplexClass(re - x.re, im - x.im);
        }

        public ComplexClass Multi(ComplexClass x)
        {
            return new ComplexClass(re * x.re, im * x.im);
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }


    class Program
    {
        
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).Пожалуйста, повторите ввод: ");
                else return x;
        }
       
        static int CheckExeptionByInput()
        {
            int result = 0;
            bool exceptionCatched;
            do
            {
                exceptionCatched = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    exceptionCatched = true;
                    string message = ex.Message;
                    Console.WriteLine("Возникло исключение: " + message);
                    Console.Write("Пожалуйста, повторите ввод: ");
                }

            } while (exceptionCatched);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int AmountOfOddNumbers = 0;
            while (true)
            {
                int number = CheckExeptionByInput();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    AmountOfOddNumbers++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Количество чисел: " + AmountOfOddNumbers);

            Console.ReadKey();
        }
    }
}
