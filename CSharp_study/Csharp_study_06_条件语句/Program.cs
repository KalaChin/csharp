using System;

namespace Csharp_study_06_条件语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //if语句

            /*
            int age = Convert.ToInt32(Console.ReadLine());
            if (age<18){
                Console.WriteLine("不可以进入");
            }
            else
            {
                Console.WriteLine("可以进入啦");
            }
            */

            //小练习
            //商场举办活动，年龄在18——30岁才能参加，如果年龄是奇数那么就中奖了。
            Console.WriteLine("请输入您的年龄！");
            int age = Convert.ToInt32(Console.ReadLine());
            int agetest = age % 2;
            if (age>=18 && age <= 30)
            {
                if (agetest == 1)
                {
                    Console.WriteLine("恭喜您，中奖了！");
                }
                else {
                    Console.WriteLine("很遗憾，您没有中奖！");
                }
            }
            else {
                Console.WriteLine("您不在活动范围内，不能参加");
            }




        }
    }
}
