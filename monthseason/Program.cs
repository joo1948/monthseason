using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("월(Month)을 입력해주세요!");
            String month = Console.ReadLine();

            switch (month)
            {
                case "3": case "03": case "3월":
                case "4": case "04": case "4월":
                case "5": case "05": case "5월":
                    Console.WriteLine("봄");
                    break;
                case "6":
                case "06":
                case "6월":
                case "7":
                case "07":
                case "7월":
                case "8":
                case "08":
                case "8월":
                    Console.WriteLine("여름");
                    break;
                case "9":
                case "09":
                case "9월":
                case "010":
                case "10":
                case "10월":
                case "11":
                case "011":
                case "11월":
                    Console.WriteLine("가을");
                    break;
                case "12":
                case "012":
                case "12월":
                case "1":
                case "01":
                case "1월":
                case "2":
                case "02":
                case "2월":
                    Console.WriteLine("겨울");
                    break;
                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    break;
            }
        }
    }
}
