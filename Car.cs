using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Car: Transport
    {
        public Car():base()
        {
            Console.WriteLine("Экзмепляр транспорта оказался автомобилем");
            Console.WriteLine("Поле страны, денег, текущей скорости и мощности двигателя можно вернуть из любой точки программы, ");
            Console.WriteLine("Максимальная скорость теперь не может быть изменена через функцию модификации, а только через функцию Upgrade");
            totalAmountOfCars++;
            Console.WriteLine("Общее количество автомобилей теперь равно:{0} ", totalAmountOfCars);
            Console.WriteLine("");
        }
        public Car(string name) : base(name)
        {
            Console.WriteLine("Экзмепляр транспорта оказался автомобилем");
            Console.WriteLine("Поле страны, денег, текущей скорости и мощности двигателя можно вернуть из любой точки программы, ");
            Console.WriteLine("Максимальная скорость теперь не может быть изменена через функцию модификации, а только через функцию Upgrade");
            totalAmountOfCars++;
            Console.WriteLine("Общее количество автомобилей теперь равно:{0} ", totalAmountOfCars);
            Console.WriteLine("");
        }
        public override void Modification()
        {
            Console.WriteLine("Для изменения имени нажмите 2");
            Console.WriteLine("Для изменения цвета нажмите 3");
            Console.WriteLine("Для изменения веса нажмите 4");
            Console.WriteLine("Для изменения количества мест нажмите 5");
            Console.WriteLine("Для изменения марки нажмите 6");
            Console.WriteLine("Для изменения габаритов нажмите 7 и следуйте инструкции");
            Console.WriteLine("Для изменения состава нажмите 8 и следуйте инструкции");
            Console.WriteLine("Для изменения страны производителя нажмите 9");
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

                case 6: Console.WriteLine("Введите марку"); Mark = Checks.CheckSingleStringInput(); break;
                case 7:
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
                case 8:
                    Console.WriteLine("Введите индекс поля состава, которое хотите изменить(>=0&&<=10)");
                    m = Convert.ToInt32(Checks.CheckSingleInput());
                    Console.WriteLine("Введите часть состава");
                    this[m - 1] = Checks.CheckSingleStringInput();
                    break;
                case 9:
                    Console.WriteLine("Введите страну производителяя");
                    Country = Checks.CheckSingleStringInput(); break;
                    
            }
            Console.WriteLine("");
        }


        public override void Information()
        {
            Console.WriteLine("1)ID автомобиля:{0} ", id);
            Console.WriteLine("2)Имя автомобиля:{0} ", Name);
            Console.WriteLine("3)Цвет автомобиля:{0} ", Color);
            Console.WriteLine("4)Вес автомобиля:{0} ", Weight);
            Console.WriteLine("5)Количество мест в автомобиле:{0} ", NumberOfSeats);
            Console.WriteLine("6)Марка автомобиля:{0} ", Mark);
            Console.WriteLine("7)Максимальная скорость автомобиля:{0} ", MaxSpeed);
            Console.WriteLine("8.1)Ширина автомобиля:{0} ", transportDimensions.width);
            Console.WriteLine("8.2)Высота автомобиля:{0} ", transportDimensions.height);
            Console.WriteLine("8.3)Длина автомобиля:{0} ", transportDimensions.length);
            Console.WriteLine("Состав автомобиля: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("9.{0}):{1} ", i + 1, this[i]);
            }
            Console.WriteLine("10)Cтрана производитель автомобиля:{0} ",Country);
            Console.WriteLine("11)Текущая передача автомобиля:{0} ", gear);
            Console.WriteLine("12)Мощность двигателя автомобиля:{0} ",EnginePower );
            Console.WriteLine("13)Текущая скорость автомобиля:{0} ", CurrentSpeed);
            Console.WriteLine("14)Остаток на счёте владельца:{0} ", Money);
            Console.WriteLine("");
          
        }
        protected string country = "empty";
        public virtual string Country { get => country; set => country = value; }
        private Gears gear = Gears.TheFirst;
        private static int totalAmountOfCars = 0;
        public static int TotalAmountOfCars => totalAmountOfCars;
        private bool carIsDead = false;
        private bool motorIsDead = false;
        private bool wheelIsLowered = false;
        private int money = 10000;
        public int Money => money;
        private double enginePower = 0;
        private double currentSpeed = 0;
        public double CurrentSpeed => currentSpeed;
        public  double EnginePower => enginePower;
        public int upgradeCounter = 0;
        public override double MaxSpeed => maxSpeed;
        public void GearShift()
        {
            Console.WriteLine("Выберите, на какую передачу переключиться (от 1 до 5) и введите номер передачи");
            int n = Convert.ToInt32(Checks.CheckSingleInput());
            switch (n)
            {
                case 1:gear = Gears.TheFirst;
                    break;
                case 2:gear = Gears.TheSecond;
                    break;
                case 3:gear = Gears.TheThird;
                    break;
                case 4:gear = Gears.TheFourth;
                    break;
                case 5:gear = Gears.TheFifth;
                    break;
                default:Console.WriteLine("Неверное значение");
                    Console.WriteLine("");
                    break;
            }
        }
        public override void Accelerate()
        {
            if (carIsDead != true)
            {
                Console.WriteLine("Скорость автомобиля увеличена!");
                switch (gear)
                {   
                    case Gears.TheFirst:

                        currentSpeed += 5;
                        break;
                    case Gears.TheSecond:
                        currentSpeed += 10;
                        break;
                    case Gears.TheThird:
                        currentSpeed += 15;
                        break;
                    case Gears.TheFourth:
                        currentSpeed += 20;
                        break;
                    case Gears.TheFifth:
                        currentSpeed += 25;
                        break;

                }
                Console.WriteLine("Текущая скорость:{0}",CurrentSpeed);
                if (MaxSpeed - currentSpeed <= 0)
                {
                    Console.WriteLine("Автомобиль сломался!");
                    Console.WriteLine("");
                    carIsDead = true;
                    currentSpeed = 0;

                }
                else if (MaxSpeed - currentSpeed < 25)
                {
                    Console.WriteLine("Аккуратно, автомобиль уже не выдерживает!");
                    Console.WriteLine("");
                }
            }
            else
            {
               Console.WriteLine("Машина сломана!");
               Console.WriteLine("");
            }
        }
        public override void Upgrade()
        {
            if (motorIsDead != true&& wheelIsLowered != true)
            {
                upgradeCounter++;
                if (upgradeCounter % 10 == 0)
                {
                    Console.WriteLine("Двигатель сломался!");
                    motorIsDead = true;
                    Console.WriteLine("");
                }
                else if (upgradeCounter % 5 == 0)
                {
                    Console.WriteLine("Прокол колеса!");
                    wheelIsLowered = true;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Мощность двигателя увеличена!");
                    enginePower += 10;
                    Console.WriteLine("Теперь его мощность:{0}", EnginePower);
                    Console.WriteLine("");
                    Console.WriteLine("Максимальная скорость автомобиля увеличена!");
                    maxSpeed += 25;
                    Console.WriteLine("Теперь его мощность:{0}", MaxSpeed);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Сначала почините части машины!");
                Console.WriteLine("");
            }
        }
        public void Repair()
        {
            Console.WriteLine("Выберите, что будем ремонтировать, 1-колесо, 2-двигатель, 3-всю машину");
            Console.WriteLine("Починить колесо стоит 100$, двигатель- 500$, всю машину-1000$");
            Console.WriteLine("Текущий остаток:{0}$", money);
            Console.WriteLine("");
            int n = Convert.ToInt32(Checks.CheckSingleInput());
            switch (n)
            {
                case 1:
                    if (money >= 100)
                    {
                        wheelIsLowered = false;
                        money -= 100;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                        Console.WriteLine("");
                    }
                    break;
                case 2:
                    if (money >= 500)
                    {
                        motorIsDead = false;
                        money -= 500;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                        Console.WriteLine("");
                    }
                    break;
                case 3:
                    if (money >= 1000)
                    {
                        carIsDead = false;
                        money -= 1000;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                        Console.WriteLine("");
                    }
                    break;
                    
                default:
                    Console.WriteLine("Неверное значение");
                    Console.WriteLine("");
                    break;
            }
        }

    }
}
