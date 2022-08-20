using System;

namespace Csharp_study_04_输入和字符转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求： 用户输入两个整数，然后计算出平均值，并显示出来

            // 题目

            Console.WriteLine("平均数计算器！");

            //输入第一个数字
            //提示用户输入第一个数字
            Console.WriteLine("Plese Input First Number");
            //声明变量num1     转化输入字符为数字     读取用户输入字符
            int num1 = Convert.ToInt32(Console.ReadLine());
            //输入第二个数字
            //提示用户输入第二个数字
            Console.WriteLine("Plese Input Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //计算结果
            Console.WriteLine("Answer Is:");
            Console.WriteLine((num1 + num2)/2);

            double test = 3 / 2;
            Console.WriteLine(test);
        }
    }
}
