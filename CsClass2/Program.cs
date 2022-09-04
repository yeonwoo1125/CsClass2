using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("str");
            Wanted<int> wantedInt = new Wanted<int>(51113);
            Wanted<double> wantedDouble = new Wanted<double>(52.1213273);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;

            Console.WriteLine("숫자 입력: ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력하세요.");
            }
            int x = 0; int y = 0;
            int vx = 1; int vy = 1;
            Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + "," + y + ")");
            Point point;
            point.x = 10;
            point.y = 10;
            point = new Point(3, 5);
            Console.WriteLine(point.x + " / " + point.y);

            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA;
            pointClassB.x = 100; pointClassB.y = 200;
            Console.WriteLine(pointClassA.x + "/" + pointClassA.y);
            Console.WriteLine(pointClassB.x + "/" + pointClassB.y);

            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;
            pointStructB.x = 100; pointStructB.y = 200;
            Console.WriteLine(pointStructA.x + "/" + pointStructA.y);
            Console.WriteLine(pointStructB.x + "/" + pointStructB.y);

            using (Dummy dummy = new Dummy())
            {
                List<Product> list = new List<Product>()
                {
                    new Product() { Name="고구마", Price=5000 },
                    new Product() { Price=2400, Name="사과" }
                };
                list.Sort();
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            IBasic basic = new TestClass();
            //basic.something();
            (basic as TestClass).someting();
        }

        class TestClass : IBasic
        {
            public void someting(){}
            public int TestProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }

        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose()");
            }
        }

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }
            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                this.testA = test;
                this.testB = test;
            }            
        }
        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
