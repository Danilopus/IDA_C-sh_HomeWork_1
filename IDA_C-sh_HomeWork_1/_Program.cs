// HomeWork template 1.0 // date: 21.09.2023

using System;
using Service;

// HomeWork 01 : [C sharp intro] --------------------------------

namespace IDA_C_sh_HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu.MainMenu mainMenu = new MainMenu.MainMenu();

            do
            {
                Console.Clear();
                mainMenu.Show_menu();
                if (mainMenu.User_Choice_Handle() == 0) break;
            } while (true);
            //Console.ReadKey();
        }


        public static void Task_1(string work_name)
        /*  Пользователь вводит с клавиатуры число в диапа-
        зоне от 1 до 100. Если число кратно 3 (делится на 3 без
        остатка) нужно вывести слово Fizz.Если число кратно 5
        нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
        вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
        вывести само число.
        Если пользователь ввел значение не в диапазоне от 1
        до 100 требуется вывести сообщение об ошибке.*/
        {
            Console.WriteLine(work_name + "\n");
            Console.WriteLine("Number [1..100] -> ");
            int? user_number = ServiceFunction.Get_Int_Positive(1,100, "Error: range expected [1..100]");
            Console.WriteLine(ServiceFunction.FizzBuzz(user_number));
        }
        public static void Task_2(string work_name)
          /*    Пользователь вводит с клавиатуры два числа.Первое
        число — это значение, второе число процент, который
        необходимо посчитать.Например, мы ввели с клавиатуры
        90 и 10. Требуется вывести на экран 10 процентов от 90.
        Результат: 9.*/
        {
            Console.WriteLine(work_name + "\n");
            Console.WriteLine("Base -> ");
            double? user_number_1 = ServiceFunction.Get_Double();
            Console.WriteLine("Percent -> ");
            double? user_number_2 = ServiceFunction.Get_Double_Positive();
            Console.WriteLine(user_number_1 + " * " + user_number_2 + "% = " + (user_number_1 / 100) * user_number_2);

        }
        public static void Task_3(string work_name)
        /*  Пользователь вводит с клавиатуры четыре цифры.
        Необходимо создать число, содержащее эти цифры.На-
        пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
        сформировать число 1578.*/
        {
            Console.WriteLine(work_name + "\n");
            string tmp_str = new string("");
            //string tmp_str;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digit [" +  i+ "] -> ");
                tmp_str += Convert.ToString(ServiceFunction.Get_Int_Positive(0, 9, "Error: digits [0..9]"));
            }
            Console.WriteLine(tmp_str);
        }
    }
}

namespace Service
{



}
