using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{


    internal class Program
    {
        static void Main(string[] args)
        {
/*            Wanted<string> WantedString = new Wanted<string>("string");
            Wanted<int> WantedInt = new Wanted<int>(12345);
            Wanted<double> WantedDouble = new Wanted<double>(12.345);

            Console.WriteLine(WantedString.Value);
            Console.WriteLine(WantedDouble.Value);
            Console.WriteLine(WantedInt.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;

            Console.Write("숫자 입력 : ");
            int output;
            bool res = int.TryParse(Console.ReadLine(), out output);
            if (res)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("숫자 입력 바람");
            }

            int x = 0; int y = 0;
            int vx = 1; int vy = 1;
            Console.WriteLine("현재 좌표 : (" + x + "," + y + ")");
            NextPos(x, y, vx, vy, out x, out y);*/

            Point point;
            point.x = 10;
            point.y = 10;
            point = new Point(1, 2);
            Console.WriteLine(point.x + "/" + point.y);

            PointClass pointClass = new PointClass(10, 20);
            PointClass pointClassB = pointClass;
            pointClass.x = 100; pointClass.y = 200;
            Console.WriteLine(pointClass.x + "/" + pointClass.y);
            Console.WriteLine(pointClassB.x + "/" + pointClassB.y);

            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;
            pointStructA.x = 100; pointStructA.y = 200;
            Console.WriteLine(pointStructA.x + "/" + pointStructA.y);
            Console.WriteLine(pointStructB.x + "/" + pointStructB.y);
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
                this.x=x;
                this.y=y;
            }
        }
    }
}
