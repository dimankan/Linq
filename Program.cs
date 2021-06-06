using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Первое знакомство с LINQ. Использовали массив

            //string[] array =
            //{
            //    "Первое","Второе","Третье","Четвертое","Пятое"
            //};

            //// Использовал Класс Array
            ////Array.Reverse(array); // Перевернул массив array с помощью класса Array и методом Reverse()
            ////Array.Sort(array);// Отсортировал по алфавиту

            ////string str = string.Join(Environment.NewLine, array); // Объеденил массив в стринг
            ////Console.WriteLine(str);// вывел в консоль


            ////Linq
            ////List<string> newlist = array.Reverse().ToList();// Создал лист в котором впервые использовали Linq
            //// тип переменной List<> можно отпустить.
            //// Мы не будем каждый раз приводить массив в ToList(). Будем использовать VAR:
            //var newlist = array.Reverse();


            //string strLinq = string.Join(Environment.NewLine, newlist); // Объеденил list<string> в стринг. JOIN переварит всё!!! 
            //Console.WriteLine(strLinq);

            #endregion

            #region Вместо массива будем использовать лист.
            //var list = new List<string>
            //{
            //    "Первое","Второе","Третье","Четвертое","Пятое"
            //};
            //Console.WriteLine(FakeBin("45385593107843568"));
            Console.WriteLine("Введите два числа");
        }

        #region Select: Определяет проекцию выбранных значений (преобразование) 
        #region CodeWars

        /// <summary>
        /// Учитывая строку цифр, вы должны заменить любую цифру ниже 5 на «0», а любую цифру от 5 и выше на «1». 
        /// Верните полученную строку.
        /// </summary>
        public static string FakeBin(string x) => string.Concat(x.Select(a => a < '5' ? "0" : "1"));

        /// <summary>
        /// Powers of 2
        /// Завершите функцию, которая принимает на вход неотрицательное целое число n и возвращает 
        /// список всех степеней двойки с показателем от 0 до n (включительно).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static BigInteger[] PowersOfTwo(int n)
        {
            return Enumerable.Range(0, n + 1).Select(x => BigInteger.Pow(2, x)).ToArray();
        }
        /// <summary>
        /// Beginner - Lost Without a Map
        /// Учитывая массив целых чисел, верните новый массив с удвоением каждого значения.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] Maps(int[] x)
        {
            return x.Select(e => e * 2).ToArray();
        }

        /// <summary>
        /// Abbreviate a Two Word Name
        /// Напишите функцию для преобразования имени в инициалы. 
        /// Это ката состоит из двух слов с одним пробелом между ними. 
        /// На выходе должны быть две заглавные буквы с точкой, разделяющей их.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();

        #endregion
        #region Описание Хруста
        //var newlist = list.Select(x => x.Contains("П"));  //Вернет True где есть буква "П"

        //var newlist = list.Select(x => "123"); // Преобразовал каждый элемент в "123"

        //int i = 1;
        //var newlist = list.Select(x => $"{i++} {x}"); // Сделал нумерацию для каждого элемента

        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);
        #endregion
        #endregion
        #region Where: Фильтрация множества. Создаем отдельный лист удовлетворяющий условию(по наличию определенной буквы)

        #region Версия без Linq с foreach

        //var newlist = new List<string>();
        //foreach (string line in list)
        //{
        //    if (line.Contains("П"))
        //    {
        //        newlist.Add(line);
        //    }
        //}

        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);
        #endregion

        //var newlist = list.Where(x => x.Contains("П")); // создает отдельный лист где каждый элемент проходит фильтрацию по "П"
        //// var newlist = list.Where(x => !x.Contains("П")); // все элементы не содержащий "П" за счёт !

        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);
        #endregion

        #region OrderBy: Упорядочивает элементы по возрастанию
        #region CodeWars
        /// <summary>
        /// В коробке несколько столбиков игрушечных кубиков, выстроенных в линию. 
        /// В i-м столбце находится a_i кубов. Сначала сила тяжести в коробке тянет кубики вниз. 
        /// Когда Боб переключает гравитацию, он начинает тянуть все кубики к определенной стороне коробки, d, 
        /// которая может быть либо «L», либо «R» (влево или вправо). 
        /// Ниже приведен пример того, как может выглядеть коробка с кубиками до и после переключения силы тяжести.
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Flip(char dir, int[] arr)
        {
            return dir == 'R' ? arr.OrderBy(x => x).ToArray() : arr.OrderByDescending(x => x).ToArray();
        }
        #endregion

        //var newlist = list.OrderBy(x => x);// Отсортировал элементы по алфавиту

        //var str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);
        #endregion
        #region OrderByDescending: Упорядочивает элементы по убыванию
        //var newlist = list.OrderByDescending(x => x);// Отсортировал элементы по алфавиту в обратном порядке

        //var str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);
        #endregion
        #region ThenBy: Задает дополнительные критерии для упорядочивания элементов по возрастанию
        //var list2 = new List<string>
        //{
        //    "2Г","2Д","1А","1Б","1В","2А","2Б","4А","6Б","2В","Г1","1Г","1Д","5А","5В","4Б","4Г", "А1", "Б1"
        //};

        //var newlist = list2.OrderByDescending(x => x.Contains("1")).ThenBy(x => x);
        ////В начале отображает все элементы где есть "1", затем ThenBy все сортирует в алфав. порядке

        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);


        #endregion
        #region ThenByDescending: Задает дополнительные критерии для упорядочивания элементов по убыванию
        //var list2 = new List<string>
        //{
        //"2Г","2Д","1А","1Б","1В","2А","2Б","4А","6Б","2В","Г1","1Г","1Д","5А","5В","4Б","4Г", "А1", "Б1"
        //};

        ////var newlist = list2.OrderByDescending(x => x.Contains("1")).ThenByDescending(x => x);
        ////////В начале отображает все элементы где есть "1", затем ThenBy все сортирует в алфав. порядке наоборот

        ////var newlist = list2.OrderByDescending(x => x.Contains("1")).ThenByDescending(x => x).Skip(1);
        ////Все то же самое, только пропускает первый элемент

        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);


        #endregion

        #region GroupBy: Группирует элементы по ключу (g => g.Key)
        //var list2 = new List<string>
        //{
        //    "Первое","Второе","Третье","Четвертое","Пятое","Второе"
        //};
        ////var newlist = list2.GroupBy(g => g).Select(g=>g.Key);// Пока по сути тоже самое что и distinct
        ////// Но уже учитывается количество дублирующихся элементов. И их можно обработать

        //var newlist = list2.GroupBy(g => g).Where(g => g.Count() > 1).Select(g => g.Key);
        //// Выведет только "Второе". Потому что количество этого элемента больше чем 1.


        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);

        #endregion

        #region Reverse: Располагает элементы в обратном порядке (Переворачивание)
        #region CodeWars

        /// <summary>
        /// Reversed Words
        /// Завершите решение, чтобы оно перевернуло все слова в переданной строке.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }

        /// <summary>
        /// My head is at the wrong end!
        /// Ваша работа - переупорядочить массив
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string[] FixTheMeerkat(string[] arr) => arr.Reverse().ToArray();
        #endregion
        #region Хруст
        ////var newlist = list.Reverse();// Ошибка CS0815  Не удается присвоить void неявно типизированной переменной.

        //list.Reverse(); // Для Reverse нужно так

        //string strLinq = string.Join(Environment.NewLine, list); // Объеденил list<string> в стринг. Но JOIN переварит всё!!! 
        //Console.WriteLine(strLinq);
        #endregion

        #endregion

        #region Contains: Определяет, содержит ли коллекция определенный элемент
        #region CodeWars
        /// <summary>
        /// Вам будет предоставлен массив a и значение x. 
        /// Все, что вам нужно сделать, это проверить, содержит ли предоставленный массив значение. 
        /// Массив может содержать числа или строки. X может быть любым. 
        /// Верните истину, если массив содержит значение, и ложь, если нет.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Check(object[] a, object x) => a.Contains(x);
        #endregion
        #endregion
        #region Distinct: Удаляет дублирующиеся элементы из коллекции 
        //var list2 = new List<string>
        //{
        //    "Первое","Второе","Третье","Четвертое","Пятое","Третье","Второе"
        //};

        //var newlist = list2.Distinct();

        //string strLinq = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(strLinq);
        #endregion

        #region Union: Объединяет две однородные коллекции  

        //var list2 = new List<string>
        //{
        //    "1","2","3","4","5"
        //};

        //var newlist = list.Union(list2);

        //string strLinq = string.Join(Environment.NewLine, newlist); // Объеденил list<string> в стринг. Но JOIN переварит всё!!! 
        //Console.WriteLine(strLinq);
        #endregion

        #region Count: Подсчитывает количество элементов коллекции (можно подсчитать по условию)
        #region CodeWars
        /// <summary>
        /// Рассмотрим массив / список овец, где некоторые овцы могут отсутствовать на своем месте.
        /// Нам нужна функция, которая считает количество овец в массиве (true означает наличие).
        /// </summary>
        /// <param name="sheeps"></param>
        /// <returns></returns>
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(s => s);

        #endregion

        //var newlist = list.Count();

        //string str = string.Join(Environment.NewLine, newlist);
        //Console.WriteLine(str);

        #endregion
        #region Sum: подсчитывает сумму числовых значений в коллекции
        #region CodeWars
        /// <summary>
        /// Суммирует все элементы массива предварительно конвертируя каждый из них
        /// </summary>
        /// <param name="x">массив обектов с цифрами неважно какого типа</param>
        /// <returns></returns>
        public static int SumMix(object[] x) => x.Sum(Convert.ToInt32);
        #endregion


        #endregion

        #region Skip: Пропускает определенное количество элементов 

        //var newlist = list.Skip(1);

        //string strLinq = string.Join(Environment.NewLine, newlist); // Объеденил list<string> в стринг. Но JOIN переварит всё!!! 
        //Console.WriteLine(strLinq);
        #endregion



        #region Concat: Объединяет две коллекции
        #region CodeWars
        /// <summary>
        /// Учитывая строку цифр, вы должны заменить любую цифру ниже 5 на «0», а любую цифру от 5 и выше на «1». 
        /// Верните полученную строку.
        /// </summary>
        public static string FakeBin1(string x) => string.Concat(x.Select(a => a < '5' ? "0" : "1"));

        /// <summary>
        /// String repeat
        /// Напишите функцию с именем repeatStr, которая повторяет заданную строку ровно n раз.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string repeatStr(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }
        #endregion

        #endregion

        #region Min:
        #region CodeWars
        /// <summary>
        /// Учитывая массив целых чисел, ваше решение должно найти наименьшее целое число. 
        /// Например: Учитывая [34, 15, 88, 2], ваше решение вернет 2. 
        /// Учитывая [34, -345, -1, 100], ваше решение вернет -345. 
        /// Для целей этого ката вы можете предположить, что предоставленный массив не будет пустым.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static int FindSmallestInt(int[] args) => args.Min();

        #endregion
        #endregion

        #region Average:
        #region CodeWars
        /// <summary>
        /// Calculate average
        /// Напишите функцию, которая вычисляет среднее значение чисел в данном списке. 
        /// Примечание: пустые массивы должны возвращать 0.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double FindAverage(double[] array)
        {
            return array.Length == 0 ? 0 : array.Average();
        }
        #endregion
        #endregion
        #region .ToArray<>:
        #region CodeWars
        /// <summary>
        /// Pre-FizzBuzz Workout #1
        /// Это первый шаг к пониманию FizzBuzz. 
        /// Ваши входные данные: положительное целое число n, большее или равное единице. n предоставляется, 
        /// у вас НЕТ КОНТРОЛЯ над его значением. 
        /// Ожидаемый результат - это массив положительных целых чисел от 1 до n (включительно). 
        /// Ваша задача - написать алгоритм, который проведет вас от входа к выходу.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] PreFizz(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }

        #endregion
        #endregion
        #region Cast: Приводит элементы объекта IEnumerable к заданному типу.
        #region CodeWars
        /// <summary>
        /// Find the first non-consecutive number
        /// Ваша задача - найти первый не последовательный элемент массива. 
        /// Под непоследовательными мы подразумеваем не на 1 больше, чем предыдущий элемент массива. Например. 
        /// Если у нас есть массив [1,2,3,4,6,7,8], то 1, затем 2, затем 3, затем 4 - все последовательные, 
        /// а 6 - нет, так что это первое непоследовательное число. Если весь массив последовательный, верните null. 
        /// В массиве всегда будет как минимум 2 элемента, и все элементы будут числами. 
        /// Номера также будут уникальными и расположены в порядке возрастания. 
        /// Числа могут быть положительными или отрицательными, и первое непоследовательное тоже может быть!
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static object FirstNonConsecutive(int[] arr) => arr.Cast<int?>().Skip(1).FirstOrDefault(i => i != ++arr[0]);

        #endregion

        #endregion
        #endregion
        /*Заметки:
        Последнее на чем остановился: Find the first non-consecutive number

        */


    }
}

