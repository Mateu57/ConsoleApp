namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();
            reader.ImportAndPrintData("data.csv"); //Mistake in name of CSV file "dataa.csv" -> "data.csv".
        }
    }
}
