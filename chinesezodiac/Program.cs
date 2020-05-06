using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinesezodiac
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("어느 해에 태어나셨죠? : ");
            int year = int.Parse(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;
                case 4:
                    Console.WriteLine("소");
                    break;
                case 5:
                    Console.WriteLine("개");
                    break;
                case 6:
                    Console.WriteLine("호랑이");
                    break;
                case 7:
                    Console.WriteLine("토끼");
                    break;
                case 8:
                    Console.WriteLine("용");
                    break;
                case 9:
                    Console.WriteLine("뱀");
                    break;
                case 10:
                    Console.WriteLine("말");
                    break;
                case 11:
                    Console.WriteLine("양");
                    break;
                default:
                    Console.WriteLine("당신...혹시...하나님...?");
                    break;
            }

        }
    }
}
