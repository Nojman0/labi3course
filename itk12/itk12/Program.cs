#region Zadanie3

using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Cars : IComparer
{
    public string Marka { get; set; }
    public int NumberOfCar { get; set; }
    public string Sname { get; set; }
    public int DateOfBuy { get; set; }
    public int Probeg { get; set; }

    public Cars() { }

    public Cars(string marka, int numbercar, string sname, int databuy, int probeg)
    {
        Marka = marka;
        NumberOfCar = numbercar;
        Sname = sname;
        DateOfBuy = databuy;
        Probeg = probeg;
    }

    ////public int CompareTo(object obj)
    ////{
    ////    Cars car = obj as Cars;

    ////    if (car != null)
    ////        return this.Probeg.CompareTo(car.Probeg);
    ////    else
    ////        throw new Exception("Невозможно сравнить два объекта");
    ////}

    public int Compare(Cars x, Cars y)
    {
        if (x.Probeg > y.Probeg)
        {
            return -1;
        }
        else if (x.Probeg < y.Probeg)
            return 1;
        else
            return 0;
    }

    public int Compare(object x, object y)
    {
        Cars car_1 = (Cars)x;
        Cars car_2 = (Cars)y;

        if (car_1.Probeg > car_2.Probeg)
        {
            return -1;
        }
        else if (car_1.Probeg < car_2.Probeg)
            return 1;
        else
            return 0;
    }
}

static void Main(string[] args)
{
    #region Inicialize
    //Cars car_1 = new Cars("BMW",777,"Sidorenko",2005,45000);
    //Cars car_2 = new Cars("Audi", 123, "Bezmen", 2018, 450000);
    //Cars car_3 = new Cars("Жигуль", 125, "Blinov", 2017, 100000);
    //Cars[] cars = new Cars[] { car_1, car_2, car_3 };
    #endregion
    Cars car_1 = new Cars();
    Cars car_2 = new Cars();
    Cars car_3 = new Cars();

    XmlSerializer formatter = new XmlSerializer(typeof(Cars[]));
    #region Serialize
    //using (FileStream fs = new FileStream("input.xml", FileMode.OpenOrCreate))
    //{
    //    formatter.Serialize(fs, cars);
    //}
    #endregion

    using (FileStream fs = new FileStream("input.xml", FileMode.OpenOrCreate))
    {
        Cars[] car = (Cars[])formatter.Deserialize(fs);

        //foreach(Cars car in newcars)        
        //Console.WriteLine("Marka: {0}  Номер Машины: {1}  Фамилия: {2} Дата покупки: {3} Пробег: {4}", car[0].Marka, car[0].NumberOfCar,car[0].Sname,car[0].DateOfBuy,car[0].Probeg);
        car_1 = new Cars(car[0].Marka, car[0].NumberOfCar, car[0].Sname, car[0].DateOfBuy, car[0].Probeg);
        car_2 = new Cars(car[1].Marka, car[1].NumberOfCar, car[1].Sname, car[1].DateOfBuy, car[1].Probeg);
        car_3 = new Cars(car[2].Marka, car[2].NumberOfCar, car[2].Sname, car[2].DateOfBuy, car[2].Probeg);
    }

    //Cars[] cars = new Cars[] { car_1, car_2, car_3 };
    ArrayList cars = new ArrayList();

    IComparer muComp = new Cars();
    cars.Add(car_1);
    cars.Add(car_2);
    cars.Add(car_3);
    cars.Sort();
    cars.Sort(muComp);

    Cars[] carsToSerial = new Cars[3];
    int help = 0;
    foreach (Cars car in cars)
    {
        if (car.DateOfBuy > 2015)
        {
            Console.WriteLine("Marka: {0}  Номер Машины: {1}  Фамилия: {2} Дата покупки: {3} Пробег: {4}", car.Marka, car.NumberOfCar, car.Sname, car.DateOfBuy, car.Probeg);
            carsToSerial[help] = car;
            help++;
        }
    }
    using (FileStream fs = new FileStream("output.xml", FileMode.OpenOrCreate))
    {
        formatter.Serialize(fs, carsToSerial);
    }
}

#endregion