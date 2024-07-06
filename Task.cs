using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
     public  class Tasks : ICloneable
    {
        public  string TaskName { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public int Priority { get; set; }//the lowest value is the highest priority
        public DateTime ExecutionDate { get; set; }
        public bool IsCompleted { get; set; }

        public object Clone()
        {
            var clone = MemberwiseClone();//create shallow copy
                                          //if there are reference type members need to manually clone.
            return clone;
        }
    }

}
