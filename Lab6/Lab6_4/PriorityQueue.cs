using System;
using System.Collections.Generic;

namespace Lab6_4
{
    public class PriorityQueue<TItem, TPriority>
    {
        private List<(TItem item, TPriority priority)> items;

        public PriorityQueue()
        {
            items = new List<(TItem, TPriority)>();
        }

        public int Count => items.Count;

        public void Enqueue(TItem item, TPriority priority)
        {
            items.Add((item, priority));
        }

        public (TItem item, TPriority priority) Dequeue()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("The queue is empty.");

            var highestPriorityItem = items[0];
            int highestPriorityIndex = 0;

            for (int i = 1; i < items.Count; i++)
            {
                if (Comparer<TPriority>.Default.Compare(items[i].priority, highestPriorityItem.priority) > 0)
                {
                    highestPriorityItem = items[i];
                    highestPriorityIndex = i;
                }
            }

            items.RemoveAt(highestPriorityIndex);
            return highestPriorityItem;
        }
    }
}