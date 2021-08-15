using BenchmarkDotNet.Running;
using System;

namespace BenchmarkTestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<Md5VsSha1>();
            //Console.ReadLine();

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

        }
    }
}
