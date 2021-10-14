using System;
using System.Text;
using System.Collections.Generic;

namespace Laba3
{
    
    class Program
    {
        partial class Stack
        {
            private List<float> arr;
            const string type = "Stack";
            public readonly long ID;
            static private int number = 0;
            public int Length { private set; get; }
            public Stack() {
                this.arr = new List<float>();
                Length = 0;
                number++;
                ID = DateTime.Now.Ticks + number;
            }
            // static и private конструкторы не инициализировал
            // а какже методов которые бы использовали ссылки ref и out
            // я не могу придумать зачем они нужны в этом классе
            public Stack(float[] arr)
            {
                this.arr = this.arr = new List<float>(arr);
                this.arr.Reverse();
                Length = this.arr.Count;
                number++;
                ID = DateTime.Now.Ticks + number;
            }
            public Stack(Stack st)
            {
                this.arr = new List<float>(st.arr);
                Length = this.arr.Count;
                number++;
                ID = DateTime.Now.Ticks + number;
            }
            public float this[int i]
            {
                get
                {
                    if (i < 0 || i >= arr.Count)
                    {
                        throw new Exception("Индекс находится за пределами границы массива");
                    }
                    else
                    {
                        return arr[i];
                    };
                }
            }
            public override string ToString()
            {
                StringBuilder str = new StringBuilder("HEAD ->");
                for(int i = arr.Count-1; i> -1; i--)
                {
                    str.Append(" "+this.arr[i].ToString()+"F ");
                    if(i!= 0)
                    {
                        str.Append("->");
                    }
                }
                return str.ToString();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || !(obj is Stack))
                    return false;
                else
                {
                    Stack sobj = (Stack)obj;
                    if (sobj.Length != this.Length) return false;
                    for(int i = 0; i<Length; i++)
                    {
                        if (this[i] != sobj[i]) return false;
                    }
                    return true;
                }
            }
            public override int GetHashCode()
            {
                int hash = 0; ;
                for(int i = 0; i<Length; i++)
                {
                    hash += Length * (int)this[i];
                }
                hash = (int)ID - hash;
                return hash;
            }
            public void push(float value)
            {
                this.arr.Add(value);
                Length++;
            }
            public float pop()
            {
                float val = this.arr[this.arr.Count - 1];
                this.arr.RemoveAt(this.arr.Count - 1);
                Length--;
                return val;
            }
            public float getValue()
            {
                return arr[this.arr.Count - 1];
            }
            public static void Info()
            {
                Console.WriteLine("Type: "+type);
                Console.WriteLine("Number of created objects: "+number);
            }
        }
        static void Main(string[] args)
        {
            Stack[] a = new Stack[] { new Stack(new float[5] { 1.456F, 356.45F, 456.45F, 12, 0.43F }), 
                                      new Stack(new float[5] { 5F, -1.31F, -2.13F,0.2345F,11F }),
                                      new Stack(new float[3] { 1F, 11F, -0.13F }),
                                      new Stack(new float[3] { -1F, 21.445F, -1.69F }),
                                      new Stack(new float[4] { 13F, -100F, -4.2F,0.0001F })};
            Stack b = new Stack(a[0]);
            Stack c = new Stack();
            Console.WriteLine(b.ToString() + " equals " + a[1].ToString() + " - " + b.Equals(a[1]));
            Console.WriteLine(b.ToString() + " equals " + a[0].ToString() + " - " + b.Equals(a[0]));
            c.push(0.125F);
            c.push(-10.227F);
            c.push(0.685F);
            c.push(11.725F);
            c.pop();
            Console.WriteLine("c.Length: {0}", c.Length);
            Console.WriteLine("c id: {0}", c.ID);
            Console.WriteLine("last value: {0}", c.getValue());
            Console.WriteLine("c hashCode: {0}", c.GetHashCode());
            Console.WriteLine("c: {0}", c.ToString());
            Console.WriteLine("c type: {0}", c.GetType());
            Stack.Info();
            int iMax = 0, iMin = 0;
            for (int i = 1; i < a.Length; i++) {
                if (a[i].getValue() > a[iMax].getValue()) iMax = i;
                if (a[i].getValue() < a[iMin].getValue()) iMin = i;
            }
            Console.WriteLine("Стек с наибольшим верхним элементом: " + a[iMax].ToString());
            Console.WriteLine("Стек с наименьшим верхним элементом: " + a[iMin].ToString());
            Console.WriteLine("Стеки содержащие отрицательные элементы: ");
            for (int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] < 0)
                    {
                        Console.WriteLine("   "+a[i].ToString()+",");
                        i++;
                        j = 0;
                        if (i >= a.Length) break;
                    }
                }
            }
            var anonim = new {arr = new List<float>(),Length = 0, type = "Stack" };
            Console.WriteLine(anonim);
        }
    }
}