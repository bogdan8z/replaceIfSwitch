using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwithUsingStrategyPattern.BeforeStrategy
{
    public class AbcWithSwitch
    {
        public string MyProperty1 { get; set; }
        public string GetMyValue()
        {
            switch (MyProperty1)
            {
                case "case-1":
                    return "return-1";
                case "case-2":
                    return "return-2";
                case "case-3":
                    return "return-3";
                default:
                    return "return-4";
            }
        }
    }
}