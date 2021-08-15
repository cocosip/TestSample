using System;
using System.Security.Cryptography;

namespace BenchmarkTestSample
{
    public static class Sha1Util
    {
        public static string  GetSha1(byte[] data)
        {
            using var sha1 = SHA1.Create();
            var buffer = sha1.ComputeHash(data);
            return BitConverter.ToString(buffer).Replace("-", "");
        }

    }
}
