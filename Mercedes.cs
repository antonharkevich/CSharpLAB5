using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Mercedes: Car
    {
        public Mercedes() : base()
        {
            Console.WriteLine("Экзмепляр автомобиля оказался мерседесом");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfMercedes++;
            Console.WriteLine("Общее количество моделей мерседес теперь равно:{0} ", totalAmountOfMercedes);
            Console.WriteLine("");
            mark = "Mercedes";
            country = "Germany";

        }
        public Mercedes(string name) : base(name)
        {
            Console.WriteLine("Экзмепляр автомобиля оказался мерседесом");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfMercedes++;
            Console.WriteLine("Общее количество моделей мерседес теперь равно:{0} ", totalAmountOfMercedes);
            Console.WriteLine("");
            mark = "Mercedes";
            country = "Germany";
        }
        private static int totalAmountOfMercedes = 0;
        public static int TotalAmountOfMercedes => totalAmountOfMercedes;
        private bool isCarTint = false;
        char @class = 'A';
        public override void Modification()
        {
            Console.WriteLine("Для изменения имени нажмите 2");
            Console.WriteLine("Для изменения цвета нажмите 3");
            Console.WriteLine("Для изменения веса нажмите 4");
            Console.WriteLine("Для изменения количества мест нажмите 5");
            Console.WriteLine("Для изменения габаритов нажмите 6 и следуйте инструкции");
            Console.WriteLine("Для изменения состава нажмите 7 и следуйте инструкции");
            int n = Convert.ToInt32(Checks.CheckSingleInput());

            switch (n)
            {

                case 2:
                    Console.WriteLine("Введите имя");
                    Name = Checks.CheckSingleStringInput(); break;
                case 3:
                    Console.WriteLine("Введите цвет");
                    Color = Checks.CheckSingleStringInput(); break;
                case 4:
                    Console.WriteLine("Введите вес");
                    Weight = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                case 5:
                    Console.WriteLine("Введите количество мест");
                    NumberOfSeats = Convert.ToInt32(Checks.CheckSingleInput()); break;


                case 6:
                    ModificationOutput2();
                    int m = Convert.ToInt32(Checks.CheckSingleInput());
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("Введите ширину");
                            double y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            if (y > 0)
                            {
                                transportDimensions.width = y;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, вы ввели неправильное значение");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Введите высоту");
                            y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            if (y > 0)
                            {
                                transportDimensions.height = y;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, вы ввели неправильное значение");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Введите длину");
                            y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            if (y > 0)
                            {
                                transportDimensions.length = y;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, вы ввели неправильное значение");
                            }
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine("Введите индекс поля состава, которое хотите изменить(>=0&&<=10)");
                    m = Convert.ToInt32(Checks.CheckSingleInput());
                    Console.WriteLine("Введите часть состава");
                    this[m - 1] = Checks.CheckSingleStringInput();
                    break;


            }
            Console.WriteLine("");
        }
        public override void Information()
        {
            base.Information();
            if (isCarTint == true)
            {
                Console.WriteLine("Мерседес в режиме тонировки");
            }
            else
            {
                Console.WriteLine("Мерседес в обычном режиме");
            }
            Console.WriteLine("Текущий класс мерседеса:{0}", @class);
            Console.WriteLine("");
        }
        public void ToTintCar()
        {
            isCarTint = true;
        }
        public void ToGeneral()
        {
            isCarTint = false;
        }
        public override string Mark { get => mark; }
        public override string Country { get => country; }

        public void ChangeClass()
        {
            Console.WriteLine("Введите цифру класса");
            Console.WriteLine("1-A,2-B,3-C,4-D,5-E,6-G,7-M,8-S");
            int n = Convert.ToInt32(Checks.CheckSingleInput());

            switch (n)
            {
                case 1: @class = 'A';break;
                case 2: @class = 'B'; break;
                case 3: @class = 'C'; break;
                case 4: @class = 'D'; break;
                case 5: @class = 'E'; break;
                case 6: @class = 'G'; break;
                case 7: @class = 'M'; break;
                case 8: @class = 'S'; break;
                default:  break;
            }

        }
    }
}
