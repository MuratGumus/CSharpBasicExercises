using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------       BYTE EXERCİSES       -----------------------

            byte first = 5;
            byte second = 15;
            // byte third = 260;
            byte maxByte = byte.MaxValue; // .Maxvalue ile alabilecek max değer verilir.
            byte minByte = byte.MinValue; // .MinValue ile alabilecek min değer verilir.

            Console.WriteLine(first);
            Console.WriteLine(second);
            //  Console.WriteLine(third); bunu yazdıramadı çünkü byte 0-255 arası değer tutabilir.
            Console.WriteLine(maxByte);
            Console.WriteLine(minByte);
            Console.ReadLine();

            // --------------       BYTE EXERCİSES       -----------------------

            short firstVariable = 1;
            short secondVariable = 25500;
            short thirdVariable = short.MaxValue;
            short fourthVariable = short.MinValue;

            Console.WriteLine(firstVariable);
            Console.WriteLine(secondVariable);
            Console.WriteLine(thirdVariable);
            Console.WriteLine(fourthVariable);
            Console.ReadLine();


            // --------------       INT EXERCİSES       -----------------------

            int firstInt = 123123;
            int secondInt = int.MaxValue;
            int thirdInt = int.MinValue;

            Console.WriteLine(firstInt);
            Console.WriteLine(secondInt);
            Console.WriteLine(thirdInt);
            Console.ReadLine();

            // --------------       LONG EXERCİSES       -----------------------

            // 10 karakterden fazla sayıları tutabilir. Örneğin tc kimlik numaraları 11 haneli olduğu için long ile yazılır.

            long firstLong = 123123123123;
            long secondLong = long.MaxValue;
            long thirdLong = long.MinValue;

            Console.WriteLine(firstLong);
            Console.WriteLine(secondLong);
            Console.WriteLine(thirdLong);
            Console.ReadLine();

            // --------------       FLOAT EXERCİSES       -----------------------

            // float değer belirlerken value kısmının sonuna f konulur. Eğer f konulmazsa sistem bunu otomatik olarak double olarak kabul eder.

            float firstFloat = 0.1f;
            float secondFloat = 1.1f;
            float thirdFlooat = float.MaxValue;
            float fourthFloat = float.MinValue;

            Console.WriteLine(firstFloat);
            Console.WriteLine(secondFloat);
            Console.WriteLine(thirdFlooat);
            Console.WriteLine(fourthFloat);
            Console.ReadLine();

            // --------------       DOUBLE EXERCİSES       -----------------------

            // Double, flota göre virgülden sonra daha fazla sayı tutabilir. Bu nedenle daha ince hesaplamalar double ile yapılır.

            double firstDouble = 0.1;
            double secondDouble = double.MaxValue;
            double thirdDouble = double.MinValue;

            Console.WriteLine(firstDouble);
            Console.WriteLine(secondDouble);
            Console.WriteLine(thirdDouble);
            Console.ReadLine();

            // --------------       BYTE EXERCİSES       -----------------------

            // Decimal, double göre virgülden sonra daha fazla sayı tutabilir. Bu nedenle çok daha ince hesaplamalar decimal ile yapılır.
            // Decimal tanımlarken value'nin sonuna m eklenir. Aksi halde sistem otomatik olarak double olarak kabul eder.

            decimal firstDecimal = 0.1m;
            decimal secondDecimal = decimal.MaxValue;
            decimal thirdDecimal = decimal.MinValue;

            Console.WriteLine(firstDecimal);
            Console.WriteLine(secondDecimal);
            Console.WriteLine(thirdDecimal);
            Console.ReadLine();


            // --------------       CHAR EXERCİSES       -----------------------

            // Sadece tek bir karakteri tutmak için yapılan tanımlamalarda kullanılır. Char tanımlarken sadece tek tırnak kullanılır

            char firtChar = 'A';
            char secondChar = '3';

            Console.WriteLine(firtChar);
            Console.WriteLine(secondChar);
            Console.ReadLine();

            // --------------       STRING EXERCİSES       -----------------------

            // Char değişkeninden farklı olarak sadece bir karakteri değil metni tutar.

            string firstString = "Elma";
            string secondString = "Portakal";

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.ReadLine();

            // --------------       BOOLEAN EXERCİSES       -----------------------

            //Boolean, sadece true veya false olarak sonuç doğurur.

            bool firstBoolean = true;
            bool secondBoolean = false;
            bool thirdBoolean = 4 > 8; // eğer 4, 8 den büyük ise yani sonuç doğru ise true sonuç gelir, aksi halde false sonuç gelir.

            Console.WriteLine(firstBoolean);
            Console.WriteLine(secondBoolean);
            Console.WriteLine(thirdBoolean);

            //--------------OBJECT EXERCİSES---------------------- -

            //Tüm variable'ları içerisinde barındırabilir. Type ayrımı yapmaz.

            object firstObject = null;
            object secondObject = 123;
            object thirdObject = "name";

            Console.WriteLine(firstObject);
            Console.WriteLine(secondObject);
            Console.WriteLine(thirdObject);
            Console.ReadLine();

            //--------------OPERATORS EXERCİSES---------------------- -








        }
    }
}
