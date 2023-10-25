using System;

namespace Lab6_4
{
    public delegate void TaskExecution<TTask>(TTask task);

    public class TaskScheduler<TTask, TPriority>
    {
        private readonly PriorityQueue<TTask, TPriority> taskQueue;
        private readonly TaskExecution<TTask> taskExecutionDelegate;

        public TaskScheduler(TaskExecution<TTask> executionDelegate)
        {
            taskQueue = new PriorityQueue<TTask, TPriority>();
            taskExecutionDelegate = executionDelegate;
        }

        public void AddTask(TTask task, TPriority priority)
        {
            taskQueue.Enqueue(task, priority);
        }

        public void ExecuteNext()
        {
            if (taskQueue.Count > 0)
            {
                var (task, priority) = taskQueue.Dequeue();
                Console.WriteLine($"Executing task with priority {priority}");
                taskExecutionDelegate(task);
            }
            else
            {
                Console.WriteLine("No tasks in the queue.");
            }
        }
    }
}