using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public interface IFileSaveAdapter
    {
        void SaveToFile(List<Tasks> tasks, string filePath);
    }
    public class FileSaveAdapter : IFileSaveAdapter
    {
        public void SaveToFile(List<Tasks> tasks, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.TaskName},{task.Priority},{task.ExecutionDate},{task.Tag}");
                }
            }
        }
    }


}
