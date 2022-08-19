using System;

namespace Csharp_study_03_字符类型
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //字符转换为数字
            //可转换，因为数字变量容量要比字符变量容量要大
            char a = 'c';
            int b = a;
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            //数字变量转换为字符变量
            //不可转换，原理同上，原因：容量不够大
            //可通过强制转换来实现,但由于容量不够，所以会丢失冗余数据
            //char d = (char)a;
            
            int c = 91;
            char d = a;
            
            Console.WriteLine(d);
            Console.WriteLine(c);

            //转义字符

            // 菜鸟教程——转义字符章节 https://www.runoob.com/csharp/csharp-constants.html

            //书写路径
            //一般写法 
            Console.WriteLine("C:\\123\\123.txt");
            //防止转义字符 加@符号
            Console.WriteLine(@"c:\123\123.txt");

            //字符串赋值
            //字符串赋值同样支持@前置取消转义字符
            string str = "woshi\nnidie";
            
            Console.WriteLine(str);


        }
    }
}
