using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[1];
            Chevrolet[] chevrolets = new Chevrolet[1];
            Ferrari[] ferraries = new Ferrari[1];
            Mercedes[] mercedeses = new Mercedes[1];
            int b = 20;
            int c = 20;
            int d = 20;
            int e = 20;
            while (true)
            {
                Console.WriteLine("Добро пожаловать в меню");
                Console.WriteLine("Для работы с обычным автомобилем нажмите 1");
                Console.WriteLine("Для работы с шевроле нажмите 2");
                Console.WriteLine("Для работы с феррари нажмите 3");
                Console.WriteLine("Для работы с мерседесами нажмите 4");
                Console.WriteLine("Для выхода из программы нажмите 0");
                int a = Convert.ToInt32(Checks.CheckSingleInput());
                switch (a)
                {
                    case 1:
                        while (true)
                        {
                            if (b == 0)
                            {
                                b = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            b = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (b)
                            {
                                case 1:
                                    if (Car.TotalAmountOfCars == 0)
                                    {

                                        cars[0] = new Car();
                                    }
                                    else
                                    {
                                        Array.Resize(ref cars, cars.Length + 1);
                                        cars[cars.Length - 1] = new Car();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Car.TotalAmountOfCars == 0)
                                    {

                                        cars[0] = new Car(str);
                                    }
                                    else
                                    {
                                        Array.Resize(ref cars, cars.Length + 1);
                                        cars[cars.Length - 1] = new Car(str);
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Car.TotalAmountOfCars!=0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", cars.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Information(); break;
                                case 5 when Car.TotalAmountOfCars!=0:
                                    Console.WriteLine("Введите индекс объекта, который хотите изменить (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Modification(); break;
                                case 6 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,у которого нужно переключить передачу  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].GearShift(); break;
                                case 7 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно починить  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Repair(); break;
                                case 8 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно ускорить  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Accelerate(); break;
                                case 9 when Car.TotalAmountOfCars != 0:
                                    Console.WriteLine("Введите индекс объекта, который нужно улучшить  (от 0 и до {0})", cars.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > cars.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    cars[i].Upgrade(); break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    b = 20; break;

                            }

                        } 
                        break;
                    case 2:
                        while (true)
                        {
                            if (c == 0)
                            {
                                c = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса в кабриолет введите 10");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса обычную шевроле введите 11");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            c = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (c)
                            {
                                case 1:
                                    if (Chevrolet.TotalAmountOfChevrolets == 0)
                                    {

                                        chevrolets[0] = new Chevrolet();
                                    }
                                    else
                                    {
                                        Array.Resize(ref chevrolets, chevrolets.Length + 1);
                                        chevrolets[chevrolets.Length - 1] = new Chevrolet();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Chevrolet.TotalAmountOfChevrolets == 0)
                                    {

                                        chevrolets[0] = new Chevrolet(str);
                                    }
                                    else
                                    {
                                        Array.Resize(ref chevrolets, chevrolets.Length + 1);
                                        chevrolets[chevrolets.Length - 1] = new Chevrolet(str);
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", chevrolets.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Information(); break;
                                case 5 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Modification(); break;
                                case 6 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта, у которого нужно переключить передачу (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].GearShift(); break;
                                case 7 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно починить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Repair(); break;
                                case 8 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно ускорить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Accelerate(); break;
                                case 9 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно улучшить (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].Upgrade(); break;
                                case 10 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно сделать кабриалетом (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].ToCabriolet(); break;
                                case 11 when Chevrolet.TotalAmountOfChevrolets != 0:
                                    Console.WriteLine("Введите индекс объекта,который нужно сделать обычным (от 0 и до {0})", chevrolets.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > chevrolets.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    chevrolets[i].ToGeneralCar(); break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    c = 20;  break;
                            }

                        }
                        break;
                    case 3:
                        while (true)
                        {
                            if (d == 0)
                            {
                                d = 20;
                                break;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса в гоночную модель введите 10");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса обычную феррари введите 11");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            d = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (d)
                            {
                                case 1:
                                    if (Ferrari.TotalAmountOfFerraries == 0)
                                    {

                                        ferraries[0] = new Ferrari();
                                    }
                                    else
                                    {
                                        Array.Resize(ref ferraries, ferraries.Length + 1);
                                        ferraries[ferraries.Length - 1] = new Ferrari();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Ferrari.TotalAmountOfFerraries == 0)
                                    {

                                        ferraries[0] = new Ferrari(str);
                                    }
                                    else
                                    {
                                        Array.Resize(ref ferraries, ferraries.Length + 1);
                                        ferraries[ferraries.Length - 1] = new Ferrari(str);
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Ferrari.TotalAmountOfFerraries!=0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", ferraries.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Information(); break;
                                case 5 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Modification(); break;
                                case 6 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,у которого хотите переключить передачу(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].GearShift(); break;
                                case 7 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите починить(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Repair(); break;
                                case 8 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите ускорить(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Accelerate(); break;
                                case 9 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите улучшить(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].Upgrade(); break;
                                case 10 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать гоночным(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].ToRacing(); break;
                                case 11 when Ferrari.TotalAmountOfFerraries != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать обычным(от 0 и до {0})", ferraries.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > ferraries.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    ferraries[i].ToGeneral(); break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    d = 20; break;
                            }
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            if (e == 0)
                            {
                                e = 20;
                                break ;
                            }
                            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
                            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
                            Console.WriteLine("Для просмотра текущей версии программы введите 3");
                            Console.WriteLine("Для просмотра информации об экзмепляре класса нажмите 4");
                            Console.WriteLine("Для модификации экземпляра класса введите 5");
                            Console.WriteLine("Для переключения передачи у экземпляра класса введите 6");
                            Console.WriteLine("Для ремонта экземпляра класса введите 7");
                            Console.WriteLine("Для увеличения скорости у экземпляра класса введите 8");
                            Console.WriteLine("Для улучшения экземпляра класса введите 9");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса в тонированную модель введите 10");
                            Console.WriteLine("Для того, чтобы превратить экземпляр класса обычную мерседес введите 11");
                            Console.WriteLine("Для перехода мерседеса в новый класс введите 12");
                            Console.WriteLine("Для выхода в меню нажмите 0");
                            e = Convert.ToInt32(Checks.CheckSingleInput());
                            switch (e)
                            {
                                case 1:
                                    if (Mercedes.TotalAmountOfMercedes == 0)
                                    {

                                        mercedeses[0] = new Mercedes();
                                    }
                                    else
                                    {
                                        Array.Resize(ref mercedeses, mercedeses.Length + 1);
                                        mercedeses[mercedeses.Length - 1] = new Mercedes();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите имя");
                                    string str = Checks.CheckSingleStringInput();
                                    if (Mercedes.TotalAmountOfMercedes == 0)
                                    {

                                        mercedeses[0] = new Mercedes(str);
                                    }
                                    else
                                    {
                                        Array.Resize(ref mercedeses, mercedeses.Length + 1);
                                        mercedeses[mercedeses.Length - 1] = new Mercedes(str);
                                    }
                                    break;
                                case 3: Transport.Version(); break;
                                case 4 when Mercedes.TotalAmountOfMercedes!=0:
                                    Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", mercedeses.Length - 1);
                                    int i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Information(); break;
                                case 5 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Modification(); break;
                                case 6 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,у которого хотите переключить передачу (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].GearShift(); break;
                                case 7 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите починить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Repair(); break;
                                case 8 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите ускорить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Modification(); break;
                                case 9 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите улучшить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].Upgrade(); break;
                                case 10 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать тонированным (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].ToTintCar(); break;
                                case 11 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,который хотите сделать обычным (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].ToGeneral(); break;
                                case 12 when Mercedes.TotalAmountOfMercedes != 0:
                                    Console.WriteLine("Введите индекс объекта,класс которого хотите изменить (от 0 и до {0})", mercedeses.Length - 1);
                                    i = Convert.ToInt32(Checks.CheckSingleInput());
                                    while (i < 0 || i > mercedeses.Length - 1)
                                    {
                                        Console.WriteLine("Введите корректное значение индекса");
                                        i = Convert.ToInt32(Checks.CheckSingleInput());
                                    }
                                    mercedeses[i].ChangeClass(); break;
                                case 0: break;
                                default:
                                    Console.WriteLine("Что-то пошло не так, вы ещё не создали объектов или ввели не то значение");
                                    e = 20; break;
                            }
                        }
                        break;
                    case 0: return;
                    default: break;
                }
            }
            
        }
    }
}













