using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public interface ISearchAdapter
    {
        List<Tasks> Search(List<Tasks> tasks, string query);
    }
    public class SearchAdapter : ISearchAdapter
    {
        public List<Tasks> Search(List<Tasks> tasks, string query)
        {
            return tasks.Where(t => t.TaskName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                                    t.Tag.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }



}
