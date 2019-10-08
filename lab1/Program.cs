using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
            /* 
            Console.WriteLine("Hello World!");
            string name="Miguel";

            Console.WriteLine("hello my name is:"+ name);
            */
            /*
            reglas del constructor
            -tener el mismo nombre que la clase
            -no tiene return
             */

        }
        public Program()
        {
            Console.WriteLine("Im the constructor");

            SayHello();
            Another();
            Another2(150);
            Loops();
            tres();
            cuatro(21, 21);
            Array();

        }

        //sintaxios de funcion
        public int SayHello()
        {
            Console.WriteLine("Hello from a fn");
            return 1;
        }
        public void Another()
        {
            int i = 0;
            for (i = 0; i < 5; i++) ;
            Console.WriteLine(i);

        }
        public void Another2(int val)
        {
            if (val < 100)
            {
                Console.WriteLine("menor que 100");

            }
            else
            {
                Console.WriteLine("mayor que 100");
            }
        }
        public void Loops()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("inside a loop");

            int j = 0;
            do
            {
                Console.WriteLine("inside a do-while");
                j = j + 1;

            } while (j < 10);
        }
        public void tres()
        {
            for (int i = 0; i < 16; i += 3)
            {
                System.Console.WriteLine(i);
            }

        }
        public void cuatro(int num1, int num2)
        {
            int res = (num1 + num2);
            System.Console.WriteLine(res);


        }
        public void Array()
        {
            string[] name = new string[9];
            name[0] = "Miguel";
            name[1] = "123";
            name[2] = "oefdw";
            name[3] = "qreq";

            for (int i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);//posicion de elemento en el array
            }

        }
        public void NuevaF()
        {
            int[] number = new int[200];
            for (int i = 0; i < 200; i++)
            {
                number[i] = i + 1;
            }
            int howMany = Odd(number);
            System.Console.WriteLine(howMany);

        }
        public int Odd(int[] number)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int num = number[i];

                if (num % 2 != 0)
                {
                    System.Console.WriteLine(num);
                    count += 1;
                }
            }

        }

                public void Homework2(){


                    
                }



    }

}
