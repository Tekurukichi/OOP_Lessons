using System;
using System.Collections.Generic;

namespace Lab6_3
{
    public class FunctionCache<TKey, TResult>
    {
        public TResult Result { get; }
        public DateTime Timestamp { get; }
        private readonly Dictionary<TKey, CachedResult> cache = new Dictionary<TKey, CachedResult>();

        public delegate TResult FuncDelegate(TKey key);

        public FuncDelegate CachedFunction { get; }

        public FunctionCache(FuncDelegate func)
        {
            CachedFunction = func;
        }

        public TResult GetResult(TKey key, TimeSpan expiration)
        {
            if (cache.TryGetValue(key, out CachedResult cached) && IsCacheValid(cached, expiration))
            {
                return cached.Result;
            }
            else
            {
                TResult result = CachedFunction(key);
                cache[key] = new CachedResult(result, DateTime.Now);
                return result;
            }
        }
        private bool IsCacheValid(CachedResult cached, TimeSpan expiration)
        {
            DateTime expirationTime = cached.Timestamp.Add(expiration);
            return DateTime.Now <= expirationTime;
        }
    }
}