using System;

namespace Lab6_3
{
        public class CachedResult
        {
                public TResult Result { get; }
                public DateTime Timestamp { get; }

                public CachedResult(TResult result, DateTime timestamp)
                {
                    Result = result;
                    Timestamp = timestamp;
                }
        }
    }
