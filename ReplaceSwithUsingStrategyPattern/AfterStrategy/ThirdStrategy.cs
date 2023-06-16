using ReplaceSwithUsingStrategyPattern.AfterStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwithUsingStrategyPattern.AfterStrategy
{
    internal class ThirdStrategy : IStrategy
    {
        public object DoStuff()
        {
            return "return-3";
        }
    }
}