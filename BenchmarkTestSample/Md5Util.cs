using System;
using System.Security.Cryptography;

namespace BenchmarkTestSample
{
    public static class Md5Util
    {
        public static string GetMd5(byte[] data)
        {
            using var md5 = MD5.Create();
            var buffer = md5.ComputeHash(data);
            return BitConverter.ToString(buffer).Replace("-", "");
        }

    }
}
