using System;
using System.Text;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //bool boolVar = true;
            byte byteVar = 3;
            //sbyte sbyteVar = 120;
            char charVar = 'f';
            //decimal decimalVar = 256474;
            double doubleVar = 0.245363;
            float floatVar = 14.364F;
            int intVar = 145;
            //uint uintVar = 15635;
            long longVar = -1452367855;
            //ulong ulongVar = 145324578235;
            short shortVar = 2345;
            ushort ushortVar = 146;
            // неявное преобразование
            Console.WriteLine("неявное преобразование:");
            longVar = intVar;
            Console.WriteLine("int {0} to long {1}", intVar, longVar);
            float floatVar2 = floatVar / intVar;
            Console.WriteLine("float{1}/int{2}: {0}", floatVar2, floatVar, intVar);
            doubleVar = shortVar / ushortVar;
            Console.WriteLine("short{1}/unsigned short{2} to double: {0}", doubleVar, shortVar, ushortVar);
            int product1 = byteVar * intVar;
            Console.WriteLine("int{0}*byte{1}: {2}", intVar, byteVar, product1);
            int product2 = shortVar * charVar;
            Console.WriteLine("short{0}*char{1}: {2}", shortVar, charVar, product2);
            // явное преобразование
            Console.WriteLine("явное преобразование:");
            double doubleVar2 = (double)shortVar / ushortVar;
            Console.WriteLine("(double)short/ushort: {0}", doubleVar2);
            byte charToByte = (byte)charVar;
            Console.WriteLine("char {0} to byte: {1}", charVar, charToByte);
            decimal decimalDouble = (decimal)doubleVar2;
            Console.WriteLine("double {0} to decimal: {1}", doubleVar2, decimalDouble);
            bool boolNum = System.Convert.ToBoolean(intVar);
            Console.WriteLine("Convert int {0} to bool: {1}", intVar, boolNum);
            char charFromByte = System.Convert.ToChar(byteVar);
            Console.WriteLine("Convert byte {0} to char: {1}", byteVar, charFromByte);

            //Упаковка приметива в объект
            object ocharVar = charVar;
            //распаковка
            charFromByte = (char)ocharVar;

            //неявно типизированная переменная
            var cVar = 'f';
            var iVar = 12;
            Console.WriteLine("char:{0} int:{1}", cVar, iVar);
            Nullable<int> nullInt = null;
            if (!nullInt.HasValue) {
                Console.WriteLine("Nullable Varriable has a Value");
            }
            Console.WriteLine(nullInt ?? 0); // если nullInt == null возвращает результат выражения справа, в противно случае nullInt
            string str1 = "asdf";
            string str2 = "asdf";
            Console.WriteLine(str1 == str2);
            str1 = new String("string one");
            str2 = new String("string two");
            string str3 = new String("string three");
            Console.WriteLine(String.Concat("Конкатенация строк: ", str1, str2));
            Console.WriteLine("Скопированная строка: " + String.Copy(str1));
            Console.WriteLine("Подстрока: " + str1.Substring(0, 6));
            char[] delims = ".,;:!?\n\xD\xA\" ".ToCharArray();
            string[] words = str1.Split(delims,
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.Write(word + ',');
            }
            Console.Write('\n');
            str2.Remove(7, 3);
            Console.WriteLine(str2);
            str2.Insert(str2.Length - 1, " insert");
            string s = "";//пустая строка
            string s2 = null;//null строка
            Console.WriteLine("пустая ли строка: {0}", string.IsNullOrEmpty(s));
            Console.WriteLine("пустая ли строка: {0}", string.IsNullOrEmpty(s2));
            Console.WriteLine("конкатенация " + s2 + " сравнение s и s2 {0}", s == s2);
            StringBuilder sb = new StringBuilder("abc", 30);
            Console.WriteLine(sb);
            sb.Remove(0, 3);
            Console.WriteLine(sb);
            sb.Append("CDEF");
            Console.WriteLine(sb);
            sb.Insert(0, "AB");
            Console.WriteLine(sb);
            int[,] matrix = new int[4,3]{ { 1, 3, 4 }, { 5, 3, 9 }, { 6, 3, 7 }, { 0, 1, 0 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j]);
                    if (j < matrix.GetLength(1) - 1) Console.Write(',');
                }
                Console.WriteLine("");
            }
            string[] arr = new string[] {"dawdsg", "idowusg", "fegewdsg", "dawdsgdwaf" };
            Console.WriteLine("Массив [{0},{1},{2},{3}], его длинна: {4}", arr[0], arr[1], arr[2], arr[3], arr.Length);
            Console.WriteLine("Введите индекс массива меньше {0}",arr.Length);
            int index = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку на которую хотите заменить");
            arr.SetValue(Console.ReadLine(), index >= arr.Length ? 0:index);
            Console.WriteLine("Массив [{0},{1},{2},{3}], его длинна: {4}", arr[0], arr[1], arr[2], arr[3], arr.Length);
            
            float[][] floatArr = new float[3][];
            floatArr[0] = new float[2];
            floatArr[1] = new float[3];
            floatArr[2] = new float[4];
            Console.WriteLine("Введите значения массива");
            for(int i = 0; i<floatArr.Length; i++)
            {
                for (int j = 0; j < floatArr[i].Length; j++)
                {
                    floatArr[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }
            for (int i = 0; i < floatArr.Length; i++)
            {
                for (int j = 0; j < floatArr[i].Length; j++)
                {
                    Console.Write("{0}, ", floatArr[i][j]);
                }
                Console.WriteLine("");
            }
            var ArrayVar = new int[3] { 1, 5, 8 };
            var StringVar = "dartherg";
            //кортежи
            (int i1, string i2, char i3, string i4, ulong i5) kortej = (10,"dwaff",'s',null,123456789345);
            	Console.WriteLine("Кортеж {0}",kortej);
            	Console.WriteLine("Элементы кортежа 1ый: {0}, 3ий: {1}, 4ый: {2}",kortej.Item1,kortej.Item3,kortej.Item4);
        	var (r1,r2,r3,r4,r5) = kortej;
        	Console.WriteLine("распаковка: {0}, {1}, {2}, {3}, {4}",r1,r2,r3,r4,r5);
        	(int i1, string i2, char i3, string i4, ulong i5) kor2 = (10,"dwaff",'s',null,123456789345);
        	(int i1, string i2, char i3, string i4, ulong i5) kor3 = (100,"dwaff",'s',null,123456789345);
        	Console.WriteLine("{0} == {1} | {2}",kortej,kor2,kortej == kor2);
        	Console.WriteLine("{0} == {1} | {2}",kortej,kor3,kortej == kor3);
        	*/
			var k = getKortej(new int[]{1,5,8,4,9},"egtrgrt");
			Console.WriteLine("{0}",k);
			func2();
            //func1();
			void func1(){
				checked{
                    int maxInt = int.MaxValue;
                    Console.WriteLine("func1: {0}", ++maxInt);
				}
			}
			void func2(){
				unchecked{
                    int maxInt = int.MaxValue;
                    Console.WriteLine("func2: {0}", ++maxInt);
                }
			}
        }
        private static (int min, int max, int sum, char firstLatter) getKortej(int[] arr, string str){
        	int min = arr[0];
        	int max = arr[0];
        	int sum = 0;
        	char firstLatter = str[0];
        		foreach(int elem in arr){
        			sum += elem;
        			min = elem < min? elem: min;
        			max = elem > max? elem: max;
        		}
        	return (min,max,sum,firstLatter);
        }
    }
}
