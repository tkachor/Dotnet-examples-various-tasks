using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace Itvdn_dotnet
{
    class Program
{
        /* 1  - Є екземпляр scr класу Screamer, здатний видавати подію Scream.
        public event EventHandler<int> Scream;
        Цілий параметр події передає в обробник тривалість крику.
        Оголосити статичний метод scr_Scream(...), який би міг бути обробником події Scream.
        Завдання обробника - збільшувати зовнішню змінну ScreamCounter, підсумовуючи в ній загальну тривалість криків.*/
        class Screamer
        {
            public event EventHandler<int> Scream;

            public void OnScream(int length)
            {
                if (Scream != null)
                    Scream(this, length);
            }
        }

        static Screamer scr = new Screamer();
        static int ScreamCounter;

       
        public static void scr_Scream(object obj, int ScreamDuration)
        {
            ScreamCounter += ScreamDuration;
        }

        /* 2 - Оголосити клас E з конструктором без параметрів та деструктором. 
        Клас повинен видавати подію типу EventHandler StartEvent при створенні об'єкта (тобто в конструкторі) 
        та видавати подію типу EventHandler FinishEvent при видаленні об'єкта (у деструкторі).
        Подію StartEvent для цього завдання зробіть статичною.*/

        class E
        {

            public static event EventHandler StartEvent;
            public event EventHandler FinishEvent;

            public E()
            {
                StartEvent?.Invoke(this, new EventArgs());
            }

            ~E()
            {
                FinishEvent?.Invoke(this, new EventArgs());
            }     

        }

        /*  3  - Оголосити делегат void MyHandler(int n) та клас Counter.
        Клас Counter має відкриту властивість int N та подію MyHandler Prime.
        Подія видається завжди, коли N стає простим числом (1 простим числом не вважається).
        Параметром події є значення властивості N.*/

        public delegate void MyHandler(int n);

        class Counter
        {
            private int n;

            public int N
            {
                get { return n; }

                set { 
                        n = value;

                        if (isPrime(n))
                        {
                            Prime?.Invoke(n);
                        }
                        
                    }
            }

            public event MyHandler Prime;

            public static bool isPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                        return false;

                return true;
            }

        }

        /*  4  - Оголосіть клас A із методом Fire(). Кожен виклик методу Fire видає подію Bang типу
        delegate void BangHandler(DateTime t),
        у параметрі t – час видання події.
        Тип делегата вже оголошено.*/

        delegate void BangHandler(DateTime t);
        class A
        {
            public event BangHandler Bang;

            public void Fire() => Bang?.Invoke(DateTime.Now);    

            
        }
        public static void Main()
        {
            //#1
            scr.Scream += scr_Scream;
            scr.OnScream(5);
            Console.WriteLine(ScreamCounter);

            //#2
            E.StartEvent += (s, e) => { Console.WriteLine("Start"); };
            E e = new E();
            e.FinishEvent += (s, e) => { Console.WriteLine("Finish"); };

            //#3
            Counter c = new Counter();
            c.Prime += n => { Console.WriteLine(n); };
            c.N = 2;
            c.N = 4;

            //#4
            A a = new A();
            a.Bang += t => { Console.WriteLine(t); };
            a.Fire();

        }

    }

}