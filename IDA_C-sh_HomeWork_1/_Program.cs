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
        /*        Пользователь вводит с клавиатуры число в диапа-
        зоне от 1 до 100. Если число кратно 3 (делится на 3 без
        остатка) нужно вывести слово Fizz.Если число кратно 5
        нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
        вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
        вывести само число.
        Если пользователь ввел значение не в диапазоне от 1
        до 100 требуется вывести сообщение об ошибке.*/
        {
            Console.WriteLine(work_name + "\n");
            Console.WriteLine("Number [1..100) -> ");
            int? user_number = ServiceFunction.Get_Int_Positive(1,100, "Error: range expected [1..100)");
            Console.WriteLine(ServiceFunction.FizzBuzz(user_number));
        }
        public static void Task_2(string work_name)
        {

        }
        public static void Task_3(string work_name)
        {

        }
    }
}

namespace Service
{



}
