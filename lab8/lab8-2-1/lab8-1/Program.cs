using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_1
{
    public class Train
    {

        //////////////////////////////////////////////////////////////////////////////////////////// > задание №8-1-2 (старт)
        public enum typeTrain
        {
            skTrain, //скорый поезд
            pasTrain,  //пассажирский поезд
            tTrain //товарный поезд
        };
        //////////////////////////////////////////////////////////////////////////////////////////// > задание №8-1-2 (конец)
        //////////////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////////////////////////////////////////////////////////////// > задание №8-1-1 (старт)
        public string number;
        public string message;
        public int cout;
        public typeTrain tType; //добавил открытый члет типа typeTrain

        public Train(string a, string b, int c, typeTrain d)
        {
            number = a;
            message = b;
            cout = c;
            tType = d; 
        }

        public override string ToString()
        {
            return String.Format("Номер: {0}\nСообщение: {1}\nКоличество вагонов: {2}\nТип поезда: {3}\n", number, message, cout, tType);
        }
        //////////////////////////////////////////////////////////////////////////////////////////// > задание №8-1-1 (конец)
    }

    //////////////////////////////////////////////////////////////////////////////////////////// > задание №8-2-1 (старт)

    public class FirmTrain : Train
    {
        string nameFirm;
        double kPrice;

        public FirmTrain(string newA, double newB, string a, string b, int c, typeTrain d) : base(a, b, c, d)
        {
            nameFirm = newA;
            kPrice = newB;
        }

        public override string ToString()
        {
            return String.Format("Номер: {0}\nСообщение: {1}\nКоличество вагонов: {2}\nТип поезда: {3}\nФирменный номер: {4}\nНаценка: {5}\n", number, message, cout, tType, nameFirm, kPrice);
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////// > задание №8-2-1 (конец)


    class Program
    {
        static void Main(string[] args)
        {
            Train temp = new Train("train1", "test", 20, Train.typeTrain.skTrain);
            Console.WriteLine(temp);
            FirmTrain temp1 = new FirmTrain("newest", 2, "train1", "test", 20, Train.typeTrain.skTrain);
            Console.WriteLine(temp1);
        }
    }
}
