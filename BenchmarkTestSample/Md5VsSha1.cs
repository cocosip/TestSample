using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;

namespace BenchmarkTestSample
{
    [SimpleJob(RuntimeMoniker.Net471, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    //[SimpleJob(RuntimeMoniker.CoreRt50)]
    [RPlotExporter]
    public class Md5VsSha1
    {
        private byte[] data;

        [Params(100, 1000, 5000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public string Sha1() => Sha1Util.GetSha1(data);

        [Benchmark]
        public string Md5() => Md5Util.GetMd5(data);

    }
}
