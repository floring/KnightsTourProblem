using System.Collections.Generic;

namespace KnightsTourProblem
{
    /// <summary>
    /// This class contains custom method extensions.
    /// </summary>
    static class Extensions
    {
        /// <summary>
        /// Shuffle any (I)List with an extension method based on the Fisher-Yates shuffle.
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="list">list to shuffle</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
