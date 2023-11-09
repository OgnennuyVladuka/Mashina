using mashina0;
namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mashina1 LadaPriora = new mashina1(); //Лада Приора
            LadaPriora.marka = "Лада";
            LadaPriora.model = "Приора";
            LadaPriora.nomer = "А000АА14";
            LadaPriora.cvet = "Красный";

            mashina1 LadaVesta = new mashina1(); //Лада Веста
            LadaVesta.marka = "Лада";
            LadaVesta.model = "Веста";
            LadaVesta.nomer = "А111АА21";
            LadaVesta.cvet = "Белый";

            mashina1 BMWX5 = new mashina1(); //BMW X5
            BMWX5.marka = "BMW";
            BMWX5.model = "X5";
            BMWX5.nomer = "В211АС60";
            BMWX5.cvet = "Чёрный";

            /*LadaPriora.zavod();  Пример использывания 
            if (LadaPriora.zav = true)
            {
                Console.WriteLine("правильно");
            }*/

            Console.WriteLine("Список машин:\r\n" +
                "1." + LadaPriora.marka + " " + LadaPriora.model + " Номер: " + LadaPriora.nomer + " Цвет: " + LadaPriora.cvet + "\r\n" +
                "2." + LadaVesta.marka + " " + LadaVesta.model + " Номер: " + LadaVesta.nomer + " Цвет: " + LadaVesta.cvet + "\r\n" +
                "3." + BMWX5.marka + " " + BMWX5.model + " Номер: " + BMWX5.nomer + " Цвет: " + BMWX5.cvet + "\r\n" +
                "\r\n" +
                "Выберите одну машину списка." +
                "\r\nДля выбора наберите цифру машину без точки.");

            int type = Convert.ToInt32(Console.ReadLine());

            string k = "ход";

            while (k == "ход")
            {
                Console.WriteLine("\r\n" +
                    "Для остановки программы наберите стоп\r\n" +
                    "\r\n" +
                    "Список действий:\r\n" +
                    "а) Запустить машину\r\n" +
                    "б) Заглушить машину\r\n" +
                    "в) Газануть\r\n" +
                    "г) Притормозить\r\n" +
                    "д) Переключить передачу на нейтраль\r\n" +
                    "е) Переключить передачу на одну вперёд\r\n" +
                    "ё) Переключить передачу на одну назад\r\n" +
                    "Для выбора наберите букву дейтвия без скобки.\r\n");

                string v = Console.ReadLine();

                Console.WriteLine("");
                
                if (v == "стоп")
                {
                    k = "стоп";
                } else if (type == 1)//1-ая машина
                {
                    if (v == "а") //Запуск машины
                    {
                        if (LadaPriora.zav == true)
                        {
                            Console.WriteLine("Машина Лада Приора уже была заведена.");
                        }
                        else
                        {
                            LadaPriora.zavod();
                            if (LadaPriora.oshibkazavod == false)
                            {
                                Console.WriteLine("Машина Лада Приора завелась.");
                            }
                            else
                            {
                                Console.WriteLine("Машина Лада Приора заглохла.");
                            }
                        }
                    }
                    if (v == "б")//Глушение машины
                    {
                        if (LadaPriora.zav == false)
                        {
                            Console.WriteLine("Машина Лада Приора уже была заглушена.");
                        }
                        else
                        {
                            LadaPriora.glush();
                            Console.WriteLine("Вы заглушили машину Лада Приора.");
                        }
                    }
                    if (v == "в")//Нажатие газа
                    {
                        if (LadaPriora.zav == true)
                        {
                            LadaPriora.nazhgaz();
                            if (LadaPriora.operm == true)
                            {
                                Console.WriteLine("Машина Лада Приора не может повысить свою скорость, достигнута максимальная скорость.\r\n" +
                                "Текущая скорость: " + LadaPriora.speed);
                            }
                            if (LadaPriora.per == 0)
                            {
                                Console.WriteLine("Переключите передачу, машина Лада Приора не может газовать пока вы на нейтральной передаче.\r\n" +
                                "Текущая скорость: " + LadaPriora.speed);
                            } else if (LadaPriora.opers == false && LadaPriora.operm == false)
                            {
                                Console.WriteLine("Машина Лада Приора повысила свою скорость на 10 км/ч.\r\n" +
                                "Текущая скорость: " + LadaPriora.speed);
                            } else if(LadaPriora.opers == true)
                            {
                                Console.WriteLine("Машина Лада Приора не может повысить свою скорость, достигнута максимальная скорость на данной передаче.\r\n" +
                                "Текущая скорость: " + LadaPriora.speed);
                            }
                        } else
                        {
                            Console.WriteLine("Машина Лада Приора не начала газовать, т.к. заглушена.\r\n" +
                                "Сначала заведите машину.");
                        }
                    }
                    if (v == "г")//Нажатие тормоза
                    {
                        if (LadaPriora.speed != 0)
                        {
                            LadaPriora.nazhtor();
                            Console.WriteLine("Машина Лада Приора понизила свою скорость на 10 км/ч.\r\n" +
                                "Текущая скорость: " + LadaPriora.speed);
                        }
                        else
                        {
                            Console.WriteLine("Машина Лада Приора уже остановилась.\r\n" +
                                "Текущая скорость: " + LadaPriora.speed);
                        }
                    }
                    if (v == "д")//Переключение на нейтраль
                    {
                        LadaPriora.pomenperN();
                        Console.WriteLine("Машина Лада Приора переключила передачу на нейтральную.");
                    }
                    if (v == "е")//Переключение на одну вперёд
                    {
                        LadaPriora.pomenperF();
                        Console.WriteLine("Лада Приора переключила передачу.\r\n" +
                            "Текущая передача: " + LadaPriora.per);
                    }
                    if (v == "ё")//Перекдючение на одну назад доделать
                    {
                        LadaPriora.pomenperR();
                        Console.WriteLine("Лада Приора переключила передачу.\r\n" +
                            "Текущая передача: " + LadaPriora.per);
                    }
                } else if (type == 2)//2-я машина
                {
                    if (v == "а") //Запуск машины
                    {
                        if (LadaVesta.zav == true)
                        {
                            Console.WriteLine("Машина Лада Веста уже была заведена.");
                        }
                        else
                        {
                            LadaVesta.zavod();
                            if (LadaVesta.oshibkazavod == false)
                            {
                                Console.WriteLine("Машина Лада Веста завелась.");
                            }
                            else
                            {
                                Console.WriteLine("Машина Лада Веста заглохла.");
                            }
                        }
                    }
                    if (v == "б")//Глушение машины
                    {
                        if (LadaVesta.zav == false)
                        {
                            Console.WriteLine("Машина Лада Веста уже была заглушена.");
                        }
                        else
                        {
                            LadaVesta.glush();
                            Console.WriteLine("Вы заглушили машину Лада Веста.");
                        }
                    }
                    if (v == "в")//Нажатие газа
                    {
                        if (LadaVesta.zav == true)
                        {
                            LadaVesta.nazhgaz();
                            if (LadaVesta.operm == true)
                            {
                                Console.WriteLine("Машина Лада Веста не может повысить свою скорость, достигнута максимальная скорость.\r\n" +
                                "Текущая скорость: " + LadaVesta.speed);
                            }
                            if (LadaVesta.per == 0)
                            {
                                Console.WriteLine("Переключите передачу, машина Лада Веста не может газовать пока вы на нейтральной передаче.\r\n" +
                                "Текущая скорость: " + LadaVesta.speed);
                            }
                            else if (LadaVesta.opers == false && LadaVesta.operm == false)
                            {
                                Console.WriteLine("Машина Лада Веста повысила свою скорость на 10 км/ч.\r\n" +
                                "Текущая скорость: " + LadaVesta.speed);
                            }
                            else if (LadaVesta.opers == true)
                            {
                                Console.WriteLine("Машина Лада Веста не может повысить свою скорость, достигнута максимальная скорость на данной передаче.\r\n" +
                                "Текущая скорость: " + LadaVesta.speed);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Машина Лада Веста не начала газовать, т.к. заглушена.\r\n" +
                                "Сначала заведите машину.");
                        }
                    }
                    if (v == "г")//Нажатие тормоза
                    {
                        if (LadaVesta.speed != 0)
                        {
                            LadaVesta.nazhtor();
                            Console.WriteLine("Машина Лада Веста понизила свою скорость на 10 км/ч.\r\n" +
                                "Текущая скорость: " + LadaVesta.speed);
                        }
                        else
                        {
                            Console.WriteLine("Машина Лада Веста уже остановилась.\r\n" +
                                "Текущая скорость: " + LadaVesta.speed);
                        }
                    }
                    if (v == "д")//Переключение на нейтраль
                    {
                        LadaVesta.pomenperN();
                        Console.WriteLine("Машина Лада Веста переключла передачу на нейтральную.");
                    }
                    if (v == "е")//Переключение на одну вперёд
                    {
                        LadaVesta.pomenperF();
                        Console.WriteLine("Лада Веста переключила передачу.\r\n" +
                            "Текущая передача: " + LadaVesta.per);
                    }
                    if (v == "ё")//Перекдючение на одну назад доделать
                    {
                        LadaVesta.pomenperR();
                        Console.WriteLine("Лада Веста переключила передачу.\r\n" +
                            "Текущая передача: " + LadaVesta.per);
                    }
                } else if (type == 3)//3-я машина
                {
                    if (v == "а") //Запуск машины
                    {
                        if (BMWX5.zav == true)
                        {
                            Console.WriteLine("Машина BMW X5 уже была заведена.");
                        }
                        else
                        {
                            BMWX5.zavod();
                            if (BMWX5.oshibkazavod == false)
                            {
                                Console.WriteLine("Машина BMW X5 завелась.");
                            }
                            else
                            {
                                Console.WriteLine("Машина BMW X5 заглохла.");
                            }
                        }
                    }
                    if (v == "б")//Глушение машины
                    {
                        if (BMWX5.zav == false)
                        {
                            Console.WriteLine("Машина BMW X5 уже была заглушена.");
                        }
                        else
                        {
                            BMWX5.glush();
                            Console.WriteLine("Вы заглушили машину BMW X5.");
                        }
                    }
                    if (v == "в")//Нажатие газа
                    {
                        if (BMWX5.zav == true)
                        {
                            BMWX5.nazhgaz();
                            if (BMWX5.operm == true)
                            {
                                Console.WriteLine("Машина BMW X5 не может повысить свою скорость, достигнута максимальная скорость.\r\n" +
                                "Текущая скорость: " + BMWX5.speed);
                            }
                            if (BMWX5.per == 0)
                            {
                                Console.WriteLine("Переключите передачу, машина BMW X5 не может газовать пока вы на нейтральной передаче.\r\n" +
                                "Текущая скорость: " + BMWX5.speed);
                            }
                            else if (BMWX5.opers == false && BMWX5.operm == false)
                            {
                                Console.WriteLine("Машина BMW X5 повысила свою скорость на 10 км/ч.\r\n" +
                                "Текущая скорость: " + BMWX5.speed);
                            }
                            else if (BMWX5.opers == true)
                            {
                                Console.WriteLine("Машина BMW X5 не может повысить свою скорость, достигнута максимальная скорость на данной передаче.\r\n" +
                                "Текущая скорость: " + BMWX5.speed);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Машина BMWX 5 не начала газовать, т.к. заглушена.\r\n" +
                                "Сначала заведите машину.");
                        }
                    }
                    if (v == "г")//Нажатие тормоза
                    {
                        if (BMWX5.speed != 0)
                        {
                            BMWX5.nazhtor();
                            Console.WriteLine("Машина  BMW X5 понизила свою скорость на 10 км/ч.\r\n" +
                                "Текущая скорость: " + BMWX5.speed);
                        }
                        else
                        {
                            Console.WriteLine("Машина BMW X5 уже остановилась.\r\n" +
                                "Текущая скорость: " + BMWX5.speed);
                        }
                    }
                    if (v == "д")//Переключение на нейтраль
                    {
                        BMWX5.pomenperN();
                        Console.WriteLine("Машина BMW X5 переключла передачу на нейтральную.");
                    }
                    if (v == "е")//Переключение на одну вперёд
                    {
                        BMWX5.pomenperF();
                        Console.WriteLine("BMW X5 переключила передачу.\r\n" +
                            "Текущая передача: " + BMWX5.per);
                    }
                    if (v == "ё")//Перекдючение на одну назад доделать
                    {
                        BMWX5.pomenperR();
                        Console.WriteLine("BMW X5 переключила передачу.\r\n" +
                            "Текущая передача: " + BMWX5.per);
                    }
                }
            }
        }
    }
}