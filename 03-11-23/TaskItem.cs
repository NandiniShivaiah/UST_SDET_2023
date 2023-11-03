using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TaskItem
    {
        public TaskItem()
        {
        }

        public TaskItem(int taskId, string? taskDescription, bool isCompleted)
        {
            TaskId = taskId;
            TaskDescription = taskDescription;
            IsCompleted = isCompleted;
        }

        public int TaskId { get; set; }

        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }


        public void AddTask(List<TaskItem> tasks)
        {
            Console.WriteLine("Added to the list");
            Console.WriteLine();
            foreach (var item in tasks)
            {
                Console.WriteLine("TaskId:" + item.TaskId + " " + "TaskDescription:" + item.TaskDescription + " " + "IsCompleted:" + item.IsCompleted);
                Console.WriteLine();
            }
        }
        public void RemoveTask(int taskId, List<TaskItem> t)
        {
            TaskItem result = t.Find(x => taskId == x.TaskId);

            if (result != null)
            {
                t.Remove(result);
                Console.WriteLine("Task " + taskId + " removed from the List");

            }
            else
            {
                Console.WriteLine("Task with id " + taskId + "  doesn't exist");
            }






        }
    }
}
    
