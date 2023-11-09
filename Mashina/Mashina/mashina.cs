namespace mashina0
{
    public class mashina1
    {
        public string marka; //марка автомобиля
        public string model; //модель автомобиля
        public string nomer; //номер автомобиля
        public string cvet; //цвет автомобиля
        public bool zav = false; //Показатель заведён ли автомобиль
        public int speed = 0; //скорость автомобиля
        public int per = 0; //передача автомобиля
        public bool oshibkazavod = false; //показатель глушения машины из-за ошибки
        public bool opers = false; //показатель ошибки повышения скорости при неверной передаче
        public bool operm = false;//показатель ошибки повышения скорости на последней передаче
        public void zavod() //метод заведения машины
        {
            if (zav == false)
            {
                oshibkazavod = false;
            }
            if (per == 0 || per == 1)
            {
                zav = true;
            } else
            {
                oshibkazavod = true;
            }
        }
        public void glush() //метод глушения автомобиля
        {
            zav = false;
        }
        public void nazhgaz() //метод нажатия педали газа
        {
            if (per == 1 && (speed >= 0 || speed <= 20))
            {
                opers = false;
                operm = false;
                speed += 10;
            }
            if (per == 1 && speed == 40)
            {
                opers = true;
                speed -= 10;
            }

            if (per == 2 && (speed >= 20 || speed <= 30))
            {
                opers = false;
                operm = false;
                speed += 10;
            }
            if (per == 2 && speed == 50)
            {
                opers = true;
                speed -= 10;
            }
            
            if (per == 3 && (speed >= 40 || speed <= 60))
            {
                opers = false;
                operm = false;
                speed += 10;
            }
            if (per == 3 && speed == 80)
            {
                opers = true;
                speed -= 10;
            }

            if (per == 4 && (speed >= 60 || speed <= 80))
            {
                opers = false;
                operm = false;
                speed += 10;
            }
            if (per == 4 && speed == 100)
            {
                opers = true;
                speed -= 10;
            }

            if (per == 5 && (speed >= 80 || speed <= 110))
            {
                opers = false;
                operm = false;
                speed += 10;
            }
            if (per == 5 && speed == 130)
            {
                operm = true;
                speed -= 10;
            }

            if (per == -1 && (speed >= -20 || speed <= 0))
            {
                opers = false;
                operm = false;
                speed -= 10;
            }
            if (per == -1 && speed == -40)
            {
                operm = true;
                speed += 10;
            }
        }
        public void nazhtor() //метод нажатия педали тормоза
        {
            if (speed >= 10)
            {
                speed -= 10;
            } else if (speed <= -10)
            {
                speed += 10;
            }
        }
        public void pomenperN() //метод смены передачи нейтраль
        {
            per = 0;
        }
        public void pomenperF() //метод смены передач вперёд
        {
            if (speed == 0)
            {
                per = 1;
            }
            if (speed >= 20 && speed <= 30)
            {
                per = 2;
            }
            if (speed >= 40 && speed <= 50)
            {
                per = 3;
            }
            if (speed >= 60 && speed <= 70)
            {
                per = 4;
            }
            if (speed >= 80 && speed <= 90)
            {
                per = 5;
            }
        }
        public void pomenperR() //метод смены передачи назад
        {
            if (speed >= 80 && speed <= 90)
            {
                per = 4;
            }
            if (speed >= 60 && speed <= 70)
            {
                per = 3;
            }
            if (speed >= 40 && speed <= 50)
            {
                per = 2;
            }
            if (speed == 20 && speed == 30)
            {
                per = 1;
            }
            if (speed == 0)
            {
                per = -1;
            }
        }
    }
}
