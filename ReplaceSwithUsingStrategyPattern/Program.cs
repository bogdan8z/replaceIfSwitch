// See https://aka.ms/new-console-template for more information

using ReplaceSwithUsingStrategyPattern.AfterStrategy;
using ReplaceSwithUsingStrategyPattern.BeforeStrategy;

var myValueWithSwitch = new AbcWithSwitch
{
    MyProperty1 = "case-2"
}
.GetMyValue();


Console.WriteLine(myValueWithSwitch); //this will be "return-2"


var myValueWithoutSwitch = new AbcWithoutSwitch()
{
   MyProperty1 = "case-2"
}
.GetMyValue();

Console.WriteLine(myValueWithoutSwitch); //this will be still  "return-2"
