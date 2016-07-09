using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//依赖倒置原则


namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar benz = new Benz();

            IDriver zhangSan = new Driver(benz);
            //张三开车
            zhangSan.drive();
        }
    }

    public class Driver : IDriver
    {
        private ICar car;

        public Driver(ICar _car)
        {
            this.car = _car;
        }

        public void drive()
        {
            car.run();
        }
    }

    public class Benz : ICar
    {
        //汽车肯定会跑
        public void run()
        {
            Console.WriteLine("奔驰汽车开始运行...");
        }
    }

    public class BMW : ICar
    {
        //宝马车当然也可以开动了
        public void run()
        {
            Console.WriteLine("宝马汽车开始运行...");
        }
    }

}
