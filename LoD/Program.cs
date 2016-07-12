using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 迪米特法则
/// 一个对象应该对其他对象有最少的了解。
/// </summary>

namespace LoD
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生一个女生群体
            ArrayList<Girl> listGirls = new ArrayList<Girl>();
            //初始化女生
            for (int i = 0; i < 20; i++)
            {
                listGirls.Add(new Girl());
            }
            Teacher teacher = new Teacher();
            //老师发布命令
            teacher.Commond(new GroupLeader(listGirls));
        }
    }
}
