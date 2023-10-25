using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6_2
{
    public class Repository<T>
    {
        private List<T> items;
        public Repository()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> Find(Criteria<T> criteria)
        {
            if (criteria == null)
            {
                throw new ArgumentNullException(nameof(criteria), "Criteria cannot be null.");
            }

            return items.Where(item => criteria(item)).ToList();
        }
    }


public delegate bool Criteria<T>(T item);
    }
