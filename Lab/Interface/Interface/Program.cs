using System;

namespace MultipleInterfaceDemo
{
    
    interface IPrintable
    {
        void Print();
    }

    
    interface ISerializable
    {
        void Save();
    }


    class Report : IPrintable, ISerializable
    {
        public void Print()
        {
            Console.WriteLine("Printing the report...");
        }

        public void Save()
        {
            Console.WriteLine("Saving the report...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();

            report.Print();
            report.Save();

            
        }
    }
}