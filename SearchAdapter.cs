using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public interface ISearch
    {
        List<Tasks> Search(List<Tasks> tasks, string keyword);
    }
    public class TaskSearch : ISearch
    {
        public List<Tasks> Search(List<Tasks> tasks, string keyword)
        {
            return tasks.Where(t => t.TaskName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }



}
