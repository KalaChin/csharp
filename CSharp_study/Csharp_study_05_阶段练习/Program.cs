using System;

namespace Csharp_study_05_阶段练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：用户输入一个三位的正整数，按数字相反的顺序输出
            /*
            Console.WriteLine("请输入一个三位的正整数！");
            int threeNum = Convert.ToInt32(Console.ReadLine());
            int ge = threeNum % 10;
            int shi = threeNum / 10 % 10;
            int bai = threeNum / 100;
            Console.WriteLine("结果是：{0}{1}{2}",ge,shi,bai);
            */

            //练习2：B国每次发送的电报都是⼀个五位数组成的，这个五位数的⼗位和千位组成的两位数，就是对应
            //      的电报内容，帮助B国对数据进⾏解密。
            //
            /*
            Console.WriteLine("请输入需破译的电报：");
            int dianbao = Convert.ToInt32(Console.ReadLine());
            int fristNum = dianbao / 10000;
            int secondNum = dianbao / 1000 % 10;
            int thirdNum = dianbao / 100 % 10;
            int fourthNum = dianbao / 10 % 10;
            int fifthNum = dianbao % 10;
            int he = (fourthNum * 10 + secondNum);
            char neirong = (char)(he);
            Console.WriteLine(he);
            Console.WriteLine();
            Console.WriteLine(neirong);
            */

            //练习3：输⼊数学的分数，和英语的分数，判断是否可以获得奖励，只有数学和英语分数都考到90分才有奖励。

            Console.WriteLine("请输入数学成绩：");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入语文成绩：");
            int language = Convert.ToInt32(Console.ReadLine());
            bool reward = math >= 90 && language >= 90;
            Console.WriteLine(reward);

        }
    }
}
