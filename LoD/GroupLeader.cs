using System;
using System.Collections;
using System.Collections.Generic;

namespace LoD
{
    public class GroupLeader
    {
        private List<Girl> listGirls;
        //传递全班的女生进来
        public GroupLeader(List<Girl> _listGirls)
        {
            this.listGirls = _listGirls;
        }
        //清查女生数量
        public void countGirls()
        {
            Console.WriteLine("女生数量是：" + this.listGirls.Count);
        }
    }
}