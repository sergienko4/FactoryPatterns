using Invoce.Enum;
using Invoce.Interface;
using System;

namespace Invoce
{
    public abstract class Build : IPrint
    {
        public long Amount;
        public BuildType BuildType;
        public DateTime Date;
        public DateTime PayUnTill { get; private set; }

        public Build(BuildType type, long amount)
        {
            this.BuildType =type;
            this.Amount = amount;
            this.Date = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine(($"Build Type :{this.BuildType} \t Build Amount: {this.Amount} \t pay it in 7 day - until: {(DateTime.Now).AddDays(7).ToShortDateString()}"));
            this.PayUnTill = (DateTime.Now).AddDays(7);
        }

    }

}
