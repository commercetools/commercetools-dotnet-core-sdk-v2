using System;
using System.Linq;

namespace commercetools.Api.IntegrationTests
{
    public static class TestingUtility
    {
        #region Fields

        private static readonly Random Random = new Random();

        #endregion
        
        #region Functions
        public static int RandomInt(int? min = null, int? max = null)
        {
            int ran;
            if (min.HasValue && max.HasValue)
            {
                ran = Random.Next(min.Value, max.Value);
            }
            else
            {
                ran = Math.Abs(Random.Next());
            }

            return ran;
        }
        public static string RandomSortOrder()
        {
            const int append = 5; //hack to not have a trailing 0 which is not accepted in sphere
            return "0." + RandomInt() + append;
        }
        public static string RandomString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        #endregion
    }
}