using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwn.Linq
{
    public static class Enumerable
    {
        public static T Aggregate<T>(this IEnumerable<T> source, Func<T, T, T> func) 
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (func == null)
                throw new ArgumentException("func");
            var enumerator = source.GetEnumerator();
            var accumulate = enumerator.Current;
            while(enumerator.MoveNext())
            {
                accumulate = func(accumulate, enumerator.Current);           
            }
            return accumulate;
        }

        public static TAccumulate Aggregate<TAccumulate,TSource>(this IEnumerable<TSource> source,
            TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            return Aggregate(source, seed, func, x => x);
        }

        public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, 
            TAccumulate seed, 
            Func<TAccumulate, TSource, TAccumulate> func,
            Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (func == null)
                throw new ArgumentException("func");
            if (resultSelector == null)
                throw new ArgumentNullException("resultSelector");

            TAccumulate currentAccumulate = seed;
            foreach (var item in source)
            {
                currentAccumulate = func(currentAccumulate, item);
            }
            return resultSelector(currentAccumulate);
        }
    }
}
