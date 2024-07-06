using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    abstract class ViewAdapter
    {

        public abstract void Display();
    }
    class ListAdapter : ViewAdapter
    {
        protected List<Tasks> tasks;

        public ListAdapter(List<Tasks> tasks)
        {
            this.tasks = tasks;
        }

        public override void Display()
        {   //display as a list
            foreach (var item in tasks)
            {
                Console.WriteLine($"{item.TaskName,-20}{item.Priority,3} " +
                $"{item.ExecutionDate.ToShortDateString()} {item.IsCompleted}");
            }
        }
    }
    class GridAdapter : ListAdapter
    {
        public GridAdapter(List<Tasks> tasks) : base(tasks)
        {
        }

        public override void Display()
        {   //display as a grid
            for (int i = 0; i < tasks.Count; i += 2)
            {
                var item = tasks[i];
                var item2 = (i + 1 >= tasks.Count) ? null : tasks[i + 1];
                Console.Write($"Task name: {item.TaskName,-20}");
                if (item2 != null) Console.WriteLine($"Task name: {item2?.TaskName,-20}");
                Console.Write($"Priority : {item.Priority,-20}");
                if (item2 != null) Console.WriteLine($"Priority : {item2?.Priority,-20}");
                Console.Write($"Tag      : {item.Tag,-20}");
                if (item2 != null) Console.WriteLine($"Tag      : {item2?.Tag,-20}");
                Console.Write($"Date     : {item.ExecutionDate.ToShortDateString(),-20}");
                if (item2 != null) Console.WriteLine($"Date     : {item2?.ExecutionDate.ToShortDateString(),-20}");
                Console.WriteLine("----------------------------------------------");
            }
        }
    }

}
