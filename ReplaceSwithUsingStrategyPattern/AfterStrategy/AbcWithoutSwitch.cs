using ReplaceSwithUsingStrategyPattern.AfterStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSwithUsingStrategyPattern.AfterStrategy
{
    public class AbcWithoutSwitch
    {
        readonly IDictionary<string, IStrategy> _strategies = new Dictionary<string, IStrategy>()
        {
                { "case-1", new FirstStrategy() },
                { "case-2", new SecondStrategy() },
                { "case-3", new ThirdStrategy() }
        };

        public string? MyProperty1 { get; set; }

        public string GetMyValue()
        {
            return GetStrategy().DoStuff().ToString();
        }

        private IStrategy GetStrategy() => _strategies[MyProperty1];
    }
}
