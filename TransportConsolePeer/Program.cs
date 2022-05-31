using System;
using System.IO;
using System.Text;
using EKRLib;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();
                //Генерирую длину массива.
                int value = rnd.Next(6, 10);
                Transport[] array = new Transport[value];
                //Заполняю массив.
                for (int i = 0; i < array.Length; i++)
                {
                    //Нужно для генерации 0 или 1. 1-Car; 0- MotorBoat.
                    int j = rnd.Next(0, 2);
                    //Если Car.
                    if (j == 1)
                    {
                        try
                        {
                            array[i] = new Car(GetModel(), (uint)rnd.Next(10, 100));
                            Console.WriteLine(array[i].StartEngine());
                        }
                        catch (Exception error)
                        {
                            //Словил искл-е.Нужно будет снова работать с этой ячейкой.И распечатать текст исключения.
                            i--;
                            Console.WriteLine(error.Message);
                        }
                    }
                    //Если MotorBoat.
                    else if (j == 0)
                    {
                        try
                        {
                            array[i] = new MotorBoat(GetModel(), (uint)rnd.Next(10, 100));
                            Console.WriteLine(array[i].StartEngine());


                        }
                        catch (Exception error)
                        {
                            i--;
                            Console.WriteLine(error.Message);
                        }
                    }

                }
                //Запись в текстовые файлы.
                Putonstream(array);
                //Условие для повтора.
                Console.WriteLine("Если хотите завершить - нажмите 'Esc'");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
        /// <summary>
        /// Метод записи в текстовые файлы.
        /// </summary>
        /// <param name="array">
        /// Массив из Car или MotorBoat.
        /// </param>
        private static void Putonstream(Transport[] array)
        {
            using (StreamWriter carstr = new StreamWriter(@"..\..\..\Cars.txt", false, Encoding.Unicode))
            {
                using (StreamWriter boatstr = new StreamWriter(@"..\..\..\MotorBoats.txt", false, Encoding.Unicode))
                {
                    //Определяем и распеделяем.
                    foreach (var elem in array)
                    {
                        if (elem is Car)
                        {
                            carstr.WriteLine(elem);
                        }
                        else if (elem is MotorBoat)
                        {
                            boatstr.WriteLine(elem);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Генерация модели.
        /// </summary>
        /// <returns></returns>
        private static string GetModel()
        {
            Random rnd = new Random();
            string model = "";
            //Это специально от 4 до 6. Чтобы выбрасывало исключения,если длина не 5.
            for (int i = 0; i < rnd.Next(4, 7); i++)
            {
                if (rnd.Next(10) == 1) { model += (char)rnd.Next('A', 'Z'); }
                else
                {
                    model += (char)rnd.Next('0', '9');
                }
            }
            return model;
        }
    }
}
