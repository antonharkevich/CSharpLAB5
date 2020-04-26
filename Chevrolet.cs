using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{//переопределить страну-производителя
    class Chevrolet:Car
    {
        public Chevrolet() : base()
        {
            Console.WriteLine("Экзмепляр автомобиля оказался шевроле");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfChevrolets++;
            Console.WriteLine("Общее количество моделей шевроле теперь равно:{0} ", totalAmountOfChevrolets);
            Console.WriteLine("");
            mark = "Chevrolet";
            country = "The U.S.A";

        }
        public Chevrolet(string name) : base(name)
        {
            Console.WriteLine("Экзмепляр автомобиля оказался шевроле");
            Console.WriteLine("Марка и страна теперь не могут быть изменены через функцию модификации");
            totalAmountOfChevrolets++;
            Console.WriteLine("Общее количество моделей шевроле теперь равно:{0} ", totalAmountOfChevrolets);
            Console.WriteLine("");
            mark = "Chevrolet";
            country = "The U.S.A";
        }
        private static int totalAmountOfChevrolets = 0;
        public static int TotalAmountOfChevrolets => totalAmountOfChevrolets;
        private bool isRoofRaised = false;
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
            if (isRoofRaised == true)
            {
                Console.WriteLine("Шевроле в режиме кабриолета");
            }
            else
            {
                Console.WriteLine("Шевроле в обычном режиме");
            }
            Console.WriteLine("");
        }
        public void ToCabriolet()
        {
            isRoofRaised = true;
        }
        public void ToGeneralCar()
        {
            isRoofRaised = false;
        }
        public override string Mark { get => mark;}
        public override string Country { get => country; }
    }
}
